#region license
// Copyright 2008 Shawn Neal (neal.shawn@gmail.com)
//
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
//
//     http://www.apache.org/licenses/LICENSE-2.0
//
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// See the License for the specific language governing permissions and
// limitations under the License.
#endregion

using System;
using System.Collections.Generic;
using NUnit.Framework;

namespace Sneal.CmdLineParser.Tests
{
    [TestFixture]
    public class CommandLineParserFixture
    {
        private TestOptions testOptions;
        private RequiredTestOptions requiredTestOptions;
        private CommandLineParser parser;

        [SetUp]
        public void SetUp()
        {
            testOptions = new TestOptions();
            requiredTestOptions = new RequiredTestOptions();
        }

        [Test]
        public void ShouldGetSettableProperties()
        {
//            parser = new CommandLineParser(new string[] { "" });
//
//            Dictionary<string, PropertyInfoSwitchAttributePair> settableOptions = 
//                parser.GetSettableOptions(testOptions);
//
//            Assert.IsNotNull(settableOptions);
//            Assert.That(settableOptions.Count == 4);
//
//            Assert.That(settableOptions.ContainsKey("StringOption"));
//            Assert.That(settableOptions.ContainsKey("BoolOption"));
//            Assert.That(settableOptions.ContainsKey("IntOption"));
//            Assert.That(settableOptions.ContainsKey("StringList"));
        }

        [Test]
        public void ShouldSetOptions()
        {
            string[] cmdLineArgs = {"/StringOption=Sneal", "/BoolOption", "/IntOption=22"};
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);

            Assert.AreEqual("Sneal", testOptions.StringOption);
            Assert.IsTrue(testOptions.BoolOption);
            Assert.AreEqual(22, testOptions.IntOption);
        }

        [Test]
        public void Should_ignore_extra_spaces()
        {
            string[] cmdLineArgs = { "  /StringOption=Sneal", " /BoolOption", "/IntOption=22" };
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);

            Assert.AreEqual("Sneal", testOptions.StringOption);
            Assert.IsTrue(testOptions.BoolOption);
            Assert.AreEqual(22, testOptions.IntOption);
        }

        [Test]
        public void Should_work_with_dashes()
        {
            string[] cmdLineArgs = { "-StringOption=Sneal", "-BoolOption", "-IntOption=22" };
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);

            Assert.AreEqual("Sneal", testOptions.StringOption);
            Assert.IsTrue(testOptions.BoolOption);
            Assert.AreEqual(22, testOptions.IntOption);
        }

        [Test]
        public void ShouldSetBoolOptionExplicit()
        {
            string[] cmdLineArgs = { "/BoolOption=true" };
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);

            Assert.IsTrue(testOptions.BoolOption);
        }

        [Test]
        [ExpectedException(typeof(CmdLineParserException))]
        public void ShouldRequireValueForString()
        {
            string[] cmdLineArgs = { "/StringOption" };
            parser = new CommandLineParser(cmdLineArgs);

            parser.BuildOptions(testOptions);
        }

        [Test]
        [ExpectedException(typeof(CmdLineParserException))]
        public void ShouldRequireValueForInt()
        {
            string[] cmdLineArgs = { "/IntOption" };
            parser = new CommandLineParser(cmdLineArgs);

            parser.BuildOptions(testOptions);
        }

        [Test]
        public void ShouldGetUsageLines()
        {
            IList<string> lines = CommandLineParser.GetUsageLines(testOptions);

            foreach (string line in lines)
                Console.WriteLine(line);

            Assert.That(lines.Count == 4);
        }

        [Test]
        [ExpectedException(typeof(RequiredParameterMissingException), ExpectedMessage = "The required parameter IntOption is missing")]
        public void Should_throw_an_exception_if_a_required_param_is_missing()
        {
            // missing int option
            string[] cmdLineArgs = { "/StringOption=Sneal", "/BoolOption" };
            parser = new CommandLineParser(cmdLineArgs);

            requiredTestOptions = parser.BuildOptions(requiredTestOptions);
            parser.EnsureRequiredOptions(requiredTestOptions);
        }

        [Test]
        public void Should_not_throw_an_exception_if_an_optional_param_is_missing()
        {
            // missing int option
            string[] cmdLineArgs = { "/StringOption=Sneal", "/BoolOption" };
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);
            parser.EnsureRequiredOptions(testOptions);
        }

        [Test]
        public void Can_handle_params_within_params()
        {
            string[] cmdLineArgs = { @"/StringOption=/p:msbuildprop1=prop1val" };
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);

            Assert.AreEqual("/p:msbuildprop1=prop1val", testOptions.StringOption);
        }

        [Test]
        public void Can_handle_multiple_params_within_params()
        {
            string[] cmdLineArgs = { @"""/StringOption=/p:msbuildprop1=prop1val /p:msbuildprop2=prop2val""" };
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);

            Assert.AreEqual("/p:msbuildprop1=prop1val /p:msbuildprop2=prop2val", testOptions.StringOption);
        }

        [Test]
        public void Should_turn_string_collection_into_generic_list_of_string()
        {
            string[] cmdLineArgs = { @"/StringList=val1 val2 val3" };
            parser = new CommandLineParser(cmdLineArgs);

            testOptions = parser.BuildOptions(testOptions);

            Assert.AreEqual(3, testOptions.StringList.Count);
            Assert.AreEqual("val1", testOptions.StringList[0]);
            Assert.AreEqual("val2", testOptions.StringList[1]);
            Assert.AreEqual("val3", testOptions.StringList[2]);
        }
    }

    public class TestOptions
    {
        private bool boolOption;
        private int intOption;
        private string stringOption;
        private List<string> _stringList;

        [Switch("StringOption", "Some sort of string option")]
        public string StringOption
        {
            get { return stringOption; }
            set { stringOption = value; }
        }

        [Switch("BoolOption", "Some sort of bool option")]
        public bool BoolOption
        {
            get { return boolOption; }
            set { boolOption = value; }
        }

        [Switch("IntOption", "Some sort of int option")]
        public int IntOption
        {
            get { return intOption; }
            set { intOption = value; }
        }

        [Switch("StringList", "Some sort of string collection option")]
        public IList<string> StringList
        {
            get { return _stringList.AsReadOnly(); }
            set { _stringList = new List<string>(value); }
        }
    }

    public class RequiredTestOptions
    {
        private bool boolOption;
        private int intOption;
        private string stringOption;

        [Switch("StringOption", "Some sort of string option", true)]
        public string StringOption
        {
            get { return stringOption; }
            set { stringOption = value; }
        }

        [Switch("BoolOption", "Some sort of bool option", true)]
        public bool BoolOption
        {
            get { return boolOption; }
            set { boolOption = value; }
        }

        [Switch("IntOption", "Some sort of int option", true)]
        public int IntOption
        {
            get { return intOption; }
            set { intOption = value; }
        }        
    }
}
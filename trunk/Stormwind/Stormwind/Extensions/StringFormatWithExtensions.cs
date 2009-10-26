﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text.RegularExpressions;
using System.Web.UI;

namespace Stormwind.Extensions
{
    /// <summary>
    /// String format extensions.
    /// </summary>
    public static class StringFormatWithExtensions
    {
        /// <summary>
        /// Formats the specifed string using named parameters.
        /// <example>Status.Text = "{UserName} last logged in at {LastLoginDate}".FormatWith(user);</example>
        /// </summary>
        public static string FormatWith(this string format, object source)
        {
            return FormatWith(format, null, source);
        }

        /// <summary>
        /// Formats the specifed string using named parameters.
        /// <example>Status.Text = "{UserName} last logged in at {LastLoginDate}".FormatWith(user);</example>
        /// </summary>
        public static string FormatWith(this string format, IFormatProvider provider, object source)
        {
            if (format == null)
                throw new ArgumentNullException("format");

            Regex r = new Regex(@"(?<start>\{)+(?<property>[\w\.\[\]]+)(?<format>:[^}]+)?(?<end>\})+",
                RegexOptions.Compiled | RegexOptions.CultureInvariant | RegexOptions.IgnoreCase);

            List<object> values = new List<object>();
            string rewrittenFormat = r.Replace(format, delegate(Match m)
            {
                Group startGroup = m.Groups["start"];
                Group propertyGroup = m.Groups["property"];
                Group formatGroup = m.Groups["format"];
                Group endGroup = m.Groups["end"];

                values.Add((propertyGroup.Value == "0")
                    ? source
                    : DataBinder.Eval(source, propertyGroup.Value));

                return new string('{', startGroup.Captures.Count) + (values.Count - 1) + formatGroup.Value
                    + new string('}', endGroup.Captures.Count);
            });

            return string.Format(provider, rewrittenFormat, values.ToArray());
        }
    }
}
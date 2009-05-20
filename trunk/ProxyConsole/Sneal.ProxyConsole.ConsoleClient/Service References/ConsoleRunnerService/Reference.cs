﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:2.0.50727.3053
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="StartExecutionMessage", Namespace="http://schemas.datacontract.org/2004/07/Sneal.ProxyConsole.WcfService")]
    [System.SerializableAttribute()]
    public partial class StartExecutionMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ArgumentsField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string FileNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int TimeoutField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string WorkingDirectoryField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private byte[] ZipPackageField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Arguments {
            get {
                return this.ArgumentsField;
            }
            set {
                if ((object.ReferenceEquals(this.ArgumentsField, value) != true)) {
                    this.ArgumentsField = value;
                    this.RaisePropertyChanged("Arguments");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string FileName {
            get {
                return this.FileNameField;
            }
            set {
                if ((object.ReferenceEquals(this.FileNameField, value) != true)) {
                    this.FileNameField = value;
                    this.RaisePropertyChanged("FileName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Timeout {
            get {
                return this.TimeoutField;
            }
            set {
                if ((this.TimeoutField.Equals(value) != true)) {
                    this.TimeoutField = value;
                    this.RaisePropertyChanged("Timeout");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string WorkingDirectory {
            get {
                return this.WorkingDirectoryField;
            }
            set {
                if ((object.ReferenceEquals(this.WorkingDirectoryField, value) != true)) {
                    this.WorkingDirectoryField = value;
                    this.RaisePropertyChanged("WorkingDirectory");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public byte[] ZipPackage {
            get {
                return this.ZipPackageField;
            }
            set {
                if ((object.ReferenceEquals(this.ZipPackageField, value) != true)) {
                    this.ZipPackageField = value;
                    this.RaisePropertyChanged("ZipPackage");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecutionFinishedMessage", Namespace="http://schemas.datacontract.org/2004/07/Sneal.ProxyConsole.WcfService")]
    [System.SerializableAttribute()]
    public partial class ExecutionFinishedMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int ExitCodeField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool IsErrorField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OutputField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int ExitCode {
            get {
                return this.ExitCodeField;
            }
            set {
                if ((this.ExitCodeField.Equals(value) != true)) {
                    this.ExitCodeField = value;
                    this.RaisePropertyChanged("ExitCode");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool IsError {
            get {
                return this.IsErrorField;
            }
            set {
                if ((this.IsErrorField.Equals(value) != true)) {
                    this.IsErrorField = value;
                    this.RaisePropertyChanged("IsError");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Output {
            get {
                return this.OutputField;
            }
            set {
                if ((object.ReferenceEquals(this.OutputField, value) != true)) {
                    this.OutputField = value;
                    this.RaisePropertyChanged("Output");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "3.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ExecutionProgressMessage", Namespace="http://schemas.datacontract.org/2004/07/Sneal.ProxyConsole.WcfService")]
    [System.SerializableAttribute()]
    public partial class ExecutionProgressMessage : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string OutputField;
        
        [global::System.ComponentModel.BrowsableAttribute(false)]
        public System.Runtime.Serialization.ExtensionDataObject ExtensionData {
            get {
                return this.extensionDataField;
            }
            set {
                this.extensionDataField = value;
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Output {
            get {
                return this.OutputField;
            }
            set {
                if ((object.ReferenceEquals(this.OutputField, value) != true)) {
                    this.OutputField = value;
                    this.RaisePropertyChanged("Output");
                }
            }
        }
        
        public event System.ComponentModel.PropertyChangedEventHandler PropertyChanged;
        
        protected void RaisePropertyChanged(string propertyName) {
            System.ComponentModel.PropertyChangedEventHandler propertyChanged = this.PropertyChanged;
            if ((propertyChanged != null)) {
                propertyChanged(this, new System.ComponentModel.PropertyChangedEventArgs(propertyName));
            }
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://proxyconsole.sneal.net", ConfigurationName="ConsoleRunnerService.ConsoleRunner", CallbackContract=typeof(Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.ConsoleRunnerCallback), SessionMode=System.ServiceModel.SessionMode.Required)]
    public interface ConsoleRunner {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://proxyconsole.sneal.net/ConsoleRunner/Run", ReplyAction="http://proxyconsole.sneal.net/ConsoleRunner/RunResponse")]
        void Run(Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.StartExecutionMessage requestMsg);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ConsoleRunnerCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://proxyconsole.sneal.net/ConsoleRunner/ExecutionComplete")]
        void ExecutionComplete(Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.ExecutionFinishedMessage completeMessage);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://proxyconsole.sneal.net/ConsoleRunner/ExecutionProgress")]
        void ExecutionProgress(Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.ExecutionProgressMessage progressMessage);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public interface ConsoleRunnerChannel : Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.ConsoleRunner, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "3.0.0.0")]
    public partial class ConsoleRunnerClient : System.ServiceModel.DuplexClientBase<Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.ConsoleRunner>, Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.ConsoleRunner {
        
        public ConsoleRunnerClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public ConsoleRunnerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public ConsoleRunnerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ConsoleRunnerClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public ConsoleRunnerClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void Run(Sneal.ProxyConsole.ConsoleClient.ConsoleRunnerService.StartExecutionMessage requestMsg) {
            base.Channel.Run(requestMsg);
        }
    }
}

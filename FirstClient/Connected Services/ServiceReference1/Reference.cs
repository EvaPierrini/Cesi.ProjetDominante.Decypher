﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Ce code a été généré par un outil.
//     Version du runtime :4.0.30319.42000
//
//     Les modifications apportées à ce fichier peuvent provoquer un comportement incorrect et seront perdues si
//     le code est régénéré.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FirstClient.ServiceReference1 {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MSG", Namespace="http://schemas.datacontract.org/2004/07/WcfService1")]
    [System.SerializableAttribute()]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(string[]))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(object[]))]
    public partial class MSG : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string appVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private object[] dataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string infoField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string operationNameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string operationVersionField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private bool statutOpField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenAppField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string tokenUserField;
        
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
        public string appVersion {
            get {
                return this.appVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.appVersionField, value) != true)) {
                    this.appVersionField = value;
                    this.RaisePropertyChanged("appVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public object[] data {
            get {
                return this.dataField;
            }
            set {
                if ((object.ReferenceEquals(this.dataField, value) != true)) {
                    this.dataField = value;
                    this.RaisePropertyChanged("data");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string info {
            get {
                return this.infoField;
            }
            set {
                if ((object.ReferenceEquals(this.infoField, value) != true)) {
                    this.infoField = value;
                    this.RaisePropertyChanged("info");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string operationName {
            get {
                return this.operationNameField;
            }
            set {
                if ((object.ReferenceEquals(this.operationNameField, value) != true)) {
                    this.operationNameField = value;
                    this.RaisePropertyChanged("operationName");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string operationVersion {
            get {
                return this.operationVersionField;
            }
            set {
                if ((object.ReferenceEquals(this.operationVersionField, value) != true)) {
                    this.operationVersionField = value;
                    this.RaisePropertyChanged("operationVersion");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public bool statutOp {
            get {
                return this.statutOpField;
            }
            set {
                if ((this.statutOpField.Equals(value) != true)) {
                    this.statutOpField = value;
                    this.RaisePropertyChanged("statutOp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tokenApp {
            get {
                return this.tokenAppField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenAppField, value) != true)) {
                    this.tokenAppField = value;
                    this.RaisePropertyChanged("tokenApp");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string tokenUser {
            get {
                return this.tokenUserField;
            }
            set {
                if ((object.ReferenceEquals(this.tokenUserField, value) != true)) {
                    this.tokenUserField = value;
                    this.RaisePropertyChanged("tokenUser");
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
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindSecretKey", ReplyAction="http://tempuri.org/IService1/FindSecretKeyResponse")]
        void FindSecretKey(string[] Text, string[] Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/FindSecretKey", ReplyAction="http://tempuri.org/IService1/FindSecretKeyResponse")]
        System.Threading.Tasks.Task FindSecretKeyAsync(string[] Text, string[] Name);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetData", ReplyAction="http://tempuri.org/IService1/SetDataResponse")]
        FirstClient.ServiceReference1.MSG SetData(string tokenUser, string[] textFile, string[] textName);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/SetData", ReplyAction="http://tempuri.org/IService1/SetDataResponse")]
        System.Threading.Tasks.Task<FirstClient.ServiceReference1.MSG> SetDataAsync(string tokenUser, string[] textFile, string[] textName);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FirstClient.ServiceReference1.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FirstClient.ServiceReference1.IService1>, FirstClient.ServiceReference1.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public void FindSecretKey(string[] Text, string[] Name) {
            base.Channel.FindSecretKey(Text, Name);
        }
        
        public System.Threading.Tasks.Task FindSecretKeyAsync(string[] Text, string[] Name) {
            return base.Channel.FindSecretKeyAsync(Text, Name);
        }
        
        public FirstClient.ServiceReference1.MSG SetData(string tokenUser, string[] textFile, string[] textName) {
            return base.Channel.SetData(tokenUser, textFile, textName);
        }
        
        public System.Threading.Tasks.Task<FirstClient.ServiceReference1.MSG> SetDataAsync(string tokenUser, string[] textFile, string[] textName) {
            return base.Channel.SetDataAsync(tokenUser, textFile, textName);
        }
    }
}

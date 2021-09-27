﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Este código fue generado por una herramienta.
//     Versión de runtime:4.0.30319.42000
//
//     Los cambios en este archivo podrían causar un comportamiento incorrecto y se perderán si
//     se vuelve a generar el código.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Metal_Bake.Infra.WcfStockReference {
    using System.Runtime.Serialization;
    using System;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="ItemStock", Namespace="http://schemas.datacontract.org/2004/07/")]
    [System.SerializableAttribute()]
    public partial class ItemStock : object, System.Runtime.Serialization.IExtensibleDataObject, System.ComponentModel.INotifyPropertyChanged {
        
        [System.NonSerializedAttribute()]
        private System.Runtime.Serialization.ExtensionDataObject extensionDataField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string ItemIdField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private string NameField;
        
        [System.Runtime.Serialization.OptionalFieldAttribute()]
        private int StockField;
        
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
        public string ItemId {
            get {
                return this.ItemIdField;
            }
            set {
                if ((object.ReferenceEquals(this.ItemIdField, value) != true)) {
                    this.ItemIdField = value;
                    this.RaisePropertyChanged("ItemId");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string Name {
            get {
                return this.NameField;
            }
            set {
                if ((object.ReferenceEquals(this.NameField, value) != true)) {
                    this.NameField = value;
                    this.RaisePropertyChanged("Name");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int Stock {
            get {
                return this.StockField;
            }
            set {
                if ((this.StockField.Equals(value) != true)) {
                    this.StockField = value;
                    this.RaisePropertyChanged("Stock");
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
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="WcfStockReference.IService")]
    public interface IService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Exist", ReplyAction="http://tempuri.org/IService/ExistResponse")]
        bool Exist(string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/Exist", ReplyAction="http://tempuri.org/IService/ExistResponse")]
        System.Threading.Tasks.Task<bool> ExistAsync(string item);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStock", ReplyAction="http://tempuri.org/IService/GetStockResponse")]
        int GetStock(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetStock", ReplyAction="http://tempuri.org/IService/GetStockResponse")]
        System.Threading.Tasks.Task<int> GetStockAsync(string key);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckStock", ReplyAction="http://tempuri.org/IService/CheckStockResponse")]
        bool CheckStock(string item, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/CheckStock", ReplyAction="http://tempuri.org/IService/CheckStockResponse")]
        System.Threading.Tasks.Task<bool> CheckStockAsync(string item, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReduceStock", ReplyAction="http://tempuri.org/IService/ReduceStockResponse")]
        bool ReduceStock(string item, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/ReduceStock", ReplyAction="http://tempuri.org/IService/ReduceStockResponse")]
        System.Threading.Tasks.Task<bool> ReduceStockAsync(string item, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IncreaseStock", ReplyAction="http://tempuri.org/IService/IncreaseStockResponse")]
        bool IncreaseStock(string item, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/IncreaseStock", ReplyAction="http://tempuri.org/IService/IncreaseStockResponse")]
        System.Threading.Tasks.Task<bool> IncreaseStockAsync(string item, int amount);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllStock", ReplyAction="http://tempuri.org/IService/GetAllStockResponse")]
        Metal_Bake.Infra.WcfStockReference.ItemStock[] GetAllStock();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/GetAllStock", ReplyAction="http://tempuri.org/IService/GetAllStockResponse")]
        System.Threading.Tasks.Task<Metal_Bake.Infra.WcfStockReference.ItemStock[]> GetAllStockAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TxtListStock", ReplyAction="http://tempuri.org/IService/TxtListStockResponse")]
        void TxtListStock();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService/TxtListStock", ReplyAction="http://tempuri.org/IService/TxtListStockResponse")]
        System.Threading.Tasks.Task TxtListStockAsync();
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServiceChannel : Metal_Bake.Infra.WcfStockReference.IService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServiceClient : System.ServiceModel.ClientBase<Metal_Bake.Infra.WcfStockReference.IService>, Metal_Bake.Infra.WcfStockReference.IService {
        
        public ServiceClient() {
        }
        
        public ServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public bool Exist(string item) {
            return base.Channel.Exist(item);
        }
        
        public System.Threading.Tasks.Task<bool> ExistAsync(string item) {
            return base.Channel.ExistAsync(item);
        }
        
        public int GetStock(string key) {
            return base.Channel.GetStock(key);
        }
        
        public System.Threading.Tasks.Task<int> GetStockAsync(string key) {
            return base.Channel.GetStockAsync(key);
        }
        
        public bool CheckStock(string item, int amount) {
            return base.Channel.CheckStock(item, amount);
        }
        
        public System.Threading.Tasks.Task<bool> CheckStockAsync(string item, int amount) {
            return base.Channel.CheckStockAsync(item, amount);
        }
        
        public bool ReduceStock(string item, int amount) {
            return base.Channel.ReduceStock(item, amount);
        }
        
        public System.Threading.Tasks.Task<bool> ReduceStockAsync(string item, int amount) {
            return base.Channel.ReduceStockAsync(item, amount);
        }
        
        public bool IncreaseStock(string item, int amount) {
            return base.Channel.IncreaseStock(item, amount);
        }
        
        public System.Threading.Tasks.Task<bool> IncreaseStockAsync(string item, int amount) {
            return base.Channel.IncreaseStockAsync(item, amount);
        }
        
        public Metal_Bake.Infra.WcfStockReference.ItemStock[] GetAllStock() {
            return base.Channel.GetAllStock();
        }
        
        public System.Threading.Tasks.Task<Metal_Bake.Infra.WcfStockReference.ItemStock[]> GetAllStockAsync() {
            return base.Channel.GetAllStockAsync();
        }
        
        public void TxtListStock() {
            base.Channel.TxtListStock();
        }
        
        public System.Threading.Tasks.Task TxtListStockAsync() {
            return base.Channel.TxtListStockAsync();
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment5.SerRef {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SerRef.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/disaster", ReplyAction="http://tempuri.org/IService1/disasterResponse")]
        string disaster(string latitude, string longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/disaster", ReplyAction="http://tempuri.org/IService1/disasterResponse")]
        System.Threading.Tasks.Task<string> disasterAsync(string latitude, string longitude);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getNearestStores", ReplyAction="http://tempuri.org/IService1/getNearestStoresResponse")]
        string[] getNearestStores(string ZipCode);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/getNearestStores", ReplyAction="http://tempuri.org/IService1/getNearestStoresResponse")]
        System.Threading.Tasks.Task<string[]> getNearestStoresAsync(string ZipCode);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : Assignment5.SerRef.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<Assignment5.SerRef.IService1>, Assignment5.SerRef.IService1 {
        
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
        
        public string disaster(string latitude, string longitude) {
            return base.Channel.disaster(latitude, longitude);
        }
        
        public System.Threading.Tasks.Task<string> disasterAsync(string latitude, string longitude) {
            return base.Channel.disasterAsync(latitude, longitude);
        }
        
        public string[] getNearestStores(string ZipCode) {
            return base.Channel.getNearestStores(ZipCode);
        }
        
        public System.Threading.Tasks.Task<string[]> getNearestStoresAsync(string ZipCode) {
            return base.Channel.getNearestStoresAsync(ZipCode);
        }
    }
}

﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18444
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Assignment5.SRNewsFocus {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="SRNewsFocus.IServicenewsfocus")]
    public interface IServicenewsfocus {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicenewsfocus/Newsfocus", ReplyAction="http://tempuri.org/IServicenewsfocus/NewsfocusResponse")]
        string[] Newsfocus(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicenewsfocus/Newsfocus", ReplyAction="http://tempuri.org/IServicenewsfocus/NewsfocusResponse")]
        System.Threading.Tasks.Task<string[]> NewsfocusAsync(string xml);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicenewsfocus/Getxml", ReplyAction="http://tempuri.org/IServicenewsfocus/GetxmlResponse")]
        string Getxml(string keyword);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IServicenewsfocus/Getxml", ReplyAction="http://tempuri.org/IServicenewsfocus/GetxmlResponse")]
        System.Threading.Tasks.Task<string> GetxmlAsync(string keyword);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IServicenewsfocusChannel : Assignment5.SRNewsFocus.IServicenewsfocus, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ServicenewsfocusClient : System.ServiceModel.ClientBase<Assignment5.SRNewsFocus.IServicenewsfocus>, Assignment5.SRNewsFocus.IServicenewsfocus {
        
        public ServicenewsfocusClient() {
        }
        
        public ServicenewsfocusClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ServicenewsfocusClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicenewsfocusClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ServicenewsfocusClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] Newsfocus(string xml) {
            return base.Channel.Newsfocus(xml);
        }
        
        public System.Threading.Tasks.Task<string[]> NewsfocusAsync(string xml) {
            return base.Channel.NewsfocusAsync(xml);
        }
        
        public string Getxml(string keyword) {
            return base.Channel.Getxml(keyword);
        }
        
        public System.Threading.Tasks.Task<string> GetxmlAsync(string keyword) {
            return base.Channel.GetxmlAsync(keyword);
        }
    }
}

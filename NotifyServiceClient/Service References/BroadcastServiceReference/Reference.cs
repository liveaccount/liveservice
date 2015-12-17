﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.18408
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace NotifyServiceClient.BroadcastServiceReference {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="BroadcastServiceReference.IBroadcastService", CallbackContract=typeof(NotifyServiceClient.BroadcastServiceReference.IBroadcastServiceCallback))]
    public interface IBroadcastService {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBroadcastService/RegisterClient")]
        void RegisterClient(string clientName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBroadcastService/RegisterClient")]
        System.Threading.Tasks.Task RegisterClientAsync(string clientName);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBroadcastService/NotifyServer")]
        void NotifyServer(NotifyService.EventDataType eventData);
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBroadcastService/NotifyServer")]
        System.Threading.Tasks.Task NotifyServerAsync(NotifyService.EventDataType eventData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBroadcastServiceCallback {
        
        [System.ServiceModel.OperationContractAttribute(IsOneWay=true, Action="http://tempuri.org/IBroadcastService/BroadcastToClient")]
        void BroadcastToClient(NotifyService.EventDataType eventData);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IBroadcastServiceChannel : NotifyServiceClient.BroadcastServiceReference.IBroadcastService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class BroadcastServiceClient : System.ServiceModel.DuplexClientBase<NotifyServiceClient.BroadcastServiceReference.IBroadcastService>, NotifyServiceClient.BroadcastServiceReference.IBroadcastService {
        
        public BroadcastServiceClient(System.ServiceModel.InstanceContext callbackInstance) : 
                base(callbackInstance) {
        }
        
        public BroadcastServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName) : 
                base(callbackInstance, endpointConfigurationName) {
        }
        
        public BroadcastServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, string remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BroadcastServiceClient(System.ServiceModel.InstanceContext callbackInstance, string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, endpointConfigurationName, remoteAddress) {
        }
        
        public BroadcastServiceClient(System.ServiceModel.InstanceContext callbackInstance, System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(callbackInstance, binding, remoteAddress) {
        }
        
        public void RegisterClient(string clientName) {
            base.Channel.RegisterClient(clientName);
        }
        
        public System.Threading.Tasks.Task RegisterClientAsync(string clientName) {
            return base.Channel.RegisterClientAsync(clientName);
        }
        
        public void NotifyServer(NotifyService.EventDataType eventData) {
            base.Channel.NotifyServer(eventData);
        }
        
        public System.Threading.Tasks.Task NotifyServerAsync(NotifyService.EventDataType eventData) {
            return base.Channel.NotifyServerAsync(eventData);
        }
    }
}

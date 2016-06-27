﻿//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан программой.
//     Исполняемая версия:4.0.30319.42000
//
//     Изменения в этом файле могут привести к неправильной работе и будут потеряны в случае
//     повторной генерации кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace WinFormApp.ServiceReferenceOnSelfHost {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReferenceOnSelfHost.IContract")]
    public interface IContract {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/CalcFactorial", ReplyAction="http://tempuri.org/IContract/CalcFactorialResponse")]
        int CalcFactorial(int i);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/ReversString", ReplyAction="http://tempuri.org/IContract/ReversStringResponse")]
        string ReversString(string param);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/GetPlayer", ReplyAction="http://tempuri.org/IContract/GetPlayerResponse")]
        Service.Player GetPlayer(int id);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IContract/SetPlayer", ReplyAction="http://tempuri.org/IContract/SetPlayerResponse")]
        void SetPlayer(Service.Player player);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IContractChannel : WinFormApp.ServiceReferenceOnSelfHost.IContract, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ContractClient : System.ServiceModel.ClientBase<WinFormApp.ServiceReferenceOnSelfHost.IContract>, WinFormApp.ServiceReferenceOnSelfHost.IContract {
        
        public ContractClient() {
        }
        
        public ContractClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ContractClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ContractClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int CalcFactorial(int i) {
            return base.Channel.CalcFactorial(i);
        }
        
        public string ReversString(string param) {
            return base.Channel.ReversString(param);
        }
        
        public Service.Player GetPlayer(int id) {
            return base.Channel.GetPlayer(id);
        }
        
        public void SetPlayer(Service.Player player) {
            base.Channel.SetPlayer(player);
        }
    }
}

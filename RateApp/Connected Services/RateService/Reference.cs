﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace RateApp.RateService {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="RateService.IRateService")]
    public interface IRateService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRateService/GetCurrencies", ReplyAction="http://tempuri.org/IRateService/GetCurrenciesResponse")]
        string[] GetCurrencies();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRateService/GetCurrencies", ReplyAction="http://tempuri.org/IRateService/GetCurrenciesResponse")]
        System.Threading.Tasks.Task<string[]> GetCurrenciesAsync();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRateService/GetRate", ReplyAction="http://tempuri.org/IRateService/GetRateResponse")]
        double GetRate(string currencyType);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IRateService/GetRate", ReplyAction="http://tempuri.org/IRateService/GetRateResponse")]
        System.Threading.Tasks.Task<double> GetRateAsync(string currencyType);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IRateServiceChannel : RateApp.RateService.IRateService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class RateServiceClient : System.ServiceModel.ClientBase<RateApp.RateService.IRateService>, RateApp.RateService.IRateService {
        
        public RateServiceClient() {
        }
        
        public RateServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public RateServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RateServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public RateServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public string[] GetCurrencies() {
            return base.Channel.GetCurrencies();
        }
        
        public System.Threading.Tasks.Task<string[]> GetCurrenciesAsync() {
            return base.Channel.GetCurrenciesAsync();
        }
        
        public double GetRate(string currencyType) {
            return base.Channel.GetRate(currencyType);
        }
        
        public System.Threading.Tasks.Task<double> GetRateAsync(string currencyType) {
            return base.Channel.GetRateAsync(currencyType);
        }
    }
}

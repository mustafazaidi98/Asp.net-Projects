﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Q6.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="http://alleychu.org/", ConfigurationName="ServiceReference1.WebService1Soap")]
    public interface WebService1Soap {
        
        // CODEGEN: Generating message contract since element name sc from namespace http://alleychu.org/ is not marked nillable
        [System.ServiceModel.OperationContractAttribute(Action="http://alleychu.org/Conversion", ReplyAction="*")]
        Q6.ServiceReference1.ConversionResponse Conversion(Q6.ServiceReference1.ConversionRequest request);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://alleychu.org/Conversion", ReplyAction="*")]
        System.Threading.Tasks.Task<Q6.ServiceReference1.ConversionResponse> ConversionAsync(Q6.ServiceReference1.ConversionRequest request);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConversionRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="Conversion", Namespace="http://alleychu.org/", Order=0)]
        public Q6.ServiceReference1.ConversionRequestBody Body;
        
        public ConversionRequest() {
        }
        
        public ConversionRequest(Q6.ServiceReference1.ConversionRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://alleychu.org/")]
    public partial class ConversionRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string sc;
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=1)]
        public string dc;
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=2)]
        public int value;
        
        public ConversionRequestBody() {
        }
        
        public ConversionRequestBody(string sc, string dc, int value) {
            this.sc = sc;
            this.dc = dc;
            this.value = value;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class ConversionResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="ConversionResponse", Namespace="http://alleychu.org/", Order=0)]
        public Q6.ServiceReference1.ConversionResponseBody Body;
        
        public ConversionResponse() {
        }
        
        public ConversionResponse(Q6.ServiceReference1.ConversionResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://alleychu.org/")]
    public partial class ConversionResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(Order=0)]
        public int ConversionResult;
        
        public ConversionResponseBody() {
        }
        
        public ConversionResponseBody(int ConversionResult) {
            this.ConversionResult = ConversionResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface WebService1SoapChannel : Q6.ServiceReference1.WebService1Soap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class WebService1SoapClient : System.ServiceModel.ClientBase<Q6.ServiceReference1.WebService1Soap>, Q6.ServiceReference1.WebService1Soap {
        
        public WebService1SoapClient() {
        }
        
        public WebService1SoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public WebService1SoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        Q6.ServiceReference1.ConversionResponse Q6.ServiceReference1.WebService1Soap.Conversion(Q6.ServiceReference1.ConversionRequest request) {
            return base.Channel.Conversion(request);
        }
        
        public int Conversion(string sc, string dc, int value) {
            Q6.ServiceReference1.ConversionRequest inValue = new Q6.ServiceReference1.ConversionRequest();
            inValue.Body = new Q6.ServiceReference1.ConversionRequestBody();
            inValue.Body.sc = sc;
            inValue.Body.dc = dc;
            inValue.Body.value = value;
            Q6.ServiceReference1.ConversionResponse retVal = ((Q6.ServiceReference1.WebService1Soap)(this)).Conversion(inValue);
            return retVal.Body.ConversionResult;
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Threading.Tasks.Task<Q6.ServiceReference1.ConversionResponse> Q6.ServiceReference1.WebService1Soap.ConversionAsync(Q6.ServiceReference1.ConversionRequest request) {
            return base.Channel.ConversionAsync(request);
        }
        
        public System.Threading.Tasks.Task<Q6.ServiceReference1.ConversionResponse> ConversionAsync(string sc, string dc, int value) {
            Q6.ServiceReference1.ConversionRequest inValue = new Q6.ServiceReference1.ConversionRequest();
            inValue.Body = new Q6.ServiceReference1.ConversionRequestBody();
            inValue.Body.sc = sc;
            inValue.Body.dc = dc;
            inValue.Body.value = value;
            return ((Q6.ServiceReference1.WebService1Soap)(this)).ConversionAsync(inValue);
        }
    }
}

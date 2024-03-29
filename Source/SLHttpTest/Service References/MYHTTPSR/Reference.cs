﻿//------------------------------------------------------------------------------
// <auto-generated>
//     此代码由工具生成。
//     运行时版本:4.0.30319.1
//
//     对此文件的更改可能会导致不正确的行为，并且如果
//     重新生成代码，这些更改将会丢失。
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace SLHttpTest.MYHTTPSR {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="MYHTTPSR.HttpHelperSoap")]
    public interface HttpHelperSoap {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="http://tempuri.org/GetURL", ReplyAction="*")]
        System.IAsyncResult BeginGetURL(SLHttpTest.MYHTTPSR.GetURLRequest request, System.AsyncCallback callback, object asyncState);
        
        SLHttpTest.MYHTTPSR.GetURLResponse EndGetURL(System.IAsyncResult result);
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetURLRequest {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetURL", Namespace="http://tempuri.org/", Order=0)]
        public SLHttpTest.MYHTTPSR.GetURLRequestBody Body;
        
        public GetURLRequest() {
        }
        
        public GetURLRequest(SLHttpTest.MYHTTPSR.GetURLRequestBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetURLRequestBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string URL;
        
        public GetURLRequestBody() {
        }
        
        public GetURLRequestBody(string URL) {
            this.URL = URL;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.ServiceModel.MessageContractAttribute(IsWrapped=false)]
    public partial class GetURLResponse {
        
        [System.ServiceModel.MessageBodyMemberAttribute(Name="GetURLResponse", Namespace="http://tempuri.org/", Order=0)]
        public SLHttpTest.MYHTTPSR.GetURLResponseBody Body;
        
        public GetURLResponse() {
        }
        
        public GetURLResponse(SLHttpTest.MYHTTPSR.GetURLResponseBody Body) {
            this.Body = Body;
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
    [System.Runtime.Serialization.DataContractAttribute(Namespace="http://tempuri.org/")]
    public partial class GetURLResponseBody {
        
        [System.Runtime.Serialization.DataMemberAttribute(EmitDefaultValue=false, Order=0)]
        public string GetURLResult;
        
        public GetURLResponseBody() {
        }
        
        public GetURLResponseBody(string GetURLResult) {
            this.GetURLResult = GetURLResult;
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface HttpHelperSoapChannel : SLHttpTest.MYHTTPSR.HttpHelperSoap, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetURLCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetURLCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public string Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((string)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class HttpHelperSoapClient : System.ServiceModel.ClientBase<SLHttpTest.MYHTTPSR.HttpHelperSoap>, SLHttpTest.MYHTTPSR.HttpHelperSoap {
        
        private BeginOperationDelegate onBeginGetURLDelegate;
        
        private EndOperationDelegate onEndGetURLDelegate;
        
        private System.Threading.SendOrPostCallback onGetURLCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public HttpHelperSoapClient() {
        }
        
        public HttpHelperSoapClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public HttpHelperSoapClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HttpHelperSoapClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public HttpHelperSoapClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Net.CookieContainer CookieContainer {
            get {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    return httpCookieContainerManager.CookieContainer;
                }
                else {
                    return null;
                }
            }
            set {
                System.ServiceModel.Channels.IHttpCookieContainerManager httpCookieContainerManager = this.InnerChannel.GetProperty<System.ServiceModel.Channels.IHttpCookieContainerManager>();
                if ((httpCookieContainerManager != null)) {
                    httpCookieContainerManager.CookieContainer = value;
                }
                else {
                    throw new System.InvalidOperationException("无法设置 CookieContainer。请确保绑定包含 HttpCookieContainerBindingElement。");
                }
            }
        }
        
        public event System.EventHandler<GetURLCompletedEventArgs> GetURLCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult SLHttpTest.MYHTTPSR.HttpHelperSoap.BeginGetURL(SLHttpTest.MYHTTPSR.GetURLRequest request, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetURL(request, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private System.IAsyncResult BeginGetURL(string URL, System.AsyncCallback callback, object asyncState) {
            SLHttpTest.MYHTTPSR.GetURLRequest inValue = new SLHttpTest.MYHTTPSR.GetURLRequest();
            inValue.Body = new SLHttpTest.MYHTTPSR.GetURLRequestBody();
            inValue.Body.URL = URL;
            return ((SLHttpTest.MYHTTPSR.HttpHelperSoap)(this)).BeginGetURL(inValue, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        SLHttpTest.MYHTTPSR.GetURLResponse SLHttpTest.MYHTTPSR.HttpHelperSoap.EndGetURL(System.IAsyncResult result) {
            return base.Channel.EndGetURL(result);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        private string EndGetURL(System.IAsyncResult result) {
            SLHttpTest.MYHTTPSR.GetURLResponse retVal = ((SLHttpTest.MYHTTPSR.HttpHelperSoap)(this)).EndGetURL(result);
            return retVal.Body.GetURLResult;
        }
        
        private System.IAsyncResult OnBeginGetURL(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string URL = ((string)(inValues[0]));
            return this.BeginGetURL(URL, callback, asyncState);
        }
        
        private object[] OnEndGetURL(System.IAsyncResult result) {
            string retVal = this.EndGetURL(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetURLCompleted(object state) {
            if ((this.GetURLCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetURLCompleted(this, new GetURLCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetURLAsync(string URL) {
            this.GetURLAsync(URL, null);
        }
        
        public void GetURLAsync(string URL, object userState) {
            if ((this.onBeginGetURLDelegate == null)) {
                this.onBeginGetURLDelegate = new BeginOperationDelegate(this.OnBeginGetURL);
            }
            if ((this.onEndGetURLDelegate == null)) {
                this.onEndGetURLDelegate = new EndOperationDelegate(this.OnEndGetURL);
            }
            if ((this.onGetURLCompletedDelegate == null)) {
                this.onGetURLCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetURLCompleted);
            }
            base.InvokeAsync(this.onBeginGetURLDelegate, new object[] {
                        URL}, this.onEndGetURLDelegate, this.onGetURLCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginOpen(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginOpen(callback, asyncState);
        }
        
        private object[] OnEndOpen(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndOpen(result);
            return null;
        }
        
        private void OnOpenCompleted(object state) {
            if ((this.OpenCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.OpenCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void OpenAsync() {
            this.OpenAsync(null);
        }
        
        public void OpenAsync(object userState) {
            if ((this.onBeginOpenDelegate == null)) {
                this.onBeginOpenDelegate = new BeginOperationDelegate(this.OnBeginOpen);
            }
            if ((this.onEndOpenDelegate == null)) {
                this.onEndOpenDelegate = new EndOperationDelegate(this.OnEndOpen);
            }
            if ((this.onOpenCompletedDelegate == null)) {
                this.onOpenCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnOpenCompleted);
            }
            base.InvokeAsync(this.onBeginOpenDelegate, null, this.onEndOpenDelegate, this.onOpenCompletedDelegate, userState);
        }
        
        private System.IAsyncResult OnBeginClose(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((System.ServiceModel.ICommunicationObject)(this)).BeginClose(callback, asyncState);
        }
        
        private object[] OnEndClose(System.IAsyncResult result) {
            ((System.ServiceModel.ICommunicationObject)(this)).EndClose(result);
            return null;
        }
        
        private void OnCloseCompleted(object state) {
            if ((this.CloseCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CloseCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CloseAsync() {
            this.CloseAsync(null);
        }
        
        public void CloseAsync(object userState) {
            if ((this.onBeginCloseDelegate == null)) {
                this.onBeginCloseDelegate = new BeginOperationDelegate(this.OnBeginClose);
            }
            if ((this.onEndCloseDelegate == null)) {
                this.onEndCloseDelegate = new EndOperationDelegate(this.OnEndClose);
            }
            if ((this.onCloseCompletedDelegate == null)) {
                this.onCloseCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCloseCompleted);
            }
            base.InvokeAsync(this.onBeginCloseDelegate, null, this.onEndCloseDelegate, this.onCloseCompletedDelegate, userState);
        }
        
        protected override SLHttpTest.MYHTTPSR.HttpHelperSoap CreateChannel() {
            return new HttpHelperSoapClientChannel(this);
        }
        
        private class HttpHelperSoapClientChannel : ChannelBase<SLHttpTest.MYHTTPSR.HttpHelperSoap>, SLHttpTest.MYHTTPSR.HttpHelperSoap {
            
            public HttpHelperSoapClientChannel(System.ServiceModel.ClientBase<SLHttpTest.MYHTTPSR.HttpHelperSoap> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetURL(SLHttpTest.MYHTTPSR.GetURLRequest request, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = request;
                System.IAsyncResult _result = base.BeginInvoke("GetURL", _args, callback, asyncState);
                return _result;
            }
            
            public SLHttpTest.MYHTTPSR.GetURLResponse EndGetURL(System.IAsyncResult result) {
                object[] _args = new object[0];
                SLHttpTest.MYHTTPSR.GetURLResponse _result = ((SLHttpTest.MYHTTPSR.GetURLResponse)(base.EndInvoke("GetURL", _args, result)));
                return _result;
            }
        }
    }
}

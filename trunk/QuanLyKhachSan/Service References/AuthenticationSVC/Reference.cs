﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace QuanLyKhachSan.AuthenticationSVC {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="AuthenticationSVC.AuthenticationSVC")]
    public interface AuthenticationSVC {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:AuthenticationSVC/Authentication_SetSession", ReplyAction="urn:AuthenticationSVC/Authentication_SetSessionResponse")]
        System.IAsyncResult BeginAuthentication_SetSession(string UserName, System.AsyncCallback callback, object asyncState);
        
        void EndAuthentication_SetSession(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:AuthenticationSVC/Authentication_CheckAccount", ReplyAction="urn:AuthenticationSVC/Authentication_CheckAccountResponse")]
        System.IAsyncResult BeginAuthentication_CheckAccount(string UserName, string PassWord, System.AsyncCallback callback, object asyncState);
        
        string EndAuthentication_CheckAccount(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:AuthenticationSVC/Authentication_GetSession", ReplyAction="urn:AuthenticationSVC/Authentication_GetSessionResponse")]
        System.IAsyncResult BeginAuthentication_GetSession(System.AsyncCallback callback, object asyncState);
        
        string EndAuthentication_GetSession(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface AuthenticationSVCChannel : QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Authentication_CheckAccountCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public Authentication_CheckAccountCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class Authentication_GetSessionCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public Authentication_GetSessionCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
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
    public partial class AuthenticationSVCClient : System.ServiceModel.ClientBase<QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC>, QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC {
        
        private BeginOperationDelegate onBeginAuthentication_SetSessionDelegate;
        
        private EndOperationDelegate onEndAuthentication_SetSessionDelegate;
        
        private System.Threading.SendOrPostCallback onAuthentication_SetSessionCompletedDelegate;
        
        private BeginOperationDelegate onBeginAuthentication_CheckAccountDelegate;
        
        private EndOperationDelegate onEndAuthentication_CheckAccountDelegate;
        
        private System.Threading.SendOrPostCallback onAuthentication_CheckAccountCompletedDelegate;
        
        private BeginOperationDelegate onBeginAuthentication_GetSessionDelegate;
        
        private EndOperationDelegate onEndAuthentication_GetSessionDelegate;
        
        private System.Threading.SendOrPostCallback onAuthentication_GetSessionCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public AuthenticationSVCClient() {
        }
        
        public AuthenticationSVCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public AuthenticationSVCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationSVCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public AuthenticationSVCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
                    throw new System.InvalidOperationException("Unable to set the CookieContainer. Please make sure the binding contains an HttpC" +
                            "ookieContainerBindingElement.");
                }
            }
        }
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> Authentication_SetSessionCompleted;
        
        public event System.EventHandler<Authentication_CheckAccountCompletedEventArgs> Authentication_CheckAccountCompleted;
        
        public event System.EventHandler<Authentication_GetSessionCompletedEventArgs> Authentication_GetSessionCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC.BeginAuthentication_SetSession(string UserName, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAuthentication_SetSession(UserName, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC.EndAuthentication_SetSession(System.IAsyncResult result) {
            base.Channel.EndAuthentication_SetSession(result);
        }
        
        private System.IAsyncResult OnBeginAuthentication_SetSession(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string UserName = ((string)(inValues[0]));
            return ((QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC)(this)).BeginAuthentication_SetSession(UserName, callback, asyncState);
        }
        
        private object[] OnEndAuthentication_SetSession(System.IAsyncResult result) {
            ((QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC)(this)).EndAuthentication_SetSession(result);
            return null;
        }
        
        private void OnAuthentication_SetSessionCompleted(object state) {
            if ((this.Authentication_SetSessionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.Authentication_SetSessionCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void Authentication_SetSessionAsync(string UserName) {
            this.Authentication_SetSessionAsync(UserName, null);
        }
        
        public void Authentication_SetSessionAsync(string UserName, object userState) {
            if ((this.onBeginAuthentication_SetSessionDelegate == null)) {
                this.onBeginAuthentication_SetSessionDelegate = new BeginOperationDelegate(this.OnBeginAuthentication_SetSession);
            }
            if ((this.onEndAuthentication_SetSessionDelegate == null)) {
                this.onEndAuthentication_SetSessionDelegate = new EndOperationDelegate(this.OnEndAuthentication_SetSession);
            }
            if ((this.onAuthentication_SetSessionCompletedDelegate == null)) {
                this.onAuthentication_SetSessionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAuthentication_SetSessionCompleted);
            }
            base.InvokeAsync(this.onBeginAuthentication_SetSessionDelegate, new object[] {
                        UserName}, this.onEndAuthentication_SetSessionDelegate, this.onAuthentication_SetSessionCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC.BeginAuthentication_CheckAccount(string UserName, string PassWord, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAuthentication_CheckAccount(UserName, PassWord, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC.EndAuthentication_CheckAccount(System.IAsyncResult result) {
            return base.Channel.EndAuthentication_CheckAccount(result);
        }
        
        private System.IAsyncResult OnBeginAuthentication_CheckAccount(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string UserName = ((string)(inValues[0]));
            string PassWord = ((string)(inValues[1]));
            return ((QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC)(this)).BeginAuthentication_CheckAccount(UserName, PassWord, callback, asyncState);
        }
        
        private object[] OnEndAuthentication_CheckAccount(System.IAsyncResult result) {
            string retVal = ((QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC)(this)).EndAuthentication_CheckAccount(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAuthentication_CheckAccountCompleted(object state) {
            if ((this.Authentication_CheckAccountCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.Authentication_CheckAccountCompleted(this, new Authentication_CheckAccountCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void Authentication_CheckAccountAsync(string UserName, string PassWord) {
            this.Authentication_CheckAccountAsync(UserName, PassWord, null);
        }
        
        public void Authentication_CheckAccountAsync(string UserName, string PassWord, object userState) {
            if ((this.onBeginAuthentication_CheckAccountDelegate == null)) {
                this.onBeginAuthentication_CheckAccountDelegate = new BeginOperationDelegate(this.OnBeginAuthentication_CheckAccount);
            }
            if ((this.onEndAuthentication_CheckAccountDelegate == null)) {
                this.onEndAuthentication_CheckAccountDelegate = new EndOperationDelegate(this.OnEndAuthentication_CheckAccount);
            }
            if ((this.onAuthentication_CheckAccountCompletedDelegate == null)) {
                this.onAuthentication_CheckAccountCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAuthentication_CheckAccountCompleted);
            }
            base.InvokeAsync(this.onBeginAuthentication_CheckAccountDelegate, new object[] {
                        UserName,
                        PassWord}, this.onEndAuthentication_CheckAccountDelegate, this.onAuthentication_CheckAccountCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC.BeginAuthentication_GetSession(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginAuthentication_GetSession(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        string QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC.EndAuthentication_GetSession(System.IAsyncResult result) {
            return base.Channel.EndAuthentication_GetSession(result);
        }
        
        private System.IAsyncResult OnBeginAuthentication_GetSession(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC)(this)).BeginAuthentication_GetSession(callback, asyncState);
        }
        
        private object[] OnEndAuthentication_GetSession(System.IAsyncResult result) {
            string retVal = ((QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC)(this)).EndAuthentication_GetSession(result);
            return new object[] {
                    retVal};
        }
        
        private void OnAuthentication_GetSessionCompleted(object state) {
            if ((this.Authentication_GetSessionCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.Authentication_GetSessionCompleted(this, new Authentication_GetSessionCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void Authentication_GetSessionAsync() {
            this.Authentication_GetSessionAsync(null);
        }
        
        public void Authentication_GetSessionAsync(object userState) {
            if ((this.onBeginAuthentication_GetSessionDelegate == null)) {
                this.onBeginAuthentication_GetSessionDelegate = new BeginOperationDelegate(this.OnBeginAuthentication_GetSession);
            }
            if ((this.onEndAuthentication_GetSessionDelegate == null)) {
                this.onEndAuthentication_GetSessionDelegate = new EndOperationDelegate(this.OnEndAuthentication_GetSession);
            }
            if ((this.onAuthentication_GetSessionCompletedDelegate == null)) {
                this.onAuthentication_GetSessionCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnAuthentication_GetSessionCompleted);
            }
            base.InvokeAsync(this.onBeginAuthentication_GetSessionDelegate, null, this.onEndAuthentication_GetSessionDelegate, this.onAuthentication_GetSessionCompletedDelegate, userState);
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
        
        protected override QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC CreateChannel() {
            return new AuthenticationSVCClientChannel(this);
        }
        
        private class AuthenticationSVCClientChannel : ChannelBase<QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC>, QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC {
            
            public AuthenticationSVCClientChannel(System.ServiceModel.ClientBase<QuanLyKhachSan.AuthenticationSVC.AuthenticationSVC> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginAuthentication_SetSession(string UserName, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = UserName;
                System.IAsyncResult _result = base.BeginInvoke("Authentication_SetSession", _args, callback, asyncState);
                return _result;
            }
            
            public void EndAuthentication_SetSession(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("Authentication_SetSession", _args, result);
            }
            
            public System.IAsyncResult BeginAuthentication_CheckAccount(string UserName, string PassWord, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = UserName;
                _args[1] = PassWord;
                System.IAsyncResult _result = base.BeginInvoke("Authentication_CheckAccount", _args, callback, asyncState);
                return _result;
            }
            
            public string EndAuthentication_CheckAccount(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Authentication_CheckAccount", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginAuthentication_GetSession(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("Authentication_GetSession", _args, callback, asyncState);
                return _result;
            }
            
            public string EndAuthentication_GetSession(System.IAsyncResult result) {
                object[] _args = new object[0];
                string _result = ((string)(base.EndInvoke("Authentication_GetSession", _args, result)));
                return _result;
            }
        }
    }
}
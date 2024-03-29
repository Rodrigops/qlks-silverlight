﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace QuanLyKhachSan.ManagementUserSVC {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="MembershipUserCollection", Namespace="http://schemas.datacontract.org/2004/07/System.Web.Security")]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.Dictionary<object, object>))]
    [System.Runtime.Serialization.KnownTypeAttribute(typeof(System.Collections.Generic.List<object>))]
    public partial class MembershipUserCollection : object, System.ComponentModel.INotifyPropertyChanged {
        
        private System.Collections.Generic.Dictionary<object, object> _IndicesField;
        
        private bool _ReadOnlyField;
        
        private System.Collections.Generic.List<object> _ValuesField;
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Collections.Generic.Dictionary<object, object> _Indices {
            get {
                return this._IndicesField;
            }
            set {
                if ((object.ReferenceEquals(this._IndicesField, value) != true)) {
                    this._IndicesField = value;
                    this.RaisePropertyChanged("_Indices");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public bool _ReadOnly {
            get {
                return this._ReadOnlyField;
            }
            set {
                if ((this._ReadOnlyField.Equals(value) != true)) {
                    this._ReadOnlyField = value;
                    this.RaisePropertyChanged("_ReadOnly");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute(IsRequired=true)]
        public System.Collections.Generic.List<object> _Values {
            get {
                return this._ValuesField;
            }
            set {
                if ((object.ReferenceEquals(this._ValuesField, value) != true)) {
                    this._ValuesField = value;
                    this.RaisePropertyChanged("_Values");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="ManagementUserSVC.ManagementUserSVC")]
    public interface ManagementUserSVC {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ManagementUserSVC/GetAllUsers", ReplyAction="urn:ManagementUserSVC/GetAllUsersResponse")]
        System.IAsyncResult BeginGetAllUsers(System.AsyncCallback callback, object asyncState);
        
        QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection EndGetAllUsers(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ManagementUserSVC/CreateUser", ReplyAction="urn:ManagementUserSVC/CreateUserResponse")]
        System.IAsyncResult BeginCreateUser(string UserName, string Password, string Email, System.AsyncCallback callback, object asyncState);
        
        void EndCreateUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ManagementUserSVC/UpdateUser", ReplyAction="urn:ManagementUserSVC/UpdateUserResponse")]
        System.IAsyncResult BeginUpdateUser(string UserName, string Email, System.AsyncCallback callback, object asyncState);
        
        void EndUpdateUser(System.IAsyncResult result);
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:ManagementUserSVC/DeleteUser", ReplyAction="urn:ManagementUserSVC/DeleteUserResponse")]
        System.IAsyncResult BeginDeleteUser(string UserName, System.AsyncCallback callback, object asyncState);
        
        void EndDeleteUser(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ManagementUserSVCChannel : QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class GetAllUsersCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public GetAllUsersCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class ManagementUserSVCClient : System.ServiceModel.ClientBase<QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC>, QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC {
        
        private BeginOperationDelegate onBeginGetAllUsersDelegate;
        
        private EndOperationDelegate onEndGetAllUsersDelegate;
        
        private System.Threading.SendOrPostCallback onGetAllUsersCompletedDelegate;
        
        private BeginOperationDelegate onBeginCreateUserDelegate;
        
        private EndOperationDelegate onEndCreateUserDelegate;
        
        private System.Threading.SendOrPostCallback onCreateUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginUpdateUserDelegate;
        
        private EndOperationDelegate onEndUpdateUserDelegate;
        
        private System.Threading.SendOrPostCallback onUpdateUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginDeleteUserDelegate;
        
        private EndOperationDelegate onEndDeleteUserDelegate;
        
        private System.Threading.SendOrPostCallback onDeleteUserCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public ManagementUserSVCClient() {
        }
        
        public ManagementUserSVCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public ManagementUserSVCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagementUserSVCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public ManagementUserSVCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<GetAllUsersCompletedEventArgs> GetAllUsersCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CreateUserCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> UpdateUserCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> DeleteUserCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.BeginGetAllUsers(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginGetAllUsers(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.EndGetAllUsers(System.IAsyncResult result) {
            return base.Channel.EndGetAllUsers(result);
        }
        
        private System.IAsyncResult OnBeginGetAllUsers(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).BeginGetAllUsers(callback, asyncState);
        }
        
        private object[] OnEndGetAllUsers(System.IAsyncResult result) {
            QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection retVal = ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).EndGetAllUsers(result);
            return new object[] {
                    retVal};
        }
        
        private void OnGetAllUsersCompleted(object state) {
            if ((this.GetAllUsersCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.GetAllUsersCompleted(this, new GetAllUsersCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void GetAllUsersAsync() {
            this.GetAllUsersAsync(null);
        }
        
        public void GetAllUsersAsync(object userState) {
            if ((this.onBeginGetAllUsersDelegate == null)) {
                this.onBeginGetAllUsersDelegate = new BeginOperationDelegate(this.OnBeginGetAllUsers);
            }
            if ((this.onEndGetAllUsersDelegate == null)) {
                this.onEndGetAllUsersDelegate = new EndOperationDelegate(this.OnEndGetAllUsers);
            }
            if ((this.onGetAllUsersCompletedDelegate == null)) {
                this.onGetAllUsersCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnGetAllUsersCompleted);
            }
            base.InvokeAsync(this.onBeginGetAllUsersDelegate, null, this.onEndGetAllUsersDelegate, this.onGetAllUsersCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.BeginCreateUser(string UserName, string Password, string Email, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginCreateUser(UserName, Password, Email, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.EndCreateUser(System.IAsyncResult result) {
            base.Channel.EndCreateUser(result);
        }
        
        private System.IAsyncResult OnBeginCreateUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string UserName = ((string)(inValues[0]));
            string Password = ((string)(inValues[1]));
            string Email = ((string)(inValues[2]));
            return ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).BeginCreateUser(UserName, Password, Email, callback, asyncState);
        }
        
        private object[] OnEndCreateUser(System.IAsyncResult result) {
            ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).EndCreateUser(result);
            return null;
        }
        
        private void OnCreateUserCompleted(object state) {
            if ((this.CreateUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.CreateUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void CreateUserAsync(string UserName, string Password, string Email) {
            this.CreateUserAsync(UserName, Password, Email, null);
        }
        
        public void CreateUserAsync(string UserName, string Password, string Email, object userState) {
            if ((this.onBeginCreateUserDelegate == null)) {
                this.onBeginCreateUserDelegate = new BeginOperationDelegate(this.OnBeginCreateUser);
            }
            if ((this.onEndCreateUserDelegate == null)) {
                this.onEndCreateUserDelegate = new EndOperationDelegate(this.OnEndCreateUser);
            }
            if ((this.onCreateUserCompletedDelegate == null)) {
                this.onCreateUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnCreateUserCompleted);
            }
            base.InvokeAsync(this.onBeginCreateUserDelegate, new object[] {
                        UserName,
                        Password,
                        Email}, this.onEndCreateUserDelegate, this.onCreateUserCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.BeginUpdateUser(string UserName, string Email, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginUpdateUser(UserName, Email, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.EndUpdateUser(System.IAsyncResult result) {
            base.Channel.EndUpdateUser(result);
        }
        
        private System.IAsyncResult OnBeginUpdateUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string UserName = ((string)(inValues[0]));
            string Email = ((string)(inValues[1]));
            return ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).BeginUpdateUser(UserName, Email, callback, asyncState);
        }
        
        private object[] OnEndUpdateUser(System.IAsyncResult result) {
            ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).EndUpdateUser(result);
            return null;
        }
        
        private void OnUpdateUserCompleted(object state) {
            if ((this.UpdateUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.UpdateUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void UpdateUserAsync(string UserName, string Email) {
            this.UpdateUserAsync(UserName, Email, null);
        }
        
        public void UpdateUserAsync(string UserName, string Email, object userState) {
            if ((this.onBeginUpdateUserDelegate == null)) {
                this.onBeginUpdateUserDelegate = new BeginOperationDelegate(this.OnBeginUpdateUser);
            }
            if ((this.onEndUpdateUserDelegate == null)) {
                this.onEndUpdateUserDelegate = new EndOperationDelegate(this.OnEndUpdateUser);
            }
            if ((this.onUpdateUserCompletedDelegate == null)) {
                this.onUpdateUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnUpdateUserCompleted);
            }
            base.InvokeAsync(this.onBeginUpdateUserDelegate, new object[] {
                        UserName,
                        Email}, this.onEndUpdateUserDelegate, this.onUpdateUserCompletedDelegate, userState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.BeginDeleteUser(string UserName, System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginDeleteUser(UserName, callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        void QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC.EndDeleteUser(System.IAsyncResult result) {
            base.Channel.EndDeleteUser(result);
        }
        
        private System.IAsyncResult OnBeginDeleteUser(object[] inValues, System.AsyncCallback callback, object asyncState) {
            string UserName = ((string)(inValues[0]));
            return ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).BeginDeleteUser(UserName, callback, asyncState);
        }
        
        private object[] OnEndDeleteUser(System.IAsyncResult result) {
            ((QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC)(this)).EndDeleteUser(result);
            return null;
        }
        
        private void OnDeleteUserCompleted(object state) {
            if ((this.DeleteUserCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.DeleteUserCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void DeleteUserAsync(string UserName) {
            this.DeleteUserAsync(UserName, null);
        }
        
        public void DeleteUserAsync(string UserName, object userState) {
            if ((this.onBeginDeleteUserDelegate == null)) {
                this.onBeginDeleteUserDelegate = new BeginOperationDelegate(this.OnBeginDeleteUser);
            }
            if ((this.onEndDeleteUserDelegate == null)) {
                this.onEndDeleteUserDelegate = new EndOperationDelegate(this.OnEndDeleteUser);
            }
            if ((this.onDeleteUserCompletedDelegate == null)) {
                this.onDeleteUserCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnDeleteUserCompleted);
            }
            base.InvokeAsync(this.onBeginDeleteUserDelegate, new object[] {
                        UserName}, this.onEndDeleteUserDelegate, this.onDeleteUserCompletedDelegate, userState);
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
        
        protected override QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC CreateChannel() {
            return new ManagementUserSVCClientChannel(this);
        }
        
        private class ManagementUserSVCClientChannel : ChannelBase<QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC>, QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC {
            
            public ManagementUserSVCClientChannel(System.ServiceModel.ClientBase<QuanLyKhachSan.ManagementUserSVC.ManagementUserSVC> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginGetAllUsers(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("GetAllUsers", _args, callback, asyncState);
                return _result;
            }
            
            public QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection EndGetAllUsers(System.IAsyncResult result) {
                object[] _args = new object[0];
                QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection _result = ((QuanLyKhachSan.ManagementUserSVC.MembershipUserCollection)(base.EndInvoke("GetAllUsers", _args, result)));
                return _result;
            }
            
            public System.IAsyncResult BeginCreateUser(string UserName, string Password, string Email, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[3];
                _args[0] = UserName;
                _args[1] = Password;
                _args[2] = Email;
                System.IAsyncResult _result = base.BeginInvoke("CreateUser", _args, callback, asyncState);
                return _result;
            }
            
            public void EndCreateUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("CreateUser", _args, result);
            }
            
            public System.IAsyncResult BeginUpdateUser(string UserName, string Email, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[2];
                _args[0] = UserName;
                _args[1] = Email;
                System.IAsyncResult _result = base.BeginInvoke("UpdateUser", _args, callback, asyncState);
                return _result;
            }
            
            public void EndUpdateUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("UpdateUser", _args, result);
            }
            
            public System.IAsyncResult BeginDeleteUser(string UserName, System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[1];
                _args[0] = UserName;
                System.IAsyncResult _result = base.BeginInvoke("DeleteUser", _args, callback, asyncState);
                return _result;
            }
            
            public void EndDeleteUser(System.IAsyncResult result) {
                object[] _args = new object[0];
                base.EndInvoke("DeleteUser", _args, result);
            }
        }
    }
}

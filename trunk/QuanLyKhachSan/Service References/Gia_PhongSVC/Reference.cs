﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.239
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This code was auto-generated by Microsoft.Silverlight.ServiceReference, version 4.0.50826.0
// 
namespace QuanLyKhachSan.Gia_PhongSVC {
    using System.Runtime.Serialization;
    
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Runtime.Serialization", "4.0.0.0")]
    [System.Runtime.Serialization.DataContractAttribute(Name="Gia_PhongInfo", Namespace="http://schemas.datacontract.org/2004/07/QuanLyKhachSan")]
    public partial class Gia_PhongInfo : object, System.ComponentModel.INotifyPropertyChanged {
        
        private string GiaGioField;
        
        private decimal GiaNgayField;
        
        private decimal GiaThangField;
        
        private decimal GiaTuanField;
        
        private int PhongIDField;
        
        private string PhongNameField;
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string GiaGio {
            get {
                return this.GiaGioField;
            }
            set {
                if ((object.ReferenceEquals(this.GiaGioField, value) != true)) {
                    this.GiaGioField = value;
                    this.RaisePropertyChanged("GiaGio");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal GiaNgay {
            get {
                return this.GiaNgayField;
            }
            set {
                if ((this.GiaNgayField.Equals(value) != true)) {
                    this.GiaNgayField = value;
                    this.RaisePropertyChanged("GiaNgay");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal GiaThang {
            get {
                return this.GiaThangField;
            }
            set {
                if ((this.GiaThangField.Equals(value) != true)) {
                    this.GiaThangField = value;
                    this.RaisePropertyChanged("GiaThang");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public decimal GiaTuan {
            get {
                return this.GiaTuanField;
            }
            set {
                if ((this.GiaTuanField.Equals(value) != true)) {
                    this.GiaTuanField = value;
                    this.RaisePropertyChanged("GiaTuan");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public int PhongID {
            get {
                return this.PhongIDField;
            }
            set {
                if ((this.PhongIDField.Equals(value) != true)) {
                    this.PhongIDField = value;
                    this.RaisePropertyChanged("PhongID");
                }
            }
        }
        
        [System.Runtime.Serialization.DataMemberAttribute()]
        public string PhongName {
            get {
                return this.PhongNameField;
            }
            set {
                if ((object.ReferenceEquals(this.PhongNameField, value) != true)) {
                    this.PhongNameField = value;
                    this.RaisePropertyChanged("PhongName");
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
    [System.ServiceModel.ServiceContractAttribute(Namespace="", ConfigurationName="Gia_PhongSVC.Gia_PhongSVC")]
    public interface Gia_PhongSVC {
        
        [System.ServiceModel.OperationContractAttribute(AsyncPattern=true, Action="urn:Gia_PhongSVC/Phong_GiaPhong", ReplyAction="urn:Gia_PhongSVC/Phong_GiaPhongResponse")]
        System.IAsyncResult BeginPhong_GiaPhong(System.AsyncCallback callback, object asyncState);
        
        System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo> EndPhong_GiaPhong(System.IAsyncResult result);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface Gia_PhongSVCChannel : QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Phong_GiaPhongCompletedEventArgs : System.ComponentModel.AsyncCompletedEventArgs {
        
        private object[] results;
        
        public Phong_GiaPhongCompletedEventArgs(object[] results, System.Exception exception, bool cancelled, object userState) : 
                base(exception, cancelled, userState) {
            this.results = results;
        }
        
        public System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo> Result {
            get {
                base.RaiseExceptionIfNecessary();
                return ((System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo>)(this.results[0]));
            }
        }
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Gia_PhongSVCClient : System.ServiceModel.ClientBase<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC>, QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC {
        
        private BeginOperationDelegate onBeginPhong_GiaPhongDelegate;
        
        private EndOperationDelegate onEndPhong_GiaPhongDelegate;
        
        private System.Threading.SendOrPostCallback onPhong_GiaPhongCompletedDelegate;
        
        private BeginOperationDelegate onBeginOpenDelegate;
        
        private EndOperationDelegate onEndOpenDelegate;
        
        private System.Threading.SendOrPostCallback onOpenCompletedDelegate;
        
        private BeginOperationDelegate onBeginCloseDelegate;
        
        private EndOperationDelegate onEndCloseDelegate;
        
        private System.Threading.SendOrPostCallback onCloseCompletedDelegate;
        
        public Gia_PhongSVCClient() {
        }
        
        public Gia_PhongSVCClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Gia_PhongSVCClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Gia_PhongSVCClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Gia_PhongSVCClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
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
        
        public event System.EventHandler<Phong_GiaPhongCompletedEventArgs> Phong_GiaPhongCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> OpenCompleted;
        
        public event System.EventHandler<System.ComponentModel.AsyncCompletedEventArgs> CloseCompleted;
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.IAsyncResult QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC.BeginPhong_GiaPhong(System.AsyncCallback callback, object asyncState) {
            return base.Channel.BeginPhong_GiaPhong(callback, asyncState);
        }
        
        [System.ComponentModel.EditorBrowsableAttribute(System.ComponentModel.EditorBrowsableState.Advanced)]
        System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo> QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC.EndPhong_GiaPhong(System.IAsyncResult result) {
            return base.Channel.EndPhong_GiaPhong(result);
        }
        
        private System.IAsyncResult OnBeginPhong_GiaPhong(object[] inValues, System.AsyncCallback callback, object asyncState) {
            return ((QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC)(this)).BeginPhong_GiaPhong(callback, asyncState);
        }
        
        private object[] OnEndPhong_GiaPhong(System.IAsyncResult result) {
            System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo> retVal = ((QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC)(this)).EndPhong_GiaPhong(result);
            return new object[] {
                    retVal};
        }
        
        private void OnPhong_GiaPhongCompleted(object state) {
            if ((this.Phong_GiaPhongCompleted != null)) {
                InvokeAsyncCompletedEventArgs e = ((InvokeAsyncCompletedEventArgs)(state));
                this.Phong_GiaPhongCompleted(this, new Phong_GiaPhongCompletedEventArgs(e.Results, e.Error, e.Cancelled, e.UserState));
            }
        }
        
        public void Phong_GiaPhongAsync() {
            this.Phong_GiaPhongAsync(null);
        }
        
        public void Phong_GiaPhongAsync(object userState) {
            if ((this.onBeginPhong_GiaPhongDelegate == null)) {
                this.onBeginPhong_GiaPhongDelegate = new BeginOperationDelegate(this.OnBeginPhong_GiaPhong);
            }
            if ((this.onEndPhong_GiaPhongDelegate == null)) {
                this.onEndPhong_GiaPhongDelegate = new EndOperationDelegate(this.OnEndPhong_GiaPhong);
            }
            if ((this.onPhong_GiaPhongCompletedDelegate == null)) {
                this.onPhong_GiaPhongCompletedDelegate = new System.Threading.SendOrPostCallback(this.OnPhong_GiaPhongCompleted);
            }
            base.InvokeAsync(this.onBeginPhong_GiaPhongDelegate, null, this.onEndPhong_GiaPhongDelegate, this.onPhong_GiaPhongCompletedDelegate, userState);
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
        
        protected override QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC CreateChannel() {
            return new Gia_PhongSVCClientChannel(this);
        }
        
        private class Gia_PhongSVCClientChannel : ChannelBase<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC>, QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC {
            
            public Gia_PhongSVCClientChannel(System.ServiceModel.ClientBase<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongSVC> client) : 
                    base(client) {
            }
            
            public System.IAsyncResult BeginPhong_GiaPhong(System.AsyncCallback callback, object asyncState) {
                object[] _args = new object[0];
                System.IAsyncResult _result = base.BeginInvoke("Phong_GiaPhong", _args, callback, asyncState);
                return _result;
            }
            
            public System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo> EndPhong_GiaPhong(System.IAsyncResult result) {
                object[] _args = new object[0];
                System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo> _result = ((System.Collections.Generic.List<QuanLyKhachSan.Gia_PhongSVC.Gia_PhongInfo>)(base.EndInvoke("Phong_GiaPhong", _args, result)));
                return _result;
            }
        }
    }
}
﻿#pragma checksum "F:\Projects\qlksprojects.SL\qlksSL\QuanLyKhachSan\Form\QuanLyPhong\frmThongTinPhong.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "BB06D6EAEA85ED15A656775A88A620DF"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.235
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace QuanLyKhachSan.Form.QuanLyPhong {
    
    
    public partial class frmLoaiPhong : System.Windows.Controls.Page {
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal Telerik.Windows.Controls.RadGridView grvLoaiPhong;
        
        internal Telerik.Windows.Controls.RadButton cmdThemLoaiPhong;
        
        internal Telerik.Windows.Controls.RadGridView grvTienNghi;
        
        internal Telerik.Windows.Controls.RadButton cmdThemTienNghi;
        
        internal Telerik.Windows.Controls.RadBusyIndicator radLoading;
        
        internal Telerik.Windows.Controls.RadGridView grvPhong;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/QuanLyKhachSan;component/Form/QuanLyPhong/frmThongTinPhong.xaml", System.UriKind.Relative));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.grvLoaiPhong = ((Telerik.Windows.Controls.RadGridView)(this.FindName("grvLoaiPhong")));
            this.cmdThemLoaiPhong = ((Telerik.Windows.Controls.RadButton)(this.FindName("cmdThemLoaiPhong")));
            this.grvTienNghi = ((Telerik.Windows.Controls.RadGridView)(this.FindName("grvTienNghi")));
            this.cmdThemTienNghi = ((Telerik.Windows.Controls.RadButton)(this.FindName("cmdThemTienNghi")));
            this.radLoading = ((Telerik.Windows.Controls.RadBusyIndicator)(this.FindName("radLoading")));
            this.grvPhong = ((Telerik.Windows.Controls.RadGridView)(this.FindName("grvPhong")));
        }
    }
}


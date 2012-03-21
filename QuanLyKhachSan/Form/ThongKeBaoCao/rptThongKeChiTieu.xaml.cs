using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using Telerik.Reporting;
using System.Collections;

namespace QuanLyKhachSan.Form.ThongKeBaoCao
{
    public partial class rptThongKeChiTieu : ChildWindow
    {
        public string Type = "";
        public string Ngay = "";
        public string Thang = "";
        public string Nam = "";
        public string TuNgay = "";
        public string DenNgay = "";
        
        public string TongTien = "";
        public rptThongKeChiTieu()
        {
            InitializeComponent();
            reportViewer1.RenderBegin += new Telerik.ReportViewer.Silverlight.RenderBeginEventHandler(reportViewer1_RenderBegin);
        }

        void reportViewer1_RenderBegin(object sender, Telerik.ReportViewer.Silverlight.RenderBeginEventArgs args)
        {
            args.ParameterValues.Add("Type", Type);
            args.ParameterValues.Add("Ngay", Ngay);
            args.ParameterValues.Add("Thang", Thang);
            args.ParameterValues.Add("Nam", Nam);
            args.ParameterValues.Add("TuNgay", TuNgay);
            args.ParameterValues.Add("DenNgay", DenNgay);
            
            args.ParameterValues.Add("TongTien", TongTien);
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


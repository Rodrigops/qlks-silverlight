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
using Telerik.Reporting.Processing;
using System.Windows.Printing;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class rptHoaDon : ChildWindow
    {
        public string Ngay = "";
        public string Thang = "";
        public string Nam = "";
        public string TenKhachHang = "";
        public string NgayVao = "";
        public string GioVao = "";
        public string PhutVao = "";
        public string NgayRa = "";
        public string GioRa = "";
        public string PhutRa = "";
        public string TienPhong = "";
        public string TienDichVu = "";
        public string TongTien = "";
        public string TraTruoc = "";
        public rptHoaDon()
        {
            InitializeComponent();
            reportViewer1.RenderBegin += new Telerik.ReportViewer.Silverlight.RenderBeginEventHandler(reportViewer1_RenderBegin);                                                                        
        }

        void reportViewer1_RenderBegin(object sender, Telerik.ReportViewer.Silverlight.RenderBeginEventArgs args)
        {
            Ngay = DateTime.Now.Day.ToString();
            Thang = DateTime.Now.Month.ToString();
            Nam = DateTime.Now.Year.ToString();
            args.ParameterValues.Add("Ngay", Ngay);
            args.ParameterValues.Add("Thang", Thang);
            args.ParameterValues.Add("Nam", Nam);
            args.ParameterValues.Add("TenKhachHang", TenKhachHang);
            args.ParameterValues.Add("NgayVao", NgayVao);

            args.ParameterValues.Add("GioVao", GioVao + "h" + PhutVao);

            args.ParameterValues.Add("NgayRa", NgayRa);
            args.ParameterValues.Add("GioRa", GioRa + "h" + PhutRa);

            args.ParameterValues.Add("TienPhong", TienPhong);
            args.ParameterValues.Add("TienDichVu", TienDichVu);
            args.ParameterValues.Add("TraTruoc", TraTruoc);
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


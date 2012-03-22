namespace Telerik.Reporting
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;

    /// <summary>
    /// Summary description for ReportHoaDon.
    /// </summary>
    [Browsable(false)]
    public partial class ReportHoaDon : Telerik.Reporting.Report
    {
        public ReportHoaDon()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            //
            // TODO: Add any constructor code after InitializeComponent call
            //
            this.Report.NeedDataSource += new EventHandler(Report_NeedDataSource);                        
        }

        void Report_NeedDataSource(object sender, EventArgs e)
        {
            txtNgay.Value = this.ReportParameters["Ngay"].Value.ToString();
            txtThang.Value = this.ReportParameters["Thang"].Value.ToString();
            txtNam.Value = this.ReportParameters["Nam"].Value.ToString();
            txtMaKH.Value = this.ReportParameters["TenKhachHang"].Value.ToString();
            
            txtNgayVao.Value = this.ReportParameters["NgayVao"].Value.ToString();
            txtGioVao.Value = this.ReportParameters["GioVao"].Value.ToString();

            txtNgayRa.Value = this.ReportParameters["NgayRa"].Value.ToString();
            txtGioRa.Value = this.ReportParameters["GioRa"].Value.ToString();

            txtTienPhong.Value = this.ReportParameters["TienPhong"].Value.ToString();
            txtTienDV.Value = this.ReportParameters["TienDichVu"].Value.ToString();
            txtTraTruoc.Value = this.ReportParameters["TraTruoc"].Value.ToString();
            txtKhoanKhac.Value = "Khoản khác :  " + this.ReportParameters["KhoanKhac"].Value.ToString();
            txtTongTien.Value = this.ReportParameters["TongTien"].Value.ToString();
            
        }
    }
}
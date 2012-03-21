namespace Telerik.Reporting
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using System.Globalization;

    /// <summary>
    /// Summary description for ReportThongKeDoanhThuDichVu.
    /// </summary>
    [Browsable(false)]
    public partial class ReportThongKeDoanhThuDichVu : Telerik.Reporting.Report
    {
        public ReportThongKeDoanhThuDichVu()
        {
            //
            // Required for telerik Reporting designer support
            //
            InitializeComponent();
            this.Report.NeedDataSource += new EventHandler(Report_NeedDataSource);
        }
        private void Report_NeedDataSource(object sender, System.EventArgs e)
        {
            CultureInfo provider = CultureInfo.InvariantCulture;
            string _Type = this.ReportParameters["Type"].Value.ToString();
            string _Ngay = this.ReportParameters["Ngay"].Value.ToString();
            string _Thang = this.ReportParameters["Thang"].Value.ToString();
            string _Nam = this.ReportParameters["Nam"].Value.ToString();
            string _TuNgay = this.ReportParameters["TuNgay"].Value.ToString();
            string _DenNgay = this.ReportParameters["DenNgay"].Value.ToString();
            string _TongTien = this.ReportParameters["TongTien"].Value.ToString();

            sqlDataSource.ProviderName = "System.Data.SqlClient";
            sqlDataSource.ConnectionString = Telerik.Reporting.Properties.Settings.Default.ttewjkqv_qlks;
            if (_Type == "1")
            {
                txtNgay.Value = "Ngày:  " + DateTime.ParseExact(_Ngay, "yyyyMMdd", provider).ToString("MM/dd/yyyy");
                sqlDataSource.SelectCommand = "dbo.sp_HoaDonDichVu_GetItems_TheoNgay";
                this.sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                {
                    new Telerik.Reporting.SqlDataSourceParameter("@NgaySo", System.Data.DbType.Int32, int.Parse(_Ngay))
                });
            }
            else if (_Type == "2")
            {
                txtNgay.Value = "Tháng   " + _Thang + "   Năm   " + _Nam;
                sqlDataSource.SelectCommand = "dbo.sp_HoaDonDichVu_GetItems_TheoThang";
                this.sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                {
                    new Telerik.Reporting.SqlDataSourceParameter("@Thang", System.Data.DbType.Int32, int.Parse(_Thang)),
                    new Telerik.Reporting.SqlDataSourceParameter("@Nam", System.Data.DbType.Int32, int.Parse(_Nam))
                });
            }
            else if (_Type == "3")
            {
                txtNgay.Value = "Năm:  " + _Nam;
                sqlDataSource.SelectCommand = "dbo.sp_HoaDonDichVu_GetItems_TheoNam";
                this.sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                {
                    new Telerik.Reporting.SqlDataSourceParameter("@Nam", System.Data.DbType.Int32, int.Parse(_Nam))
                });
            }
            else if (_Type == "4")
            {
                txtNgay.Value = "Từ ngày: " + DateTime.ParseExact(_TuNgay, "yyyyMMdd", provider).ToString("MM/dd/yyyy") + "    Đến ngày: " + DateTime.ParseExact(_DenNgay, "yyyyMMdd", provider).ToString("MM/dd/yyyy");
                sqlDataSource.SelectCommand = "dbo.sp_HoaDonDichVu_GetItems_TuNgayDenNgay";
                sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                    {
                        new Telerik.Reporting.SqlDataSourceParameter("@TuNgaySo", System.Data.DbType.Int32, int.Parse(_TuNgay)),
                        new Telerik.Reporting.SqlDataSourceParameter("@DenNgaySo", System.Data.DbType.Int32, int.Parse(_DenNgay))
                    });
            }
            sqlDataSource.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            txtTongTien.Value = _TongTien;
        }  
    }
}
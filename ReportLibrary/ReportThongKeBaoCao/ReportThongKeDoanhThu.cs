namespace Telerik.Reporting
{
    using System;
    using System.ComponentModel;
    using System.Drawing;
    using System.Windows.Forms;
    using Telerik.Reporting;
    using Telerik.Reporting.Drawing;
    using System.Globalization;
    using System.Data;

    /// <summary>
    /// Summary description for ReportThongKeDoanhThu.
    /// </summary>
    [Browsable(false)]
    public partial class ReportThongKeDoanhThu : Telerik.Reporting.Report
    {
        public ReportThongKeDoanhThu()
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
                sqlDataSource.SelectCommand = "dbo.sp_HoaDon_GetItems_TheoNgay";
                this.sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                {
                    new Telerik.Reporting.SqlDataSourceParameter("@NgayRaSo", System.Data.DbType.Int32, int.Parse(_Ngay))
                });
            }
            else if (_Type == "2")
            {
                txtNgay.Value = "Tháng   " + _Thang + "   Năm   " + _Nam;
                sqlDataSource.SelectCommand = "dbo.sp_HoaDon_GetItems_TheoThang";
                this.sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                {
                    new Telerik.Reporting.SqlDataSourceParameter("@ThangRa", System.Data.DbType.Int32, int.Parse(_Thang)),
                    new Telerik.Reporting.SqlDataSourceParameter("@NamRa", System.Data.DbType.Int32, int.Parse(_Nam))
                });
            }
            else if (_Type == "3")
            {
                txtNgay.Value = "Năm:  " + _Nam;
                sqlDataSource.SelectCommand = "dbo.sp_HoaDon_GetItems_TheoNam";
                this.sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                {
                    new Telerik.Reporting.SqlDataSourceParameter("@NamRa", System.Data.DbType.Int32, int.Parse(_Nam))
                });
            }
            else if (_Type == "4")
            {
                txtNgay.Value = "Từ ngày: " + DateTime.ParseExact(_TuNgay, "yyyyMMdd", provider).ToString("MM/dd/yyyy") + "    Đến ngày: " + DateTime.ParseExact(_DenNgay, "yyyyMMdd", provider).ToString("MM/dd/yyyy");
                sqlDataSource.SelectCommand = "dbo.sp_HoaDon_GetItems_TuNgayDenNgay";
                sqlDataSource.Parameters.AddRange(new Telerik.Reporting.SqlDataSourceParameter[] 
                    {
                        new Telerik.Reporting.SqlDataSourceParameter("@TuNgaySo", System.Data.DbType.Int32, int.Parse(_TuNgay)),
                        new Telerik.Reporting.SqlDataSourceParameter("@DenNgaySo", System.Data.DbType.Int32, int.Parse(_DenNgay))
                    });
            }
            sqlDataSource.SelectCommandType = Telerik.Reporting.SqlDataSourceCommandType.StoredProcedure;
            sqlDataSource.CalculatedFields.Add(new CalculatedField("Thue", typeof(string), "=iif(Fields.LoaiThue=0,'Theo giờ', iif(Fields.LoaiThue=1, 'Theo ngày', iif(Fields.LoaiThue=2, 'Qua đêm', 'Theo tháng')))"));
            sqlDataSource.CalculatedFields.Add(new CalculatedField("LoaiCa", typeof(string), "=iif(Fields.Ca=0, 'Ca ngày', 'Ca đêm')"));

            txtTongTien.Value = _TongTien;
        }  
    }
}
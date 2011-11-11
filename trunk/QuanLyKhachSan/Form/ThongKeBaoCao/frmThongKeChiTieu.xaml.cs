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
using System.Windows.Navigation;
using QuanLyKhachSan.PhieuNhapKhoSVC;
using QuanLyKhachSan.TKChiTieuSVC;
namespace QuanLyKhachSan.Form.ThongKeBaoCao
{
    public partial class frmThongKeChiTieu : Page
    {
        private PhieuNhapKhoSVCClient PhieuNhapKhoClient = null;
        private TKChiTieuSVCClient TKChiTieuClient = null;
        public frmThongKeChiTieu()
        {
            InitializeComponent();
            Nam_Load();
            Thang_Load();
            LoadingPanel.IsBusy = true;
            PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
            PhieuNhapKhoClient.PhieuNhapKho_GetItemsCompleted += new EventHandler<PhieuNhapKho_GetItemsCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_GetItemsCompleted);
            PhieuNhapKhoClient.PhieuNhapKho_GetItemsAsync();
        }
        void PhieuNhapKhoClient_PhieuNhapKho_GetItemsCompleted(object sender, PhieuNhapKho_GetItemsCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        #region RadioButton Event
        private void rdbTheoNgay_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNgay.IsChecked)
            {
                rdpTheoNgay.IsEnabled = true;
                rdpTuNgay.IsEnabled = false;
                rdpDenNgay.IsEnabled = false;
                cbxTheoNam.IsEnabled = false;
                cbxTheoThang.IsEnabled = false;
                cbxTheoThangNam.IsEnabled = false;
            }
        }
        private void rdbTheoThang_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoThang.IsChecked)
            {
                rdpTheoNgay.IsEnabled = false;
                rdpTuNgay.IsEnabled = false;
                rdpDenNgay.IsEnabled = false;
                cbxTheoNam.IsEnabled = false;
                cbxTheoThang.IsEnabled = true;
                cbxTheoThangNam.IsEnabled = true;
            }
        }
        private void rdbTheoNam_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNam.IsChecked)
            {
                rdpTheoNgay.IsEnabled = false;
                rdpTuNgay.IsEnabled = false;
                rdpDenNgay.IsEnabled = false;
                cbxTheoNam.IsEnabled = true;
                cbxTheoThang.IsEnabled = false;
                cbxTheoThangNam.IsEnabled = false;
            }
        }
        private void rdbTuNgay_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTuNgay.IsChecked)
            {
                rdpTheoNgay.IsEnabled = false;
                rdpTuNgay.IsEnabled = true;
                rdpDenNgay.IsEnabled = true;
                cbxTheoNam.IsEnabled = false;
                cbxTheoThang.IsEnabled = false;
                cbxTheoThangNam.IsEnabled = false;
            }
        }
        private void Nam_Load()
        {
            int currentYear = DateTime.Now.Year;
            cbxTheoNam.Items.Clear();
            cbxTheoThangNam.Items.Clear();
            try
            {
                while ((currentYear >= 2000))
                {
                    cbxTheoNam.Items.Add(new YearInfo(currentYear, currentYear.ToString()));
                    cbxTheoThangNam.Items.Add(new YearInfo(currentYear, currentYear.ToString()));
                    currentYear = currentYear - 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Thang_Load()
        {
            int currentMonth = 1;
            cbxTheoThang.Items.Clear();
            try
            {
                while ((currentMonth <= 12))
                {
                    cbxTheoThang.Items.Add(new MonthInfo(currentMonth, currentMonth.ToString()));
                    currentMonth = currentMonth + 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion
        #region "Sub Class"
        private class YearInfo
        {
            int _Nam;
            string _TenNam;
            public YearInfo(int Nam, string TenNam)
            {
                _Nam = Nam;
                _TenNam = TenNam;
            }
            public int Nam()
            {
                return _Nam;
            }
            public string TenNam()
            {
                return _TenNam;
            }
            public override string ToString()
            {
                return _TenNam;
            }
        }
        private class MonthInfo
        {
            int _Thang;
            string _TenThang;
            public MonthInfo(int Thang, string TenThang)
            {
                _Thang = Thang;
                _TenThang = TenThang;
            }
            public int Thang()
            {
                return _Thang;
            }
            public string TenThang()
            {
                return _TenThang;
            }
            public override string ToString()
            {
                return _TenThang;
            }
        }
        #endregion

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTheoNgay.SelectedDate.ToString()))
                {
                    LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoNgayCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoNgayCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayAsync(int.Parse(rdpTheoNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                }
            }
            else if ((bool)rdbTheoThang.IsChecked)
            {
                if (cbxTheoThang.SelectedIndex == -1 && cbxTheoThangNam.SelectedIndex == -1)
                {
                    LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoThangCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoThangCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoThangCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoThangAsync((int)cbxTheoThang.SelectedValue, (int)cbxTheoThangNam.SelectedValue);
                }
            }
            else if ((bool)rdbTheoNam.IsChecked)
            {
                if (cbxTheoNam.SelectedIndex == -1)
                {
                    LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNamCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoNamCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoNamCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNamAsync((int)cbxTheoNam.SelectedValue);
                }
            }
            else if ((bool)rdbTuNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTuNgay.SelectedDate.ToString()) && !String.IsNullOrEmpty(rdpDenNgay.SelectedDate.ToString()))
                {
                    if (rdpTuNgay.SelectedDate < rdpDenNgay.SelectedDate)
                    {
                        LoadingPanel.IsBusy = true;
                        TKChiTieuClient = new TKChiTieuSVCClient();
                        TKChiTieuClient.PhieuNhapKho_GetItems_TuNgayDenNgayCompleted += new EventHandler<PhieuNhapKho_GetItems_TuNgayDenNgayCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TuNgayDenNgayCompleted);
                        TKChiTieuClient.PhieuNhapKho_GetItems_TuNgayDenNgayAsync(int.Parse(rdpTuNgay.SelectedDate.Value.ToString("yyyyMMdd")), int.Parse(rdpDenNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                    }
                }
            }
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TuNgayDenNgayCompleted(object sender, PhieuNhapKho_GetItems_TuNgayDenNgayCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoNamCompleted(object sender, PhieuNhapKho_GetItems_TheoNamCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoThangCompleted(object sender, PhieuNhapKho_GetItems_TheoThangCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoNgayCompleted(object sender, PhieuNhapKho_GetItems_TheoNgayCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }
    }
}

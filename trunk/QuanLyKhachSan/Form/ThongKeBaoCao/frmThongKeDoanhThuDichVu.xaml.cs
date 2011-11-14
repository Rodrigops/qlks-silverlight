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
using QuanLyKhachSan.TKDoanhThuDichVuSVC;
namespace QuanLyKhachSan.Form.ThongKeBaoCao
{
    public partial class frmThongKeDoanhThuDichVu : Page
    {
        private TKDoanhThuDichVuSVCClient TKDoanhThuDichVuClient = null;
        public frmThongKeDoanhThuDichVu()
        {
            InitializeComponent();
            Nam_Load();
            Thang_Load();
            LoadingPanel.Visibility = Visibility.Visible;
            LoadingPanel.IsBusy = true;
            TKDoanhThuDichVuClient = new TKDoanhThuDichVuSVCClient();
            TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoNgayCompleted += new EventHandler<HoaDonDichVu_GetItems_TheoNgayCompletedEventArgs>(TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TheoNgayCompleted);
            TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoNgayAsync(int.Parse(DateTime.Now.ToString("yyyyMMdd")));
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
                cbxTheoThang.SelectedValue = DateTime.Now.Month;
                cbxTheoThangNam.SelectedValue = DateTime.Now.Year;
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
                cbxTheoNam.SelectedValue = DateTime.Now.Year;
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
                    cbxTheoNam.Items.Add(currentYear);
                    cbxTheoThangNam.Items.Add(currentYear);
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
                    cbxTheoThang.Items.Add(currentMonth);
                    currentMonth = currentMonth + 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTheoNgay.SelectedDate.ToString()))
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKDoanhThuDichVuClient = new TKDoanhThuDichVuSVCClient();
                    TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoNgayCompleted += new EventHandler<HoaDonDichVu_GetItems_TheoNgayCompletedEventArgs>(TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TheoNgayCompleted);
                    TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoNgayAsync(int.Parse(rdpTheoNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                }
            }
            else if ((bool)rdbTheoThang.IsChecked)
            {
                if (cbxTheoThang.SelectedIndex != -1 && cbxTheoThangNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKDoanhThuDichVuClient = new TKDoanhThuDichVuSVCClient();
                    TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoThangCompleted += new EventHandler<HoaDonDichVu_GetItems_TheoThangCompletedEventArgs>(TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TheoThangCompleted);
                    TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoThangAsync((int)cbxTheoThang.SelectedValue, (int)cbxTheoThangNam.SelectedValue);
                }
            }
            else if ((bool)rdbTheoNam.IsChecked)
            {
                if (cbxTheoNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKDoanhThuDichVuClient = new TKDoanhThuDichVuSVCClient();
                    TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoNamCompleted += new EventHandler<HoaDonDichVu_GetItems_TheoNamCompletedEventArgs>(TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TheoNamCompleted);
                    TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TheoNamAsync((int)cbxTheoNam.SelectedValue);
                }
            }
            else if ((bool)rdbTuNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTuNgay.SelectedDate.ToString()) && !String.IsNullOrEmpty(rdpDenNgay.SelectedDate.ToString()))
                {
                    if (rdpTuNgay.SelectedDate < rdpDenNgay.SelectedDate)
                    {
                        LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                        TKDoanhThuDichVuClient = new TKDoanhThuDichVuSVCClient();
                        TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TuNgayDenNgayCompleted += new EventHandler<HoaDonDichVu_GetItems_TuNgayDenNgayCompletedEventArgs>(TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TuNgayDenNgayCompleted);
                        TKDoanhThuDichVuClient.HoaDonDichVu_GetItems_TuNgayDenNgayAsync(int.Parse(rdpTuNgay.SelectedDate.Value.ToString("yyyyMMdd")), int.Parse(rdpDenNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                    }
                }
            }
        }

        void TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TuNgayDenNgayCompleted(object sender, HoaDonDichVu_GetItems_TuNgayDenNgayCompletedEventArgs e)
        {
            grvHoaDonDichVu.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;
            LoadingPanel.IsBusy = false;
        }

        void TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TheoNamCompleted(object sender, HoaDonDichVu_GetItems_TheoNamCompletedEventArgs e)
        {
            grvHoaDonDichVu.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;
            LoadingPanel.IsBusy = false;
        }

        void TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TheoThangCompleted(object sender, HoaDonDichVu_GetItems_TheoThangCompletedEventArgs e)
        {
            grvHoaDonDichVu.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;
            LoadingPanel.IsBusy = false;
        }

        void TKDoanhThuDichVuClient_HoaDonDichVu_GetItems_TheoNgayCompleted(object sender, HoaDonDichVu_GetItems_TheoNgayCompletedEventArgs e)
        {
            grvHoaDonDichVu.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;
            LoadingPanel.IsBusy = false;
        }
    }
}

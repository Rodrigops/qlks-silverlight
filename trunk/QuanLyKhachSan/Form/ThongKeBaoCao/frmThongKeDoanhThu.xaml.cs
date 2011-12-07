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
using QuanLyKhachSan.TKDoanhThuSVC;
namespace QuanLyKhachSan.Form.ThongKeBaoCao
{
    public partial class frmThongKeDoanhThu : Page
    {
        private TKDoanhThuSVCClient TKDoanhThuClient = null;
        public frmThongKeDoanhThu()
        {
            InitializeComponent();
            Nam_Load();
            Thang_Load();
            LoadingPanel.Visibility = Visibility.Visible;
            LoadingPanel.IsBusy = true;
            TKDoanhThuClient = new TKDoanhThuSVCClient();
            TKDoanhThuClient.HoaDon_GetItems_TheoNgayCompleted += new EventHandler<HoaDon_GetItems_TheoNgayCompletedEventArgs>(TKDoanhThuClient_HoaDon_GetItems_TheoNgayCompleted);
            TKDoanhThuClient.HoaDon_GetItems_TheoNgayAsync(int.Parse(DateTime.Now.ToString("yyyyMMdd")));
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
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKDoanhThuClient = new TKDoanhThuSVCClient();
                    TKDoanhThuClient.HoaDon_GetItems_TheoNgayCompleted += new EventHandler<HoaDon_GetItems_TheoNgayCompletedEventArgs>(TKDoanhThuClient_HoaDon_GetItems_TheoNgayCompleted);
                    TKDoanhThuClient.HoaDon_GetItems_TheoNgayAsync(int.Parse(rdpTheoNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                }
            }
            else if ((bool)rdbTheoThang.IsChecked)
            {
                if (cbxTheoThang.SelectedIndex != -1 && cbxTheoThangNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKDoanhThuClient = new TKDoanhThuSVCClient();
                    TKDoanhThuClient.HoaDon_GetItems_TheoThangCompleted += new EventHandler<HoaDon_GetItems_TheoThangCompletedEventArgs>(TKDoanhThuClient_HoaDon_GetItems_TheoThangCompleted);
                    TKDoanhThuClient.HoaDon_GetItems_TheoThangAsync((int)cbxTheoThang.SelectedValue, (int)cbxTheoThangNam.SelectedValue);
                }
            }
            else if ((bool)rdbTheoNam.IsChecked)
            {
                if (cbxTheoNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKDoanhThuClient = new TKDoanhThuSVCClient();
                    TKDoanhThuClient.HoaDon_GetItems_TheoNamCompleted += new EventHandler<HoaDon_GetItems_TheoNamCompletedEventArgs>(TKDoanhThuClient_HoaDon_GetItems_TheoNamCompleted);
                    TKDoanhThuClient.HoaDon_GetItems_TheoNamAsync((int)cbxTheoNam.SelectedValue);
                }
            }
            else if ((bool)rdbTuNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTuNgay.SelectedDate.ToString()) && !String.IsNullOrEmpty(rdpDenNgay.SelectedDate.ToString()))
                {
                    if (rdpTuNgay.SelectedDate < rdpDenNgay.SelectedDate)
                    {
                        LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                        TKDoanhThuClient = new TKDoanhThuSVCClient();
                        TKDoanhThuClient.HoaDon_GetItems_TuNgayDenNgayCompleted += new EventHandler<HoaDon_GetItems_TuNgayDenNgayCompletedEventArgs>(TKDoanhThuClient_HoaDon_GetItems_TuNgayDenNgayCompleted);
                        TKDoanhThuClient.HoaDon_GetItems_TuNgayDenNgayAsync(int.Parse(rdpTuNgay.SelectedDate.Value.ToString("yyyyMMdd")), int.Parse(rdpDenNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                    }
                }
            }
        }

        void TKDoanhThuClient_HoaDon_GetItems_TuNgayDenNgayCompleted(object sender, HoaDon_GetItems_TuNgayDenNgayCompletedEventArgs e)
        {
            grvHoaDon.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        void TKDoanhThuClient_HoaDon_GetItems_TheoNamCompleted(object sender, HoaDon_GetItems_TheoNamCompletedEventArgs e)
        {
            grvHoaDon.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        void TKDoanhThuClient_HoaDon_GetItems_TheoThangCompleted(object sender, HoaDon_GetItems_TheoThangCompletedEventArgs e)
        {
            grvHoaDon.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        void TKDoanhThuClient_HoaDon_GetItems_TheoNgayCompleted(object sender, HoaDon_GetItems_TheoNgayCompletedEventArgs e)
        {
            grvHoaDon.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        //private void button1_Click(object sender, RoutedEventArgs e)
        //{
        //    rptHoaDon HoaDon = new rptHoaDon();
        //    HoaDon.Show();
        //}
    }
}

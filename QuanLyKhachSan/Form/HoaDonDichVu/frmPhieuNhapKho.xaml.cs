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
using QuanLyKhachSan.PhieuNhapKhoSVC;
using QuanLyKhachSan.TKChiTieuSVC;
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmPhieuNhapKho : ChildWindow
    {
        private PhieuNhapKhoSVCClient PhieuNhapKhoClient = null;
        private TKChiTieuSVCClient TKChiTieuClient = null;
        public frmPhieuNhapKho()
        {
            InitializeComponent();
            Nam_Load();
            Thang_Load();
            LoadingPanel.Visibility = Visibility.Visible;
            LoadingPanel.IsBusy = true;
            rdbTheoNgay.IsChecked = true;
            PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
            PhieuNhapKhoClient.PhieuNhapKho_GetItemsCompleted += new EventHandler<PhieuNhapKho_GetItemsCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_GetItemsCompleted);
            PhieuNhapKhoClient.PhieuNhapKho_GetItemsAsync();
        }
        void PhieuNhapKhoClient_PhieuNhapKho_GetItemsCompleted(object sender, PhieuNhapKho_GetItemsCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed; 
            LoadingPanel.IsBusy = false;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
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
                rdpTheoNgay.SelectedDate = DateTime.Now.Date;
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
                rdpTuNgay.SelectedDate = DateTime.Now.Date;
                rdpDenNgay.SelectedDate = DateTime.Now.Date;
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
        private void btnThem_Click(object sender, RoutedEventArgs e)
        {
            frmPhieuNhapKhoEdit PhieuNhapKhoEdit = new frmPhieuNhapKhoEdit();
            PhieuNhapKhoEdit.Closed += new EventHandler(PhieuNhapKhoEdit_Closed);
            PhieuNhapKhoEdit.PhieuNhapKhoEdit_Load(0);
            PhieuNhapKhoEdit.Show();
        }
        void PhieuNhapKhoEdit_Closed(object sender, EventArgs e)
        {
            frmPhieuNhapKhoEdit PhieuNhapKhoEdit = sender as frmPhieuNhapKhoEdit;
            if (PhieuNhapKhoEdit.DialogResult == true)
            {
                PhieuNhapKhoClient.PhieuNhapKho_GetItemsAsync();
            }
        }
        private void cmdSuaPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaPhieuNhap = sender as HyperlinkButton;
            int PhieuNhapID = int.Parse(cmdSuaPhieuNhap.CommandParameter.ToString());
            frmPhieuNhapKhoEdit PhieuNhapKhoEdit = new frmPhieuNhapKhoEdit();
            PhieuNhapKhoEdit.Closed += new EventHandler(PhieuNhapKhoEdit_Closed);
            PhieuNhapKhoEdit.PhieuNhapKhoEdit_Load(PhieuNhapID);
            PhieuNhapKhoEdit.Show();
        }
        void PhieuNhapKhoXacNhan_Closed(object sender, EventArgs e)
        {
            frmPhieuNhapKho_XacNhanXoa PhieuNhapKhoXacNhan = new frmPhieuNhapKho_XacNhanXoa();
            if (PhieuNhapKhoXacNhan.DialogResult == true)
            {
                PhieuNhapKhoClient.PhieuNhapKho_GetItemsAsync();
            }
        }
        private void cmdXoaPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaPhieuNhap = sender as HyperlinkButton;
            int PhieuNhapID = int.Parse(cmdXoaPhieuNhap.CommandParameter.ToString());
            frmPhieuNhapKho_XacNhanXoa PhieuNhapKhoXacNhan = new frmPhieuNhapKho_XacNhanXoa();
            PhieuNhapKhoXacNhan.Closed += new EventHandler(PhieuNhapKhoXacNhan_Closed);
            PhieuNhapKhoXacNhan.PhieuNhapID = PhieuNhapID;
            PhieuNhapKhoXacNhan.Show();
        }

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTheoNgay.SelectedDate.ToString()))
                {
                    LoadingPanel.Visibility = Visibility.Collapsed; 
                    LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoNgayCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoNgayCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayAsync(int.Parse(rdpTheoNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                }
            }
            else if ((bool)rdbTheoThang.IsChecked)
            {
                if (cbxTheoThang.SelectedIndex != -1 && cbxTheoThangNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Collapsed; 
                    LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoThangCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoThangCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoThangCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoThangAsync((int)cbxTheoThang.SelectedValue, (int)cbxTheoThangNam.SelectedValue);
                }
            }
            else if ((bool)rdbTheoNam.IsChecked)
            {
                if (cbxTheoNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Collapsed; 
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
                        LoadingPanel.Visibility = Visibility.Collapsed; 
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
            LoadingPanel.Visibility = Visibility.Collapsed; 
            LoadingPanel.IsBusy = false;
        }
        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoNamCompleted(object sender, PhieuNhapKho_GetItems_TheoNamCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;
            LoadingPanel.IsBusy = false;
        }
        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoThangCompleted(object sender, PhieuNhapKho_GetItems_TheoThangCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed; 
            LoadingPanel.IsBusy = false;
        }
        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoNgayCompleted(object sender, PhieuNhapKho_GetItems_TheoNgayCompletedEventArgs e)
        {
            grvPhieuNhapKho.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;
            LoadingPanel.IsBusy = false;
        }
    }
}


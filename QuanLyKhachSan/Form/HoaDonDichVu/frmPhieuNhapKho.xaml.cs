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
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmPhieuNhapKho : ChildWindow
    {
        private PhieuNhapKhoSVCClient PhieuNhapKhoClient = null;
        public frmPhieuNhapKho()
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
        private void cmdXoaPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaPhieuNhap = sender as HyperlinkButton;
            int PhieuNhapID = int.Parse(cmdXoaPhieuNhap.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                PhieuNhapKhoClient.PhieuNhapKho_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_DeleteCompleted);
                PhieuNhapKhoClient.PhieuNhapKho_DeleteAsync(PhieuNhapID, 0, DateTime.Now.ToString("MM/dd/yyyy"));
            }
        }
        void PhieuNhapKhoClient_PhieuNhapKho_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            PhieuNhapKhoClient.PhieuNhapKho_GetItemsAsync();
        }
    }
}


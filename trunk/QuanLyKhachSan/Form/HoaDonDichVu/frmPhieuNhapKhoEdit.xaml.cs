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
using QuanLyKhachSan.DichVuSVC;
using QuanLyKhachSan.PhieuNhapKhoSVC;
using QuanLyKhachSan.ChiTietPhieuNhapKhoSVC;
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmPhieuNhapKhoEdit : ChildWindow
    {
        public int PhieuNhapKhoID = -1;
        private PhieuNhapKhoSVCClient PhieuNhapKhoClient = null;
        private ChiTietPhieuNhapKhoSVCClient ChiTietClient = null;
        private DichVuSVCClient DichVuClient = new DichVuSVCClient();
        public frmPhieuNhapKhoEdit()
        {
            InitializeComponent();
        }
        public void PhieuNhapKhoEdit_Load(int _PhieuNhapKhoID)
        {
            if (_PhieuNhapKhoID != 0)
            {
                LoadingPanel.IsBusy = true;
                btnThemPhieuNhap.Content = "Cập nhật phiếu nhập";
                btnAddDichVu.IsEnabled = true;
                PhieuNhapKhoID = _PhieuNhapKhoID;

                PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
                PhieuNhapKhoClient.PhieuNhapKho_GetItemCompleted += new EventHandler<PhieuNhapKho_GetItemCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_GetItemCompleted);
                PhieuNhapKhoClient.PhieuNhapKho_GetItemAsync(PhieuNhapKhoID);

                ChiTietClient = new ChiTietPhieuNhapKhoSVCClient();
                ChiTietClient.ChiTietPhieuNhapKho_GetItemsCompleted += new EventHandler<ChiTietPhieuNhapKho_GetItemsCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_GetItemsCompleted);
                ChiTietClient.ChiTietPhieuNhapKho_GetItemsAsync(PhieuNhapKhoID);
            }
        }
        void PhieuNhapKhoClient_PhieuNhapKho_GetItemCompleted(object sender, PhieuNhapKho_GetItemCompletedEventArgs e)
        {
            PhieuNhapKhoInfo PhieuNhap = e.Result;
            if (!string.IsNullOrEmpty(PhieuNhap.NgayNhap))
                rdpNgayNhap.SelectedDate = DateTime.Parse(PhieuNhap.NgayNhap);
            txtGhiChu.Text = PhieuNhap.GhiChu;
        }
        void ChiTietClient_ChiTietPhieuNhapKho_GetItemsCompleted(object sender, ChiTietPhieuNhapKho_GetItemsCompletedEventArgs e)
        {
            grvChiTietPhieuNhap.ItemsSource = e.Result;
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
        private void cmdSuaCTPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaCTPhieuNhap = sender as HyperlinkButton;
            int CTPhieuNhapID = int.Parse(cmdSuaCTPhieuNhap.CommandParameter.ToString());
            frmPhieuNhapKho_ChiTiet PhieuNhapKho_ChiTiet = new frmPhieuNhapKho_ChiTiet();
            PhieuNhapKho_ChiTiet.Closed += new EventHandler(PhieuNhapKho_ChiTiet_Closed);
            PhieuNhapKho_ChiTiet.CTPhieuNhapKhoEdit_Load(CTPhieuNhapID, PhieuNhapKhoID);
            PhieuNhapKho_ChiTiet.Show();
        }
        void PhieuNhapKho_ChiTiet_Closed(object sender, EventArgs e)
        {
            frmPhieuNhapKho_ChiTiet PhieuNhapKho_ChiTiet = sender as frmPhieuNhapKho_ChiTiet;
            if (PhieuNhapKho_ChiTiet.DialogResult == true)
            {
                ChiTietClient = new ChiTietPhieuNhapKhoSVCClient();
                ChiTietClient.ChiTietPhieuNhapKho_GetItemsCompleted += new EventHandler<ChiTietPhieuNhapKho_GetItemsCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_GetItemsCompleted);
                ChiTietClient.ChiTietPhieuNhapKho_GetItemsAsync(PhieuNhapKhoID);
            }
        }
        private void cmdXoaCTPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaCTPhieuNhap = sender as HyperlinkButton;
            int CTPhieuNhapID = int.Parse(cmdXoaCTPhieuNhap.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                ChiTietClient.ChiTietPhieuNhapKho_GetItemCompleted += new EventHandler<ChiTietPhieuNhapKho_GetItemCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_GetItemCompleted);
                ChiTietClient.ChiTietPhieuNhapKho_GetItemAsync(CTPhieuNhapID);
                
                ChiTietClient.ChiTietPhieuNhapKho_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_DeleteCompleted);
                ChiTietClient.ChiTietPhieuNhapKho_DeleteAsync(CTPhieuNhapID);
            }
        }

        void ChiTietClient_ChiTietPhieuNhapKho_GetItemCompleted(object sender, ChiTietPhieuNhapKho_GetItemCompletedEventArgs e)
        {
            ChiTietPhieuNhapKhoInfo ChiTiet = e.Result;
            DichVuClient.DichVu_Edit_SLAsync(ChiTiet.DichVuID, 0 - ChiTiet.SoLuong);
        }
        void ChiTietClient_ChiTietPhieuNhapKho_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            ChiTietClient.ChiTietPhieuNhapKho_GetItemsAsync(PhieuNhapKhoID);
        }
        private void btnAddDichVu_Click(object sender, RoutedEventArgs e)
        {
            frmPhieuNhapKho_ChiTiet PhieuNhapKho_ChiTiet = new frmPhieuNhapKho_ChiTiet();
            PhieuNhapKho_ChiTiet.Closed += new EventHandler(PhieuNhapKho_ChiTiet_Closed);
            PhieuNhapKho_ChiTiet.CTPhieuNhapKhoEdit_Load(0, PhieuNhapKhoID);
            PhieuNhapKho_ChiTiet.Show();
        }

        private void btnThemPhieuNhap_Click(object sender, RoutedEventArgs e)
        {
            string ngaynhap = string.Empty;
            int thangnhap = 0;
            int namnhap = 0;
            int ngaynhapso = 0;
            if (!String.IsNullOrEmpty(rdpNgayNhap.SelectedDate.ToString()))
            {
                ngaynhap = rdpNgayNhap.SelectedDate.Value.ToString("MM/dd/yyyy");
                thangnhap = rdpNgayNhap.SelectedDate.Value.Month;
                namnhap = rdpNgayNhap.SelectedDate.Value.Year;
                ngaynhapso = int.Parse(rdpNgayNhap.SelectedDate.Value.ToString("yyyyMMdd"));
            }
            else
            {
                rdpNgayNhap.SelectedDate = DateTime.Now;
                ngaynhap = DateTime.Now.ToString("MM/dd/yyyy");
                thangnhap = DateTime.Now.Month;
                namnhap = DateTime.Now.Year;
                ngaynhapso = int.Parse(DateTime.Now.ToString("yyyyMMdd"));
            }
            if (PhieuNhapKhoID == -1)
            {
                PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
                PhieuNhapKhoClient.PhieuNhapKho_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_AddCompleted);
                PhieuNhapKhoClient.PhieuNhapKho_AddAsync(ngaynhap, thangnhap, namnhap, ngaynhapso, txtGhiChu.Text.Trim(), User.UserID, DateTime.Now.ToString("MM/dd/yyyy"));
            }
            else
            {
                PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
                PhieuNhapKhoClient.PhieuNhapKho_EditAsync(PhieuNhapKhoID, ngaynhap, thangnhap, namnhap, ngaynhapso, txtGhiChu.Text.Trim(), User.UserID, DateTime.Now.ToString("MM/dd/yyyy"));
            }
        }
         void PhieuNhapKhoClient_PhieuNhapKho_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            btnThemPhieuNhap.Content = "Cập nhật phiếu nhập";
            btnAddDichVu.IsEnabled = true;
            PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
            PhieuNhapKhoClient.PhieuNhapKho_GetLatestItemCompleted += new EventHandler<PhieuNhapKho_GetLatestItemCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_GetLatestItemCompleted);
            PhieuNhapKhoClient.PhieuNhapKho_GetLatestItemAsync();
        }
        void PhieuNhapKhoClient_PhieuNhapKho_GetLatestItemCompleted(object sender, PhieuNhapKho_GetLatestItemCompletedEventArgs e)
        {
            PhieuNhapKhoInfo PhieuNhap = e.Result;
            PhieuNhapKhoID = PhieuNhap.PhieuNhapKhoID;
        }
    }
}


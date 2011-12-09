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
    public partial class frmPhieuNhapKho_XacNhanXoa : ChildWindow
    {
        public int PhieuNhapID = -1;
        private DichVuSVCClient DichVuClient = null;
        private PhieuNhapKhoSVCClient PhieuNhapKhoClient = null;
        private ChiTietPhieuNhapKhoSVCClient ChiTietClient = null;
        public frmPhieuNhapKho_XacNhanXoa()
        {
            InitializeComponent();
        }

        private void btnCancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        void PhieuNhapKhoClient_PhieuNhapKho_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void btnXoaPhieu_Click(object sender, RoutedEventArgs e)
        {
            PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
            PhieuNhapKhoClient.PhieuNhapKho_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_DeleteCompleted);
            PhieuNhapKhoClient.PhieuNhapKho_DeleteAsync(PhieuNhapID, int.Parse(User.UserID), DateTime.Now.ToString("MM/dd/yyyy"));
        }
        private void btnTruKho_Click(object sender, RoutedEventArgs e)
        {
            ChiTietClient = new ChiTietPhieuNhapKhoSVCClient();
            ChiTietClient.ChiTietPhieuNhapKho_GetItemsCompleted += new EventHandler<ChiTietPhieuNhapKho_GetItemsCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_GetItemsCompleted);
            ChiTietClient.ChiTietPhieuNhapKho_GetItemsAsync(PhieuNhapID);

            PhieuNhapKhoClient = new PhieuNhapKhoSVCClient();
            PhieuNhapKhoClient.PhieuNhapKho_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhieuNhapKhoClient_PhieuNhapKho_DeleteCompleted);
            PhieuNhapKhoClient.PhieuNhapKho_DeleteAsync(PhieuNhapID, int.Parse(User.UserID), DateTime.Now.ToString("MM/dd/yyyy"));
        }
        void ChiTietClient_ChiTietPhieuNhapKho_GetItemsCompleted(object sender, ChiTietPhieuNhapKho_GetItemsCompletedEventArgs e)
        {
            List<ChiTietPhieuNhapKhoInfo> ChiTiet = e.Result;
            foreach (ChiTietPhieuNhapKhoInfo Item in ChiTiet)
            {
                ChiTietClient = new ChiTietPhieuNhapKhoSVCClient();
                ChiTietClient.ChiTietPhieuNhapKho_GetItemCompleted += new EventHandler<ChiTietPhieuNhapKho_GetItemCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_GetItemCompleted);
                ChiTietClient.ChiTietPhieuNhapKho_GetItemAsync(Item.ChiTietPhieuNhapID);

                //ChiTietClient.ChiTietPhieuNhapKho_DeleteAsync(Item.ChiTietPhieuNhapID);
            }
        }
        void ChiTietClient_ChiTietPhieuNhapKho_GetItemCompleted(object sender, ChiTietPhieuNhapKho_GetItemCompletedEventArgs e)
        {
            ChiTietPhieuNhapKhoInfo ChiTiet = e.Result;
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_Edit_SLAsync(ChiTiet.DichVuID, 0 - ChiTiet.SoLuong);
        }
    }
}


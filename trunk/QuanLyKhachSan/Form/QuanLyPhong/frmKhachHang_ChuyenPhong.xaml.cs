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
using QuanLyKhachSan.PhongSVC;
using QuanLyKhachSan.HoaDon_KhachHangSVC;
using QuanLyKhachSan.HoaDon_TraTruocSVC;
using QuanLyKhachSan.HoaDonSVC;
using QuanLyKhachSan.HoaDonDichVuSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmKhachHang_ChuyenPhong : ChildWindow
    {
        private int HoaDonID;
        private int PhongID;
        HoaDonSVCClient HoaDonClient = null;
        PhongSVCClient PhongClient = null;
        HoaDon_KhachHangSVCClient HDKHClient = null;
        HoaDon_TraTruocSVCClient TraTruocClient = null;
        PhongSVCClient Phong1Client = null;
        public frmKhachHang_ChuyenPhong()
        {
            InitializeComponent();
        }
        public void ChuyenPhong_Load(int _HoaDonID, int _PhongID)
        {
            HoaDonID = _HoaDonID;
            PhongID = _PhongID;
            LoadingPanel.IsBusy = true;

            Phong1Client = new PhongSVCClient();
            Phong1Client.Phong_GetItemCompleted += new EventHandler<Phong_GetItemCompletedEventArgs>(Phong1Client_Phong_GetItemCompleted);
            Phong1Client.Phong_GetItemAsync(PhongID);

            PhongClient = new PhongSVCClient();
            PhongClient.Phong_GetItems_ByTinhTrangCompleted += new EventHandler<Phong_GetItems_ByTinhTrangCompletedEventArgs>(PhongClient_Phong_GetItems_ByTinhTrangCompleted);
            PhongClient.Phong_GetItems_ByTinhTrangAsync();
        }

        void PhongClient_Phong_GetItems_ByTinhTrangCompleted(object sender, Phong_GetItems_ByTinhTrangCompletedEventArgs e)
        {
            cbxPhong.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }
        void Phong1Client_Phong_GetItemCompleted(object sender, Phong_GetItemCompletedEventArgs e)
        {
            PhongInfo Phong = e.Result;
            lblTuPhong.Text += " " + Phong.PhongName;
        }
        private void cbxPhong_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            LoadingPanel.IsBusy = true;
            PhongClient = new PhongSVCClient();
            PhongClient.Phong_GetItemCompleted += new EventHandler<Phong_GetItemCompletedEventArgs>(PhongClient_Phong_GetItemCompleted);
            PhongClient.Phong_GetItemAsync((int)cbxPhong.SelectedValue);
        }
        void PhongClient_Phong_GetItemCompleted(object sender, Phong_GetItemCompletedEventArgs e)
        {
            PhongInfo Phong = e.Result;
            txtSoGiuong.Text = Phong.SoGiuong.ToString();
            txtSoNguoi.Text = Phong.SoNguoi.ToString();
            txtTienNghi.Text = Phong.TienNghiName;
            lblDenPhong.Text = "Đến Phòng: " + Phong.PhongName;
            LoadingPanel.IsBusy = false;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (cbxPhong.SelectedIndex != -1)
            {
                //Edit Phong
                HDKHClient = new HoaDon_KhachHangSVCClient();
                HDKHClient.HoaDon_KhachHang_EditPhongCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HDKHClient_HoaDon_KhachHang_EditPhongCompleted);
                HDKHClient.HoaDon_KhachHang_EditPhongAsync(HoaDonID, (int)cbxPhong.SelectedValue);                

                
            }
        }
        void HDKHClient_HoaDon_KhachHang_EditPhongCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //Edit TraTruoc
            TraTruocClient = new HoaDon_TraTruocSVCClient();
            TraTruocClient.TinhTrang_Phong_EditIsActiveCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(TraTruocClient_TinhTrang_Phong_EditIsActiveCompleted);
            TraTruocClient.TinhTrang_Phong_EditIsActiveAsync(HoaDonID);
        }
        void TraTruocClient_TinhTrang_Phong_EditIsActiveCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //Edit TinhTrangPhong
            HoaDonClient = new HoaDonSVCClient();
            HoaDonClient.HoaDon_GetItemCompleted += new EventHandler<HoaDon_GetItemCompletedEventArgs>(HoaDonClient_HoaDon_GetItemCompleted);
            HoaDonClient.HoaDon_GetItemAsync(HoaDonID);
        }
        void HoaDonClient_HoaDon_GetItemCompleted(object sender, HoaDon_GetItemCompletedEventArgs e)
        {
            HoaDonInfo HoaDon = e.Result;
            PhongClient = new PhongSVCClient();
            PhongClient.TinhTrang_Phong_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_TinhTrang_Phong_EditCompleted);
            PhongClient.TinhTrang_Phong_EditAsync(HoaDonID,(int)cbxPhong.SelectedValue);
        }

        void PhongClient_TinhTrang_Phong_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //Chuyen DichVu
            HoaDonDichVuSVCClient HoaDonDichVuService = new HoaDonDichVuSVCClient();
            HoaDonDichVuService.HoaDonDichVu_ChuyenPhongCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonDichVuService_HoaDonDichVu_ChuyenPhongCompleted);
            HoaDonDichVuService.HoaDonDichVu_ChuyenPhongAsync(HoaDonID,(int)cbxPhong.SelectedValue);         
        }

        void HoaDonDichVuService_HoaDonDichVu_ChuyenPhongCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


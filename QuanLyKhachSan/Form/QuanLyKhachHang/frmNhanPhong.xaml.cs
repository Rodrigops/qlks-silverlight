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
using QuanLyKhachSan.KhachHangSVC;
using QuanLyKhachSan.HoaDonSVC;
using QuanLyKhachSan.HoaDon_KhachHangSVC;
namespace QuanLyKhachSan.Form.QuanLyKhachHang
{
    public partial class frmNhanPhong : ChildWindow
    {
        PhongSVCClient PhongClient = new PhongSVCClient();
        private List<KhachHangInfo> listKhachHang;
        public frmNhanPhong()
        {
            InitializeComponent();
            PhongClient.Phong_GetItems_ByTinhTrangCompleted += new EventHandler<Phong_GetItems_ByTinhTrangCompletedEventArgs>(PhongClient_Phong_GetItems_ByTinhTrangCompleted);
            PhongClient.Phong_GetItems_ByTinhTrangAsync();
        }
        public void KhachHang_Load(List<KhachHangInfo> _listKhachHang)
        {
            listKhachHang = _listKhachHang;
            grvKhachHang.ItemsSource = listKhachHang;
        }
        void PhongClient_Phong_GetItems_ByTinhTrangCompleted(object sender, Phong_GetItems_ByTinhTrangCompletedEventArgs e)
        {
            cbxPhong.ItemsSource = e.Result;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            HoaDonSVCClient HoaDonClient = new HoaDonSVCClient();
            HoaDonClient.HoaDon_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonClient_HoaDon_AddCompleted);
            HoaDonClient.HoaDon_AddAsync(1);
        }

        void HoaDonClient_HoaDon_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            HoaDon_KhachHangSVCClient HoaDon_KhachHangClient = new HoaDon_KhachHangSVCClient();
            PhongSVCClient PhongClient = new PhongSVCClient();
            int PhongID = int.Parse(cbxPhong.SelectedValue.ToString());
            string sNgayBatDau = "";
            int iGioBatDau;
            int iPhutBatDau;
            int iNgayBatDau_So;
            int iThangBatDau;
            int iNamBatDau;
            string sNgayKetThuc = "";

            if (!String.IsNullOrEmpty(calNgayVao.SelectedDate.ToString()))
                sNgayBatDau = calNgayVao.SelectedDate.Value.ToString("MM/dd/yyyy");
            iGioBatDau = int.Parse(cbxGioVao.Text.ToString());
            iPhutBatDau = int.Parse(cbxPhutVao.Text.ToString());
            iNgayBatDau_So = DateToNumberConverter.Date2Number(sNgayBatDau);
            iThangBatDau = DateToNumberConverter.Date2Month(sNgayBatDau);
            iNamBatDau = DateToNumberConverter.Date2Year(sNgayBatDau);
            if (!String.IsNullOrEmpty(calNgayRa.SelectedDate.ToString()))
                sNgayKetThuc = calNgayRa.SelectedDate.Value.ToString("MM/dd/yyyy");

            foreach (KhachHangInfo item in listKhachHang)
            {                   
                HoaDon_KhachHangClient.HoaDon_KhachHang_AddAsync("NhanPhong",item.KhachHangID, PhongID, sNgayBatDau, iGioBatDau, iPhutBatDau, iNgayBatDau_So, iThangBatDau, iNamBatDau, sNgayKetThuc);                
            }
            PhongClient.TinhTrang_Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_TinhTrang_Phong_AddCompleted);
            PhongClient.TinhTrang_Phong_AddAsync(PhongID, 3, iNgayBatDau_So);
        }

        void PhongClient_TinhTrang_Phong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        

        
    }
}


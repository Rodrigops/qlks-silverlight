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
using QuanLyKhachSan.HoaDon_KhachHangSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmPhong_KhachHang_DatPhong : ChildWindow
    {
        private int HoaDonID;
        private int PhongID;
        private HoaDon_KhachHangSVCClient HoaDon_KhachHang = new HoaDon_KhachHangSVCClient();
        public frmPhong_KhachHang_DatPhong()
        {
            InitializeComponent();
        }
        public void Phong_KhachHang_DatPhong_Load(int _HoaDonID, int _PhongID)
        {
            try
            {
                HoaDonID = _HoaDonID;
                PhongID = _PhongID;
                HoaDon_KhachHang.Phong_KhachHang_DatPhongCompleted += new EventHandler<Phong_KhachHang_DatPhongCompletedEventArgs>(HoaDon_KhachHang_Phong_KhachHang_DatPhongCompleted);
                HoaDon_KhachHang.Phong_KhachHang_DatPhongAsync(PhongID);
            }
            catch (Exception ex)
            {                
                throw;
            }
        }

        void HoaDon_KhachHang_Phong_KhachHang_DatPhongCompleted(object sender, Phong_KhachHang_DatPhongCompletedEventArgs e)
        {
            grvKhachHang.ItemsSource = e.Result;
        }

        private void cmdDong_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }

        private void cmdXoa_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoa = sender as HyperlinkButton;
            Phong_KhachHangInfo item = cmdXoa.CommandParameter as Phong_KhachHangInfo;            
            HoaDon_KhachHang.Phong_KhachHang_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDon_KhachHang_Phong_KhachHang_DeleteCompleted);
            HoaDon_KhachHang.Phong_KhachHang_DeleteAsync(item.HoaDonID, item.KhachHangID);
        }

        void HoaDon_KhachHang_Phong_KhachHang_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            HoaDon_KhachHang.Phong_KhachHang_DatPhongAsync(PhongID);
        }

        private void cmdSua_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}


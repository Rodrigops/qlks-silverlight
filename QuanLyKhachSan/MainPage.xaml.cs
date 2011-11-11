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
using QuanLyKhachSan.AuthenticationSVC;
namespace QuanLyKhachSan
{
    public partial class MainPage : UserControl
    {
        private AuthenticationSVCClient Authentication = new AuthenticationSVCClient();
        public MainPage()
        {
            InitializeComponent();
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }
        private string KeyMapping = "";
        void Authentication_Authentication_GetSessionCompleted(object sender, Authentication_GetSessionCompletedEventArgs e)
        {
            if (e.Result.ToString() == "")
            {
                cmdLogout.Visibility = System.Windows.Visibility.Collapsed;
                cmdLogout.Content = "";
                ContentFrame.Navigate(new Uri("Login", UriKind.Relative));
            }
            else
            {
                cmdLogout.Visibility = System.Windows.Visibility.Visible;
                cmdLogout.Content = "[" + e.Result.ToString() + " - Thoát]"; 
                //PhanQuyen
                switch (KeyMapping)
                {
                    case "ThongTinPhong" :                        
                            ContentFrame.Navigate(new Uri("ThongTinPhong", UriKind.Relative));
                        break;
                    case "GiaPhong":
                        ContentFrame.Navigate(new Uri("GiaPhong", UriKind.Relative));
                        break;
                    case "CaiDatGia":
                        ContentFrame.Navigate(new Uri("CaiDatGia", UriKind.Relative));
                        break;
                    case "":
                        ContentFrame.Navigate(new Uri("", UriKind.Relative));
                        break;
                    case "KhachHang":
                        ContentFrame.Navigate(new Uri("KhachHang", UriKind.Relative));
                        break;
                    case "HoaDonDichVu":
                        ContentFrame.Navigate(new Uri("HoaDonDichVu", UriKind.Relative));
                        break;
                    case "QuanLyUser":
                        ContentFrame.Navigate(new Uri("QuanLyUser", UriKind.Relative));
                        break;
                    case "PhanQuyenUser":
                        ContentFrame.Navigate(new Uri("PhanQuyenUser", UriKind.Relative));
                        break;
                    case "ThongKeDoanhThu":
                        ContentFrame.Navigate(new Uri("ThongKeDoanhThu", UriKind.Relative));
                        break;
                    case "ThongKeChiTieu":
                        ContentFrame.Navigate(new Uri("ThongKeChiTieu", UriKind.Relative));
                        break;
                    case "ThongKeDoanhThuDichVu":
                        ContentFrame.Navigate(new Uri("ThongKeDoanhThuDichVu", UriKind.Relative));
                        break;
                }
            }            
        }
        private void cmdThongTinPhong_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongTinPhong";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        private void cmdGiaPhong_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "GiaPhong";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        private void cmdCaiDatGia_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "CaiDatGia";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        private void cmdTinhTrangPhong_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        private void cmdKhachHang_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "KhachHang";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();        
        }

        private void cmdDatPhong_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdNhanPhong_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdDichVuPhong_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "HoaDonDichVu";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        private void cmdQuanLyUser_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "QuanLyUser";            
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }
        private void cmdPhanQuyenUser_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "PhanQuyenUser";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }
        private void cmdLogout_Click(object sender, RoutedEventArgs e)
        {
            Authentication.Authentication_SetSessionCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(Authentication_Authentication_SetSessionCompleted);
            Authentication.Authentication_SetSessionAsync("");
        }

        void Authentication_Authentication_SetSessionCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            Authentication.Authentication_GetSessionAsync();   
        }

        private void cmdThongKeDoanhThu_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongKeDoanhThu";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        private void cmdThongKeChiTieu_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongKeChiTieu";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        private void cmdThongKeDoanhThuDichVu_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongKeDoanhThuDichVu";
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        
    }
}

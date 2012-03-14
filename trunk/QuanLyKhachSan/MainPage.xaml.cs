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
using QuanLyKhachSan.ModuleSVC;
using QuanLyKhachSan.UserGroupSVC;
using QuanLyKhachSan.AuthenticationService;
using System.IO.IsolatedStorage;
using QuanLyKhachSan.Libs.Common;
namespace QuanLyKhachSan
{
    public partial class MainPage : UserControl
    {        
        //private AuthenticationSVCSoapClient Authentication = new AuthenticationSVCSoapClient();
        private ModuleSVCClient Module = new ModuleSVCClient();
        AuthenticationServiceClient ClientLogin = new AuthenticationServiceClient();
        public MainPage()
        {
            InitializeComponent();            
            ClientLogin.IsLoggedInCompleted += new EventHandler<IsLoggedInCompletedEventArgs>(ClientLogin_IsLoggedInCompleted);
            ClientLogin.IsLoggedInAsync();
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }

        void ClientLogin_IsLoggedInCompleted(object sender, IsLoggedInCompletedEventArgs e)
        {
            if (!e.Result)
            {
                System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("Login.aspx", UriKind.Relative));
            }
            else
            {
                 txtUserName.Content = "Xin chào " + IsolatedStorageSettings.SiteSettings["UserName"].ToString();
            }
        }
        public string KeyMapping = "";
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
                redirect(KeyMapping);
                //PhanQuyen
                //UserGroupSVCClient UserGroup = new UserGroupSVCClient();
                //UserGroup.GroupIDByUserNameCompleted += new EventHandler<GroupIDByUserNameCompletedEventArgs>(UserGroup_GroupIDByUserNameCompleted);
                //UserGroup.GroupIDByUserNameAsync(e.Result);

            }
        }

        void UserGroup_GroupIDByUserNameCompleted(object sender, GroupIDByUserNameCompletedEventArgs e)
        {
            Module.Module_GetItemsCompleted += new EventHandler<Module_GetItemsCompletedEventArgs>(Module_Module_GetItemsCompleted);
            Module.Module_GetItemsAsync(int.Parse(e.Result.ToString()));
        }

        void Module_Module_GetItemsCompleted(object sender, Module_GetItemsCompletedEventArgs e)
        {
            List<ModuleInfo> _moduleInfo = e.Result;
            foreach (ModuleInfo item in _moduleInfo)
            {
                bool Permission = item.IsView == 1 ? true : false;
                SetPermission(item.ModuleKey, Permission);
            }
            switch (KeyMapping)
            {
                case "ThongTinPhong":
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
        public void Permission_Load()
        {
            //PhanQuyen
            Module.Module_GetItemsCompleted += new EventHandler<Module_GetItemsCompletedEventArgs>(Module_Module_GetItemsCompleted);
            Module.Module_GetItemsAsync(1);
        }
        public void SetPermission(string ModuleKey, bool Permission)
        {
            switch (ModuleKey)
            {
                case "frmTinhTrangPhong":
                    cmdTinhTrangPhong.IsEnabled = Permission;
                    break;
                case "frmKhachHang":
                    //cmdKhachHang.IsEnabled = Permission;
                    break;
                case "frmDatPhong":
                    //cmdDatPhong.IsEnabled = Permission;
                    break;
                case "frmNhanPhong":
                    //cmdNhanPhong.IsEnabled = Permission;
                    break;
                case "frmDichVuPhong":
                    //cmdDichVuPhong.IsEnabled = Permission;
                    break;
                case "frmThongTinPhong":
                    cmdThongTinPhong.IsEnabled = Permission;
                    break;
                case "frmGiaPhong":
                    cmdGiaPhong.IsEnabled = Permission;
                    break;
                case "frmCaiDatGia":
                    cmdCaiDatGia.IsEnabled = Permission;
                    break;
                case "frmThongKeDoanhThu":
                    cmdThongKeDoanhThu.IsEnabled = Permission;
                    break;
                case "frmThongKeChiTieu":
                    cmdThongKeChiTieu.IsEnabled = Permission;
                    break;
                case "frmThongKeDoanhThuDichVu":
                    cmdThongKeDoanhThuDichVu.IsEnabled = Permission;
                    break;
                case "frmQuanLyUser":
                    cmdQuanLyUser.IsEnabled = Permission;
                    break;
                case "frmPhanQuyen":
                    cmdPhanQuyenUser.IsEnabled = Permission;
                    break;
            }
        }
        private void redirect(string KeyMapping)
        {
            switch (KeyMapping)
            {
                case "ThongTinPhong":
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
        private void cmdThongTinPhong_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongTinPhong";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }

        private void cmdGiaPhong_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "GiaPhong";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }

        private void cmdCaiDatGia_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "CaiDatGia";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }

        private void cmdTinhTrangPhong_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();

        }

        private void cmdKhachHang_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "KhachHang";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
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
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }

        private void cmdQuanLyUser_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "QuanLyUser";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }
        private void cmdPhanQuyenUser_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "PhanQuyenUser";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }
        private void cmdLogout_Click(object sender, RoutedEventArgs e)
        {
            Common.ShowBusyIndicator();
            ClientLogin.LogoutCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(ClientLogin_LogoutCompleted);
            ClientLogin.LogoutAsync();
        }

        void ClientLogin_LogoutCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //return Login.apsx
            Common.CloseBusyIndicator();
            System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("Login.aspx", UriKind.Relative));
        }

        void Authentication_Authentication_SetSessionCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            //Authentication.Authentication_GetSessionAsync();
        }

        private void cmdThongKeDoanhThu_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongKeDoanhThu";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }

        private void cmdThongKeChiTieu_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongKeChiTieu";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }

        private void cmdThongKeDoanhThuDichVu_Click(object sender, RoutedEventArgs e)
        {
            KeyMapping = "ThongKeDoanhThuDichVu";
            redirect(KeyMapping);
            //Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            //Authentication.Authentication_GetSessionAsync();
        }


    }
}

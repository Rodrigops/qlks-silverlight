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
using QuanLyKhachSan.Login.AuthenticationService;
using System.ServiceModel;
using System.IO.IsolatedStorage;
using QuanLyKhachSan.Libs.Common;

namespace QuanLyKhachSan.Login
{
    public partial class MainPage : UserControl
    {
        AuthenticationServiceClient ClientLogin = new AuthenticationServiceClient();
        public MainPage()
        {
            InitializeComponent();
            IsolatedStorageSettings.SiteSettings.Clear();
        }

        private void cmdLogin_Click(object sender, RoutedEventArgs e)
        {

            Common.ShowBusyIndicator();
            ClientLogin.LoginCompleted += new EventHandler<LoginCompletedEventArgs>(ClientLogin_LoginCompleted);
            ClientLogin.LoginAsync(txtUserName.Text, txtPassword.Password, "", true, txtUserName.Text);
        }

        void ClientLogin_LoginCompleted(object sender, LoginCompletedEventArgs e)
        {
            Common.CloseBusyIndicator();
            if (bool.Parse(e.Result.ToString()))
            {
                lblError.Visibility = System.Windows.Visibility.Collapsed;
                IsolatedStorageSettings.SiteSettings.Clear();
                IsolatedStorageSettings.SiteSettings.Add("UserName", txtUserName.Text);
                IsolatedStorageSettings.SiteSettings.Save();
                
                System.Windows.Browser.HtmlPage.Window.Navigate(new Uri("Default.aspx", UriKind.Relative));
                
            }
            else
            {
                lblError.Visibility = System.Windows.Visibility.Visible;
            }
        }
        public static string GetHostRoot()
        {
            string hostName = Application.Current.Host.Source.Host;
            if (Application.Current.Host.Source.Port != 80)
            {
                hostName += ":" + Application.Current.Host.Source.Port;
            }
            return "http://" + hostName + "/QuanLyKhachSan.WebServices/";
        }

        public static EndpointAddress GetEndpointAddress()
        {
            return new EndpointAddress(GetHostRoot() + string.Format("Services/{0}/", "Authentication") + "AuthenticationService" + ".svc");
        }

        private void txtUserName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                txtPassword.Focus();
            }
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                if (txtPassword.Password != "" & txtUserName.Text != "")
                {
                    lblError.Visibility = System.Windows.Visibility.Collapsed;
                    Common.ShowBusyIndicator();
                    ClientLogin.LoginCompleted += new EventHandler<LoginCompletedEventArgs>(ClientLogin_LoginCompleted);
                    ClientLogin.LoginAsync(txtUserName.Text, txtPassword.Password, "", true, txtUserName.Text);
                }
                else
                {
                    lblError.Content = "Vui lòng nhập đầy đủ thông tin!";
                    lblError.Visibility = System.Windows.Visibility.Visible;
                }
            }
        }


    }
}

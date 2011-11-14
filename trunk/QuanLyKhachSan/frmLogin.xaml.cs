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
using System.Windows.Navigation;
using QuanLyKhachSan.AuthenticationSVC;
namespace QuanLyKhachSan
{
    public partial class frmLogin : Page
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void radButton1_Click(object sender, RoutedEventArgs e)
        {
            AuthenticationSVCClient Authentication = new AuthenticationSVCClient();
            Authentication.Authentication_CheckAccountCompleted += new EventHandler<Authentication_CheckAccountCompletedEventArgs>(Authentication_Authentication_CheckAccountCompleted);
            Authentication.Authentication_CheckAccountAsync(txtUserName.Text.Trim(), txtPassword.Password.Trim());          
        }

        void Authentication_Authentication_CheckAccountCompleted(object sender, Authentication_CheckAccountCompletedEventArgs e)
        {
            if (e.Result.ToString() == "Success")
            {                
                this.NavigationService.Navigate(new Uri("", UriKind.Relative));
            }
            else
            {             
                this.NavigationService.Navigate(new Uri("Login", UriKind.Relative));
            }
        }
        void Authentication_Authentication_SetSessionCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            AuthenticationSVCClient Authentication = new AuthenticationSVCClient();
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }

        void Authentication_Authentication_GetSessionCompleted(object sender, Authentication_GetSessionCompletedEventArgs e)
        {
            if (e.Result.ToString() != "")
            {
                Authentication.isLogged = true;                
            
            }
        }

    }
}

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
            AuthenticationSVCSoapClient Authentication = new AuthenticationSVCSoapClient();
            Authentication.Authentication_CheckAccountCompleted += new EventHandler<Authentication_CheckAccountCompletedEventArgs>(Authentication_Authentication_CheckAccountCompleted);
            Authentication.Authentication_CheckAccountAsync(txtUserName.Text.Trim(), txtPassword.Password.Trim());          
        }

        void Authentication_Authentication_CheckAccountCompleted(object sender, Authentication_CheckAccountCompletedEventArgs e)
        {
            if (e.Result.ToString() != "Fail")
            {               
                AuthenticationSVCSoapClient Authentication = new AuthenticationSVCSoapClient();
                Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
                Authentication.Authentication_GetSessionAsync();
                User.UserID = e.Result.ToString();
            }
            else
            {             
                this.NavigationService.Navigate(new Uri("Login", UriKind.Relative));
            }
        }
        void Authentication_Authentication_SetSessionCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            AuthenticationSVCSoapClient Authentication = new AuthenticationSVCSoapClient();
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();
        }
        private MainPage mainParent = null;
        void Authentication_Authentication_GetSessionCompleted(object sender, Authentication_GetSessionCompletedEventArgs e)
        {
            if (e.Result.ToString() != "")
            {
                mainParent = FindParentOfType<MainPage>(this);
                mainParent.cmdLogout.Visibility = System.Windows.Visibility.Visible;
                mainParent.cmdLogout.Content = "[" + e.Result.ToString() + " - Thoát]";
                this.NavigationService.Navigate(new Uri("", UriKind.Relative));                            
            }
        }
        public static T FindParentOfType<T>(FrameworkElement element)
        {
            var parent = element.Parent as FrameworkElement;
            while (parent != null)
            {
                if (parent is T)
                    return (T)(object)parent;
                parent = parent.Parent as FrameworkElement;
            }
            return default(T);

        }
    }
}

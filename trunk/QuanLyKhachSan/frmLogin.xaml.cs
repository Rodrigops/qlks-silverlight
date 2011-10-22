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
            if (txtUserName.Text == "1")
            {
             
                this.NavigationService.Navigate(new Uri("", UriKind.Relative));
            }
            else
            {
             
            }
        }

    }
}

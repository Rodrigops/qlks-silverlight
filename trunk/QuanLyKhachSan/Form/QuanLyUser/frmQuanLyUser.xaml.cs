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

namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmQuanLyUser : Page
    {
        public frmQuanLyUser()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }

        private void cmdThemUser_Click(object sender, RoutedEventArgs e)
        {
            frmUserEdit UserEdit = new frmUserEdit();
            UserEdit.Show();
        }

    }
}

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
using QuanLyKhachSan.ManagementUserSVC;

namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmQuanLyUser : Page
    {
        private ManagementUserSVCClient ManagementUserClient = new ManagementUserSVCClient();
        public frmQuanLyUser()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            GetAllUsers();
        }

        private void cmdThemUser_Click(object sender, RoutedEventArgs e)
        {
            frmUserEdit UserEdit = new frmUserEdit();
            UserEdit.Show();
        }
        private void GetAllUsers()
        {
            ManagementUserClient.GetAllUsersCompleted += new EventHandler<GetAllUsersCompletedEventArgs>(ManagementUserClient_GetAllUsersCompleted);
            ManagementUserClient.GetAllUsersAsync();
        }

        void ManagementUserClient_GetAllUsersCompleted(object sender, GetAllUsersCompletedEventArgs e)
        {
            grvUser.ItemsSource = e.Result;
        }

    }
}

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
using QuanLyKhachSan.ManagementUserSVC;
namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmUserEdit : ChildWindow
    {
        private ManagementUserSVCClient ManagementUserClient = new ManagementUserSVCClient();
        public frmUserEdit()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            ManagementUserClient.CreateUserCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(ManagementUserClient_CreateUserCompleted);
            ManagementUserClient.CreateUserAsync(txtUserName.Text, txtPassword.Password, txtPassword2.Password, txtEmail.Text);
        }

        void ManagementUserClient_CreateUserCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


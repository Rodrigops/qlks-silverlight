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
using QuanLyKhachSan.UserSVC;
namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmUserEdit : ChildWindow
    {
        public int UserID = -1;
        private UserSVCClient UserClient = null;
        public frmUserEdit()
        {
            InitializeComponent();
        }

        public void User_Load(int _UserID)
        {
            UserID = _UserID;
            UserClient = new UserSVCClient();
            UserClient.User_GetItemCompleted += new EventHandler<User_GetItemCompletedEventArgs>(UserClient_User_GetItemCompleted);
            UserClient.User_GetItemAsync(UserID);
        }

        void UserClient_User_GetItemCompleted(object sender, User_GetItemCompletedEventArgs e)
        {
            UserInfo User = e.Result;

            txUserName.Text = User.UserName;
            txtFullName.Text = User.FullName;
            txtDisplayName.Text = User.DisplayName;
            if (User.IsActived == 1)
                chkIsActived.IsChecked = true;
            else
                chkIsActived.IsChecked = false;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            UserClient = new UserSVCClient();

            int IsActived = 0;
            if ((bool)chkIsActived.IsChecked)
                IsActived = 1;

            //Common com = new Common();
            if (UserID == -1)
            {
                UserClient.User_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(UserClient_User_AddCompleted);
                //UserClient.User_AddAsync(txUserName.Text, com.Encrypt(txtPassWord.Text), txtFullName.Text, txtDisplayName.Text, IsActived, 0, DateTime.Now.ToString("MM/dd/yyyy"));
            }
            else
            {
                UserClient.User_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(UserClient_User_EditCompleted);
                //UserClient.User_EditAsync(UserID, txUserName.Text, com.Encrypt(txtPassWord.Text), txtFullName.Text, txtDisplayName.Text, IsActived, 0, DateTime.Now.ToString("MM/dd/yyyy"));
            }
        }

        void UserClient_User_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void UserClient_User_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            UserID = -1;
            this.DialogResult = true;
        }
    }
}


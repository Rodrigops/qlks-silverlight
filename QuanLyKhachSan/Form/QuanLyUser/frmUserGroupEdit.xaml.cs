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
using QuanLyKhachSan.GroupSVC;
using QuanLyKhachSan.UserSVC;
using QuanLyKhachSan.UserGroupSVC;
namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmUserGroupEdit : ChildWindow
    {
        private int UserID = -1;
        private string ListGroupID = "";
        private GroupSVCClient GroupClient = new GroupSVCClient();
        private UserSVCClient UserClient = new UserSVCClient();
        private UserGroupSVCClient UserGroupClient = new UserGroupSVCClient();
        public frmUserGroupEdit()
        {
            InitializeComponent();
        }

        public void UserGroup_Load(int _UserID)
        {
            UserID = _UserID;
            GroupClient = new GroupSVCClient();
            GroupClient.Group_GetActivedItemsCompleted += new EventHandler<Group_GetActivedItemsCompletedEventArgs>(GroupClient_Group_GetActivedItemsCompleted);
            GroupClient.Group_GetActivedItemsAsync();

            UserClient = new UserSVCClient();
            UserClient.User_GetActivedItemsCompleted += new EventHandler<User_GetActivedItemsCompletedEventArgs>(UserClient_User_GetActivedItemsCompleted);
            UserClient.User_GetActivedItemsAsync();

            cbxUser.SelectedIndex = 0;
            if (UserID != -1)
            {
                UserGroupClient = new UserGroupSVCClient();
                UserGroupClient.UserGroup_GetItemCompleted += new EventHandler<UserGroup_GetItemCompletedEventArgs>(UserGroupClient_UserGroup_GetItemCompleted);
                UserGroupClient.UserGroup_GetItemAsync(UserID);
            }
        }

        void UserGroupClient_UserGroup_GetItemCompleted(object sender, UserGroup_GetItemCompletedEventArgs e)
        {
            throw new NotImplementedException();
        }

        void UserClient_User_GetActivedItemsCompleted(object sender, User_GetActivedItemsCompletedEventArgs e)
        {
            cbxUser.ItemsSource = e.Result;
        }
        void GroupClient_Group_GetActivedItemsCompleted(object sender, Group_GetActivedItemsCompletedEventArgs e)
        {
            grvGroup.ItemsSource = e.Result;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


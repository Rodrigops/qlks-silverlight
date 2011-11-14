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
using QuanLyKhachSan.GroupSVC;
using QuanLyKhachSan.UserSVC;
using QuanLyKhachSan.UserGroupSVC;
namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmQuanLyUser : Page
    {
        private GroupSVCClient GroupClient = new GroupSVCClient();
        private UserSVCClient UserClient = new UserSVCClient();
        private UserGroupSVCClient UserGroupClient = new UserGroupSVCClient();
        public frmQuanLyUser()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
            GroupClient.Group_GetItemsCompleted += new EventHandler<Group_GetItemsCompletedEventArgs>(GroupClient_Group_GetItemsCompleted);
            GroupClient.Group_GetItemsAsync();

            UserClient.User_GetItemsCompleted += new EventHandler<User_GetItemsCompletedEventArgs>(UserClient_User_GetItemsCompleted);
            UserClient.User_GetItemsAsync(0);

            UserGroupClient.UserGroup_GetItemsCompleted += new EventHandler<UserGroup_GetItemsCompletedEventArgs>(UserGroupClient_UserGroup_GetItemsCompleted);
            UserGroupClient.UserGroup_GetItemsAsync();
        }

        #region Group
        void GroupClient_Group_GetItemsCompleted(object sender, Group_GetItemsCompletedEventArgs e)
        {
            grvGroup.ItemsSource = e.Result;
        }
        void GroupClient_Group_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            GroupClient.Group_GetItemsAsync(0);
        }
        void GroupEdit_Closed(object sender, EventArgs e)
        {
            frmGroupEdit GroupEdit = sender as frmGroupEdit;
            if (GroupEdit.DialogResult == true)
            {
                GroupClient.Group_GetItemsAsync();
            }
        }
        private void cmdThemGroup_Click(object sender, RoutedEventArgs e)
        {
            frmGroupEdit GroupEdit = new frmGroupEdit();
            GroupEdit.Closed += new EventHandler(GroupEdit_Closed);
            GroupEdit.Group_Load(0);
            GroupEdit.Show();
        }
        private void cmdSuaGroup_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaGroup = sender as HyperlinkButton;
            int GroupID = int.Parse(cmdSuaGroup.CommandParameter.ToString());
            frmGroupEdit GroupEdit = new frmGroupEdit();
            GroupEdit.Closed += new EventHandler(GroupEdit_Closed);
            GroupEdit.Group_Load(GroupID);
            GroupEdit.Show();
        }
        private void cmdXoaGroup_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaGroup = sender as HyperlinkButton;
            int GroupID = int.Parse(cmdXoaGroup.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                GroupClient.Group_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(GroupClient_Group_DeleteCompleted);
                GroupClient.Group_DeleteAsync(GroupID);
            }
        }
        #endregion

        #region User
        void UserClient_User_GetItemsCompleted(object sender, User_GetItemsCompletedEventArgs e)
        {
            grvUser.ItemsSource = e.Result;
        }
        void UserClient_User_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            UserClient.User_GetItemsAsync(0);
        }
        void UserEdit_Closed(object sender, EventArgs e)
        {
            frmUserEdit UserEdit = sender as frmUserEdit;
            if (UserEdit.DialogResult == true)
            {
                UserClient.User_GetItemsAsync(0);
            }
        }
        private void cmdThemUser_Click(object sender, RoutedEventArgs e)
        {
            frmUserEdit UserEdit = new frmUserEdit();
            UserEdit.Closed += new EventHandler(UserEdit_Closed);
            UserEdit.User_Load(0);
            UserEdit.Show();
        }
        private void cmdSuaUser_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaUser = sender as HyperlinkButton;
            int UserID = int.Parse(cmdSuaUser.CommandParameter.ToString());
            frmUserEdit UserEdit = new frmUserEdit();
            UserEdit.Closed += new EventHandler(UserEdit_Closed);
            UserEdit.User_Load(UserID);
            UserEdit.Show();
        }
        private void cmdXoaUser_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaUser = sender as HyperlinkButton;
            int UserID = int.Parse(cmdXoaUser.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                UserClient.User_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(UserClient_User_DeleteCompleted);
                UserClient.User_DeleteAsync(UserID);
            }
        }
        #endregion

        #region UserGroup
        void UserGroupClient_UserGroup_GetItemsCompleted(object sender, UserGroup_GetItemsCompletedEventArgs e)
        {
            grvUserGroup.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }
        void UserGroupClient_UserGroup_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            UserGroupClient.UserGroup_GetItemsAsync(0);
        }
        void UserGroupEdit_Closed(object sender, EventArgs e)
        {
            frmUserGroupEdit UserGroupEdit = sender as frmUserGroupEdit;
            if (UserGroupEdit.DialogResult == true)
            {
                UserGroupClient.UserGroup_GetItemsAsync(0);
            }
        }
        private void cmdThemUserGroup_Click(object sender, RoutedEventArgs e)
        {
            frmUserGroupEdit UserGroupEdit = new frmUserGroupEdit();
            UserGroupEdit.Closed += new EventHandler(UserGroupEdit_Closed);
            UserGroupEdit.UserGroup_Load(0);
            UserGroupEdit.Show();
        }
        private void cmdSuaUserGroup_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaUserGroup = sender as HyperlinkButton;
            int UserID = int.Parse(cmdSuaUserGroup.CommandParameter.ToString());
            frmUserGroupEdit UserGroupEdit = new frmUserGroupEdit();
            UserGroupEdit.Closed += new EventHandler(UserGroupEdit_Closed);
            UserGroupEdit.UserGroup_Load(UserID);
            UserGroupEdit.Show();
        }
        private void cmdXoaUserGroup_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaUserGroup = sender as HyperlinkButton;
            int UserGroupID = int.Parse(cmdXoaUserGroup.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                UserGroupClient.UserGroup_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(UserGroupClient_UserGroup_DeleteCompleted);
                UserGroupClient.UserGroup_DeleteAsync(UserGroupID);
            }
        }
        #endregion
    }
}

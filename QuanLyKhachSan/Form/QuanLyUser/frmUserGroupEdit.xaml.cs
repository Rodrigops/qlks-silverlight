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
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;
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
            
            GroupClient = new GroupSVCClient();
            GroupClient.Group_GetActivedItemsCompleted += new EventHandler<Group_GetActivedItemsCompletedEventArgs>(GroupClient_Group_GetActivedItemsCompleted);
            GroupClient.Group_GetActivedItemsAsync();

            UserClient = new UserSVCClient();
            UserClient.User_GetActivedItemsCompleted += new EventHandler<User_GetActivedItemsCompletedEventArgs>(UserClient_User_GetActivedItemsCompleted);
            UserClient.User_GetActivedItemsAsync();

            if (_UserID > 0)
            {
                UserID = _UserID;
                cbxUser.SelectedValue = UserID;
                UserGroupClient = new UserGroupSVCClient();
                UserGroupClient.UserGroup_GetItemCompleted += new EventHandler<UserGroup_GetItemCompletedEventArgs>(UserGroupClient_UserGroup_GetItemCompleted);
                UserGroupClient.UserGroup_GetItemAsync(UserID);
            }
            else
                cbxUser.SelectedIndex = 0;
        }
        void GroupClient_Group_GetActivedItemsCompleted(object sender, Group_GetActivedItemsCompletedEventArgs e)
        {
            grvGroup.ItemsSource = e.Result;
        }
        void UserClient_User_GetActivedItemsCompleted(object sender, User_GetActivedItemsCompletedEventArgs e)
        {
            cbxUser.ItemsSource = e.Result;
        }
        void UserGroupClient_UserGroup_GetItemCompleted(object sender, UserGroup_GetItemCompletedEventArgs e)
        {
            List<UserGroupInfo> UGList = new List<UserGroupInfo>();
            UGList = e.Result;

            var cells = grvGroup.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "GroupName").ToList();
            for (int i = 0; i < cells.Count; i++)
            {
                CheckBox cbx = cells[i].ChildrenOfType<CheckBox>().First();
                int gid = int.Parse(cbx.CommandParameter.ToString());

                foreach (UserGroupInfo UG in UGList)
                {
                    if (gid == UG.GroupID)
                    {
                        cbx.IsChecked = true;
                    }
                }
            }
            
            if (!string.IsNullOrEmpty(UGList[0].ExpiryDate))
                rdpExpiryDate.SelectedDate = DateTime.Parse(UGList[0].ExpiryDate);
            if (!string.IsNullOrEmpty(UGList[0].EffectiveDate))
                rdpEffectiveDate.SelectedDate = DateTime.Parse(UGList[0].EffectiveDate);
            if (UGList[0].IsTrialUsed == 1)
                chkIsTrialUsed.IsChecked = true;
            else
                chkIsTrialUsed.IsChecked = false;
        }

        

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            var cells = grvGroup.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "GroupName").ToList();
            for (int i = 0; i < cells.Count; i++)
            {
                CheckBox cbx = cells[i].ChildrenOfType<CheckBox>().First();
                if (cbx.IsChecked == true)
                {
                    ListGroupID += int.Parse(cbx.CommandParameter.ToString()) + ";";
                }
            }
            int IsTrialUsed = 0;

            string expirydate = string.Empty;
            string effectivedate = string.Empty;

            if (!string.IsNullOrEmpty(rdpExpiryDate.SelectedDate.ToString()))
                expirydate = rdpExpiryDate.SelectedDate.Value.ToString("MM/dd/yyyy");
            if (!string.IsNullOrEmpty(rdpEffectiveDate.SelectedDate.ToString()))
                effectivedate = rdpEffectiveDate.SelectedDate.Value.ToString("MM/dd/yyyy");

            if ((bool)chkIsTrialUsed.IsChecked)
                IsTrialUsed = 1;

            UserGroupClient = new UserGroupSVCClient();
            UserGroupClient.UserGroup_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(UserGroupClient_UserGroup_AddCompleted);
            UserGroupClient.UserGroup_AddAsync((int)cbxUser.SelectedValue, ListGroupID, expirydate, effectivedate, IsTrialUsed);
        }

        void UserGroupClient_UserGroup_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            UserID = -1;
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            UserID = -1;
            this.DialogResult = false;
        }
    }
}


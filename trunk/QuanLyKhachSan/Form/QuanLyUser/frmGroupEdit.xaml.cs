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
namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmGroupEdit : ChildWindow
    {
        public int GroupID = -1;
        private GroupSVCClient GroupClient = null;
        public frmGroupEdit()
        {
            InitializeComponent();
        }

        public void Group_Load(int _GroupID)
        {
            if (_GroupID > 0)
            {
                GroupID = _GroupID;
                GroupClient = new GroupSVCClient();
                GroupClient.Group_GetItemCompleted += new EventHandler<Group_GetItemCompletedEventArgs>(GroupClient_Group_GetItemCompleted);
                GroupClient.Group_GetItemAsync(GroupID);
            }
        }

        void GroupClient_Group_GetItemCompleted(object sender, Group_GetItemCompletedEventArgs e)
        {
            GroupInfo Group = e.Result;
            txtGroupName.Text = Group.GroupName;
            txtDescriptions.Text = Group.Descriptions;
            if (Group.IsActived == 1)
                chkIsActived.IsChecked= true;
            else
                chkIsActived.IsChecked = false;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtGroupName.Text.Trim()))
            {
                GroupClient = new GroupSVCClient();

                int IsActived = 0;
                if ((bool)chkIsActived.IsChecked)
                    IsActived = 1;

                if (GroupID == -1)
                {
                    GroupClient.Group_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(GroupClient_Group_AddCompleted);
                    GroupClient.Group_AddAsync(txtGroupName.Text.Trim(), txtDescriptions.Text, IsActived, 0, DateTime.Now.ToString("MM/dd/yyyy"));
                }
                else
                {
                    GroupClient.Group_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(GroupClient_Group_EditCompleted);
                    GroupClient.Group_EditAsync(GroupID, txtGroupName.Text.Trim(), txtDescriptions.Text, IsActived, 0, DateTime.Now.ToString("MM/dd/yyyy"));
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại các trường bắt buộc nhập", "Thông báo", MessageBoxButton.OK);
            }
        }

        void GroupClient_Group_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            GroupID = -1;
            this.DialogResult = true;
        }

        void GroupClient_Group_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


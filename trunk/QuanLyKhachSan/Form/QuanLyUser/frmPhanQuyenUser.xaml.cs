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
using QuanLyKhachSan.ModuleSVC;
using Telerik.Windows.Data;
using QuanLyKhachSan.GroupSVC;
using Telerik.Windows.Controls.GridView;
using QuanLyKhachSan.AuthenticationSVC;
using QuanLyKhachSan.UserGroupSVC;
namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmPhanQuyenUser : Page
    {
        ModuleSVCClient module = new ModuleSVCClient();
        GroupSVCClient group = new GroupSVCClient();

        public frmPhanQuyenUser()
        {
            InitializeComponent();
            BusyLoading.IsBusy = true;
            group.Group_GetActivedItemsCompleted += new EventHandler<Group_GetActivedItemsCompletedEventArgs>(group_Group_GetActivedItemsCompleted);
            group.Group_GetActivedItemsAsync();
        }

        void group_Group_GetActivedItemsCompleted(object sender, Group_GetActivedItemsCompletedEventArgs e)
        {
            cbxNhomNguoiDung.ItemsSource = e.Result;
            int GroupID = int.Parse(cbxNhomNguoiDung.SelectedValue.ToString());
            module.Module_GetItemsCompleted += new EventHandler<Module_GetItemsCompletedEventArgs>(module_Module_GetItemsCompleted);
            module.Module_GetItemsAsync(GroupID);
        }

        void grvModules_DataLoaded(object sender, EventArgs e)
        {
            if (this.grvModules.Items.Groups.Count > 0)
            {
                foreach (IGroup groupItem in grvModules.Items.Groups)
                {
                    List<ModuleInfo> listItems = groupItem.Items.Cast<ModuleInfo>().ToList<ModuleInfo>();
                    bool isCollapseGroup = true;
                    foreach (ModuleInfo item in listItems)
                    {
                        if (item.ModuleName != "")
                        {
                            isCollapseGroup = false;
                        }
                    }
                    if (isCollapseGroup)
                    {
                        this.grvModules.CollapseGroup(groupItem);
                    }
                    else
                    {
                        this.grvModules.ExpandGroup(groupItem);
                    }
                }
            }
            this.grvModules.DataLoaded -= new EventHandler<EventArgs>(grvModules_DataLoaded); 
        }

        void module_Module_GetItemsCompleted(object sender, Module_GetItemsCompletedEventArgs e)
        {
            grvModules.DataLoaded += new EventHandler<EventArgs>(grvModules_DataLoaded);
            grvModules.ItemsSource = e.Result;
            BusyLoading.IsBusy = false;
        }
        
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        protected void PhanQuyen_Load()
        {
            
        }

        private void cmdLuu_Click(object sender, RoutedEventArgs e)
        {
            BusyLoading.IsBusy = true;
            int GroupID = int.Parse(cbxNhomNguoiDung.SelectedValue.ToString());
            string ListModulePermission = "";
            List<CheckBox> lCheckBox = GetCheckBoxControls(grvModules).OfType<CheckBox>().ToList<CheckBox>();;
            ModuleInfo info =null;
            int IsView=0;
            int IsEdit=0;
            for (int i = 0; i < lCheckBox.Count; i++)
            {
                    if (lCheckBox[i].CommandParameter.ToString() != "")
                    { 
                        info = lCheckBox[i].Tag as ModuleInfo;
                        if (lCheckBox[i].Name.Contains("View"))
                        {
                            if (lCheckBox[i].IsChecked == true)
                            {
                                IsView = 1;
                            }
                            else
                            {
                                IsView = 0;
                            }
                        }
                        if (lCheckBox[i+1].Name.Contains("Edit"))
                        {
                            if (lCheckBox[i+1].IsChecked == true)
                            {
                                IsEdit = 1;
                            }
                            else
                            {
                                IsEdit = 0;
                            }
                        }
                        ListModulePermission += info.ModuleKey + "_" + IsView.ToString() + "_" + IsEdit.ToString() +";";
                    }
                i++;
            }
            module.ModulePermission_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(module_ModulePermission_AddCompleted);
            module.ModulePermission_AddAsync(GroupID, ListModulePermission);
        }
        private MainPage mainParent = null;
        private AuthenticationSVCSoapClient Authentication = new AuthenticationSVCSoapClient();
        private ModuleSVCClient Permission = new ModuleSVCClient();
        void module_ModulePermission_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {          
            BusyLoading.IsBusy = false;
            Authentication.Authentication_GetSessionCompleted += new EventHandler<Authentication_GetSessionCompletedEventArgs>(Authentication_Authentication_GetSessionCompleted);
            Authentication.Authentication_GetSessionAsync();

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
        void Authentication_Authentication_GetSessionCompleted(object sender, Authentication_GetSessionCompletedEventArgs e)
        {
            UserGroupSVCClient UserGroup = new UserGroupSVCClient();
            UserGroup.GroupIDByUserNameCompleted += new EventHandler<GroupIDByUserNameCompletedEventArgs>(UserGroup_GroupIDByUserNameCompleted);
            UserGroup.GroupIDByUserNameAsync(e.Result);            
        }

        void UserGroup_GroupIDByUserNameCompleted(object sender, GroupIDByUserNameCompletedEventArgs e)
        {
            Permission.Module_GetItemsCompleted += new EventHandler<Module_GetItemsCompletedEventArgs>(Permission_Module_GetItemsCompleted);
            Permission.Module_GetItemsAsync(int.Parse(e.Result.ToString()));
        }

        void Permission_Module_GetItemsCompleted(object sender, Module_GetItemsCompletedEventArgs e)
        {
            List<ModuleInfo> _moduleInfo = e.Result;
            mainParent = FindParentOfType<MainPage>(this);
            foreach (ModuleInfo item in _moduleInfo)
            {
                bool Permission = item.IsView == 1 ? true : false;
                SetPermission(item.ModuleKey, Permission);
            }
        }
        public void SetPermission(string ModuleKey, bool Permission)
        {
            switch (ModuleKey)
            {
                case "frmTinhTrangPhong":
                    mainParent.cmdTinhTrangPhong.IsEnabled = Permission;
                    break;
                case "frmKhachHang":
                    //mainParent.cmdKhachHang.IsEnabled = Permission;
                    break;
                case "frmDatPhong":
                    //mainParent.cmdDatPhong.IsEnabled = Permission;
                    break;
                case "frmNhanPhong":
                    //mainParent.cmdNhanPhong.IsEnabled = Permission;
                    break;
                case "frmDichVuPhong":
                    //mainParent.cmdDichVuPhong.IsEnabled = Permission;
                    break;
                case "frmThongTinPhong":
                    mainParent.cmdThongTinPhong.IsEnabled = Permission;
                    break;
                case "frmGiaPhong":
                    mainParent.cmdGiaPhong.IsEnabled = Permission;
                    break;
                case "frmCaiDatGia":
                    mainParent.cmdCaiDatGia.IsEnabled = Permission;
                    break;
                case "frmThongKeDoanhThu":
                    mainParent.cmdThongKeDoanhThu.IsEnabled = Permission;
                    break;
                case "frmThongKeChiTieu":
                    mainParent.cmdThongKeChiTieu.IsEnabled = Permission;
                    break;
                case "frmThongKeDoanhThuDichVu":
                    mainParent.cmdThongKeDoanhThuDichVu.IsEnabled = Permission;
                    break;
                case "frmQuanLyUser":
                    mainParent.cmdQuanLyUser.IsEnabled = Permission;
                    break;
                case "frmPhanQuyen":
                    mainParent.cmdPhanQuyenUser.IsEnabled = Permission;
                    break;
            }
        }
        IEnumerable<DependencyObject> GetCheckBoxControls(DependencyObject root)
        {
            List<DependencyObject> doList = new List<DependencyObject>();
            doList.Add(root);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(root); i++)
                doList.AddRange(GetCheckBoxControls(VisualTreeHelper.GetChild(root, i)));

            return doList;
        }

        private void cbxNhomNguoiDung_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            BusyLoading.IsBusy = true;
            int GroupID = int.Parse(cbxNhomNguoiDung.SelectedValue.ToString());
            module.Module_GetItemsCompleted += new EventHandler<Module_GetItemsCompletedEventArgs>(module_Module_GetItemsCompleted);
            module.Module_GetItemsAsync(GroupID);
        }
    }
}

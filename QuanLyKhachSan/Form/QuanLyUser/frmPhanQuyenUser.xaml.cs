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
namespace QuanLyKhachSan.Form.QuanLyUser
{
    public partial class frmPhanQuyenUser : Page
    {
        ModuleSVCClient module = new ModuleSVCClient();
        public frmPhanQuyenUser()
        {
            InitializeComponent();
            module.Module_GetItemsCompleted += new EventHandler<Module_GetItemsCompletedEventArgs>(module_Module_GetItemsCompleted);
            module.Module_GetItemsAsync();
            grvModules.DataLoaded += new EventHandler<EventArgs>(grvModules_DataLoaded);
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
            grvModules.ItemsSource = e.Result;
            //
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

        }
        protected void PhanQuyen_Load()
        {
            
        }

    }
}

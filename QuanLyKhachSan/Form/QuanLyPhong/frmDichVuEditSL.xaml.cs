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
using QuanLyKhachSan.DichVuSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmDichVuEditSL : ChildWindow
    {
        DichVuSVCClient DichVuClient = null;
        public frmDichVuEditSL()
        {
            InitializeComponent();
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_GetItemsCompleted += new EventHandler<DichVu_GetItemsCompletedEventArgs>(DichVuClient_DichVu_GetItemsCompleted);
            DichVuClient.DichVu_GetItemsAsync();
        }

        void DichVuClient_DichVu_GetItemsCompleted(object sender, DichVu_GetItemsCompletedEventArgs e)
        {
            cbxDichVu.ItemsSource = e.Result;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (cbxDichVu.SelectedValue != null)
            {
                DichVuClient = new DichVuSVCClient();
                DichVuClient.DichVu_Edit_SLCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(DichVuClient_DichVu_Edit_SLCompleted);
                int SoLuongTon = 0;
                if (txtSL.Text.Trim().ToString() != "")
                { 
                    SoLuongTon = int.Parse(txtSL.Text.Trim().ToString());
                }
                DichVuClient.DichVu_Edit_SLAsync((int)cbxDichVu.SelectedValue, SoLuongTon);
            }
        }

        void DichVuClient_DichVu_Edit_SLCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            txtSL.Text = string.Empty;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }
    }
}


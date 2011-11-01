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
    public partial class frmDichVuEdit : ChildWindow
    {
        public int DichVuID = -1;
        private DichVuSVCClient DichVuClient = null;
        public frmDichVuEdit()
        {
            InitializeComponent(); 
        }
        public void DichVu_Load(int _DichVuID)
        {
            DichVuID = _DichVuID;
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_GetItemCompleted += new EventHandler<DichVu_GetItemCompletedEventArgs>(DichVuClient_DichVu_GetItemCompleted);
            DichVuClient.DichVu_GetItemAsync(DichVuID);
        }
        void DichVuClient_DichVu_GetItemCompleted(object sender, DichVu_GetItemCompletedEventArgs e)
        {
            DichVuInfo DichVu = e.Result;
            txtDichVu.Text = DichVu.DichVuName;
        }
        void DichVuClient_DichVu_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DichVuID = -1;
            this.DialogResult = true;
        }
        void DichVuClient_DichVu_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtDichVu.Text.Trim()) && !String.IsNullOrEmpty(txtGiaTien.Text.Trim()))
            {
                DichVuClient = new DichVuSVCClient();
                if (DichVuID == -1)
                {
                    DichVuClient.DichVu_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(DichVuClient_DichVu_AddCompleted);
                    DichVuClient.DichVu_AddAsync(txtDichVu.Text, decimal.Parse(txtGiaTien.Text));
                }
                else
                {
                    DichVuClient.DichVu_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(DichVuClient_DichVu_EditCompleted);
                    DichVuClient.DichVu_EditAsync(DichVuID, txtDichVu.Text, decimal.Parse(txtGiaTien.Text));
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại các trường bắt buộc nhập", "Thông báo", MessageBoxButton.OK);
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        private void Number_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (((e.Key > Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Back || e.Key == Key.Tab))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }
    }
}


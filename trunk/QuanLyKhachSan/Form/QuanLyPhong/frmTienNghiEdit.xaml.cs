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
using QuanLyKhachSan.LoaiPhongSVC;
using QuanLyKhachSan.TienNghiSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmTienNghiEdit : ChildWindow
    {
        public int TienNghiID = -1;
        private TienNghiSVCClient TienNghiClient = null;
        public frmTienNghiEdit()
        {
            InitializeComponent(); 
        }

        public void TienNghi_Load(int _TienNghiID)
        {
            TienNghiID = _TienNghiID;
            TienNghiClient = new TienNghiSVCClient();
            TienNghiClient.TienNghi_GetItemCompleted += new EventHandler<TienNghi_GetItemCompletedEventArgs>(TienNghiClient_TienNghi_GetItemCompleted);
            TienNghiClient.TienNghi_GetItemAsync(TienNghiID);
        }

        void TienNghiClient_TienNghi_GetItemCompleted(object sender, TienNghi_GetItemCompletedEventArgs e)
        {
            TienNghiInfo TienNghi = e.Result;
            txtTienNghi.Text = TienNghi.TienNghiName;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            TienNghiClient = new TienNghiSVCClient();
            if (TienNghiID == -1)
            {
                TienNghiClient.TienNghi_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(TienNghiClient_TienNghi_AddCompleted);
                TienNghiClient.TienNghi_AddAsync(txtTienNghi.Text, 0);
            }
            else
            {
                TienNghiClient.TienNghi_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(TienNghiClient_TienNghi_EditCompleted);
                TienNghiClient.TienNghi_EditAsync(TienNghiID, txtTienNghi.Text, 0);
            }
        }

        void TienNghiClient_TienNghi_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            TienNghiID = -1;
            this.DialogResult = true;
        }

        void TienNghiClient_TienNghi_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


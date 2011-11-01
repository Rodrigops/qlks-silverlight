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
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmLoaiPhongEdit : ChildWindow
    {
        public int LoaiPhongID = -1;
        private LoaiPhongSVCClient LoaiPhongClient = null;
        public frmLoaiPhongEdit()
        {
            InitializeComponent(); 
        }

        public void LoaiPhong_Load(int _LoaiPhongID)
        {
            LoaiPhongID = _LoaiPhongID;
            LoaiPhongClient = new LoaiPhongSVCClient();
            LoaiPhongClient.LoaiPhong_GetItemCompleted += new EventHandler<LoaiPhong_GetItemCompletedEventArgs>(LoaiPhongClient_LoaiPhong_GetItemCompleted);
            LoaiPhongClient.LoaiPhong_GetItemAsync(LoaiPhongID);
        }

        void LoaiPhongClient_LoaiPhong_GetItemCompleted(object sender, LoaiPhong_GetItemCompletedEventArgs e)
        {
            LoaiPhongInfo LoaiPhong = e.Result;
            txtLoaiPhong.Text = LoaiPhong.LoaiPhongName;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtLoaiPhong.Text.Trim()))
            {
                LoaiPhongClient = new LoaiPhongSVCClient();
                if (LoaiPhongID == -1)
                {
                    LoaiPhongClient.LoaiPhong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(LoaiPhongClient_LoaiPhong_AddCompleted);
                    LoaiPhongClient.LoaiPhong_AddAsync(txtLoaiPhong.Text);
                }
                else
                {
                    LoaiPhongClient.LoaiPhong_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(LoaiPhongClient_LoaiPhong_EditCompleted);
                    LoaiPhongClient.LoaiPhong_EditAsync(LoaiPhongID, txtLoaiPhong.Text);
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cái trường bắt buộc nhập", "Thông báo", MessageBoxButton.OK);
            }
        }

        void LoaiPhongClient_LoaiPhong_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            LoaiPhongID = -1;
            this.DialogResult = true;
        }

        void LoaiPhongClient_LoaiPhong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


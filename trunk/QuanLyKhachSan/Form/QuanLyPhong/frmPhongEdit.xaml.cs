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
using QuanLyKhachSan.PhongSVC;
using QuanLyKhachSan.LoaiPhongSVC;
using QuanLyKhachSan.TienNghiSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmPhongEdit : ChildWindow
    {
        public int PhongID = -1;
        private PhongSVCClient PhongClient = null;
        private LoaiPhongSVCClient LoaiPhongClient = new LoaiPhongSVCClient();
        private TienNghiSVCClient TienNghiClient = new TienNghiSVCClient();
        public frmPhongEdit()
        {
            InitializeComponent();
        }
        public void Phong_Load(int _PhongID)
        {
            LoaiPhongClient = new LoaiPhongSVCClient();
            LoaiPhongClient.LoaiPhong_GetItemsCompleted += new EventHandler<LoaiPhong_GetItemsCompletedEventArgs>(LoaiPhongClient_LoaiPhong_GetItemsCompleted);
            LoaiPhongClient.LoaiPhong_GetItemsAsync();
            cbxLoaiPhong.SelectedIndex = 0;

            TienNghiClient = new TienNghiSVCClient();
            TienNghiClient.TienNghi_GetItemsCompleted += new EventHandler<TienNghi_GetItemsCompletedEventArgs>(TienNghiClient_TienNghi_GetItemsCompleted);
            TienNghiClient.TienNghi_GetItemsAsync();
            cbxTienNghi.SelectedIndex = 0;
            if (_PhongID != 0)
            {
                PhongID = _PhongID;
                PhongClient = new PhongSVCClient();
                PhongClient.Phong_GetItemCompleted += new EventHandler<Phong_GetItemCompletedEventArgs>(PhongClient_Phong_GetItemCompleted);
                PhongClient.Phong_GetItemAsync(PhongID);
            }
        }

        void TienNghiClient_TienNghi_GetItemsCompleted(object sender, TienNghi_GetItemsCompletedEventArgs e)
        {
            cbxTienNghi.ItemsSource = e.Result;
        }
        void LoaiPhongClient_LoaiPhong_GetItemsCompleted(object sender, LoaiPhong_GetItemsCompletedEventArgs e)
        {
            cbxLoaiPhong.ItemsSource = e.Result;
        }
        void PhongClient_Phong_GetItemCompleted(object sender, Phong_GetItemCompletedEventArgs e)
        {
            PhongInfo Phong = e.Result;
            cbxLoaiPhong.SelectedValue = Phong.LoaiPhongID;
            txtTenPhong.Text = Phong.PhongName;
            cbxTienNghi.SelectedValue = Phong.TienNghiID;
            txtSoGiuong.Text = Phong.SoGiuong.ToString();
            txtSoNguoi.Text = Phong.SoNguoi.ToString();
        }
        void PhongClient_Phong_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            PhongID = -1;
            this.DialogResult = true;
        }
        void PhongClient_Phong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtTenPhong.Text.Trim()))
            {
                PhongClient = new PhongSVCClient();
                if (PhongID == -1)
                {
                    PhongClient.Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_Phong_AddCompleted);
                    PhongClient.Phong_AddAsync(int.Parse(cbxLoaiPhong.SelectedValue.ToString()), txtTenPhong.Text, int.Parse(cbxTienNghi.SelectedValue.ToString()), int.Parse(txtSoGiuong.Text.ToString()), int.Parse(txtSoNguoi.Text.ToString()));
                }
                else
                {
                    PhongClient.Phong_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_Phong_EditCompleted);
                    PhongClient.Phong_EditAsync(PhongID, int.Parse(cbxLoaiPhong.SelectedValue.ToString()), txtTenPhong.Text, int.Parse(cbxTienNghi.SelectedValue.ToString()), int.Parse(txtSoGiuong.Text.ToString()), int.Parse(txtSoNguoi.Text.ToString()));
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cái trường bắt buộc nhập", "Thông báo", MessageBoxButton.OK);
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


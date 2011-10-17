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
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmChiTietPhong : ChildWindow
    {
        private int PhongID;
        private int TinhTrangPhongID;
        public frmChiTietPhong()
        {
            InitializeComponent();
        }
        public void Phong_Load(int _PhongID,int _TinhTrangPhongID)
        {
            try
            {
                PhongID = _PhongID;
                TinhTrangPhongID = _TinhTrangPhongID;
                PhongSVCClient PhongClient = new PhongSVCClient();
                PhongClient.Phong_GetItemCompleted += new EventHandler<Phong_GetItemCompletedEventArgs>(PhongClient_Phong_GetItemCompleted);
                LoadingPanel.IsBusy = true;
                switch (_TinhTrangPhongID)
                { 
                    case 1:
                        rbtCoTheDung.IsChecked =true;
                        break;
                    case 2:
                    rbtCoTheDung.IsChecked =true;
                    break;
                    case 3:
                    rbtCoTheDung.IsChecked =true;
                    break;
                    case  4:
                    rbtCanSua.IsChecked = true;
                    break;
                    case 5:
                    rbtChuaDon.IsChecked = true;
                    break;
                    case 6:
                    rbtRoiPhong.IsChecked = true;
                    break;
                }
                PhongClient.Phong_GetItemAsync(PhongID);
            }
            catch (Exception)
            {                
                throw;
            }
        }

        void PhongClient_Phong_GetItemCompleted(object sender, Phong_GetItemCompletedEventArgs e)
        {
            PhongInfo item = e.Result;
            txtPhong.Text = item.PhongName;
            txtTienNghi.Text = item.TienNghiName;
            txtSoGiuong.Text = item.SoNguoi.ToString();
            txtSoNguoi.Text = item.SoNguoi.ToString();
            LoadingPanel.IsBusy = false;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            PhongSVCClient PhongClient = new PhongSVCClient();
            PhongClient.TinhTrang_Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_TinhTrang_Phong_AddCompleted);
            int _TinhTrangPhongID=0;
            if (rbtCoTheDung.IsChecked==true)
            {
                _TinhTrangPhongID = TinhTrangPhongID;
            }
            else if (rbtCanSua.IsChecked == true)
            {
                _TinhTrangPhongID = 4;
            }
            else if (rbtChuaDon.IsChecked == true)
            {
                _TinhTrangPhongID = 5;
            }
            else if (rbtRoiPhong.IsChecked == true)
            {
                _TinhTrangPhongID = 6;
            }
            PhongClient.TinhTrang_Phong_AddAsync(PhongID, _TinhTrangPhongID, 0);
        }

        void PhongClient_TinhTrang_Phong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


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
using QuanLyKhachSan.HoaDonDichVuSVC;
using QuanLyKhachSan.PhongSVC;
using QuanLyKhachSan.KhachHangSVC;
using QuanLyKhachSan.DichVuSVC;
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmHoaDonDichVuEdit : ChildWindow
    {
        public int HoaDonDichVuID = -1;
        private HoaDonDichVuSVCClient HoaDonDichVuClient = null;
        private PhongSVCClient PhongClient = new PhongSVCClient();
        private KhachHangSVCClient KhachHangClient = new KhachHangSVCClient();
        private DichVuSVCClient DichVuClient = new DichVuSVCClient();
        public frmHoaDonDichVuEdit()
        {
            InitializeComponent();
        }
        public void HoaDonDichVu_Load(int _KhachHangID)
        {
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_GetItemsCompleted += new EventHandler<DichVu_GetItemsCompletedEventArgs>(DichVuClient_DichVu_GetItemsCompleted);
            DichVuClient.DichVu_GetItemsAsync();
            cbxDichVu.SelectedIndex = 0;

            //lay danh sach phong dang su dung

            //lay danh sach khach trong phong
        }

        void DichVuClient_DichVu_GetItemsCompleted(object sender, DichVu_GetItemsCompletedEventArgs e)
        {
            cbxDichVu.ItemsSource = e.Result;
        }
        void HoaDonDichVugClient_HoaDonDichVu_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            HoaDonDichVuID = -1;
            this.DialogResult = true;
        }
        void HoaDonDichVuClient_HoaDonDichVu_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


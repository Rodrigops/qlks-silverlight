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
using Telerik.Windows.Controls;
using QuanLyKhachSan.KhachHangSVC;
using QuanLyKhachSan.QuocTichSVC;

namespace QuanLyKhachSan.Form.QuanLyKhachHang
{
    public partial class frmKhachHangEdit : ChildWindow
    {
        public int KhachHangID = -1;
        private KhachHangSVCClient KhachHangClient = null;
        private QuocTichSVCClient QuocTichClient = new QuocTichSVCClient();
        public frmKhachHangEdit()
        {
            InitializeComponent();
        }
        public void KhachHang_Load(int _KhachHangID)
        {
            QuocTichClient = new QuocTichSVCClient();
            QuocTichClient.QuocTich_GetItemsCompleted += new EventHandler<QuocTich_GetItemsCompletedEventArgs>(QuocTichClient_QuocTich_GetItemsCompleted);
            QuocTichClient.QuocTich_GetItemsAsync();

            cbxQuocTich.SelectedValue = 1;
            if (_KhachHangID != 0)
            {
                KhachHangID = _KhachHangID;
                KhachHangClient = new KhachHangSVCClient();
                KhachHangClient.KhachHang_GetItemCompleted += new EventHandler<KhachHang_GetItemCompletedEventArgs>(KhachHangClient_KhachHang_GetItemCompleted);
                KhachHangClient.KhachHang_GetItemAsync(KhachHangID);
            }
        }
        void QuocTichClient_QuocTich_GetItemsCompleted(object sender, QuocTich_GetItemsCompletedEventArgs e)
        {
            cbxQuocTich.ItemsSource = e.Result;
        }
        void KhachHangClient_KhachHang_GetItemCompleted(object sender, KhachHang_GetItemCompletedEventArgs e)
        {
            KhachHangInfo KhachHang = e.Result;
            txtHoTen.Text = KhachHang.HoTen;
            txtDiaChi.Text = KhachHang.DiaChi;
            txtDienThoai.Text = KhachHang.DienThoai;
            txtCMND.Text = KhachHang.CMND;
            if (!string.IsNullOrEmpty(KhachHang.NgaySinh))
                rdpNgaySinh.SelectedDate = DateTime.Parse(KhachHang.NgaySinh);
            txtNoiSinh.Text = KhachHang.NoiSinh;
            txtSoVisa.Text = KhachHang.SoVisa;
            if (!string.IsNullOrEmpty(KhachHang.ThoiHanVisa))
                rdpThoiHanVisa.SelectedDate = DateTime.Parse(KhachHang.ThoiHanVisa);
            txtNguoiTiepNhan.Text = KhachHang.NguoiTiepNhan;
            if (!string.IsNullOrEmpty(KhachHang.NgayNhapCanh))
                rdpNgayNhapCanh.SelectedDate = DateTime.Parse(KhachHang.NgayNhapCanh);
            if (!string.IsNullOrEmpty(KhachHang.TamTruTuNgay))
                rdpTuNgay.SelectedDate = DateTime.Parse(KhachHang.TamTruTuNgay);
            if (!string.IsNullOrEmpty(KhachHang.TamTruDenNgay))
                rdpDenNgay.SelectedDate = DateTime.Parse(KhachHang.TamTruDenNgay);
            cbxQuocTich.SelectedValue = KhachHang.QuocTichID;
            if (KhachHang.GioiTinh != -1)
                cbxGioiTinh.SelectedIndex = KhachHang.GioiTinh;

            
        }
        void KhachHangClient_KhachHang_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            KhachHangID = -1;
            this.DialogResult = true;
        }
        void KhachHangClient_KhachHang_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtHoTen.Text.Trim()) && !String.IsNullOrEmpty(txtCMND.Text.Trim()))
            {
                string ngaysinh = string.Empty;
                string thoihanvisa = string.Empty;
                string ngaynhapcanh = string.Empty;
                string tungay = string.Empty;
                string denngay = string.Empty;
                int gioitinh = -1;

                if (!String.IsNullOrEmpty(rdpNgaySinh.SelectedDate.ToString()))
                    ngaysinh = rdpNgaySinh.SelectedDate.Value.ToString("MM/dd/yyyy");
                if (!String.IsNullOrEmpty(rdpThoiHanVisa.SelectedDate.ToString()))
                    thoihanvisa = rdpThoiHanVisa.SelectedDate.Value.ToString("MM/dd/yyyy");
                if (!String.IsNullOrEmpty(rdpNgayNhapCanh.SelectedDate.ToString()))
                    ngaynhapcanh = rdpNgayNhapCanh.SelectedDate.Value.ToString("MM/dd/yyyy");
                if (!String.IsNullOrEmpty(rdpTuNgay.SelectedDate.ToString()))
                    tungay = rdpTuNgay.SelectedDate.Value.ToString("MM/dd/yyyy");
                if (!String.IsNullOrEmpty(rdpDenNgay.SelectedDate.ToString()))
                    denngay = rdpDenNgay.SelectedDate.Value.ToString("MM/dd/yyyy");
                //if (cbxGioiTinh.SelectedIndex == -1)
                //    gioitinh = int.Parse(cbxGioiTinh.SelectedIndex.ToString());
                RadComboBoxItem SelectedItem = cbxGioiTinh.SelectedValue as RadComboBoxItem;
                gioitinh = int.Parse(SelectedItem.Tag.ToString());
                KhachHangClient = new KhachHangSVCClient();
                if (KhachHangID == -1)
                {
                    KhachHangClient.KhachHang_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(KhachHangClient_KhachHang_AddCompleted);
                    KhachHangClient.KhachHang_AddAsync(txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtCMND.Text, ngaysinh, txtNoiSinh.Text, txtSoVisa.Text,
                        thoihanvisa, txtNguoiTiepNhan.Text, ngaynhapcanh, tungay, denngay, int.Parse(cbxQuocTich.SelectedValue.ToString()),
                        gioitinh, User.UserID, DateTime.Now.ToString("MM/dd/yyyy"));
                }
                else
                {
                    KhachHangClient.KhachHang_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(KhachHangClient_KhachHang_EditCompleted);
                    KhachHangClient.KhachHang_EditAsync(KhachHangID, txtHoTen.Text, txtDiaChi.Text, txtDienThoai.Text, txtCMND.Text, ngaysinh, txtNoiSinh.Text, txtSoVisa.Text,
                        thoihanvisa, txtNguoiTiepNhan.Text, ngaynhapcanh, tungay, denngay, int.Parse(cbxQuocTich.SelectedValue.ToString()),
                        gioitinh, User.UserID, DateTime.Now.ToString("MM/dd/yyyy"));
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


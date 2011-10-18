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
        //Load DichVu Theo HoaDonID | PhongID
        public void DichVu_Load(int _HoaDonID, int _PhongID)
        { 
            // your code here
        }
        public void HoaDonDichVu_Load(int _HoaDonDichVuID)
        {
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_GetItemsCompleted += new EventHandler<DichVu_GetItemsCompletedEventArgs>(DichVuClient_DichVu_GetItemsCompleted);
            DichVuClient.DichVu_GetItemsAsync();
            cbxDichVu.SelectedIndex = 0;

            //lay danh sach phong dang su dung
            PhongClient = new PhongSVCClient();
            PhongClient.Phong_GetItemsOnServiceCompleted += new EventHandler<Phong_GetItemsOnServiceCompletedEventArgs>(PhongClient_Phong_GetItemsOnServiceCompleted);
            PhongClient.Phong_GetItemsOnServiceAsync();

            if (_HoaDonDichVuID != 0)
            {
                HoaDonDichVuID = _HoaDonDichVuID;
                HoaDonDichVuClient = new HoaDonDichVuSVCClient();
                HoaDonDichVuClient.HoaDonDichVu_GetItemCompleted += new EventHandler<HoaDonDichVu_GetItemCompletedEventArgs>(HoaDonDichVuClient_HoaDonDichVu_GetItemCompleted);
                HoaDonDichVuClient.HoaDonDichVu_GetItemAsync(HoaDonDichVuID);
            }
        }

        void HoaDonDichVuClient_HoaDonDichVu_GetItemCompleted(object sender, HoaDonDichVu_GetItemCompletedEventArgs e)
        {
            HoaDonDichVuInfo HDDV = e.Result;
            cbxDichVu.SelectedValue = HDDV.DichVuID;
            txtSoLuong.Text = HDDV.SoLuong.ToString();
            txtDonGia.Text = Format_NumberVietnamese(HDDV.DonGia.ToString());
            txtTongTien.Text = Format_NumberVietnamese(HDDV.TongTien.ToString());
            if (!string.IsNullOrEmpty(HDDV.NgaySuDung))
                rdpNgaySuDung.SelectedDate = DateTime.Parse(HDDV.NgaySuDung);
            cbxPhong.SelectedValue = HDDV.PhongID;
            cbxKhachHang.SelectedValue = HDDV.KhachHangID;
        }
        void HoaDonDichVuClient_HoaDonDichVu_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            HoaDonDichVuID = -1;
            this.DialogResult = true;
        }
        void HoaDonDichVuClient_HoaDonDichVu_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void cbxPhong_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            if (cbxPhong.SelectedValue != null)
            {
                KhachHangClient = new KhachHangSVCClient();
                KhachHangClient.KhachHang_GetItemsInPhongCompleted += new EventHandler<KhachHang_GetItemsInPhongCompletedEventArgs>(KhachHangClient_KhachHang_GetItemsInPhongCompleted);
                //KhachHangClient.KhachHang_GetItemsInPhongAsync((int)cbxPhong.SelectedValue);
                KhachHangClient.KhachHang_GetItemsInPhongAsync(0);
            }
        }
        private void cbxDichVu_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_GetItemCompleted += new EventHandler<DichVu_GetItemCompletedEventArgs>(DichVuClient_DichVu_GetItemCompleted);
            DichVuClient.DichVu_GetItemAsync((int)cbxDichVu.SelectedValue);
        }
        private void txtSoLuong_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSoLuong.Text.Trim()))
            {
                decimal sl = decimal.Parse(txtSoLuong.Text.Trim()) * decimal.Parse(txtDonGia.Text.Trim());
                txtTongTien.Text = Format_NumberVietnamese(sl.ToString());
            }
            else
            {
                txtTongTien.Text = Format_NumberVietnamese("0");
            }
        }
        void DichVuClient_DichVu_GetItemCompleted(object sender, DichVu_GetItemCompletedEventArgs e)
        {
            DichVuInfo DichVu = e.Result;
            txtDonGia.Text = Format_NumberVietnamese(DichVu.GiaTien.ToString());
            if (!String.IsNullOrEmpty(txtSoLuong.Text.Trim()))
            {
                decimal sl = decimal.Parse(txtSoLuong.Text.Trim()) * DichVu.GiaTien;
                txtTongTien.Text = Format_NumberVietnamese(sl.ToString());
            }
            else
            {
                txtTongTien.Text = Format_NumberVietnamese("0");
            }
        }
        void DichVuClient_DichVu_GetItemsCompleted(object sender, DichVu_GetItemsCompletedEventArgs e)
        {
            cbxDichVu.ItemsSource = e.Result;
        }
        void PhongClient_Phong_GetItemsOnServiceCompleted(object sender, Phong_GetItemsOnServiceCompletedEventArgs e)
        {
            cbxPhong.ItemsSource = e.Result;
        }
        void KhachHangClient_KhachHang_GetItemsInPhongCompleted(object sender, KhachHang_GetItemsInPhongCompletedEventArgs e)
        {
            cbxKhachHang.ItemsSource = e.Result;
        }
        
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string ngaysudung = string.Empty;
            if (!String.IsNullOrEmpty(rdpNgaySuDung.SelectedDate.ToString()))
                ngaysudung = rdpNgaySuDung.SelectedDate.Value.ToString("MM/dd/yyyy");

            if (HoaDonDichVuID == -1)
            {
                HoaDonDichVuClient = new HoaDonDichVuSVCClient();
                HoaDonDichVuClient.HoaDonDichVu_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonDichVuClient_HoaDonDichVu_AddCompleted);
                HoaDonDichVuClient.HoaDonDichVu_AddAsync(1, (int)cbxPhong.SelectedValue, (int)cbxDichVu.SelectedValue, (int)cbxKhachHang.SelectedValue, ngaysudung,
                    int.Parse(txtSoLuong.Text.ToString()), decimal.Parse(txtDonGia.Text.ToString()), decimal.Parse(txtTongTien.Text.ToString()), 0, DateTime.Now.ToString("MM/dd/yyyy"));
            }
            else
            {
                HoaDonDichVuClient = new HoaDonDichVuSVCClient();
                HoaDonDichVuClient.HoaDonDichVu_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonDichVuClient_HoaDonDichVu_EditCompleted);
                HoaDonDichVuClient.HoaDonDichVu_EditAsync(HoaDonDichVuID, 1, (int)cbxPhong.SelectedValue, (int)cbxDichVu.SelectedValue, (int)cbxKhachHang.SelectedValue, ngaysudung,
                    int.Parse(txtSoLuong.Text.ToString()), decimal.Parse(txtDonGia.Text.ToString()), decimal.Parse(txtTongTien.Text.ToString()), 0, DateTime.Now.ToString("MM/dd/yyyy"));
            }
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        public string Format_NumberVietnamese(string Gia)
        {
            try
            {
                if (Gia.IndexOf("%") > 0 || Gia == "")
                {
                    return Gia;
                }
                else
                {
                    decimal value = decimal.Parse(Gia);
                    string retGia = value.ToString("N", System.Globalization.CultureInfo.CurrentCulture);
                    return retGia.Replace(".00", "");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}


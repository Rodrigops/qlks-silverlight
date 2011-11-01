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
using QuanLyKhachSan.ChiTietPhieuNhapKhoSVC;
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmPhieuNhapKho_ChiTiet : ChildWindow
    {
        public int PhieuNhapKhoID = -1;
        public int CTPhieuNhapKhoID = -1;
        private int dichvuid = 0;
        private ChiTietPhieuNhapKhoSVCClient ChiTietClient = null;
        private DichVuSVCClient DichVuClient = new DichVuSVCClient();
        public frmPhieuNhapKho_ChiTiet()
        {
            InitializeComponent();
        }

        public void CTPhieuNhapKhoEdit_Load(int _CTPhieuNhapKhoID, int _PhieuNhapKhoID)
        {
            PhieuNhapKhoID = _PhieuNhapKhoID;
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_GetItemsCompleted += new EventHandler<DichVu_GetItemsCompletedEventArgs>(DichVuClient_DichVu_GetItemsCompleted);
            DichVuClient.DichVu_GetItemsAsync();
            cbxDichVu.SelectedIndex = 0;

            if (_CTPhieuNhapKhoID != 0)
            {
                CTPhieuNhapKhoID = _CTPhieuNhapKhoID;
                ChiTietClient = new ChiTietPhieuNhapKhoSVCClient();
                ChiTietClient.ChiTietPhieuNhapKho_GetItemCompleted += new EventHandler<ChiTietPhieuNhapKho_GetItemCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_GetItemCompleted);
                ChiTietClient.ChiTietPhieuNhapKho_GetItemAsync(CTPhieuNhapKhoID);
            }
        }

        void ChiTietClient_ChiTietPhieuNhapKho_GetItemCompleted(object sender, ChiTietPhieuNhapKho_GetItemCompletedEventArgs e)
        {
            ChiTietPhieuNhapKhoInfo ChiTiet = e.Result;
            dichvuid = ChiTiet.DichVuID;
            cbxDichVu.SelectedValue = ChiTiet.DichVuID;
            txtSoLuong.Text = ChiTiet.SoLuong.ToString();
            txtDonGia.Text = Format_NumberVietnamese(ChiTiet.DonGia.ToString());
            txtTongTien.Text = Format_NumberVietnamese(ChiTiet.TongTien.ToString());
        }
        private void cbxDichVu_SelectionChanged(object sender, Telerik.Windows.Controls.SelectionChangedEventArgs e)
        {
            DichVuClient = new DichVuSVCClient();
            DichVuClient.DichVu_GetItemCompleted += new EventHandler<DichVu_GetItemCompletedEventArgs>(DichVuClient_DichVu_GetItemCompleted);
            DichVuClient.DichVu_GetItemAsync((int)cbxDichVu.SelectedValue);
        }
        private void txtSoLuong_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSoLuong.Text.Trim()) && !String.IsNullOrEmpty(txtDonGia.Text.Trim()))
            {
                decimal tien = decimal.Parse(txtSoLuong.Text.Trim()) * decimal.Parse(txtDonGia.Text.Trim());
                txtTongTien.Text = Format_NumberVietnamese(tien.ToString());
            }
            else
            {
                txtTongTien.Text = Format_NumberVietnamese("0");
            }
        }
        void DichVuClient_DichVu_GetItemCompleted(object sender, DichVu_GetItemCompletedEventArgs e)
        {
            DichVuInfo DichVu = e.Result;
            if (dichvuid != (int)cbxDichVu.SelectedValue)
            {
                txtDonGia.Text = Format_NumberVietnamese(DichVu.GiaTien.ToString());
                if (!String.IsNullOrEmpty(txtSoLuong.Text.Trim()) && !String.IsNullOrEmpty(txtDonGia.Text.Trim()))
                {
                    decimal tien = decimal.Parse(txtSoLuong.Text.Trim()) * DichVu.GiaTien;
                    txtTongTien.Text = Format_NumberVietnamese(tien.ToString());
                }
                else
                {
                    txtTongTien.Text = Format_NumberVietnamese("0");
                }
            }
        }
        void DichVuClient_DichVu_GetItemsCompleted(object sender, DichVu_GetItemsCompletedEventArgs e)
        {
            cbxDichVu.ItemsSource = e.Result;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            if (!String.IsNullOrEmpty(txtSoLuong.Text.Trim()))
            {
                if (CTPhieuNhapKhoID == -1)
                {
                    ChiTietClient = new ChiTietPhieuNhapKhoSVCClient();
                    ChiTietClient.ChiTietPhieuNhapKho_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_AddCompleted);
                    ChiTietClient.ChiTietPhieuNhapKho_AddAsync(PhieuNhapKhoID, int.Parse(txtSoLuong.Text.ToString()), decimal.Parse(txtDonGia.Text.ToString()), 
                        decimal.Parse(txtTongTien.Text.ToString()), (int)cbxDichVu.SelectedValue);
                }
                else
                {
                    ChiTietClient = new ChiTietPhieuNhapKhoSVCClient();
                    ChiTietClient.ChiTietPhieuNhapKho_EditCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(ChiTietClient_ChiTietPhieuNhapKho_EditCompleted);
                    ChiTietClient.ChiTietPhieuNhapKho_EditAsync(CTPhieuNhapKhoID, PhieuNhapKhoID, int.Parse(txtSoLuong.Text.ToString()), decimal.Parse(txtDonGia.Text.ToString()),
                        decimal.Parse(txtTongTien.Text.ToString()), (int)cbxDichVu.SelectedValue);
                }
            }
            else
            {
                MessageBox.Show("Kiểm tra lại cái trường bắt buộc nhập", "Thông báo", MessageBoxButton.OK);
            }
        }
        void ChiTietClient_ChiTietPhieuNhapKho_EditCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        void ChiTietClient_ChiTietPhieuNhapKho_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
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


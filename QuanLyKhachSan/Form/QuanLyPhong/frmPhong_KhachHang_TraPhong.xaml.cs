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
using QuanLyKhachSan.Form.HoaDonDichVu;
using QuanLyKhachSan.HoaDonSVC;
using QuanLyKhachSan.Form.QuanLyKhachHang;
using QuanLyKhachSan.HoaDonDichVuSVC;
using QuanLyKhachSan.Gio_PhongSVC;
using QuanLyKhachSan.Ngay_PhongSVC;
using QuanLyKhachSan.HoaDon_TraTruocSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmPhong_KhachHang_TraPhong : ChildWindow
    {
        public int HoaDonID;
        public int PhongID;
        private string TenKhachHang = "";
        private List<HoaDonDichVuInfo> lstDichVu = null; 
        private HoaDonSVCClient HoaDon = new HoaDonSVCClient();
        private HoaDonDichVuSVCClient HoaDon_DichVu = new HoaDonDichVuSVCClient();
        public frmPhong_KhachHang_TraPhong()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        public void LoadData(int _HoaDonID, int _PhongID)
        {
            HoaDonID = _HoaDonID;
            PhongID = _PhongID;
            LoadingPanel.IsBusy = true;
            Gio_PhongSVCClient Gio_PhongClient = new Gio_PhongSVCClient();
            Gio_PhongClient.Gio_Phong_GetItemByPhongIDCompleted += new EventHandler<Gio_Phong_GetItemByPhongIDCompletedEventArgs>(Gio_PhongClient_Gio_Phong_GetItemByPhongIDCompleted);
            Gio_PhongClient.Gio_Phong_GetItemByPhongIDAsync(PhongID);
                
        }
        private List<Gio_PhongInfo> listGio_Phong = null;
        void Gio_PhongClient_Gio_Phong_GetItemByPhongIDCompleted(object sender, Gio_Phong_GetItemByPhongIDCompletedEventArgs e)
        {
            listGio_Phong = e.Result;
            Ngay_PhongSVCClient Ngay_PhongClient = new Ngay_PhongSVCClient();
            Ngay_PhongClient.Ngay_Phong_GetItemByPhongIDCompleted+=new EventHandler<Ngay_Phong_GetItemByPhongIDCompletedEventArgs>(Ngay_PhongClient_Ngay_Phong_GetItemByPhongIDCompleted);
            Ngay_PhongClient.Ngay_Phong_GetItemByPhongIDAsync(PhongID);
        }
        private Ngay_PhongInfo itemNgay_Phong = null;
        void Ngay_PhongClient_Ngay_Phong_GetItemByPhongIDCompleted(object sender, Ngay_Phong_GetItemByPhongIDCompletedEventArgs e)
        {
            itemNgay_Phong = e.Result;
            HoaDon_Load(HoaDonID, PhongID);
        }

        public void HoaDon_Load(int _HoaDonID,int _PhongID)
        {
            HoaDonID = _HoaDonID;
            PhongID = _PhongID;
            HoaDon.HoaDon_GetItemCompleted += new EventHandler<HoaDon_GetItemCompletedEventArgs>(HoaDon_HoaDon_GetItemCompleted);
            
            HoaDon_DichVu.HoaDonDichVu_GetItemsByIDCompleted += new EventHandler<HoaDonDichVu_GetItemsByIDCompletedEventArgs>(HoaDon_DichVu_HoaDonDichVu_GetItemsByIDCompleted);
            HoaDon_DichVu.HoaDonDichVu_GetItemsByIDAsync(HoaDonID, PhongID);

            HoaDon_TraTruocSVCClient HoaDon_TraTruocClient = new HoaDon_TraTruocSVCClient();
            HoaDon_TraTruocClient.HoaDon_TraTruoc_GetItemsCompleted += new EventHandler<HoaDon_TraTruoc_GetItemsCompletedEventArgs>(HoaDon_TraTruocClient_HoaDon_TraTruoc_GetItemsCompleted);
            HoaDon_TraTruocClient.HoaDon_TraTruoc_GetItemsAsync(HoaDonID);
        }
        private decimal TongTraTruoc = 0;
        void HoaDon_TraTruocClient_HoaDon_TraTruoc_GetItemsCompleted(object sender, HoaDon_TraTruoc_GetItemsCompletedEventArgs e)
        {            
            List<HoaDon_TraTruocInfo> listTraTruoc = e.Result;
            foreach (HoaDon_TraTruocInfo item in listTraTruoc)
            {
                TongTraTruoc += item.TraTruoc;
            }
            //txtTraTruoc.Text = Format_NumberVietnamese(TongTraTruoc.ToString());
            
        }
        private decimal DichVu = 0;
        void HoaDon_DichVu_HoaDonDichVu_GetItemsByIDCompleted(object sender, HoaDonDichVu_GetItemsByIDCompletedEventArgs e)
        {
            lstDichVu = e.Result;
            TextBlock txtContent = null;
            foreach (HoaDonDichVuInfo item in lstDichVu)
            {
                txtContent = new TextBlock();
                txtContent.Text = Format_NumberVietnamese(item.TongTien.ToString()) + " [Ngày : " + item.NgaySuDung + " " +  item.SoLuong + "x" + item.DichVuName  +"]";
                DichVu += item.TongTien;
                SPDichVu.Children.Add(txtContent);
            }
            HoaDon.HoaDon_GetItemAsync(HoaDonID);
        }
        decimal TienTraTruoc = 0;
        decimal KhoanKhac = 0;
        void HoaDon_HoaDon_GetItemCompleted(object sender, HoaDon_GetItemCompletedEventArgs e)
        {
            try
            {
                HoaDonInfo item = e.Result;
                txtNgayVao.Text = DateToNumberConverter.Date2Vietnamese(item.NgayVao);
                txtGioVao.Text = item.GioVao.ToString();
                txtPhutVao.Text = item.PhutVao.ToString();
                txtNgayRa.Text =DateToNumberConverter.Date2Vietnamese(item.NgayRa);
                txtGioRa.Text = item.GioRa.ToString();
                txtPhutRa.Text = item.PhutRa.ToString();
                TienTraTruoc = item.KhuyenMai;
                txtKhuyenMai.Text = Format_NumberVietnamese(item.KhuyenMai.ToString());
                txtKhoanKhac.Text = item.KhoanKhac.ToString();
                txtGhiChu.Text = item.GhiChu;
                TenKhachHang = item.TenKhachHang;
                int GioVao_So = int.Parse(item.GioVao.ToString() + item.PhutVao.ToString());
                int GioRa_So = int.Parse(item.GioRa.ToString() + item.PhutRa.ToString());
                int LoaiThue = item.LoaiThue;
                int Ca = item.Ca;
                switch (LoaiThue)
                { 
                    case 0:
                        TinhTienTheoGio(item.GioVao, item.PhutVao, item.GioRa, item.PhutRa,Ca);
                        break;
                    case 1:
                        TinhTienTheoNgay(item.NgayVao_So, item.NgayRa_So);
                        break;
                    case 2:
                        TinhTienQuaDem(item.NgayVao_So, item.NgayRa_So, item.GioRa, item.PhutRa);
                        break;
                    case 3:
                        TinhTienTheoThang(item.NgayVao_So, item.NgayRa_So);
                        break;
                }
                //Hien Thong Tin Hoa Don
                if (txtKhoanKhac.Text == "")
                {
                    KhoanKhac = 0;
                }
                else
                {
                    KhoanKhac = decimal.Parse(txtKhoanKhac.Text.ToString());
                }
                txtTongThanhToan.Text = Format_NumberVietnamese((DichVu + TongTienPhong + KhoanKhac - TienTraTruoc).ToString());
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
        private void generateGiaPhong(int NgayVao_So, int NgayRa_So,int GioVao,int PhutVao,int GioRa,int PhutRa,int GioVaoTinh,int GioRaTinh)
        {
            int GioMoc = 1200; //12 gio trua
            int GioMocTinh = 12;
            int PhutDuDau = 0;
            int PhutDuCuoi = 0;
            int GioDuDau = 0;
            int GioDuCuoi=0;
            int k;
            int SoNgay=0;
            if (NgayRa_So > NgayVao_So)
            {
                if (GioVao <= GioMoc)
                {
                    //GioDuDau = GioMoc - GioVao;
                    GioDuDau = GioMocTinh - GioVaoTinh;
                    if (GioRa <= GioMoc)
                    {
                        k = 1;
                        //GioDuCuoi = GioMoc + GioRa;
                        GioDuCuoi = GioMocTinh + GioRaTinh;
                    }
                    else
                    {
                        k = 0;
                        //GioDuCuoi = GioRa - GioMoc;
                        GioDuCuoi = GioRaTinh - GioMocTinh;
                    }
                    SoNgay = NgayRa_So - NgayVao_So - k;
                }
                else
                {//
                    if (GioRa <= GioMoc)
                    {
                        k = 1;
                        //GioDuDau = (23 - GioVao) + GioRa;
                        GioDuDau = (23 - GioVaoTinh)+ GioMocTinh;// +GioRaTinh;
                        GioDuCuoi = GioMocTinh-GioRaTinh;
                    }
                    else
                    {//
                        k = 0;
                        //GioDuDau = (24 - GioVao) + GioMoc;
                        GioDuDau = (24 - GioVaoTinh) + GioMocTinh;
                        GioDuCuoi = GioRaTinh- GioMocTinh;
                    }
                    SoNgay = NgayRa_So - (NgayVao_So + 1) - k;
                }
            }
            //tinh phut
            if (PhutVao != 0)
            {
                if (PhutVao > 30)
                {
                    GioDuDau = GioDuDau - 1;
                    PhutDuDau = 60 - PhutVao;
                }
                else
                {
                    PhutDuDau = 60 - PhutVao;
                }
            }
            if (PhutRa != 0)
            {
                if (PhutRa > 30)
                {
                    if (GioRa <= GioMoc)
                    {
                        GioDuCuoi = GioDuCuoi - 1;
                        PhutDuCuoi = 60 - PhutRa;
                    }
                    else
                    {
                        PhutDuCuoi = PhutRa;
                    }
                }
                else
                {
                    PhutDuCuoi = PhutRa;
                }
            }
            TextBlock txtGioDau = new TextBlock();
            TextBlock txtNgay = new TextBlock();
            TextBlock txtGioCuoi = new TextBlock();
            if (NgayRa_So > NgayVao_So)
            {
                if (GioVao <= GioMoc)
                {
                    txtGioDau.Text = "-" + GioDuDau.ToString() + "h" + PhutDuDau.ToString() + "'" + "(" + GioVaoTinh.ToString() + ":" + PhutVao.ToString() + "-" + GioMocTinh.ToString() + ":00 " + DateToNumberConverter.NumberToDate((NgayVao_So ).ToString()) + ")";
                    txtNgay.Text = "-" + SoNgay.ToString() + "ngày (" + DateToNumberConverter.NumberToDate((NgayVao_So).ToString()) + " - " + DateToNumberConverter.NumberToDate((NgayVao_So + SoNgay).ToString());
                }
                else
                {
                    txtGioDau.Text = "-" + GioDuDau.ToString() + "h" + PhutDuDau.ToString() + "'" + "(" + GioVaoTinh.ToString() + ":" + PhutVao.ToString() + "-" + GioMocTinh.ToString() + ":00 " + DateToNumberConverter.NumberToDate((NgayVao_So + 1).ToString()) + ")";
                    txtNgay.Text = "-" + SoNgay.ToString() + "ngày (" + DateToNumberConverter.NumberToDate((NgayVao_So+1).ToString()) + " - " + DateToNumberConverter.NumberToDate((NgayVao_So +1+ SoNgay).ToString());
                }

                if (NgayRa_So - NgayVao_So == 1)
                {
                    if (GioRa <= GioMoc)
                    {
                        txtGioCuoi.Text = "-" + GioDuCuoi.ToString() + "h" + PhutDuCuoi.ToString() + "'" + "(" + GioMocTinh.ToString() + ":00 " + DateToNumberConverter.NumberToDate((NgayVao_So).ToString()) + "-" + GioRaTinh.ToString() + ":" + PhutRa.ToString() + " " + DateToNumberConverter.NumberToDate(NgayRa_So.ToString()) + ")";
                    }
                    else
                    {
                        txtGioCuoi.Text = "-" + GioDuCuoi.ToString() + "h" + PhutDuCuoi.ToString() + "'" + "(" + GioMocTinh.ToString() + ":00" + "-" + GioRaTinh.ToString() + ":" + PhutRa.ToString() + " " + DateToNumberConverter.NumberToDate(NgayRa_So.ToString()) + ")";
                    }
                }
                else
                {
                    if (GioRa <= GioMoc)
                    {
                        txtGioCuoi.Text = "-" + GioDuCuoi.ToString() + "h" + PhutDuCuoi.ToString() + "'" + "(" + GioRaTinh.ToString() + ":" + PhutRa.ToString() + "-" + GioMocTinh.ToString() + ":00" + " " + DateToNumberConverter.NumberToDate(NgayRa_So.ToString()) + ")";
                    }
                    else
                    {
                        txtGioCuoi.Text = "-" + GioDuCuoi.ToString() + "h" + PhutDuCuoi.ToString() + "'" + "(" + GioMocTinh.ToString() + ":00" + "-" + GioRaTinh.ToString() + ":" + PhutRa.ToString() + " " + DateToNumberConverter.NumberToDate(NgayRa_So.ToString()) + ")";
                    }
                }                

                SPTienPhong.Orientation = Orientation.Vertical;
                SPTienPhong.Children.Add(txtGioDau);
                if (SoNgay > 0)
                {
                    SPTienPhong.Children.Add(txtNgay);
                }
                SPTienPhong.Children.Add(txtGioCuoi);
            }
            else
            {
                GioDuDau = GioRaTinh - GioVaoTinh;
                if (PhutVao != 0)
                {
                    if (PhutVao > 30)
                    {
                        GioDuDau = GioDuDau - 1;
                        PhutDuDau = 60 - PhutVao;
                    }
                    else
                    {
                        PhutDuDau = 60 - PhutVao;
                    }
                }
                PhutDuCuoi = PhutRa;
                int SoPhut = PhutDuDau + PhutDuCuoi;
                int SoPhutDu=0;
                if (SoPhut>=60)
                {
                    GioDuDau= GioDuDau + 1;
                    SoPhutDu = SoPhut-60;
                }
                else
                {
                    SoPhutDu = SoPhut;
                }
                if (SoPhutDu > 30)
                {
                    GioDuDau = GioDuDau + 1;
                }
                txtGioDau.Text = "- Tổng số giờ :" + GioDuDau.ToString() + " Tổng tiền phòng : " + Format_NumberVietnamese(TinhTienTheoGio(GioDuDau).ToString());
                SPTienPhong.Children.Add(txtGioDau);
            }
            txtTongThanhToan.Text = Format_NumberVietnamese((TinhTienTheoGio(GioDuDau) + DichVu + TongTraTruoc).ToString());
            LoadingPanel.IsBusy = false;
        }
        private decimal TinhTienTheoGio(int SoGio)
        {
            try
            {
                decimal TienTheoGio = 0;
                for (int i = 1; i <= SoGio; i++)
                {                    
                    TienTheoGio += GiaTheoGio(i);
                }
                return TienTheoGio;
            }
            catch (Exception)
            {
                
                throw;
            }  
        }
        private decimal GiaTheoGio(int Gio)
        {
            decimal retGia=0;
            retGia = GiaTheoGioGanNhat(Gio);
            while (retGia == 0&&Gio>=0)
            {
                Gio--;
                retGia = GiaTheoGioGanNhat(Gio);
            }
            return retGia;
        }
        private decimal GiaTheoGioGanNhat(int Gio)
        {
            decimal Gia = 0;
            foreach (Gio_PhongInfo item in listGio_Phong)
            {
                if (item.GioPhongName.Trim() == Gio.ToString())
                {
                    Gia = item.GiaTien;
                    break;
                }
            }
            return Gia;
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
        private void cmdThemTraTruoc_Click(object sender, RoutedEventArgs e)
        {
            frmHoaDon_ThemTraTruoc HoaDon_ThemTraTruoc = new frmHoaDon_ThemTraTruoc();
            HoaDon_ThemTraTruoc.HoaDonID = HoaDonID;
            HoaDon_ThemTraTruoc.TraTruoc_Load(HoaDonID);
            HoaDon_ThemTraTruoc.Closed += new EventHandler(HoaDon_ThemTraTruoc_Closed);
            HoaDon_ThemTraTruoc.Show();
        }

        void HoaDon_ThemTraTruoc_Closed(object sender, EventArgs e)
        {
            HoaDon_TraTruocSVCClient HoaDon_TraTruocClient = new HoaDon_TraTruocSVCClient();
            HoaDon_TraTruocClient.HoaDon_TraTruoc_GetItemsCompleted += new EventHandler<HoaDon_TraTruoc_GetItemsCompletedEventArgs>(HoaDon_TraTruocClient_HoaDon_TraTruoc_GetItemsCompleted);
            HoaDon_TraTruocClient.HoaDon_TraTruoc_GetItemsAsync(HoaDonID);
        }
        #region TinhTien
        decimal TongTienPhong = 0;
        private void TinhTienTheoGio(int GioVao , int PhutVao, int GioRa, int PhutRa,int Ca)
        {
            try
            {
                decimal TongTien = 0;//20g15 23 = 45 + (23-21)= 2tieng 45 phut
                int TongSoPhut = 0;// (GioRa - GioVao) * 60 + PhutVao + PhutRa;
                if (GioRa == GioVao)
                {
                    TongSoPhut = PhutRa - PhutVao;
                }
                else
                {
                    if (PhutVao == 0)
                    {
                        TongSoPhut = (GioRa - GioVao) * 60 + PhutRa;
                    }
                    else
                    {

                        TongSoPhut = (60 - PhutVao) + (GioRa - (GioVao + 1)) * 60 + PhutRa;   
                    }
                }
                if (Ca == 0)
                {
                    //Ca Ngay
                    if (TongSoPhut <= 70)
                    {
                        TongTien = 50000;
                    }
                    else
                    {
                        int SoPhutDu = TongSoPhut - 70;
                        int k = SoPhutDu / 30;
                        TongTien = 50000 + k * 10000;
                    }
                }
                else
                { 
                    //Ca Dem
                    if (TongSoPhut <= 70)
                    {
                        TongTien = 60000;
                    }
                    else
                    {
                        int SoPhutDu = TongSoPhut - 70;
                        int k = SoPhutDu / 30;
                        TongTien = 60000 + k * 10000;
                    }
                }
                Label txtGioDau = new Label();
                txtGioDau.Content =  Format_NumberVietnamese(TongTien.ToString());
                SPTienPhong.Children.Add(txtGioDau);
                LoadingPanel.IsBusy = false;
                TongTienPhong = TongTien;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void TinhTienQuaDem(int NgayVao_So, int NgayRa_So, int GioRa, int PhutRa)
        {
            try
            {
                decimal TongTien = 0;
                decimal GiaPhong = itemNgay_Phong.GiaTuan;
                if (NgayRa_So == NgayVao_So)
                {
                    TongTien = GiaPhong;
                }
                else
                {
                    if (GioRa > 12)
                    {
                        int SoPhutDu = (GioRa - 12) * 60 + PhutRa;
                        if (SoPhutDu <= 70)
                        {
                            TongTien = GiaPhong + 20000;
                        }
                        else if (SoPhutDu > 70)
                        {
                            TongTien = GiaPhong + (SoPhutDu - 70) / 30 * 10000;
                        }
                    }
                    else
                    {
                        TongTien = GiaPhong;
                    }
                }
                Label txtGioDau = new Label();
                txtGioDau.Content =  Format_NumberVietnamese(TongTien.ToString());
                SPTienPhong.Children.Add(txtGioDau);
                LoadingPanel.IsBusy = false;
                TongTienPhong = TongTien;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void TinhTienTheoNgay(int NgayVao_So, int NgayRa_So)
        {
            try
            {
                decimal TongTien = 0;
                decimal GiaNgay = itemNgay_Phong.GiaNgay;
                if (NgayVao_So == NgayRa_So)
                {
                    TongTien = GiaNgay;
                }
                else
                {
                    TongTien = GiaNgay * (NgayRa_So - NgayVao_So);
                }
                Label txtGioDau = new Label();
                txtGioDau.Content =  Format_NumberVietnamese(TongTien.ToString());
                SPTienPhong.Children.Add(txtGioDau);
                LoadingPanel.IsBusy = false;
                TongTienPhong = TongTien;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        private void TinhTienTheoThang(int NgayVao_So, int NgayRa_So)
        {
            try
            {
                decimal TongTien = 0;
                decimal GiaThang = itemNgay_Phong.GiaThang;
                if (NgayVao_So == NgayRa_So)
                {
                    TongTien = GiaThang;
                }
                else
                {
                    TongTien = GiaThang * ((NgayRa_So - NgayVao_So) / 30 + 1);
                }
                Label txtGioDau = new Label();
                txtGioDau.Content = Format_NumberVietnamese(TongTien.ToString());
                SPTienPhong.Children.Add(txtGioDau);
                LoadingPanel.IsBusy = false;
                TongTienPhong = TongTien;
            }
            catch (Exception)
            {
                
                throw;
            }
        }
        #endregion

        private void txtKhoanKhac_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtKhoanKhac.Text == "")
            {
                KhoanKhac = 0;
            }
            else
            {
                KhoanKhac = decimal.Parse(txtKhoanKhac.Text.ToString());
            }
            txtTongThanhToan.Text = Format_NumberVietnamese((DichVu + TongTienPhong + KhoanKhac - TienTraTruoc).ToString());
        }

        private void cmdThanhToan_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                decimal TongTien = decimal.Parse(txtTongThanhToan.Text.ToString());
                HoaDon.HoaDon_ThanhToanCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDon_HoaDon_ThanhToanCompleted);
                HoaDon.HoaDon_ThanhToanAsync(HoaDonID, TongTien);
            }
            catch (Exception)
            {
                
                throw;
            }
        }

        void HoaDon_HoaDon_ThanhToanCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {            
            this.DialogResult = true;
        }

        private void cmdInHoaDon_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rptHoaDon InHoaDon = new rptHoaDon();
                InHoaDon.TenKhachHang = TenKhachHang;
                InHoaDon.NgayVao = txtNgayVao.Text;
                InHoaDon.GioVao = txtGioVao.Text;
                InHoaDon.PhutVao = txtPhutVao.Text;
                InHoaDon.NgayRa = txtNgayRa.Text;
                InHoaDon.GioRa = txtGioRa.Text;
                InHoaDon.PhutRa = txtPhutRa.Text;
                InHoaDon.TienPhong =  Format_NumberVietnamese(TongTienPhong.ToString());
                InHoaDon.TienDichVu = Format_NumberVietnamese(DichVu.ToString());
                InHoaDon.TongTien = Format_NumberVietnamese(txtTongThanhToan.Text.ToString());
                InHoaDon.TraTruoc = Format_NumberVietnamese(txtKhuyenMai.Text.ToString());
                InHoaDon.Show();
            }
            catch (Exception)
            {
                
                throw;
            }
        }
    }
}


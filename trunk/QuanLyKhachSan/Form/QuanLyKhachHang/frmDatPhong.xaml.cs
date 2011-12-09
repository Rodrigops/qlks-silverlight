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
using QuanLyKhachSan.KhachHangSVC;
using QuanLyKhachSan.HoaDonSVC;
using QuanLyKhachSan.HoaDon_KhachHangSVC;
using Telerik.Windows.Controls;
namespace QuanLyKhachSan.Form.QuanLyKhachHang
{
    public partial class frmDatPhong : ChildWindow
    {
        PhongSVCClient PhongClient = new PhongSVCClient();
        private List<KhachHangInfo> listKhachHang;
        public frmDatPhong()
        {
            InitializeComponent();
            LoaiThue_Load();
            Ca_Load();
            PhongClient.Phong_GetItems_ByTinhTrangCompleted += new EventHandler<Phong_GetItems_ByTinhTrangCompletedEventArgs>(PhongClient_Phong_GetItems_ByTinhTrangCompleted);
            PhongClient.Phong_GetItems_ByTinhTrangAsync();
        }
        public void KhachHang_Load(List<KhachHangInfo> _listKhachHang)
        {
            listKhachHang = _listKhachHang;
            grvKhachHang.ItemsSource = listKhachHang;
        }
        void PhongClient_Phong_GetItems_ByTinhTrangCompleted(object sender, Phong_GetItems_ByTinhTrangCompletedEventArgs e)
        {
            cbxPhong.ItemsSource = e.Result;
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            int LoaiThue = int.Parse(cbxLoaiThue.SelectedValue.ToString());
            int Ca = int.Parse(cbxCa.SelectedValue.ToString());
            decimal KhuyenMai;
            if (String.IsNullOrEmpty(txtKhuyenMai.Text))
            {
                KhuyenMai = 0;
            }
            else
            {
                KhuyenMai = decimal.Parse(txtKhuyenMai.Text.ToString());
            }
            string GhiChu = txtGhiChu.Text;
            string sNgayVao = "";
            int iNgayVao_So;
            int iGioVao;
            int iPhutVao;
            int iThangVao;
            int iNamVao;
            string sNgayRa = "";
            int iNgayRa_So;
            int iGiora;
            int iPhutRa;
            int iThangRa;
            int iNamRa;
            //validate
            if (String.IsNullOrEmpty(calNgayVao.SelectedDate.ToString()))
            {
                MessageBox.Show("Bạn chưa chọn ngày nhận phòng.Vui lòng kiểm tra lại");
                return;
            }
            if (!String.IsNullOrEmpty(calNgayVao.SelectedDate.ToString()))
                sNgayVao = calNgayVao.SelectedDate.Value.ToString("MM/dd/yyyy");
            iGioVao = int.Parse(cbxGioVao.Text.ToString());
            iPhutVao = int.Parse(cbxPhutVao.Text.ToString());
            iNgayVao_So = DateToNumberConverter.Date2Number(sNgayVao);
            iThangVao = DateToNumberConverter.Date2Month(sNgayVao);
            iNamVao = DateToNumberConverter.Date2Year(sNgayVao);
            if (!String.IsNullOrEmpty(calNgayRa.SelectedDate.ToString()))
                sNgayRa = calNgayRa.SelectedDate.Value.ToString("MM/dd/yyyy");
            iGiora = int.Parse(cbxGioRa.Text.ToString());
            iPhutRa = int.Parse(cbxPhutRa.Text.ToString());
            iNgayRa_So = DateToNumberConverter.Date2Number(sNgayRa);
            iThangRa = DateToNumberConverter.Date2Month(sNgayRa);
            iNamRa = DateToNumberConverter.Date2Year(sNgayRa);
            HoaDonSVCClient HoaDonClient = new HoaDonSVCClient();
            HoaDonClient.HoaDon_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonClient_HoaDon_AddCompleted);
            HoaDonClient.HoaDon_AddAsync(LoaiThue, Ca, "DatPhong", KhuyenMai, GhiChu, sNgayVao, iNgayVao_So, iGioVao, iPhutVao, iThangVao, iNamVao, sNgayRa, iNgayRa_So, iGiora, iPhutRa, iThangRa, iNamRa, int.Parse(User.UserID));
        }

        void HoaDonClient_HoaDon_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            HoaDon_KhachHangSVCClient HoaDon_KhachHangClient = new HoaDon_KhachHangSVCClient();
            PhongSVCClient PhongClient = new PhongSVCClient();
            int PhongID = int.Parse(cbxPhong.SelectedValue.ToString());
            string sNgayBatDau = "";
            int iGioBatDau;
            int iPhutBatDau;
            int iNgayBatDau_So;
            int iThangBatDau;
            int iNamBatDau;
            string sNgayKetThuc = "";

            if (!String.IsNullOrEmpty(calNgayVao.SelectedDate.ToString()))
                sNgayBatDau = calNgayVao.SelectedDate.Value.ToString("MM/dd/yyyy");
            iGioBatDau = int.Parse(cbxGioVao.Text.ToString());
            iPhutBatDau = int.Parse(cbxPhutVao.Text.ToString());
            iNgayBatDau_So = DateToNumberConverter.Date2Number(sNgayBatDau);
            iThangBatDau = DateToNumberConverter.Date2Month(sNgayBatDau);
            iNamBatDau = DateToNumberConverter.Date2Year(sNgayBatDau);
            if (!String.IsNullOrEmpty(calNgayRa.SelectedDate.ToString()))
                sNgayKetThuc = calNgayRa.SelectedDate.Value.ToString("MM/dd/yyyy");

            foreach (KhachHangInfo item in listKhachHang)
            {
                HoaDon_KhachHangClient.HoaDon_KhachHang_AddAsync("DatPhong", item.KhachHangID, PhongID, sNgayBatDau, iGioBatDau, iPhutBatDau, iNgayBatDau_So, iThangBatDau, iNamBatDau, sNgayKetThuc);
            }
            PhongClient.TinhTrang_Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_TinhTrang_Phong_AddCompleted);
            PhongClient.TinhTrang_Phong_AddAsync(0, PhongID, 2, iNgayBatDau_So);
        }

        void PhongClient_TinhTrang_Phong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        private void LoaiThue_Load()
        {
            LoaiThueInfo item = null;
            List<LoaiThueInfo> listLoaiThue = new List<LoaiThueInfo>();
            item = new LoaiThueInfo();
            item.LoaiThueID = 0;
            item.LoaiThue = "Theo giờ";
            listLoaiThue.Add(item);
            item = new LoaiThueInfo();
            item.LoaiThueID = 1;
            item.LoaiThue = "Theo ngày";
            item = new LoaiThueInfo();
            listLoaiThue.Add(item);
            item.LoaiThueID = 2;
            item.LoaiThue = "Qua đêm";
            listLoaiThue.Add(item);
            item = new LoaiThueInfo();
            item.LoaiThueID = 3;
            item.LoaiThue = "Theo tháng";
            listLoaiThue.Add(item);
            cbxPhong.ItemsSource = listLoaiThue;
        }
        private void Ca_Load()
        {
            CaInfo item = null;
            List<CaInfo> listCa = new List<CaInfo>();
            item = new CaInfo();
            item.CaID = 0;
            item.TenCa = "Ca ngày";
            listCa.Add(item);
            item = new CaInfo();
            item.CaID = 1;
            item.TenCa = "Ca đêm";
            listCa.Add(item);
            cbxCa.ItemsSource = listCa;

        }

        
    }
}


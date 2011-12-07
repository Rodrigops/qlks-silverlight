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
    public partial class frmNhanPhong : ChildWindow
    {
        PhongSVCClient PhongClient = new PhongSVCClient();
        private List<KhachHangInfo> listKhachHang;
        private List<TinhTrang_PhongInfo> listTinhTrangPhong;
        public frmNhanPhong()
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
            listTinhTrangPhong = e.Result.ToList<TinhTrang_PhongInfo>();
        }
        private bool CheckStatusInValid(int PhongID)
        {
            bool ret;
            TinhTrang_PhongInfo itemCheck = null;
            foreach (TinhTrang_PhongInfo item in listTinhTrangPhong)
            {
                if (item.PhongID == PhongID)
                {
                    itemCheck = item;
                }
            }
            if (itemCheck.TinhTrangPhongID == 3)
            {
                ret = true;
            }
            else
            {
                ret = false;
            }
            return ret;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            //Kiem Tra Tinh Trang Phong
            object itemSelected = cbxPhong.SelectedValue;
            if (CheckStatusInValid( int.Parse(itemSelected.ToString())))
            {
                MessageBox.Show("Phòng bạn chọn đã có người nhận.Vui lòng chọn phòng khác!","Thông báo",MessageBoxButton.OK);
                return;
            }
            int LoaiThue=int.Parse(cbxLoaiThue.SelectedValue.ToString());
            int Ca = int.Parse(cbxCa.SelectedValue.ToString());
            decimal TraTruoc=0;
            if (LoaiThue != 0)
            {
                if (txtTraTruoc.Text == "")
                {
                    MessageBox.Show("Vui lòng nhập trả trước!", "Thông báo", MessageBoxButton.OK);
                    return;
                }
            }
            if (String.IsNullOrEmpty(txtTraTruoc.Text))
            {
                TraTruoc = 0;
            }
            else
            {
                TraTruoc = decimal.Parse(txtTraTruoc.Text.ToString());
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
            HoaDonClient.HoaDon_AddCompleted+=new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonClient_HoaDon_AddCompleted);
            HoaDonClient.HoaDon_AddAsync(LoaiThue, Ca, "NhanPhong", TraTruoc, GhiChu, sNgayVao, iNgayVao_So, iGioVao, iPhutVao, iThangVao, iNamVao, sNgayRa, iNgayRa_So, iGiora, iPhutRa, iThangRa, iNamRa, 0);

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
                HoaDon_KhachHangClient.HoaDon_KhachHang_AddAsync("NhanPhong",item.KhachHangID, PhongID, sNgayBatDau, iGioBatDau, iPhutBatDau, iNgayBatDau_So, iThangBatDau, iNamBatDau, sNgayKetThuc);                
            }
            PhongClient.TinhTrang_Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_TinhTrang_Phong_AddCompleted);
            PhongClient.TinhTrang_Phong_AddAsync(0,PhongID, 3, iNgayBatDau_So);
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
            listLoaiThue.Add(item);
            item = new LoaiThueInfo();
            item.LoaiThueID = 2;
            item.LoaiThue = "Qua đêm";
            listLoaiThue.Add(item);
            item = new LoaiThueInfo();
            item.LoaiThueID = 3;
            item.LoaiThue = "Theo tháng";
            listLoaiThue.Add(item);
            cbxLoaiThue.ItemsSource = listLoaiThue;
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
            //
            int Gio = DateTime.Now.Hour;
            if (Gio >= 7 && Gio < 19)
            {
                cbxCa.SelectedIndex = 0;
            }
            else
            {
                cbxCa.SelectedIndex = 1;
            }
            cbxGioVao.SelectedIndex = Gio;
            cbxGioRa.SelectedIndex = Gio;          
            calNgayVao.SelectedValue = DateTime.Now;
            calNgayRa.SelectedValue = DateTime.Now;
        }

    }
}


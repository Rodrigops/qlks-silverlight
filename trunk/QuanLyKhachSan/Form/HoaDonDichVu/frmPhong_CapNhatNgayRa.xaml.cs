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
using QuanLyKhachSan.HoaDonDichVuSVC;
using QuanLyKhachSan.Form.QuanLyKhachHang;
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmPhong_CapNhatNgayRa : ChildWindow
    {
        public int HoaDonID = -1;
        private HoaDonDichVuSVCClient HoaDonDichVuClient = null;
        public frmPhong_CapNhatNgayRa()
        {
            InitializeComponent();
        }
        public void HoaDon_Load(int _HoaDonID)
        {
            HoaDonID = _HoaDonID;

            HoaDonDichVuClient = new HoaDonDichVuSVCClient();
            HoaDonDichVuClient.HoaDonDichVu_GetItem_NgayVaoCompleted += new EventHandler<HoaDonDichVu_GetItem_NgayVaoCompletedEventArgs>(HoaDonDichVuClient_HoaDonDichVu_GetItem_NgayVaoCompleted);
            HoaDonDichVuClient.HoaDonDichVu_GetItem_NgayVaoAsync(HoaDonID);
        }

        void HoaDonDichVuClient_HoaDonDichVu_GetItem_NgayVaoCompleted(object sender, HoaDonDichVu_GetItem_NgayVaoCompletedEventArgs e)
        {
            HoaDonNgayVaoRaInfo HDDV = e.Result;
            DateTime dt = DateTime.Parse(HDDV.NgayVao);
            lblNgayVao.Text = String.Format("{0:dd/MM/yyyy}", dt) + " " + HDDV.GioVao.ToString() + "h" + HDDV.PhutVao.ToString();
            rdpNgayRa.SelectedDate = DateTime.Parse(HDDV.NgayRa);
            cbxGioRa.SelectedIndex = HDDV.GioRa;
            for (int i = 0; i < cbxPhutRa.Items.Count; i++)
            {
                var item = ((RadComboBoxItem)cbxPhutRa.Items[i]).Content;
                if (item.Equals(HDDV.PhutRa.ToString()))
                    cbxPhutRa.SelectedIndex = i;
            }
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            string sNgayRa = "";
            int iGioRa;
            int iPhutRa;
            int iNgayRa_So;
            int iThangRa;
            int iNamRa;

            if (!String.IsNullOrEmpty(rdpNgayRa.SelectedDate.ToString()))
                sNgayRa = rdpNgayRa.SelectedDate.Value.ToString("MM/dd/yyyy");
            iGioRa = int.Parse(cbxGioRa.Text.ToString());
            iPhutRa = int.Parse(cbxPhutRa.Text.ToString());
            iNgayRa_So = DateToNumberConverter.Date2Number(sNgayRa);
            iThangRa = DateToNumberConverter.Date2Month(sNgayRa);
            iNamRa = DateToNumberConverter.Date2Year(sNgayRa);

            HoaDonDichVuClient = new HoaDonDichVuSVCClient();
            HoaDonDichVuClient.HoaDonNgayRa_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonDichVuClient_HoaDonNgayRa_AddCompleted);
            HoaDonDichVuClient.HoaDonNgayRa_AddAsync(HoaDonID, sNgayRa, iGioRa, iPhutRa, iNgayRa_So, iThangRa, iNamRa);
        }
        void HoaDonDichVuClient_HoaDonNgayRa_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            this.DialogResult = true;
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


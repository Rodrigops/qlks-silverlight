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
using QuanLyKhachSan.HoaDon_TraTruocSVC;
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmHoaDon_ThemTraTruoc : ChildWindow
    {
        public int HoaDonID = -1;
        private HoaDon_TraTruocSVCClient HoaDon_TraTruocClient = null;
        public frmHoaDon_ThemTraTruoc()
        {
            InitializeComponent();
        }
        public void TraTruoc_Load(int _HoaDonID)
        {
            HoaDonID = _HoaDonID;
            LoadingPanel.IsBusy = true;
            HoaDon_TraTruocClient = new HoaDon_TraTruocSVCClient();
            HoaDon_TraTruocClient.HoaDon_TraTruoc_GetItemsCompleted += new EventHandler<HoaDon_TraTruoc_GetItemsCompletedEventArgs>(HoaDon_TraTruocClient_HoaDon_TraTruoc_GetItemsCompleted);
            HoaDon_TraTruocClient.HoaDon_TraTruoc_GetItemsAsync(HoaDonID);
        }
        void HoaDon_TraTruocClient_HoaDon_TraTruoc_GetItemsCompleted(object sender, HoaDon_TraTruoc_GetItemsCompletedEventArgs e)
        {
            grvHoaDon_TraTruoc.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            HoaDon_TraTruocClient = new HoaDon_TraTruocSVCClient();
            HoaDon_TraTruocClient.HoaDon_TraTruoc_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDon_TraTruocClient_HoaDon_TraTruoc_AddCompleted);
            HoaDon_TraTruocClient.HoaDon_TraTruoc_AddAsync(HoaDonID, txtGhiChu.Text.Trim(), decimal.Parse(txtTraTruoc.Text.ToString()), 0, DateTime.Now.ToString("MM/dd/yyyy"));
        }

        void HoaDon_TraTruocClient_HoaDon_TraTruoc_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            txtGhiChu.Text = String.Empty;
            txtTraTruoc.Text = String.Empty;
            
            TraTruoc_Load(HoaDonID);
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


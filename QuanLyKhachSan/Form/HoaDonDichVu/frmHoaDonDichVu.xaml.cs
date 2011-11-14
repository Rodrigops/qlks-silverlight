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
using System.Windows.Navigation;
using System.Windows.Data;
using QuanLyKhachSan.HoaDonDichVuSVC;
namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmHoaDonDichVu : Page
    {
        private HoaDonDichVuSVCClient HoaDonDichVuClient = new HoaDonDichVuSVCClient();
        public frmHoaDonDichVu()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = true;
            HoaDonDichVuClient.HoaDonDichVu_GetItemsCompleted += new EventHandler<HoaDonDichVu_GetItemsCompletedEventArgs>(HoaDonDichVuClient_HoaDonDichVu_GetItemsCompleted);
            HoaDonDichVuClient.HoaDonDichVu_GetItemsAsync(0);
        }
        void HoaDonDichVuClient_HoaDonDichVu_GetItemsCompleted(object sender, HoaDonDichVu_GetItemsCompletedEventArgs e)
        {
            grvHoaDonDichVu.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }
        void HoaDonDichVuClient_HoaDonDichVu_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            HoaDonDichVuClient.HoaDonDichVu_GetItemsAsync(0);
        }
        void HoaDonDichVuEdit_Closed(object sender, EventArgs e)
        {
            frmHoaDonDichVuEdit HoaDonDichVuEdit = sender as frmHoaDonDichVuEdit;
            if (HoaDonDichVuEdit.DialogResult == true)
            {
                HoaDonDichVuClient.HoaDonDichVu_GetItemsAsync(0);
            }
        }

        private void cmdThemHoaDon_Click(object sender, RoutedEventArgs e)
        {
            frmHoaDonDichVuEdit HoaDonDichVuEdit = new frmHoaDonDichVuEdit();
            HoaDonDichVuEdit.Closed += new EventHandler(HoaDonDichVuEdit_Closed);
            HoaDonDichVuEdit.HoaDonDichVu_Load(0);
            HoaDonDichVuEdit.Show();
        }
        private void cmdSuaHoaDon_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaHoaDon = sender as HyperlinkButton;
            int HoaDonDichVuID = int.Parse(cmdSuaHoaDon.CommandParameter.ToString());
            frmHoaDonDichVuEdit HoaDonDichVuEdit = new frmHoaDonDichVuEdit();
            HoaDonDichVuEdit.Closed += new EventHandler(HoaDonDichVuEdit_Closed);
            HoaDonDichVuEdit.HoaDonDichVu_Load(HoaDonDichVuID);
            HoaDonDichVuEdit.Show();
        }
        private void cmdXoaHoaDon_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaHoaDon = sender as HyperlinkButton;
            int HoaDonDichVuID = int.Parse(cmdXoaHoaDon.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                HoaDonDichVuClient.HoaDonDichVu_DeleteCompleted +=new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonDichVuClient_HoaDonDichVu_DeleteCompleted);
                HoaDonDichVuClient.HoaDonDichVu_DeleteAsync(HoaDonDichVuID);
            }
        }
    }
}

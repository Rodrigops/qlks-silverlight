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
using QuanLyKhachSan.KhachHangSVC;
using System.Windows.Data;
namespace QuanLyKhachSan.Form.QuanLyKhachHang
{
    public partial class frmKhachHang : Page
    {
        private KhachHangSVCClient KhachHangClient = new KhachHangSVCClient();
        public frmKhachHang()
        {
            InitializeComponent();
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            KhachHangClient.KhachHang_GetItemsCompleted += new EventHandler<KhachHang_GetItemsCompletedEventArgs>(KhachHangClient_KhachHang_GetItemsCompleted);
            KhachHangClient.KhachHang_GetItemsAsync(0);
        }

        void KhachHangClient_KhachHang_GetItemsCompleted(object sender, KhachHang_GetItemsCompletedEventArgs e)
        {
            grvKhachHang.ItemsSource = e.Result;
        }

        void KhachHangClient_KhachHang_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            KhachHangClient.KhachHang_GetItemsAsync(0);
        }

        void KhachHangEdit_Closed(object sender, EventArgs e)
        {
            frmKhachHangEdit KhachHangEdit = sender as frmKhachHangEdit;
            if (KhachHangEdit.DialogResult == true)
            {
                KhachHangClient.KhachHang_GetItemsAsync(0);
            }
        }

        private void cmdThemKhachHang_Click(object sender, RoutedEventArgs e)
        {
            frmKhachHangEdit KhachHangEdit = new frmKhachHangEdit();
            KhachHangEdit.Closed += new EventHandler(KhachHangEdit_Closed);
            KhachHangEdit.KhachHang_Load(0);
            KhachHangEdit.Show();
        }

        private void cmdSuaKhachHang_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaKhachHang = sender as HyperlinkButton;
            int KhachHangID = int.Parse(cmdSuaKhachHang.CommandParameter.ToString());
            frmKhachHangEdit KhachHangEdit = new frmKhachHangEdit();
            KhachHangEdit.Closed += new EventHandler(KhachHangEdit_Closed);
            KhachHangEdit.KhachHang_Load(KhachHangID);
            KhachHangEdit.Show();
        }

        private void cmdXoaKhachHang_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaKhachHang = sender as HyperlinkButton;
            int KhachHangID = int.Parse(cmdXoaKhachHang.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                KhachHangClient.KhachHang_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(KhachHangClient_KhachHang_DeleteCompleted);
                KhachHangClient.KhachHang_DeleteAsync(KhachHangID, 0, DateTime.Now.ToString("MM/dd/yyyy"));
            }
        }
    }
}

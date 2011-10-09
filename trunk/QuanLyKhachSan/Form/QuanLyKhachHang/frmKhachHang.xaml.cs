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
using  QuanLyKhachSan.KhachHangSVC;
namespace QuanLyKhachSan.Form.KhachHang
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
            KhachHangClient.KhachHang_GetItemsCompleted+=new EventHandler<KhachHang_GetItemsCompletedEventArgs>(KhachHangClient_KhachHang_GetItemsCompleted);
            KhachHangClient.KhachHang_GetItemsAsync(0);
        }

        void  KhachHangClient_KhachHang_GetItemsCompleted(object sender, KhachHang_GetItemsCompletedEventArgs e)
        {
 	        grvKhachHang.ItemsSource = e.Result;
        }

        private void cmdSuaKhachHang_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdXoaKhachHang_Click(object sender, RoutedEventArgs e)
        {

        }

    }
}

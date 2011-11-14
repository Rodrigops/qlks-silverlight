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
using QuanLyKhachSan.Gia_PhongSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmGiaPhong : Page
    {
        Gia_PhongSVCClient Gia_PhongClient = new Gia_PhongSVCClient();
        public frmGiaPhong()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception)
            {                
                throw;
            }            
        }

        void Gia_PhongClient_Phong_GiaPhongCompleted(object sender, Phong_GiaPhongCompletedEventArgs e)
        {
            grvGiaPhong.ItemsSource = e.Result;
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            try
            {                
                LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                Gia_PhongClient.Phong_GiaPhongCompleted += new EventHandler<Phong_GiaPhongCompletedEventArgs>(Gia_PhongClient_Phong_GiaPhongCompleted);
                Gia_PhongClient.Phong_GiaPhongAsync();
            }
            catch (Exception)
            {
                
                throw;
            }
        }

    }
}

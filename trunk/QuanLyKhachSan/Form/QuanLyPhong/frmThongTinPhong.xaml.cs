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
using QuanLyKhachSan.LoaiPhongSVC;
using System.ServiceModel;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmLoaiPhong : Page
    {
        private LoaiPhongSVCClient LoaiPhongClient = new LoaiPhongSVCClient();

        public frmLoaiPhong()
        {
            InitializeComponent();
            
           
        }

        void LoaiPhongClient_LoaiPhong_GetItemsCompleted(object sender, LoaiPhong_GetItemsCompletedEventArgs e)
        {
            grvLoaiPhong.ItemsSource = e.Result;
        }
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LoaiPhongClient.LoaiPhong_GetItemsCompleted += new EventHandler<LoaiPhong_GetItemsCompletedEventArgs>(LoaiPhongClient_LoaiPhong_GetItemsCompleted);
            LoaiPhongClient.LoaiPhong_GetItemsAsync();
        }

        private void cmdThemLoaiPhong_Click(object sender, RoutedEventArgs e)
        {
            frmLoaiPhongEdit LoaiPhongEdit = new frmLoaiPhongEdit();
            LoaiPhongEdit.Closed += new EventHandler(LoaiPhongEdit_Closed);
            LoaiPhongEdit.Show();
            
        }

        void LoaiPhongEdit_Closed(object sender, EventArgs e)
        {
            try
            {       
                LoaiPhongClient.LoaiPhong_GetItemsAsync();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void cmdSuaLoaiPhong_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaLoaiPhong = sender as HyperlinkButton;
            int LoaiPhongID = int.Parse(cmdSuaLoaiPhong.CommandParameter.ToString());
            frmLoaiPhongEdit LoaiPhongEdit = new frmLoaiPhongEdit();
            LoaiPhongEdit.Closed += new EventHandler(LoaiPhongEdit_Closed);
            LoaiPhongEdit.LoaiPhong_Load(LoaiPhongID);
            LoaiPhongEdit.Show();
        }

        private void cmdXoaLoaiPhong_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaLoaiPhong = sender as HyperlinkButton;
            int LoaiPhongID = int.Parse(cmdXoaLoaiPhong.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                LoaiPhongClient.LoaiPhong_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(LoaiPhongClient_LoaiPhong_DeleteCompleted);
                LoaiPhongClient.LoaiPhong_DeleteAsync(LoaiPhongID);
            }
                
        }

        void LoaiPhongClient_LoaiPhong_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            LoaiPhongClient.LoaiPhong_GetItemsAsync();
        }
    }
}

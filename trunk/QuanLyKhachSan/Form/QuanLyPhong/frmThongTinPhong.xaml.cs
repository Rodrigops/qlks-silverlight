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
using System.ServiceModel;
using QuanLyKhachSan.LoaiPhongSVC;
using QuanLyKhachSan.TienNghiSVC;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmLoaiPhong : Page
    {
        private LoaiPhongSVCClient LoaiPhongClient = new LoaiPhongSVCClient();
        private TienNghiSVCClient TienNghiClient = new TienNghiSVCClient();
        public frmLoaiPhong()
        {
            InitializeComponent();            
           
        }
        
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            radLoading.IsBusy = true;
            LoaiPhongClient.LoaiPhong_GetItemsCompleted += new EventHandler<LoaiPhong_GetItemsCompletedEventArgs>(LoaiPhongClient_LoaiPhong_GetItemsCompleted);
            LoaiPhongClient.LoaiPhong_GetItemsAsync();

            TienNghiClient.TienNghi_GetItemsCompleted += new EventHandler<TienNghi_GetItemsCompletedEventArgs>(TienNghiClient_TienNghi_GetItemsCompleted);
            TienNghiClient.TienNghi_GetItemsAsync();
        }
        #region LoaiPhong
        void LoaiPhongClient_LoaiPhong_GetItemsCompleted(object sender, LoaiPhong_GetItemsCompletedEventArgs e)
        {
            grvLoaiPhong.ItemsSource = e.Result;
            radLoading.IsBusy = false;
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
                frmLoaiPhongEdit LoaiPhongEdit = sender as frmLoaiPhongEdit;
                if (LoaiPhongEdit.DialogResult == true)
                {
                    LoaiPhongClient.LoaiPhong_GetItemsAsync();
                }
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
        #endregion
        #region TienNghi
            /// <summary>
            /// Binding Tien Nghi
            /// </summary>
            /// <param name="sender"></param>
            /// <param name="e"></param>
            void TienNghiClient_TienNghi_GetItemsCompleted(object sender, TienNghi_GetItemsCompletedEventArgs e)
            {
                grvTienNghi.ItemsSource = e.Result;
            }
            private void cmdSuaTienNghi_Click(object sender, RoutedEventArgs e)
            {
                HyperlinkButton cmdSuaTienNghi = sender as HyperlinkButton;
                int TienNghiID = int.Parse(cmdSuaTienNghi.CommandParameter.ToString());
                frmTienNghiEdit TienNghiEdit = new frmTienNghiEdit();
                TienNghiEdit.Closed += new EventHandler(TienNghiEdit_Closed);
                TienNghiEdit.TienNghi_Load(TienNghiID);
                TienNghiEdit.Show();
            }

            void TienNghiEdit_Closed(object sender, EventArgs e)
            {
                frmTienNghiEdit TienNghiEdit = sender as frmTienNghiEdit;
                if (TienNghiEdit.DialogResult==true)
                {
                    TienNghiClient.TienNghi_GetItemsAsync();
                }                
            }

            private void cmdXoaTienNghi_Click(object sender, RoutedEventArgs e)
            {
                HyperlinkButton cmdXoaTienNghi = sender as HyperlinkButton;
                int TienNghiID = int.Parse(cmdXoaTienNghi.CommandParameter.ToString());
                MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
                if (msgResult == MessageBoxResult.OK)
                {
                    TienNghiClient.TienNghi_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(TienNghiClient_TienNghi_DeleteCompleted);
                    TienNghiClient.TienNghi_DeleteAsync(TienNghiID);
                }
            }

            void TienNghiClient_TienNghi_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
            {
                TienNghiClient.TienNghi_GetItemsAsync();
            }

            private void cmdThemTienNghi_Click(object sender, RoutedEventArgs e)
            {
                frmTienNghiEdit TienNghiEdit = new frmTienNghiEdit();
                TienNghiEdit.Closed += new EventHandler(TienNghiEdit_Closed);
                TienNghiEdit.Show();
            }
        #endregion
    }
}

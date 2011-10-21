using System;
using System.Collections.Generic;
using System.Globalization;
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
using QuanLyKhachSan.DichVuSVC;
using QuanLyKhachSan.PhongSVC;

namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmLoaiPhong : Page
    {
        private LoaiPhongSVCClient LoaiPhongClient = new LoaiPhongSVCClient();
        private TienNghiSVCClient TienNghiClient = new TienNghiSVCClient();
        private DichVuSVCClient DichVuClient = new DichVuSVCClient();
        private PhongSVCClient PhongClient = new PhongSVCClient();
        public frmLoaiPhong()
        {
            InitializeComponent();

        }
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            LoadingPanel.IsBusy = true;
            LoaiPhongClient.LoaiPhong_GetItemsCompleted += new EventHandler<LoaiPhong_GetItemsCompletedEventArgs>(LoaiPhongClient_LoaiPhong_GetItemsCompleted);
            LoaiPhongClient.LoaiPhong_GetItemsAsync();

            TienNghiClient.TienNghi_GetItemsCompleted += new EventHandler<TienNghi_GetItemsCompletedEventArgs>(TienNghiClient_TienNghi_GetItemsCompleted);
            TienNghiClient.TienNghi_GetItemsAsync();

            DichVuClient.DichVu_GetItemsCompleted += new EventHandler<DichVu_GetItemsCompletedEventArgs>(DichVuClient_DichVu_GetItemsCompleted);
            DichVuClient.DichVu_GetItemsAsync();

            PhongClient.Phong_GetItemsCompleted += new EventHandler<Phong_GetItemsCompletedEventArgs>(PhongClient_Phong_GetItemsCompleted);
            PhongClient.Phong_GetItemsAsync(0);
        }
        
        #region LoaiPhong
        void LoaiPhongClient_LoaiPhong_GetItemsCompleted(object sender, LoaiPhong_GetItemsCompletedEventArgs e)
        {
            grvLoaiPhong.ItemsSource = e.Result;
        }
        void LoaiPhongClient_LoaiPhong_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            LoaiPhongClient.LoaiPhong_GetItemsAsync();
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
        private void cmdThemLoaiPhong_Click(object sender, RoutedEventArgs e)
        {
            frmLoaiPhongEdit LoaiPhongEdit = new frmLoaiPhongEdit();
            LoaiPhongEdit.Closed += new EventHandler(LoaiPhongEdit_Closed);
            LoaiPhongEdit.Show();
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
        void TienNghiClient_TienNghi_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            TienNghiClient.TienNghi_GetItemsAsync();
        }
        void TienNghiEdit_Closed(object sender, EventArgs e)
        {
            frmTienNghiEdit TienNghiEdit = sender as frmTienNghiEdit;
            if (TienNghiEdit.DialogResult == true)
            {
                TienNghiClient.TienNghi_GetItemsAsync();
            }
        }
        private void cmdThemTienNghi_Click(object sender, RoutedEventArgs e)
        {
            frmTienNghiEdit TienNghiEdit = new frmTienNghiEdit();
            TienNghiEdit.Closed += new EventHandler(TienNghiEdit_Closed);
            TienNghiEdit.Show();
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
        #endregion
        #region DichVu
        /// <summary>
        /// Binding Dich Vu
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void DichVuClient_DichVu_GetItemsCompleted(object sender, DichVu_GetItemsCompletedEventArgs e)
        {
            grvDichVu.ItemsSource = e.Result;
        }
        void DichVuClient_DichVu_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            DichVuClient.DichVu_GetItemsAsync();
        }
        void DichVuEdit_Closed(object sender, EventArgs e)
        {
            frmDichVuEdit DichVuEdit = sender as frmDichVuEdit;
            if (DichVuEdit.DialogResult == true)
            {
                DichVuClient.DichVu_GetItemsAsync();
            }
        }
        void DichVuEditSL_Closed(object sender, EventArgs e)
        {
            frmDichVuEditSL DichVuEditSL = sender as frmDichVuEditSL;
            if (DichVuEditSL.DialogResult == true)
            {
                DichVuClient.DichVu_GetItemsAsync();
            }
        }
        private void cmdThemDichVu_Click(object sender, RoutedEventArgs e)
        {
            frmDichVuEdit DichVuEdit = new frmDichVuEdit();
            DichVuEdit.Closed += new EventHandler(DichVuEdit_Closed);
            DichVuEdit.Show();
        }
        private void cmdSuaDichVu_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaDichVu = sender as HyperlinkButton;
            int DichVuID = int.Parse(cmdSuaDichVu.CommandParameter.ToString());
            frmDichVuEdit DichVuEdit = new frmDichVuEdit();
            DichVuEdit.Closed += new EventHandler(DichVuEdit_Closed);
            DichVuEdit.DichVu_Load(DichVuID);
            DichVuEdit.Show();
        }
        private void cmdXoaDichVu_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaDichVu = sender as HyperlinkButton;
            int DichVuID = int.Parse(cmdXoaDichVu.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                DichVuClient.DichVu_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(DichVuClient_DichVu_DeleteCompleted);
                DichVuClient.DichVu_DeleteAsync(DichVuID);
            }
        }
        private void cmdThemSLTon_Click(object sender, RoutedEventArgs e)
        {
            frmDichVuEditSL DichVuEditSL = new frmDichVuEditSL();
            DichVuEditSL.Closed += new EventHandler(DichVuEditSL_Closed);
            DichVuEditSL.Show();
        }
        #endregion
        #region Phong
        void PhongClient_Phong_GetItemsCompleted(object sender, Phong_GetItemsCompletedEventArgs e)
        {
            grvPhong.ItemsSource = e.Result;
            LoadingPanel.IsBusy = false;
        }
        void PhongClient_Phong_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            PhongClient.Phong_GetItemsAsync(0);
        }
        void PhongEdit_Closed(object sender, EventArgs e)
        {
            frmPhongEdit PhongEdit = sender as frmPhongEdit;
            if (PhongEdit.DialogResult == true)
            {
                PhongClient.Phong_GetItemsAsync(0);
            }
        }
        private void grvPhong_DataLoading(object sender, Telerik.Windows.Controls.GridView.GridViewDataLoadingEventArgs e)
        {
            grvPhong.IsBusy = true;
        }
        private void grvPhong_DataLoaded(object sender, EventArgs e)
        {
            grvPhong.IsBusy = false;
        }
        private void cmdThemPhong_Click(object sender, RoutedEventArgs e)
        {
            frmPhongEdit PhongEdit = new frmPhongEdit();
            PhongEdit.Closed += new EventHandler(PhongEdit_Closed);
            PhongEdit.Phong_Load(0);
            PhongEdit.Show();
        }
        private void cmdSuaPhong_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSuaPhong = sender as HyperlinkButton;
            int PhongID = int.Parse(cmdSuaPhong.CommandParameter.ToString());
            frmPhongEdit PhongEdit = new frmPhongEdit();
            PhongEdit.Closed += new EventHandler(PhongEdit_Closed);
            PhongEdit.Phong_Load(PhongID);
            PhongEdit.Show();
        }
        private void cmdXoaPhong_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXoaPhong = sender as HyperlinkButton;
            int PhongID = int.Parse(cmdXoaPhong.CommandParameter.ToString());
            MessageBoxResult msgResult = MessageBox.Show("Bạn muốn xóa mục này", "Thông báo", MessageBoxButton.OKCancel);
            if (msgResult == MessageBoxResult.OK)
            {
                PhongClient.Phong_DeleteCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(PhongClient_Phong_DeleteCompleted);
                PhongClient.Phong_DeleteAsync(PhongID);
            }
        }
        #endregion
    }
}

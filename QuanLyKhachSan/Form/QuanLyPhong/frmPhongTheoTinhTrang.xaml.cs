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
using Telerik.Windows.Controls;
using QuanLyKhachSan.PhongSVC;
using QuanLyKhachSan.KhachHangSVC;
using QuanLyKhachSan.Form.QuanLyKhachHang;
using Telerik.Windows.Controls.GridView;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmPhongTheoTinhTrang : Page
    {
        PhongSVCClient PhongClient = new PhongSVCClient();
        KhachHangSVCClient KhachHangClient = new KhachHangSVCClient();
        public frmPhongTheoTinhTrang()
        {
            InitializeComponent();
            LoadingPanel.IsBusy = true;
            PhongClient.Phong_GetItems_ByTinhTrangCompleted += new EventHandler<Phong_GetItems_ByTinhTrangCompletedEventArgs>(PhongClient_Phong_GetItems_ByTinhTrangCompleted);
            PhongClient.Phong_GetItems_ByTinhTrangAsync();
            KhachHangClient.KhachHang_GetItemsCompleted += new EventHandler<KhachHang_GetItemsCompletedEventArgs>(KhachHangClient_KhachHang_GetItemsCompleted);
            KhachHangClient.KhachHang_GetItemsAsync(0);
        }

        void KhachHangClient_KhachHang_GetItemsCompleted(object sender, KhachHang_GetItemsCompletedEventArgs e)
        {
            grvKhachHang.ItemsSource = e.Result;
        }

        void PhongClient_Phong_GetItems_ByTinhTrangCompleted(object sender, Phong_GetItems_ByTinhTrangCompletedEventArgs e)
        {
            List<TinhTrang_PhongInfo> ListPhong = new List<TinhTrang_PhongInfo>();
            ListPhong = e.Result.ToList<TinhTrang_PhongInfo>();
            GenerateRepeateColumn(15, ListPhong);
            LoadingPanel.IsBusy = false;
        }

        protected void GenerateRepeateColumn(int RepeatedColumns,List<TinhTrang_PhongInfo> ListPhong)
        {
            int TotalItems = ListPhong.Count;
            int mod = TotalItems % RepeatedColumns;
            int Row = TotalItems / RepeatedColumns;
            if (mod > 0)
            {
                Row = Row + 1;
            }
            StackPanel pnel = null;
            pnlMain.Children.Clear();
            for (int i = 0; i < Row; i++)
            {
                pnel = new StackPanel();
                pnel.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
                pnel.Orientation = Orientation.Horizontal;
                pnel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                for (int j = 0; j < RepeatedColumns; j++)
                {
                    if (j + RepeatedColumns*i < TotalItems)
                    {
                        pnel.Children.Add(Column((ListPhong[j + RepeatedColumns*i])));   
                    }
                }
                pnlMain.Children.Add(pnel);
            }
        }
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        private void Page_Loaded(object sender, RoutedEventArgs e)
        {

            // Do not load your data at design time.
            // if (!System.ComponentModel.DesignerProperties.GetIsInDesignMode(this))
            // {
            // 	//Load your data here and assign the result to the CollectionViewSource.
            // 	System.Windows.Data.CollectionViewSource myCollectionViewSource = (System.Windows.Data.CollectionViewSource)this.Resources["Resource Key for CollectionViewSource"];
            // 	myCollectionViewSource.Source = your data
            // }
        }
        //customize info repeated column
        //CornerRadius="5" BorderBrush="Black" Cursor="Hand"  Background="White" BorderThickness="1" Width="50" Height="50" Margin="5" HorizontalAlignment="Center" VerticalAlignment="Center">        
        private Border Column(TinhTrang_PhongInfo item)
        {
            Border retBorder = new Border();
            retBorder.CornerRadius = new CornerRadius(5);
            retBorder.BorderBrush = new SolidColorBrush(Colors.Black);            
            switch (item.TinhTrangPhongID)
            { 
                case 1://còn trống
                    retBorder.Background = new SolidColorBrush(Colors.White);
                    RadContextMenu.SetContextMenu(retBorder, TinyMenu(item));
                    break;
                case 2://đã đặt
                    retBorder.Background = new SolidColorBrush(Colors.Brown);
                    RadContextMenu.SetContextMenu(retBorder, CustomMenu(item));
                    break;
                case 3://đang ở
                    retBorder.Background = new SolidColorBrush(Colors.Green);
                    RadContextMenu.SetContextMenu(retBorder, FullMenu(item));
                    break;
                case 4://cần sửa
                    retBorder.Background = new SolidColorBrush(Colors.Red);
                    RadContextMenu.SetContextMenu(retBorder, TinyMenu(item));
                    break;
                case 5://chưa dọn
                    retBorder.Background = new SolidColorBrush(Colors.Yellow);
                    RadContextMenu.SetContextMenu(retBorder, TinyMenu(item));
                    break;
                case 6://Rời phòng
                    retBorder.Background = new SolidColorBrush(Colors.Purple);
                    RadContextMenu.SetContextMenu(retBorder, TinyMenu(item));
                    break;
            }
            
            retBorder.Cursor = Cursors.Hand;
            retBorder.BorderThickness = new Thickness(1);
            retBorder.Width = 50;
            retBorder.Height = 50;
            retBorder.Margin = new Thickness(5);
            retBorder.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            retBorder.VerticalAlignment = System.Windows.VerticalAlignment.Center;            
            TextBlock txtContent = new TextBlock();
            txtContent.Text = item.PhongName;
            txtContent.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            txtContent.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            txtContent.FontWeight = FontWeights.Bold;
            
            retBorder.Child = txtContent;
            return retBorder;
        }
        private RadContextMenu CustomMenu(TinhTrang_PhongInfo item)
        {
            RadContextMenu retContextMenu = new RadContextMenu();
            retContextMenu.Cursor = Cursors.Hand;
            retContextMenu.EventName = "MouseLeftButtonUp";
            retContextMenu.IconColumnWidth = 0;
            StyleManager.SetTheme(retContextMenu, new Office_BlueTheme());
            RadMenuItem menuItem = null;
            menuItem = new RadMenuItem();
            menuItem.Tag = "ThongTinPhong";
            menuItem.CommandParameter = item;
            menuItem.Header = "Thông tin phòng";
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Header = "Danh sách khách hàng";
            menuItem.Tag = "DanhSachKhachHang";
            menuItem.CommandParameter = item;
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Header = "Danh sách đặt phòng";
            menuItem.Tag = "DanhSachDatPhong";
            menuItem.CommandParameter = item;
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            return retContextMenu;
        }
        private RadContextMenu TinyMenu(TinhTrang_PhongInfo item)
        {
            RadContextMenu retContextMenu = new RadContextMenu();
            retContextMenu.Cursor = Cursors.Hand;
            retContextMenu.EventName = "MouseLeftButtonUp";
            retContextMenu.IconColumnWidth = 0;
            StyleManager.SetTheme(retContextMenu, new Office_BlueTheme());
            RadMenuItem menuItem = null;
            menuItem = new RadMenuItem();
            menuItem.Tag = "ThongTinPhong";
            menuItem.CommandParameter = item;
            menuItem.Header = "Thông tin phòng";
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            return retContextMenu;
        }

        void menuItem_Click(object sender, Telerik.Windows.RadRoutedEventArgs e)
        {
            RadMenuItem menuItem = sender as RadMenuItem;
            TinhTrang_PhongInfo item = menuItem.CommandParameter as TinhTrang_PhongInfo;
            switch (menuItem.Tag.ToString())
            { 
                case "ThongTinPhong":
                    frmChiTietPhong ChiTietPhong = new frmChiTietPhong();
                    ChiTietPhong.Closed += new EventHandler(ChiTietPhong_Closed);
                    ChiTietPhong.Show();
                    ChiTietPhong.Phong_Load(item.PhongID,item.TinhTrangPhongID);
                    break;
                case "DanhSachKhachHang":
                    frmPhong_KhachHang_NhanPhong DanhSachKhachHang_NhanPhong = new frmPhong_KhachHang_NhanPhong();
                    DanhSachKhachHang_NhanPhong.Title = "Danh sách khách hàng phòng " + item.PhongName;
                    DanhSachKhachHang_NhanPhong.Phong_KhachHang_Load(item.HoaDonID, item.PhongID);
                    DanhSachKhachHang_NhanPhong.Show();
                    break;
                case "DanhSachDatPhong":
                    frmPhong_KhachHang_DatPhong DanhSachKhachHang_DatPhong = new frmPhong_KhachHang_DatPhong();
                    DanhSachKhachHang_DatPhong.Title = "Danh sách khách hàng đặt phòng " + item.PhongName;
                    DanhSachKhachHang_DatPhong.Phong_KhachHang_DatPhong_Load(item.HoaDonID, item.PhongID);
                    DanhSachKhachHang_DatPhong.Show();
                    break;
            }

        }

        void ChiTietPhong_Closed(object sender, EventArgs e)
        {
            frmChiTietPhong ChiTietPhong = sender as frmChiTietPhong;
            if (ChiTietPhong.DialogResult == true)
            {
                PhongClient.Phong_GetItems_ByTinhTrangAsync();
            }
        }
        private RadContextMenu FullMenu( TinhTrang_PhongInfo item )
        {
            RadContextMenu retContextMenu = new RadContextMenu();            
            retContextMenu.Cursor = Cursors.Hand;
            retContextMenu.EventName = "MouseLeftButtonUp";
            retContextMenu.IconColumnWidth = 0;
            StyleManager.SetTheme(retContextMenu, new Office_BlueTheme());
            RadMenuItem menuItem = null;
            menuItem = new RadMenuItem();
            menuItem.Header = "Thông tin phòng";
            menuItem.Tag = "ThongTinPhong";
            menuItem.CommandParameter = item;
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Header = "Danh sách khách hàng";
            menuItem.Tag = "DanhSachKhachHang";
            menuItem.CommandParameter = item;
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Header = "Danh sách đặt phòng";
            menuItem.Tag = "DanhSachDatPhong";
            menuItem.CommandParameter = item;
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Tag = "XemThemDichVu";
            menuItem.CommandParameter = item;
            menuItem.Header = "Xem/Thêm dịch vụ";
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Tag = "ChuyenPhong";
            menuItem.CommandParameter = item;
            menuItem.Header = "Chuyển phòng";
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Tag = "CapNhatNgayRaDuTinh";
            menuItem.CommandParameter = item ;
            menuItem.Header = "Cập nhật ngày ra dự tính";
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            menuItem = new RadMenuItem();
            menuItem.Tag = "TraPhong";
            menuItem.CommandParameter = item;
            menuItem.Header = "Trả phòng";
            menuItem.Click += new Telerik.Windows.RadRoutedEventHandler(menuItem_Click);
            retContextMenu.Items.Add(menuItem);
            return retContextMenu;
        }
        #region KhachHang
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
        void KhachHangClient_KhachHang_DeleteCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            KhachHangClient.KhachHang_GetItemsAsync(0);
        }
        #endregion
        #region DatPhong
        private void cmdThucHien_Click(object sender, RoutedEventArgs e)
        {
            var cells = grvKhachHang.ChildrenOfType<GridViewCell>().Where(c => c.Column.UniqueName == "HoTen").ToList();
            //cells.ForEach(c => c.ChildrenOfType<CheckBox>().First().IsChecked = true);
            List<KhachHangInfo> listKhachHang = new List<KhachHangInfo>();
            for (int i = 0; i < cells.Count; i++)
            {
                CheckBox cbx = cells[i].ChildrenOfType<CheckBox>().First();
                if (cbx.IsChecked == true)
                {
                    KhachHangInfo item = cbx.CommandParameter as KhachHangInfo;
                    listKhachHang.Add(item);
                }
            }
            if (listKhachHang.Count == 0)
            {
                MessageBox.Show("Vui lòng chọn khách hàng trước khi thao tác!");                
            }
            else
            {
                RadComboBoxItem SelectedItem = cbxThaoTac.SelectedValue as RadComboBoxItem;
                if (SelectedItem.Tag.ToString() == "0")
                {
                    frmDatPhong DatPhong = new frmDatPhong();
                    DatPhong.KhachHang_Load(listKhachHang);
                    DatPhong.Closed += new EventHandler(DatPhong_Closed);
                    DatPhong.Show();
                }
                else if (SelectedItem.Tag.ToString() == "1")
                {
                    frmNhanPhong NhanPhong = new frmNhanPhong();
                    NhanPhong.KhachHang_Load(listKhachHang);
                    NhanPhong.Closed += new EventHandler(NhanPhong_Closed);
                    NhanPhong.Show();
                }
                else if (SelectedItem.Tag.ToString() == "2")
                {

                }
            }
        }

        void NhanPhong_Closed(object sender, EventArgs e)
        {
            frmNhanPhong NhanPhong = sender as frmNhanPhong;
            if (NhanPhong.DialogResult == true)
            {
                PhongClient.Phong_GetItems_ByTinhTrangAsync();
            }
        }

        void DatPhong_Closed(object sender, EventArgs e)
        {
            frmDatPhong DatPhong = sender as frmDatPhong;
            if (DatPhong.DialogResult == true)
            {
                PhongClient.Phong_GetItems_ByTinhTrangAsync();
            }
        }
        #endregion
    }
}

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
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmPhongTheoTinhTrang : Page
    {
        PhongSVCClient PhongClient = new PhongSVCClient();
        public frmPhongTheoTinhTrang()
        {
            InitializeComponent();
            LoadingPanel.IsBusy = true;
            PhongClient.Phong_GetItems_ByTinhTrangCompleted += new EventHandler<Phong_GetItems_ByTinhTrangCompletedEventArgs>(PhongClient_Phong_GetItems_ByTinhTrangCompleted);
            PhongClient.Phong_GetItems_ByTinhTrangAsync();

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
                case 1:
                    retBorder.Background = new SolidColorBrush(Colors.White);
                    RadContextMenu.SetContextMenu(retBorder, TinyMenu(item));
                    break;
                case 2:
                    retBorder.Background = new SolidColorBrush(Colors.Green);
                    RadContextMenu.SetContextMenu(retBorder, FullMenu(item));
                    break;
                case 4:
                    retBorder.Background = new SolidColorBrush(Colors.Red);
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
            MessageBox.Show(menuItem.Tag.ToString() + "_" + item.PhongID);
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
    }
}

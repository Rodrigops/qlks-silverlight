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
using QuanLyKhachSan.PhongSVC;
using QuanLyKhachSan.Gio_PhongSVC;
using QuanLyKhachSan.Ngay_PhongSVC;
using QuanLyKhachSan.Nguoi_PhongSVC;
using Telerik.Windows.Controls;
using Telerik.Windows.Controls.GridView;
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmCaiDatGia : Page
    {
        public int PhongID = -1;
        public int GioPhongNextID = -1;
        public int NguoiPhongNextID = -1;

        PhongSVCClient PhongClient = new PhongSVCClient();
        Gio_PhongSVCClient Gio_PhongClient = new Gio_PhongSVCClient();
        Ngay_PhongSVCClient Ngay_PhongClient = new Ngay_PhongSVCClient();
        Nguoi_PhongSVCClient Nguoi_PhongClient = new Nguoi_PhongSVCClient();
        public frmCaiDatGia()
        {
            InitializeComponent();
            PhongClient.Phong_GetItemsCompleted += new EventHandler<Phong_GetItemsCompletedEventArgs>(PhongClient_Phong_GetItemsCompleted);
            LoadingPanel.IsBusy = true;
            PhongClient.Phong_GetItemsAsync(0);
            Gio_Phong_Load();
            Nguoi_Phong_Load();
        }
        void PhongClient_Phong_GetItemsCompleted(object sender, Phong_GetItemsCompletedEventArgs e)
        {
            List<PhongInfo> ListPhong = new List<PhongInfo>();
            ListPhong = e.Result.ToList<PhongInfo>();
            GenerateRepeateColumn(12, ListPhong);
            LoadingPanel.IsBusy = false;
        }
        void Gio_PhongClient_Gio_Phong_GetItemByPhongIDCompleted(object sender, Gio_Phong_GetItemByPhongIDCompletedEventArgs e)
        {
            //Gio_PhongInfo Gio_Phong = e.Result;
            grvTheoGio.ItemsSource = e.Result;

            List<Gio_PhongInfo> Gio_Phong = e.Result;
            List<Gio_PhongInfo> Gio_PhongNew = new List<Gio_PhongInfo>();
            Gio_PhongInfo Item = null;
            if (Gio_Phong.Count > 0)
            {
                for (int i = 0; i < Gio_Phong.Count; i++)
                {
                    Item = new Gio_PhongInfo();
                    Item.Gio_PhongID = Gio_Phong[i].Gio_PhongID;
                    Item.GiaTien = Gio_Phong[i].GiaTien;
                    Item.GioPhongName = Gio_Phong[i].GioPhongName;
                    Item.GiaTien = Gio_Phong[i].GiaTien;
                    Item.PhanTram = Gio_Phong[i].PhanTram;
                    if (i == 0)
                        Item.ImageUrl = "Thêm";
                    else
                        Item.ImageUrl = "Xóa";
                    Gio_PhongNew.Add(Item);
                }
                grvTheoGio.ItemsSource = Gio_PhongNew;
            }
        }
        void Ngay_PhongClient_Ngay_Phong_GetItemByPhongIDCompleted(object sender, Ngay_Phong_GetItemByPhongIDCompletedEventArgs e)
        {
            Ngay_PhongInfo Ngay_Phong = e.Result;

            txtTheoNgay.Text = Format_NumberVietnamese(Ngay_Phong.GiaNgay.ToString());
            txtTheoTuan.Text = Format_NumberVietnamese(Ngay_Phong.GiaTuan.ToString());
            txtTheoThang.Text = Format_NumberVietnamese(Ngay_Phong.GiaThang.ToString());
        }
        void Nguoi_PhongClient_Nguoi_Phong_GetItemByPhongIDCompleted(object sender, Nguoi_Phong_GetItemByPhongIDCompletedEventArgs e)
        {
            List<Nguoi_PhongInfo> Nguoi_Phong = e.Result;
            List<Nguoi_PhongInfo> Nguoi_PhongNew = new List<Nguoi_PhongInfo>();
            foreach (Nguoi_PhongInfo item in Nguoi_Phong)
            {
                if (item.status.Trim().Equals("GiaCuoi"))
                    txtCongThem.Text = item.CongThem;
                else
                {
                    item.ImageUrl = "Thêm";
                    Nguoi_PhongNew.Add(item);
                }
            }
            grvTheoSoNguoi.ItemsSource = Nguoi_PhongNew;
        }
        protected void GenerateRepeateColumn(int RepeatedColumns, List<PhongInfo> ListPhong)
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
                pnel.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
                pnel.Orientation = Orientation.Horizontal;
                for (int j = 0; j < RepeatedColumns; j++)
                {
                    if (j + RepeatedColumns*i < TotalItems)
                    {
                        pnel.Children.Add(Column((ListPhong[j + RepeatedColumns * i])));
                    }
                }
                pnlMain.Children.Add(pnel);
            }
        }
        private StackPanel Column(PhongInfo item)
        {
            StackPanel retBorder = new StackPanel();
            retBorder.Orientation = Orientation.Vertical;
            retBorder.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            retBorder.Cursor = Cursors.Hand;
            retBorder.Margin = new Thickness(20,10,0,15);
            retBorder.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            retBorder.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            CheckBox cbx = new CheckBox();
            cbx.Name = item.PhongID.ToString();
            cbx.CommandParameter = item;
            TextBlock txtContent = new TextBlock();
            txtContent.FontSize = 14;
            txtContent.Text = item.PhongName;
            txtContent.VerticalAlignment = System.Windows.VerticalAlignment.Center;
            txtContent.HorizontalAlignment = System.Windows.HorizontalAlignment.Center;
            txtContent.FontWeight = FontWeights.Bold;
            StackPanel Row0 = new StackPanel();
            Row0.Orientation = Orientation.Horizontal;
            Row0.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            Row0.Children.Add(cbx);
            Row0.Children.Add(txtContent);
            StackPanel Row1 = new StackPanel();
            Row1.Orientation = Orientation.Horizontal;
            Row1.HorizontalAlignment = System.Windows.HorizontalAlignment.Left;
            HyperlinkButton cmdXem = new HyperlinkButton();
            cmdXem.Content = "[xem]";
            cmdXem.CommandParameter = item;
            cmdXem.Click += new RoutedEventHandler(cmdXem_Click);
            HyperlinkButton cmdSua = new HyperlinkButton();
            cmdSua.Content = "[sửa]";
            cmdSua.CommandParameter = item;
            cmdSua.Click += new RoutedEventHandler(cmdSua_Click);
            Row1.Children.Add(cmdXem);
            Row1.Children.Add(cmdSua);
            retBorder.Children.Add(Row0);
            retBorder.Children.Add(Row1);
            return retBorder;
        }
        IEnumerable<DependencyObject> GetCheckBoxControls(DependencyObject root)
        {
            List<DependencyObject> doList = new List<DependencyObject>();
            doList.Add(root);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(root); i++)
                doList.AddRange(GetCheckBoxControls(VisualTreeHelper.GetChild(root, i)));

            return doList;
        }
        public string Format_NumberVietnamese(string Gia)
        {
            try
            {
                if (Gia.IndexOf("%") > 0 || Gia == "")
                {
                    return Gia;
                }
                else
                {
                    decimal value = decimal.Parse(Gia);
                    string retGia = value.ToString("N", System.Globalization.CultureInfo.CurrentCulture);
                    return retGia.Replace(".00", "");
                }
            }
            catch (Exception)
            {
                throw;
            }
        }
        void GetData(int PhongID)
        {
            Gio_PhongClient.Gio_Phong_GetItemByPhongIDCompleted += new EventHandler<Gio_Phong_GetItemByPhongIDCompletedEventArgs>(Gio_PhongClient_Gio_Phong_GetItemByPhongIDCompleted);
            Gio_PhongClient.Gio_Phong_GetItemByPhongIDAsync(PhongID);

            Ngay_PhongClient.Ngay_Phong_GetItemByPhongIDCompleted += new EventHandler<Ngay_Phong_GetItemByPhongIDCompletedEventArgs>(Ngay_PhongClient_Ngay_Phong_GetItemByPhongIDCompleted);
            Ngay_PhongClient.Ngay_Phong_GetItemByPhongIDAsync(PhongID);

            Nguoi_PhongClient.Nguoi_Phong_GetItemByPhongIDCompleted += new EventHandler<Nguoi_Phong_GetItemByPhongIDCompletedEventArgs>(Nguoi_PhongClient_Nguoi_Phong_GetItemByPhongIDCompleted);
            Nguoi_PhongClient.Nguoi_Phong_GetItemByPhongIDAsync(PhongID);
            LoadingPanel.IsBusy = false;
        }
        void cmdSua_Click(object sender, RoutedEventArgs e)
        {
            LoadingPanel.IsBusy = true;
            HyperlinkButton cmdSua = sender as HyperlinkButton;
            PhongInfo item  = cmdSua.CommandParameter as PhongInfo;
            var cbxs = GetCheckBoxControls(LayoutRoot).OfType<CheckBox>();
            foreach (var i in cbxs)
            {
                CheckBox cbx = i as CheckBox;
                if (cbx.Name == item.PhongID.ToString())
                {
                    GetData(item.PhongID);
                    cbx.IsChecked = true;
                }
                else
                {
                    cbx.IsChecked = false;
                }
            }
            cmdCapNhat.Visibility = System.Windows.Visibility.Visible;
        }
        void cmdXem_Click(object sender, RoutedEventArgs e)
        {
            LoadingPanel.IsBusy = true;
            HyperlinkButton cmdXem = sender as HyperlinkButton;
            PhongInfo item = cmdXem.CommandParameter as PhongInfo;
            var cbxs = GetCheckBoxControls(LayoutRoot).OfType<CheckBox>();
            foreach (var i in cbxs)
            {
                CheckBox cbx = i as CheckBox;
                if(cbx.Name == item.PhongID.ToString())
                {
                    
                    GetData(item.PhongID);
                    cbx.IsChecked = true;
                }
                else
                {
                    cbx.IsChecked = false;
                }
            }
            cmdCapNhat.Visibility = System.Windows.Visibility.Collapsed;
        }
        private void cmdCapNhat_Click(object sender, RoutedEventArgs e)
        {
            //Gio_Phong_Add
            string ListPhongID = "";
            string ListGioPhongName = "";
            int PhanTram = 0;
            string ListGiaTien = "";
            string Status = "";
            //ListPhongID
            var cbxs = GetCheckBoxControls(LayoutRoot).OfType<CheckBox>();
            PhongInfo item = null;
            foreach (var i in cbxs)
            {
                CheckBox cbx = i as CheckBox;
                item = cbx.CommandParameter as PhongInfo;
                if (cbx.IsChecked == true)
                {
                    ListPhongID += item.PhongID.ToString() + ";";
                }
            }
            //ListGioPhongName
            for (int i = 0; i < grvTheoGio.Items.Count; i++)
            {
                Gio_PhongInfo Gio_Phong = (Gio_PhongInfo)grvTheoGio.Items[i];
                string GioPhongName = Gio_Phong.GioPhongName;
                decimal GiaTien = Gio_Phong.GiaTien;
                if (GioPhongName != "")
                {
                    ListGioPhongName += GioPhongName + ";";
                    ListGiaTien += GiaTien + ";";
                }
            }
            Gio_PhongClient.Gio_Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(Gio_PhongClient_Gio_Phong_AddCompleted);
            Gio_PhongClient.Gio_Phong_AddAsync(ListPhongID, ListGioPhongName, PhanTram, ListGiaTien, Status);
            //Ngay_Phong_Add
            decimal GiaNgay = decimal.Parse(txtTheoNgay.Text.ToString() == "" ? "0" : txtTheoNgay.Text.ToString());
            decimal GiaTuan = decimal.Parse(txtTheoTuan.Text.ToString() == "" ? "0" : txtTheoTuan.Text.ToString());
            decimal GiaThang = decimal.Parse(txtTheoThang.Text.ToString() == "" ? "0" : txtTheoThang.Text.ToString());
            Ngay_PhongClient.Ngay_Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(Ngay_PhongClient_Ngay_Phong_AddCompleted);
            Ngay_PhongClient.Ngay_Phong_AddAsync(ListPhongID, GiaNgay, GiaTuan, GiaThang);
            //Nguoi_Phong_Add
            string ListNguoiPhongName = "";
            string ListCongThem = "";
            string CongThemTiepTheo = txtCongThem.Text == "" ? "0%" : txtCongThem.Text;
            for (int i = 0; i < grvTheoSoNguoi.Items.Count; i++)
            {
                Nguoi_PhongInfo Nguoi_Phong = (Nguoi_PhongInfo)grvTheoSoNguoi.Items[i];
                string Them = Nguoi_Phong.NguoiPhongName;
                string Cong = Nguoi_Phong.CongThem;
                if (Them != "")
                {
                    ListNguoiPhongName += Them + ";";
                    ListCongThem += Cong + ";";
                }
            }
            Nguoi_PhongClient.Nguoi_Phong_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(Nguoi_PhongClient_Nguoi_Phong_AddCompleted);
            Nguoi_PhongClient.Nguoi_Phong_AddAsync(ListPhongID, ListNguoiPhongName, ListCongThem, CongThemTiepTheo);
        }
        void Gio_PhongClient_Gio_Phong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
        }
        void Ngay_PhongClient_Ngay_Phong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
        }
        void Nguoi_PhongClient_Nguoi_Phong_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            MessageBox.Show("Cập nhật hoàn thành", "Thông Báo", MessageBoxButton.OK);
        }
        protected void Nguoi_Phong_Load()
        {
            try
            {
                //Tao Du Lieu Trong
                List<Nguoi_PhongInfo> GioPhong = new List<Nguoi_PhongInfo>();
                Nguoi_PhongInfo Item = new Nguoi_PhongInfo();
                Item.Nguoi_PhongID = 1;
                Item.NguoiPhongName = "1";
                Item.GiaTien = 0;
                Item.PhanTram = 0;
                Item.CongThem = "";
                Item.ImageUrl = "Thêm";
                GioPhong.Add(Item);
                NguoiPhongNextID = 2;
                grvTheoSoNguoi.ItemsSource = GioPhong;
            }
            catch (Exception)
            {
                throw;
            }
        }
        protected void Gio_Phong_Load()
        {
            try
            {
                //Tao Du Lieu Trong
                List<Gio_PhongInfo> GioPhong = new List<Gio_PhongInfo>();
                Gio_PhongInfo Item = new Gio_PhongInfo();
                Item.Gio_PhongID = 1;
                Item.GioPhongName = "1";
                Item.GiaTien = 0;
                Item.PhanTram = 0;
                Item.ImageUrl = "Thêm";
                GioPhong.Add(Item);
                GioPhongNextID = 2;
                grvTheoGio.ItemsSource = GioPhong;
            }
            catch (Exception)
            {
                throw;
            }
        }
        private void cmdThemGioPhong_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HyperlinkButton cmdThemGioPhong = (HyperlinkButton)sender;
                List<Gio_PhongInfo> ListGioPhong = new List<Gio_PhongInfo>();
                ListGioPhong = (List<Gio_PhongInfo>)grvTheoGio.ItemsSource;
                
                //add new row
                int Gio_PhongID = 0;
                Gio_PhongInfo GioPhong = null;
                if (cmdThemGioPhong.Content.Equals("Thêm"))
                {
                    if (GioPhongNextID != -1)
                    {
                        Gio_PhongID = GioPhongNextID;
                    }
                    GioPhong = new Gio_PhongInfo();
                    GioPhong.Gio_PhongID = Gio_PhongID;
                    GioPhong.GiaTien = 0;
                    GioPhong.GioPhongName = "";
                    GioPhong.ImageUrl = "Xóa";
                    ListGioPhong.Add(GioPhong);
                }
                else
                {
                    Gio_PhongID = int.Parse(cmdThemGioPhong.CommandParameter.ToString());
                    for (int i = 0; i < ListGioPhong.Count; i++)
                    {
                        if (ListGioPhong[i].Gio_PhongID == Gio_PhongID)
                        {
                            ListGioPhong.RemoveAt(i);
                            break;
                        }
                    }
                }
                GioPhongNextID = Gio_PhongID + 1;
                grvTheoGio.ItemsSource = null;
                grvTheoGio.ItemsSource = ListGioPhong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void cmdThemNguoiPhong_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                HyperlinkButton cmdThemNguoiPhong = (HyperlinkButton)sender;
                List<Nguoi_PhongInfo> ListNguoiPhong = new List<Nguoi_PhongInfo>();
                ListNguoiPhong = (List<Nguoi_PhongInfo>)grvTheoSoNguoi.ItemsSource;

                //add new row
                int Nguoi_PhongID = 0;
                Nguoi_PhongInfo NguoiPhong = null;
                if (cmdThemNguoiPhong.Content.Equals("Thêm"))
                {
                    if (NguoiPhongNextID != -1)
                    {
                        Nguoi_PhongID = NguoiPhongNextID;
                    }
                    NguoiPhong = new Nguoi_PhongInfo();
                    NguoiPhong.Nguoi_PhongID = Nguoi_PhongID;
                    NguoiPhong.NguoiPhongName = "";
                    NguoiPhong.CongThem = "";
                    NguoiPhong.ImageUrl = "Xóa";
                    ListNguoiPhong.Add(NguoiPhong);
                }
                else
                {
                    Nguoi_PhongID = int.Parse(cmdThemNguoiPhong.CommandParameter.ToString());
                    for (int i = 0; i < ListNguoiPhong.Count; i++)
                    {
                        if (ListNguoiPhong[i].Nguoi_PhongID == Nguoi_PhongID)
                        {
                            ListNguoiPhong.RemoveAt(i);
                            break;
                        }
                    }
                }
                NguoiPhongNextID = Nguoi_PhongID + 1;
                grvTheoSoNguoi.ItemsSource = null;
                grvTheoSoNguoi.ItemsSource = ListNguoiPhong;
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Number_KeyDown(object sender, KeyEventArgs e)
        {
            {
                if (((e.Key > Key.D0 && e.Key <= Key.D9) || (e.Key >= Key.NumPad0 && e.Key <= Key.NumPad9) || e.Key == Key.Back || e.Key == Key.Tab))
                    e.Handled = false;
                else
                    e.Handled = true;
            }
        }
    }
}

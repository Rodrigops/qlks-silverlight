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
using QuanLyKhachSan.KhachHangSVC;
using Telerik.Windows.Controls;
using System.Collections.ObjectModel;
using System.Windows.Data;
using QuanLyKhachSan.PhongSVC;
using QuanLyKhachSan.HoaDonSVC;
using QuanLyKhachSan.HoaDon_KhachHangSVC;
namespace QuanLyKhachSan.Form.QuanLyKhachHang
{
    public partial class frmDatPhong : ChildWindow
    {
        public frmDatPhong()
        {
            InitializeComponent();
        }

        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            //Tao Hoa Don
            HoaDonSVCClient HoaDonClient = new HoaDonSVCClient();
            HoaDonClient.HoaDon_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDonClient_HoaDon_AddCompleted);
            HoaDonClient.HoaDon_AddAsync(1);            
        }

        void HoaDonClient_HoaDon_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            HoaDon_KhachHangSVCClient HoaDon_KhachHangClient = new HoaDon_KhachHangSVCClient();
            HoaDon_KhachHangClient.HoaDon_KhachHang_AddCompleted += new EventHandler<System.ComponentModel.AsyncCompletedEventArgs>(HoaDon_KhachHangClient_HoaDon_KhachHang_AddCompleted);
            PhongSVCClient PhongClient = new PhongSVCClient();

            RadComboBox cbxPhong = null;
            RadDatePicker calNgayDen = null;
            RadComboBox cbxGioDen = null;
            RadComboBox cbxPhutDen = null;
            RadDatePicker calNgayDi = null;
            RadComboBox cbxGioDi = null;
            try
            {
                int PhongID;
                string sNgayBatDau = "";
                int iGioBatDau;
                int iPhutBatDau;
                int iNgayBatDau_So;
                int iThangBatDau;
                int iNamBatDau;
                string sNgayKetThuc = "";
                List<PhongInfo> phongAdded = new List<PhongInfo>();
                PhongInfo itemAdd = null;
                bool isExist;
                foreach (KhachHangInfo item in listKhachHang)
                {
                    cbxPhong = (RadComboBox)LayoutRoot.FindName("cbxPhong" + item.KhachHangID);
                    calNgayDen = (RadDatePicker)LayoutRoot.FindName("calNgayDen" + item.KhachHangID);
                    cbxGioDen = (RadComboBox)LayoutRoot.FindName("cbxGioDen" + item.KhachHangID);
                    cbxPhutDen = (RadComboBox)LayoutRoot.FindName("cbxPhutDen" + item.KhachHangID);
                    calNgayDi = (RadDatePicker)LayoutRoot.FindName("calNgayDi" + item.KhachHangID);
                    cbxGioDi = (RadComboBox)LayoutRoot.FindName("cbxGioDi" + item.KhachHangID);
                    PhongID = int.Parse(cbxPhong.SelectedValue.ToString());                    
                    if (!String.IsNullOrEmpty(calNgayDen.SelectedDate.ToString()))
                        sNgayBatDau = calNgayDen.SelectedDate.Value.ToString("MM/dd/yyyy");

                    iGioBatDau =int.Parse(cbxGioDen.SelectedValue.ToString().Replace("h",""));
                    iPhutBatDau = int.Parse(cbxPhutDen.SelectedValue.ToString());
                    iNgayBatDau_So =  DateToNumberConverter.Date2Number(sNgayBatDau) ;
                    iThangBatDau = DateToNumberConverter.Date2Month(sNgayBatDau);
                    iNamBatDau = DateToNumberConverter.Date2Year(sNgayBatDau);
                    if (!String.IsNullOrEmpty(calNgayDi.SelectedDate.ToString()))
                        sNgayKetThuc = calNgayDi.SelectedDate.Value.ToString("MM/dd/yyyy");
                    HoaDon_KhachHangClient.HoaDon_KhachHang_AddAsync(item.KhachHangID, PhongID, sNgayBatDau, iGioBatDau, iPhutBatDau, iNgayBatDau_So, iThangBatDau, iNamBatDau, sNgayKetThuc);
                    //
                    isExist =false;
                    foreach (PhongInfo phong in phongAdded)
                    {
                        if (phong.PhongID == PhongID)
                        {
                            isExist = true;
                            break;
                        }
                    }
                    if (isExist == false)
                    {
                        itemAdd = new PhongInfo();
                        itemAdd.PhongID = PhongID;
                        phongAdded.Add(itemAdd);
                        PhongClient.TinhTrang_Phong_AddAsync(PhongID, 3, iNgayBatDau_So);
                    }
                    
                }
                this.DialogResult=true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }     
        }

        void HoaDon_KhachHangClient_HoaDon_KhachHang_AddCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            
            
        }
        IEnumerable<DependencyObject> GetCheckBoxControls(DependencyObject root)
        {
            List<DependencyObject> doList = new List<DependencyObject>();
            doList.Add(root);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(root); i++)
                doList.AddRange(GetCheckBoxControls(VisualTreeHelper.GetChild(root, i)));

            return doList;
        }
        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
        public List<KhachHangInfo> listKhachHang = null;
        public void Load_DanhSach(List<KhachHangInfo> _listKhachHang)
        {
            listKhachHang = _listKhachHang;
           PhongSVCClient PhongClient = new PhongSVCClient();
           PhongClient.Phong_GetItems_ByTinhTrangCompleted += new EventHandler<Phong_GetItems_ByTinhTrangCompletedEventArgs>(PhongClient_Phong_GetItems_ByTinhTrangCompleted);
           PhongClient.Phong_GetItems_ByTinhTrangAsync();
        }

        void PhongClient_Phong_GetItems_ByTinhTrangCompleted(object sender, Phong_GetItems_ByTinhTrangCompletedEventArgs e)
        {
            List<TinhTrang_PhongInfo> listPhong = e.Result.ToList<TinhTrang_PhongInfo>();
            foreach (KhachHangInfo item in listKhachHang)
            {
                stackKhachHang.Children.Add(AddNewRow(item, listPhong));
            }
        }       

        private void grvDanhSachDatPhong_DataLoaded(object sender, EventArgs e)
        {
           
        }

        void PhongClient_Phong_GetItemsCompleted(object sender, Phong_GetItemsCompletedEventArgs e)
        {
            
        }
        //generate Grid.FromArgb("B3D0F3")
        private Border AddNewRow(KhachHangInfo item, List<TinhTrang_PhongInfo> listPhong)
        {
            Border retBorder = new Border();
            retBorder.Background = new SolidColorBrush(Colors.White);
            retBorder.BorderBrush = new SolidColorBrush(Color.FromArgb(179,179, 208, 243));
            retBorder.BorderThickness = new Thickness(1);
            //-------------------------------------------------o
            StackPanel stackPnl = new StackPanel();
            stackPnl.Orientation = Orientation.Horizontal;
            TextBlock txtTenKhachHang = new TextBlock();

            RadComboBox cbxPhong = new RadComboBox();
            RadDatePicker calNgayDen = new RadDatePicker();
            RadComboBox cbxGioDen = new RadComboBox();
            RadComboBox cbxPhutDen = new RadComboBox();

            RadDatePicker calNgayDi = new RadDatePicker();
            RadComboBox cbxGioDi = new RadComboBox();
            HyperlinkButton cmdXoa = new HyperlinkButton();
            txtTenKhachHang.Name = "txtTenKhachHang" + item.KhachHangID;
            txtTenKhachHang.Width = 200;
            txtTenKhachHang.Text = item.HoTen;

            cbxPhong.Name = "cbxPhong" + +item.KhachHangID;
            cbxPhong.ItemsSource = listPhong;
            cbxPhong.DisplayMemberPath = "TinhTrangPhongName";
            cbxPhong.SelectedValuePath = "PhongID";
            cbxPhong.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Left;
            cbxPhong.Width = 120;

            calNgayDen.Name = "calNgayDen" + item.KhachHangID;
            calNgayDen.Width = 100;
            calNgayDen.Culture = new System.Globalization.CultureInfo("vi-VN");
            calNgayDen.DateTimeWatermarkContent = "Chọn ngày";
            calNgayDen.SelectedValue = DateTime.Now;

            cbxGioDen.Name = "cbxGioDen" + item.KhachHangID;
            cbxGioDen.ItemsSource = "0h 1h 2h 3h 4h 5h 6h 7h 8h 9h 10h 11h 12h 13h 14h 15h 16h 17h 18h 19h 20h 21h 22h 23h".Split();
            cbxGioDen.SelectedValue = "12h";
            cbxGioDen.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            cbxGioDen.Width = 50;

            cbxPhutDen.Name = "cbxPhutDen" + item.KhachHangID;
            cbxPhutDen.ItemsSource = "0 5 10 15 20 25 30 35 40 45 50 55".Split();
            cbxPhutDen.SelectedValue = "0";
            cbxPhutDen.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            cbxPhutDen.Width = 50;

            calNgayDi.Name = "calNgayDi" + item.KhachHangID;
            calNgayDi.Width = 100;
            calNgayDi.Culture = new System.Globalization.CultureInfo("vi-VN");
            calNgayDi.DateTimeWatermarkContent = "Chọn ngày";

            cbxGioDi.Name = "cbxGioDi" + item.KhachHangID;
            cbxGioDi.ItemsSource = "0h 1h 2h 3h 4h 5h 6h 7h 8h 9h 10h 11h 12h 13h 14h 15h 16h 17h 18h 19h 20h 21h 22h 23h".Split();
            cbxGioDi.SelectedValue = "12h";
            cbxGioDi.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            cbxGioDi.Width = 50;

            cmdXoa.Content = "[Xóa]";
            cmdXoa.Width = 100;
            cmdXoa.HorizontalContentAlignment = System.Windows.HorizontalAlignment.Center;
            StyleManager.SetTheme(cbxPhong, new Office_BlueTheme());
            StyleManager.SetTheme(calNgayDen, new Office_BlueTheme());
            StyleManager.SetTheme(cbxGioDen, new Office_BlueTheme());
            StyleManager.SetTheme(cbxPhutDen, new Office_BlueTheme());
            StyleManager.SetTheme(calNgayDi, new Office_BlueTheme());
            StyleManager.SetTheme(cbxGioDi, new Office_BlueTheme());
            stackPnl.Children.Add(txtTenKhachHang);
            stackPnl.Children.Add(cbxPhong);
            stackPnl.Children.Add(calNgayDen);            
            stackPnl.Children.Add(cbxGioDen);
            stackPnl.Children.Add(cbxPhutDen);
            stackPnl.Children.Add(calNgayDi);
            stackPnl.Children.Add(cbxGioDi);
            stackPnl.Children.Add(cmdXoa);
            retBorder.Child = stackPnl;
            return retBorder;
        }
    }
}


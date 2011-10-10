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
namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmCaiDatGia : Page
    {
        PhongSVCClient PhongClient = new PhongSVCClient();
        public frmCaiDatGia()
        {
            InitializeComponent();
            PhongClient.Phong_GetItemsCompleted += new EventHandler<Phong_GetItemsCompletedEventArgs>(PhongClient_Phong_GetItemsCompleted);
            LoadingPanel.IsBusy = true;
            PhongClient.Phong_GetItemsAsync(0);
           
        }

        void PhongClient_Phong_GetItemsCompleted(object sender, Phong_GetItemsCompletedEventArgs e)
        {
            List<PhongInfo> ListPhong = new List<PhongInfo>();
            ListPhong = e.Result.ToList<PhongInfo>();
            GenerateRepeateColumn(12, ListPhong);
            LoadingPanel.IsBusy = false;
        }

        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {

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

        void cmdSua_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdSua = sender as HyperlinkButton;
            PhongInfo item  = cmdSua.CommandParameter as PhongInfo;
            var cbxs = GetCheckBoxControls(LayoutRoot).OfType<CheckBox>();
            foreach (var i in cbxs)
            {
                CheckBox cbx = i as CheckBox;
                if (cbx.Name == item.PhongID.ToString())
                {
                    cbx.IsChecked = true;
                }
                else
                {
                    cbx.IsChecked = false;
                }
            }
            //MessageBox.Show("Sửa phòng :" + item.PhongName + " ,PhongID=" + item.PhongID);
        }

        void cmdXem_Click(object sender, RoutedEventArgs e)
        {
            HyperlinkButton cmdXem = sender as HyperlinkButton;
            PhongInfo item = cmdXem.CommandParameter as PhongInfo;
            var cbxs = GetCheckBoxControls(LayoutRoot).OfType<CheckBox>();
            foreach (var i in cbxs)
            {
                CheckBox cbx = i as CheckBox;
                if(cbx.Name == item.PhongID.ToString())
                {
                    cbx.IsChecked = true;
                }
                else
                {
                    cbx.IsChecked = false;
                }
            }
            //MessageBox.Show("Xem phòng :" + item.PhongName + " ,PhongID=" + item.PhongID);
        }
        IEnumerable<DependencyObject> GetCheckBoxControls(DependencyObject root)
        {
            List<DependencyObject> doList = new List<DependencyObject>();
            doList.Add(root);
            for (int i = 0; i < VisualTreeHelper.GetChildrenCount(root); i++)
            doList.AddRange(GetCheckBoxControls(VisualTreeHelper.GetChild(root, i)));

            return doList;
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            string ListPhongID = "";
            var cbxs = GetCheckBoxControls(LayoutRoot).OfType<CheckBox>();
            PhongInfo item = null;
            foreach (var i in cbxs)
            {
                CheckBox cbx = i as CheckBox;
                item = cbx.CommandParameter as PhongInfo;
                if (cbx.IsChecked ==true)
                {
                    ListPhongID += item.PhongID.ToString() + ";";
                }
                
            }
            textBox1.Text = ListPhongID;
        }
    }
}

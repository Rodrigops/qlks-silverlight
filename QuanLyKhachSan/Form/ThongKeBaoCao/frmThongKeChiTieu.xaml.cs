﻿using System;
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
using QuanLyKhachSan.TKChiTieuSVC;
namespace QuanLyKhachSan.Form.ThongKeBaoCao
{
    public partial class frmThongKeChiTieu : Page
    {
        private TKChiTieuSVCClient TKChiTieuClient = null;
        public frmThongKeChiTieu()
        {
            InitializeComponent();
            Nam_Load();
            Thang_Load();
            LoadingPanel.Visibility = Visibility.Visible;
            LoadingPanel.IsBusy = true;
            rdbTheoNgay.IsChecked = true;
            TKChiTieuClient = new TKChiTieuSVCClient();
            TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoNgayCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoNgayCompleted);
            TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayAsync(int.Parse(DateTime.Now.ToString("yyyyMMdd")));
        }
        // Executes when the user navigates to this page.
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
        }

        #region RadioButton Event
        private void rdbTheoNgay_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNgay.IsChecked)
            {
                rdpTheoNgay.IsEnabled = true;
                rdpTuNgay.IsEnabled = false;
                rdpDenNgay.IsEnabled = false;
                cbxTheoNam.IsEnabled = false;
                cbxTheoThang.IsEnabled = false;
                cbxTheoThangNam.IsEnabled = false;
                rdpTheoNgay.SelectedDate = DateTime.Now.Date;
            }
        }
        private void rdbTheoThang_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoThang.IsChecked)
            {
                rdpTheoNgay.IsEnabled = false;
                rdpTuNgay.IsEnabled = false;
                rdpDenNgay.IsEnabled = false;
                cbxTheoNam.IsEnabled = false;
                cbxTheoThang.IsEnabled = true;
                cbxTheoThangNam.IsEnabled = true;
                cbxTheoThang.SelectedValue = DateTime.Now.Month;
                cbxTheoThangNam.SelectedValue = DateTime.Now.Year;
            }
        }
        private void rdbTheoNam_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNam.IsChecked)
            {
                rdpTheoNgay.IsEnabled = false;
                rdpTuNgay.IsEnabled = false;
                rdpDenNgay.IsEnabled = false;
                cbxTheoNam.IsEnabled = true;
                cbxTheoThang.IsEnabled = false;
                cbxTheoThangNam.IsEnabled = false;
                cbxTheoNam.SelectedValue = DateTime.Now.Year;
            }
        }
        private void rdbTuNgay_Checked(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTuNgay.IsChecked)
            {
                rdpTheoNgay.IsEnabled = false;
                rdpTuNgay.IsEnabled = true;
                rdpDenNgay.IsEnabled = true;
                cbxTheoNam.IsEnabled = false;
                cbxTheoThang.IsEnabled = false;
                cbxTheoThangNam.IsEnabled = false;
                rdpTuNgay.SelectedDate = DateTime.Now.Date;
                rdpDenNgay.SelectedDate = DateTime.Now.Date;
            }
        }
        private void Nam_Load()
        {
            int currentYear = DateTime.Now.Year;
            cbxTheoNam.Items.Clear();
            cbxTheoThangNam.Items.Clear();
            try
            {
                while ((currentYear >= 2000))
                {
                    cbxTheoNam.Items.Add(currentYear);
                    cbxTheoThangNam.Items.Add(currentYear);
                    currentYear = currentYear - 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        private void Thang_Load()
        {
            int currentMonth = 1;
            cbxTheoThang.Items.Clear();
            try
            {
                while ((currentMonth <= 12))
                {
                    cbxTheoThang.Items.Add(currentMonth);
                    currentMonth = currentMonth + 1;
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
        #endregion

        private void btnThongKe_Click(object sender, RoutedEventArgs e)
        {
            if ((bool)rdbTheoNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTheoNgay.SelectedDate.ToString()))
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoNgayCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoNgayCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNgayAsync(int.Parse(rdpTheoNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                }
            }
            else if ((bool)rdbTheoThang.IsChecked)
            {
                if (cbxTheoThang.SelectedIndex != -1 && cbxTheoThangNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoThangCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoThangCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoThangCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoThangAsync((int)cbxTheoThang.SelectedValue, (int)cbxTheoThangNam.SelectedValue);
                }
            }
            else if ((bool)rdbTheoNam.IsChecked)
            {
                if (cbxTheoNam.SelectedIndex != -1)
                {
                    LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                    TKChiTieuClient = new TKChiTieuSVCClient();
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNamCompleted += new EventHandler<PhieuNhapKho_GetItems_TheoNamCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TheoNamCompleted);
                    TKChiTieuClient.PhieuNhapKho_GetItems_TheoNamAsync((int)cbxTheoNam.SelectedValue);
                }
            }
            else if ((bool)rdbTuNgay.IsChecked)
            {
                if (!String.IsNullOrEmpty(rdpTuNgay.SelectedDate.ToString()) && !String.IsNullOrEmpty(rdpDenNgay.SelectedDate.ToString()))
                {
                    if (rdpTuNgay.SelectedDate < rdpDenNgay.SelectedDate)
                    {
                        LoadingPanel.Visibility = Visibility.Visible;LoadingPanel.IsBusy = true;
                        TKChiTieuClient = new TKChiTieuSVCClient();
                        TKChiTieuClient.PhieuNhapKho_GetItems_TuNgayDenNgayCompleted += new EventHandler<PhieuNhapKho_GetItems_TuNgayDenNgayCompletedEventArgs>(TKChiTieuClient_PhieuNhapKho_GetItems_TuNgayDenNgayCompleted);
                        TKChiTieuClient.PhieuNhapKho_GetItems_TuNgayDenNgayAsync(int.Parse(rdpTuNgay.SelectedDate.Value.ToString("yyyyMMdd")), int.Parse(rdpDenNgay.SelectedDate.Value.ToString("yyyyMMdd")));
                    }
                }
            }
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TuNgayDenNgayCompleted(object sender, PhieuNhapKho_GetItems_TuNgayDenNgayCompletedEventArgs e)
        {
            List<TKChiTieuInfo> TKDoanhThu = new List<TKChiTieuInfo>();
            TKDoanhThu = e.Result.ToList<TKChiTieuInfo>();

            grvPhieuNhapKho.ItemsSource = TKDoanhThu;
            TinhTong(TKDoanhThu);
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoNamCompleted(object sender, PhieuNhapKho_GetItems_TheoNamCompletedEventArgs e)
        {
            List<TKChiTieuInfo> TKDoanhThu = new List<TKChiTieuInfo>();
            TKDoanhThu = e.Result.ToList<TKChiTieuInfo>();

            grvPhieuNhapKho.ItemsSource = TKDoanhThu;
            TinhTong(TKDoanhThu);
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoThangCompleted(object sender, PhieuNhapKho_GetItems_TheoThangCompletedEventArgs e)
        {
            List<TKChiTieuInfo> TKDoanhThu = new List<TKChiTieuInfo>();
            TKDoanhThu = e.Result.ToList<TKChiTieuInfo>();

            grvPhieuNhapKho.ItemsSource = TKDoanhThu;
            TinhTong(TKDoanhThu);
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        void TKChiTieuClient_PhieuNhapKho_GetItems_TheoNgayCompleted(object sender, PhieuNhapKho_GetItems_TheoNgayCompletedEventArgs e)
        {
            List<TKChiTieuInfo> TKDoanhThu = new List<TKChiTieuInfo>();
            TKDoanhThu = e.Result.ToList<TKChiTieuInfo>();

            grvPhieuNhapKho.ItemsSource = TKDoanhThu;
            TinhTong(TKDoanhThu);
            LoadingPanel.Visibility = Visibility.Collapsed;LoadingPanel.IsBusy = false;
        }

        void TinhTong(List<TKChiTieuInfo> TKDoanhThu)
        {
            decimal tong = 0;
            foreach (TKChiTieuInfo TK in TKDoanhThu)
            {
                tong += TK.TongTien;
            }
            txtTongTien.Text = Format_NumberVietnamese(tong.ToString());
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

        private void btnInBaoCao_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                rptThongKeChiTieu InBaoCao = new rptThongKeChiTieu();
                if ((bool)rdbTheoNgay.IsChecked)
                {
                    InBaoCao.Type = "1";
                    if (!String.IsNullOrEmpty(rdpTheoNgay.SelectedDate.ToString()))
                    {
                        InBaoCao.Ngay = rdpTheoNgay.SelectedDate.Value.ToString("yyyyMMdd");
                    }
                }
                else if ((bool)rdbTheoThang.IsChecked)
                {
                    InBaoCao.Type = "2";
                    if (cbxTheoThang.SelectedIndex != -1 && cbxTheoThangNam.SelectedIndex != -1)
                    {
                        InBaoCao.Thang = cbxTheoThang.SelectedValue.ToString();
                        InBaoCao.Nam = cbxTheoThangNam.SelectedValue.ToString();
                    }
                }
                else if ((bool)rdbTheoNam.IsChecked)
                {
                    InBaoCao.Type = "3";
                    if (cbxTheoNam.SelectedIndex != -1)
                    {
                        InBaoCao.Nam = cbxTheoNam.SelectedValue.ToString();
                    }
                }
                else if ((bool)rdbTuNgay.IsChecked)
                {
                    InBaoCao.Type = "4";
                    if (!String.IsNullOrEmpty(rdpTuNgay.SelectedDate.ToString()))
                    {
                        InBaoCao.TuNgay = rdpTuNgay.SelectedDate.Value.ToString("yyyyMMdd");
                    }
                    if (!String.IsNullOrEmpty(rdpDenNgay.SelectedDate.ToString()))
                    {
                        InBaoCao.DenNgay = rdpDenNgay.SelectedDate.Value.ToString("yyyyMMdd");
                    }
                }
                InBaoCao.TongTien = txtTongTien.Text;
                InBaoCao.Show();
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

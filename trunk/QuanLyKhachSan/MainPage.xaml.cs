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

namespace QuanLyKhachSan
{
    public partial class MainPage : UserControl
    {
        public MainPage()
        {
            InitializeComponent();
        }
        private void cmdThongTinPhong_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("ThongTinPhong", UriKind.Relative));   
        }

        private void cmdGiaPhong_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("GiaPhong", UriKind.Relative));   
        }

        private void cmdCaiDatGia_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("CaiDatGia", UriKind.Relative));   
        }

        private void cmdTinhTrangPhong_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("", UriKind.Relative));   
        }

        private void cmdKhachHang_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("KhachHang", UriKind.Relative));   
        }

        private void cmdDatPhong_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdNhanPhong_Click(object sender, RoutedEventArgs e)
        {

        }

        private void cmdDichVuPhong_Click(object sender, RoutedEventArgs e)
        {
            ContentFrame.Navigate(new Uri("HoaDonDichVu", UriKind.Relative));   
        }
    }
}
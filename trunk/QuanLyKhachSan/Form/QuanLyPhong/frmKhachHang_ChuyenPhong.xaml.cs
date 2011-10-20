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

namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public partial class frmKhachHang_ChuyenPhong : ChildWindow
    {
        private int HoaDonID;
        private int PhongID;
        public frmKhachHang_ChuyenPhong()
        {
            InitializeComponent();
        }
        public void ChuyenPhong_Load(int _HoaDonID, int _PhongID)
        {
            HoaDonID = _HoaDonID;
            PhongID = _PhongID;
        }
        private void OKButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = true;
        }

        private void CancelButton_Click(object sender, RoutedEventArgs e)
        {
            this.DialogResult = false;
        }
    }
}


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

namespace QuanLyKhachSan.Form.HoaDonDichVu
{
    public partial class frmPhong_CapNhatNgayRa : ChildWindow
    {
        public frmPhong_CapNhatNgayRa()
        {
            InitializeComponent();
        }
        public void HoaDon_Load(int _HoaDonID)
        { 
        
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


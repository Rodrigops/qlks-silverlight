using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;
using System.Windows.Data;

namespace QuanLyKhachSan.Form.QuanLyKhachHang
{
    public class SexFormater : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string GioiTinh = value.ToString();
            string retGioiTinh = "";
            switch (GioiTinh)
            {
                case "0":
                    retGioiTinh = "Nam";
                    break;
                case "1":
                    retGioiTinh = "Nữ";
                    break;
                case "-1":
                    retGioiTinh = "Chưa xác định";
                    break;
            }
            return retGioiTinh;
            throw new NotImplementedException();
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        #endregion
    }
}

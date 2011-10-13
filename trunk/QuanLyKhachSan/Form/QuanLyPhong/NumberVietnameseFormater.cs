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

namespace QuanLyKhachSan.Form.QuanLyPhong
{
    public class NumberVietnameseFormater : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string Gia = value.ToString();
            if (Gia.IndexOf("%") > 0 || Gia == "")
            {
                return Gia;
            }
            else
            {
                decimal revalue = decimal.Parse(Gia);
                string retGia = revalue.ToString("N", culture);
                return retGia.Replace(".00", "");
            }
            throw new NotImplementedException();
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string Gia = value.ToString();
            if (Gia.IndexOf("%") > 0 || Gia == "")
            {
                return Gia;
            }
            else
            {
                decimal revalue = decimal.Parse(Gia);
                string retGia = revalue.ToString("N", culture);
                return retGia.Replace(".00", "");
            }
            throw new NotImplementedException();
        }
        #endregion
    }
}

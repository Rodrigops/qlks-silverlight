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

namespace QuanLyKhachSan.Form.ThongKeBaoCao
{
    public class LoaiThueFormater : IValueConverter
    {
        
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            if (value.ToString() == "0")
            {
                return "Theo giờ";
            }
            else if (value.ToString() == "1")
            {
                return "Theo ngày";
            }
            else if (value.ToString() == "2")
            {
                return "Qua đêm";
            }
            else
            {
                return "Theo tháng";
            }
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
    }
}

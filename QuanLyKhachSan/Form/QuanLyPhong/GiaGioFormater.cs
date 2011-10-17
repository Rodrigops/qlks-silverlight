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
    public class GiaGioFormater : IValueConverter
    {
        #region IValueConverter Members
        public object Convert(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            string retGiaGio = "";
            string[] aGiaGio = value.ToString().Split(("|").ToCharArray());
            for (var i = 0; i < aGiaGio.Length; i++)
            {
                if (aGiaGio[i] != "")
                {
                    string[] aItem = aGiaGio[i].ToString().Split((";").ToCharArray());
                    retGiaGio += aItem[0] + "h:" + Format_NumberVietnamese(aItem[1], culture) + "\n";
                }
            }
            return retGiaGio;
            throw new NotImplementedException();
        }
        public object ConvertBack(object value, Type targetType, object parameter, System.Globalization.CultureInfo culture)
        {
            throw new NotImplementedException();
        }
        public string Format_NumberVietnamese(string Gia, System.Globalization.CultureInfo culture)
        {
            try
            {
                decimal value = decimal.Parse(Gia);
                string retGia = value.ToString("N", culture);
                return retGia.Replace(".00", "");
            }
            catch (Exception)
            {

                throw;
            }
        }
        #endregion
    }
}

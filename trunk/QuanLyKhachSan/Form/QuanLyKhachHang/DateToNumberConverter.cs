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

namespace QuanLyKhachSan.Form.QuanLyKhachHang
{
    public class DateToNumberConverter
    {
       public static int Date2Number(string Date)
        {
            try
            {
                int retInt;
                string[] aDate = Date.Split("/".ToCharArray());
                retInt = int.Parse(aDate[2].ToString() + aDate[0].ToString() + aDate[1].ToString());
                return retInt;
            }
            catch (Exception)
            {                
                throw;
            }
        }
       public static int Date2Month(string Date)
        {
            try
            {
                int retInt;
                string[] aDate = Date.Split("/".ToCharArray());
                retInt = int.Parse(aDate[0].ToString());
                return retInt;
            }
            catch (Exception)
            {
                throw;
            }
        }
      public static int Date2Year(string Date)
        {
            try
            {
                int retInt;
                string[] aDate = Date.Split("/".ToCharArray());
                retInt = int.Parse(aDate[2].ToString());
                return retInt;
            }
            catch (Exception)
            {
                throw;
            }
        }
    }
}

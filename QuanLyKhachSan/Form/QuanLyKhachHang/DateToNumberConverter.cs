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
        public static string Date2Vietnamese(string Date)
        {
            try
            {
                string retInt="";
                if (Date == "")
                    return "";
                string[] aDate = Date.Split("/".ToCharArray());
                retInt = aDate[1].ToString() + "/" +  aDate[0].ToString() + "/" + aDate[2].ToString();
                return retInt;
            }
            catch (Exception)
            {
                throw;
            }
        }
        public static string NumberToDate(string Number)
        {
            try
            {
                string Nam = "";
                string Thang = "";
                string Ngay = "";
                Nam = Number.Substring(0, 4);
                Thang = Number.Substring(4, 2);
                Ngay = Number.Substring(6, 2);
                return Ngay + "/" + Thang + "/" + Nam;
            }
            catch (Exception)
            {
                throw;
            }
        }
       public static int Date2Number(string Date)
        {
            try
            {
                int retInt;
                if (Date == "")
                    return 0;
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
                if (Date == "")
                    return 0;
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
                if (Date == "")
                    return 0;
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

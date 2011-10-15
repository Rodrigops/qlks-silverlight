using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class HoaDonBAL
    {
        public static void HoaDon_Add(int UserId)
        {
            HoaDonDAL doit = new HoaDonDAL();
            doit.HoaDon_Add(UserId);
        }
    }
}
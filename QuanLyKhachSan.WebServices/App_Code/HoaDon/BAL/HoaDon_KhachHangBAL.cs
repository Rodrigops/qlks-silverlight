using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class HoaDon_KhachHangBAL
    {
        public static void HoaDon_KhachHang_Add(int KhachHangId, int PhongID, string NgayBatDau, int GioBatDau, int PhutBatDau, int NgayBatDau_So, int ThangBatDau, int NamBatDau, string NgayKetThuc)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            doit.HoaDon_KhachHang_Add(KhachHangId, PhongID, NgayBatDau, GioBatDau, PhutBatDau, NgayBatDau_So, ThangBatDau, NamBatDau, NgayKetThuc);
        }
       
    }
}
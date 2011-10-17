using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class HoaDon_KhachHangBAL
    {
        public static void HoaDon_KhachHang_Add(string LoaiHoaDon,int KhachHangId, int PhongID, string NgayBatDau, int GioBatDau, int PhutBatDau, int NgayBatDau_So, int ThangBatDau, int NamBatDau, string NgayKetThuc)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            doit.HoaDon_KhachHang_Add(LoaiHoaDon,KhachHangId, PhongID, NgayBatDau, GioBatDau, PhutBatDau, NgayBatDau_So, ThangBatDau, NamBatDau, NgayKetThuc);
        }
        public static List<Phong_KhachHangInfo> Phong_KhachHang_GetItems(int HoaDonID, int PhongID)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            return doit.Phong_KhachHang_GetItems(HoaDonID, PhongID);
        }
        public static void Phong_KhachHang_Delete(int HoaDonID, int KhachHangID)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            doit.Phong_KhachHang_Delete(HoaDonID, KhachHangID);
        }
        public static List<Phong_KhachHangInfo> Phong_KhachHang_DatPhong(int PhongID)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            return doit.Phong_KhachHang_DatPhong(PhongID);
        }
    }
}
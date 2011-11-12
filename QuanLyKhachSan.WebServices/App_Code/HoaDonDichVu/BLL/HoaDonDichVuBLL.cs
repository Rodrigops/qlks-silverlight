using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class HoaDonDichVuBLL
    {
        public static void HoaDonDichVu_Add(int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int Thang, int Nam, int NgaySo, 
            int SoLuong, decimal DonGia, decimal TongTien, int CreatedByUser, string CreatedDate)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonDichVu_Add(HoaDonID, PhongID, DichVuID, KhachHangID, NgaySuDung, Thang, Nam, NgaySo, SoLuong, DonGia, TongTien, CreatedByUser, CreatedDate);
        }
        public static void HoaDonDichVu_Edit(int HoaDon_DichVuID, int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int Thang, int Nam, int NgaySo,
            int SoLuong, decimal DonGia, decimal TongTien, int ModifiedByUser, string ModifiedDate)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonDichVu_Edit(HoaDon_DichVuID, HoaDonID, PhongID, DichVuID, KhachHangID, NgaySuDung, Thang, Nam, NgaySo, SoLuong, DonGia, TongTien, ModifiedByUser, ModifiedDate);
        }
        public static void HoaDonDichVu_Delete(int HoaDon_DichVuID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonDichVu_Delete(HoaDon_DichVuID);
        }
        public static HoaDonDichVuInfo HoaDonDichVu_GetItem(int HoaDon_DichVuID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            return doit.HoaDonDichVu_GetItem(HoaDon_DichVuID);
        }
        public static List<HoaDonDichVuInfo> HoaDonDichVu_GetItems([Optional, DefaultParameterValue(0)] int HoaDon_DichVuID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            return doit.HoaDonDichVu_GetItems(HoaDon_DichVuID);
        }
    }
}
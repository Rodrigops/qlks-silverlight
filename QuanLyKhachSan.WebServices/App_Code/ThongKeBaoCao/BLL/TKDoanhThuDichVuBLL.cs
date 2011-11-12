using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class TKDoanhThuDichVuBLL
    {
        public static List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoNgay(int NgaySo)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TheoNgay(NgaySo);
        }
        public static List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoThang(int Thang, int Nam)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TheoThang(Thang, Nam);
        }
        public static List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoNam(int Nam)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TheoNam(Nam);
        }
        public static List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TuNgayDenNgay(TuNgaySo, DenNgaySo);
        }
    }
}
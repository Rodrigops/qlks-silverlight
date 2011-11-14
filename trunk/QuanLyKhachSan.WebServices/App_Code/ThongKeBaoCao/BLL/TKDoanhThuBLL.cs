using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class TKDoanhThuBLL
    {
        public static List<TKDoanhThuInfo> HoaDon_GetItems_DaThanhToan()
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_DaThanhToan();
        }
        public static List<TKDoanhThuInfo> HoaDon_GetItems_TheoNgay(int NgayRaSo)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TheoNgay(NgayRaSo);
        }
        public static List<TKDoanhThuInfo> HoaDon_GetItems_TheoThang(int ThangRa, int NamRa)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TheoThang(ThangRa, NamRa);
        }
        public static List<TKDoanhThuInfo> HoaDon_GetItems_TheoNam(int NamRa)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TheoNam(NamRa);
        }
        public static List<TKDoanhThuInfo> HoaDon_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TuNgayDenNgay(TuNgaySo, DenNgaySo);
        }
    }
}
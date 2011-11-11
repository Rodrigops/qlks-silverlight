using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class TKChiTieuBLL
    {
        public static List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoNgay(int NgayNhapSo)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TheoNgay(NgayNhapSo);
        }
        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoThang(int ThangNhap, int NamNhap)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TheoThang(ThangNhap, NamNhap);
        }
        public static List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoNam(int NamNhap)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TheoNam(NamNhap);
        }
        public static List<TKChiTieuInfo> PhieuNhapKho_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TuNgayDenNgay(TuNgaySo, DenNgaySo);
        }
    }
}
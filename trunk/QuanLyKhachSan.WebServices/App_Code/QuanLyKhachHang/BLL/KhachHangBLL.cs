using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class KhachHangBLL
    {
        public static void KhachHang_Add(string HoTen, string DiaChi, string DienThoai, string CMND, string NgaySinh, string NoiSinh,
            string SoVisa, string ThoiHanVisa, string NguoiTiepNhan, string NgayNhapCanh, string TamTruTuNgay, string TamTruDenNgay,
            int QuocTichID, int GioiTinh, int CreatedByUser, string CreatedDate)
        {
            KhachHangDAL doit = new KhachHangDAL();
            doit.KhachHang_Add(HoTen, DiaChi, DienThoai, CMND, NgaySinh, NoiSinh, SoVisa, ThoiHanVisa, NguoiTiepNhan, NgayNhapCanh,
                TamTruTuNgay, TamTruDenNgay, QuocTichID, GioiTinh, CreatedByUser, CreatedDate);
        }
        public static void KhachHang_Edit(int KhachHangID, string HoTen, string DiaChi, string DienThoai, string CMND, string NgaySinh, string NoiSinh,
            string SoVisa, string ThoiHanVisa, string NguoiTiepNhan, string NgayNhapCanh, string TamTruTuNgay, string TamTruDenNgay,
            int QuocTichID, int GioiTinh, int ModifiedByUser, string ModifiedDate)
        {
            KhachHangDAL doit = new KhachHangDAL();
            doit.KhachHang_Edit(KhachHangID, HoTen, DiaChi, DienThoai, CMND, NgaySinh, NoiSinh, SoVisa, ThoiHanVisa, NguoiTiepNhan, NgayNhapCanh,
                TamTruTuNgay, TamTruDenNgay, QuocTichID, GioiTinh, ModifiedByUser, ModifiedDate);
        }
        public static void KhachHang_Delete(int KhachHangID, int DeletedByUser, string DeletedDate)
        {
            KhachHangDAL doit = new KhachHangDAL();
            doit.KhachHang_Delete(KhachHangID, DeletedByUser, DeletedDate);
        }
        public static KhachHangInfo KhachHang_GetItem(int KhachHangID)
        {
            KhachHangDAL doit = new KhachHangDAL();
            return doit.KhachHang_GetItem(KhachHangID);
        }
        public static List<KhachHangInfo> KhachHang_GetItems([Optional, DefaultParameterValue(0)] int KhachHangID)
        {
            KhachHangDAL doit = new KhachHangDAL();
            return doit.KhachHang_GetItems(KhachHangID);
        }
        public static List<KhachHangInfo> KhachHang_GetItemsInPhong([Optional, DefaultParameterValue(0)] int KhachHangID)
        {
            KhachHangDAL doit = new KhachHangDAL();
            return doit.KhachHang_GetItemsInPhong(KhachHangID);
        }
    }
}
using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class PhieuNhapKhoBLL
    {
        public static void PhieuNhapKho_Add(string NgayNhap, int ThangNhap, int NamNhap, string NgayNhapSo, string GhiChu, 
            int CreatedByUser, string CreatedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Add(NgayNhap, ThangNhap, NamNhap, NgayNhapSo, GhiChu, CreatedByUser, CreatedDate);
        }
        public static void PhieuNhapKho_Edit(int PhieuNhapKhoID, string NgayNhap, int ThangNhap, int NamNhap, string NgayNhapSo, string GhiChu,
            int ModifiedByUser, string ModifiedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Edit(PhieuNhapKhoID, NgayNhap, ThangNhap, NamNhap, NgayNhapSo, GhiChu, ModifiedByUser, ModifiedDate);
        }
        public static void PhieuNhapKho_Delete(int PhieuNhapKhoID,int DeletedByUser, string DeletedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Delete(PhieuNhapKhoID, DeletedByUser, DeletedDate);
        }
        public static PhieuNhapKhoInfo PhieuNhapKho_GetItem(int PhieuNhapKhoID)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            return doit.PhieuNhapKho_GetItem(PhieuNhapKhoID);
        }
        public static List<PhieuNhapKhoInfo> PhieuNhapKho_GetItems([Optional, DefaultParameterValue(0)] int PhieuNhapKhoID)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            return doit.PhieuNhapKho_GetItems(PhieuNhapKhoID);
        }
    }
}
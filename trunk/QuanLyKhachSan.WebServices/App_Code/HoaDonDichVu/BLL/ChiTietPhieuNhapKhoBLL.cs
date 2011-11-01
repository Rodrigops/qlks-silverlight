using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class ChiTietPhieuNhapKhoBLL
    {
        public static void ChiTietPhieuNhapKho_Add(int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Add(PhieuNhapKhoID, SoLuong, DonGia, ThanhTien, DichVuID);
        }
        public static void ChiTietPhieuNhapKho_Edit(int ChiTietPhieuNhapID, int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Edit(ChiTietPhieuNhapID, PhieuNhapKhoID, SoLuong, DonGia, ThanhTien, DichVuID);
        }
        public static void ChiTietPhieuNhapKho_Delete(int ChiTietPhieuNhapID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Delete(ChiTietPhieuNhapID);
        }
        public static ChiTietPhieuNhapKhoInfo ChiTietPhieuNhapKho_GetItem(int ChiTietPhieuNhapID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            return doit.ChiTietPhieuNhapKho_GetItem(ChiTietPhieuNhapID);
        }
        public static List<ChiTietPhieuNhapKhoInfo> ChiTietPhieuNhapKho_GetItems([Optional, DefaultParameterValue(0)] int PhieuNhapKhoID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            return doit.ChiTietPhieuNhapKho_GetItems(PhieuNhapKhoID);
        }
    }
}
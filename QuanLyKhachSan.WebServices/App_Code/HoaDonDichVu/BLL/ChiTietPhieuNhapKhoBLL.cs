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
        public static void ChiTietPhieuNhapKho_Edit(int ChiTietPhieuNhapKho, int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Edit(ChiTietPhieuNhapKho, PhieuNhapKhoID, SoLuong, DonGia, ThanhTien, DichVuID);
        }
        public static void ChiTietPhieuNhapKho_Delete(int ChiTietPhieuNhapKho)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Delete(ChiTietPhieuNhapKho);
        }
        public static ChiTietPhieuNhapKhoInfo ChiTietPhieuNhapKho_GetItem(int ChiTietPhieuNhapKho)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            return doit.ChiTietPhieuNhapKho_GetItem(ChiTietPhieuNhapKho);
        }
    }
}
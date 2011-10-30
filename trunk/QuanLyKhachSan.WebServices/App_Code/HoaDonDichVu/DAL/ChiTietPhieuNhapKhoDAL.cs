using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class ChiTietPhieuNhapKhoDAL
    {
        public ChiTietPhieuNhapKhoDAL()
        {

        }
        public void ChiTietPhieuNhapKho_Add(int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SQLDB.Addparameter("@SoLuong", SoLuong);
            SQLDB.Addparameter("@DonGia", DonGia);
            SQLDB.Addparameter("@ThanhTien", ThanhTien);
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.executenonquery("sp_ChiTietPhieuNhapKho_Add", CommandType.StoredProcedure);
        }
        public void ChiTietPhieuNhapKho_Edit(int ChiTietPhieuNhapKho, int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ChiTietPhieuNhapKho", ChiTietPhieuNhapKho);
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SQLDB.Addparameter("@SoLuong", SoLuong);
            SQLDB.Addparameter("@DonGia", DonGia);
            SQLDB.Addparameter("@ThanhTien", ThanhTien);
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.executenonquery("sp_ChiTietPhieuNhapKho_Edit", CommandType.StoredProcedure);
        }
        public void ChiTietPhieuNhapKho_Delete(int ChiTietPhieuNhapKho)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ChiTietPhieuNhapKho", ChiTietPhieuNhapKho);
            SQLDB.executenonquery("sp_ChiTietPhieuNhapKho_Delete", CommandType.StoredProcedure);
        }
        public ChiTietPhieuNhapKhoInfo ChiTietPhieuNhapKho_GetItem(int ChiTietPhieuNhapKho)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ChiTietPhieuNhapKho", ChiTietPhieuNhapKho);
            SqlDataReader rd = SQLDB.executereader("sp_ChiTietPhieuNhapKho_GetItem", CommandType.StoredProcedure);
            ChiTietPhieuNhapKhoInfo item = null;
            while (rd.Read())
            {
                item = new ChiTietPhieuNhapKhoInfo();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
            }
            return item;
        }
    }
}


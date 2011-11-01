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
        public void ChiTietPhieuNhapKho_Edit(int ChiTietPhieuNhapID, int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ChiTietPhieuNhapID", ChiTietPhieuNhapID);
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SQLDB.Addparameter("@SoLuong", SoLuong);
            SQLDB.Addparameter("@DonGia", DonGia);
            SQLDB.Addparameter("@ThanhTien", ThanhTien);
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.executenonquery("sp_ChiTietPhieuNhapKho_Edit", CommandType.StoredProcedure);
        }
        public void ChiTietPhieuNhapKho_Delete(int ChiTietPhieuNhapID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ChiTietPhieuNhapID", ChiTietPhieuNhapID);
            SQLDB.executenonquery("sp_ChiTietPhieuNhapKho_Delete", CommandType.StoredProcedure);
        }
        public ChiTietPhieuNhapKhoInfo ChiTietPhieuNhapKho_GetItem(int ChiTietPhieuNhapID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ChiTietPhieuNhapID", ChiTietPhieuNhapID);
            SqlDataReader rd = SQLDB.executereader("sp_ChiTietPhieuNhapKho_GetItem", CommandType.StoredProcedure);
            ChiTietPhieuNhapKhoInfo item = null;
            while (rd.Read())
            {
                item = new ChiTietPhieuNhapKhoInfo();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["ThanhTien"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
            }
            return item;
        }
        public List<ChiTietPhieuNhapKhoInfo> ChiTietPhieuNhapKho_GetItems([Optional, DefaultParameterValue(0)] int PhieuNhapKhoID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SqlDataReader rd = SQLDB.executereader("sp_ChiTietPhieuNhapKho_GetItems", CommandType.StoredProcedure);
            List<ChiTietPhieuNhapKhoInfo> list = new List<ChiTietPhieuNhapKhoInfo>();
            ChiTietPhieuNhapKhoInfo item = null;
            while (rd.Read())
            {
                item = new ChiTietPhieuNhapKhoInfo();
                item.ChiTietPhieuNhapID = int.Parse(rd["ChiTietPhieuNhapID"].ToString());
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["ThanhTien"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.DichVuName = rd["DichVuName"].ToString();
                list.Add(item);
            }
            return list;
        }
    }
}


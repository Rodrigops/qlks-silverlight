using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class HoaDonDichVuDAL
    {
        public HoaDonDichVuDAL()
        {

        }
        public void HoaDonDichVu_Add(int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int SoLuong,
            decimal DonGia, decimal TongTien, int CreatedByUser, string CreatedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SQLDB.Addparameter("@NgaySuDung", NgaySuDung);
            SQLDB.Addparameter("@SoLuong", SoLuong);
            SQLDB.Addparameter("@DonGia", DonGia);
            SQLDB.Addparameter("@TongTien", TongTien);
            SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_HoaDonDichVu_Add", CommandType.StoredProcedure);
        }
        public void HoaDonDichVu_Edit(int HoaDon_DichVuID, int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int SoLuong,
            decimal DonGia, decimal TongTien, int ModifiedByUser, string ModifiedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SQLDB.Addparameter("@NgaySuDung", NgaySuDung);
            SQLDB.Addparameter("@SoLuong", SoLuong);
            SQLDB.Addparameter("@DonGia", DonGia);
            SQLDB.Addparameter("@TongTien", TongTien);
            SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_HoaDonDichVu_Edit", CommandType.StoredProcedure);
        }
        public void HoaDonDichVu_Delete(int HoaDon_DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SQLDB.executenonquery("sp_HoaDonDichVu_Delete", CommandType.StoredProcedure);
        }
        public HoaDonDichVuInfo HoaDonDichVu_GetItem(int HoaDon_DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItem", CommandType.StoredProcedure);
            HoaDonDichVuInfo item = null;
            while (rd.Read())
            {
                item = new HoaDonDichVuInfo();
                item.HoaDon_DichVuID = int.Parse(rd["HoaDon_DichVuID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.NgaySuDung = rd["NgaySuDung"].ToString();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());
            }
            return item;
        }
        public List<HoaDonDichVuInfo> HoaDonDichVu_GetItems([Optional, DefaultParameterValue(0)] int HoaDon_DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItems", CommandType.StoredProcedure);
            List<HoaDonDichVuInfo> list = new List<HoaDonDichVuInfo>();
            HoaDonDichVuInfo item = null;
            while (rd.Read())
            {
                item = new HoaDonDichVuInfo();
                item.HoaDon_DichVuID = int.Parse(rd["HoaDon_DichVuID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.PhongName = rd["PhongName"].ToString();
                item.NgaySuDung = rd["NgaySuDung"].ToString();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }
    }
}


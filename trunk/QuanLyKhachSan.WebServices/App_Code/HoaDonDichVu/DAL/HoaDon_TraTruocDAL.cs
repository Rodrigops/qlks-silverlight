using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class HoaDon_TraTruocDAL
    {
        public HoaDon_TraTruocDAL()
        {

        }
        public void HoaDon_TraTruoc_Add(int HoaDonID, string GhiChu, decimal TraTruoc, int CreatedByUser, string CreatedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@GhiChu", GhiChu);
            SQLDB.Addparameter("@TraTruoc", TraTruoc);
            SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_HoaDon_TraTruoc_Add", CommandType.StoredProcedure);
        }
        public void HoaDon_TraTruoc_Edit(int HoaDon_TraTruocID, int HoaDonID, string GhiChu, decimal TraTruoc, int ModifiedByUser, string ModifiedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_TraTruocID", HoaDon_TraTruocID);
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@GhiChu", GhiChu);
            SQLDB.Addparameter("@TraTruoc", TraTruoc);
            SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_HoaDon_TraTruoc_Edit", CommandType.StoredProcedure);
        }
        public void HoaDon_TraTruoc_Delete(int HoaDon_TraTruocID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_TraTruocID", HoaDon_TraTruocID);
            SQLDB.executenonquery("sp_HoaDon_TraTruoc_Delete", CommandType.StoredProcedure);
        }
        public HoaDon_TraTruocInfo HoaDon_TraTruoc_GetItem(int HoaDonID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_TraTruoc_GetItem", CommandType.StoredProcedure);
            HoaDon_TraTruocInfo item = null;
            while (rd.Read())
            {
                item = new HoaDon_TraTruocInfo();
                item.HoaDon_TraTruocID = int.Parse(rd["HoaDon_TraTruocID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.GhiChu = rd["GhiChu"].ToString();
                item.TraTruoc = decimal.Parse(rd["TraTruoc"].ToString());
            }
            return item;
        }
        public List<HoaDon_TraTruocInfo> HoaDon_TraTruoc_GetItems([Optional, DefaultParameterValue(0)] int HoaDonID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_TraTruoc_GetItems", CommandType.StoredProcedure);
            List<HoaDon_TraTruocInfo> list = new List<HoaDon_TraTruocInfo>();
            HoaDon_TraTruocInfo item = null;
            while (rd.Read())
            {
                item = new HoaDon_TraTruocInfo();
                item.HoaDon_TraTruocID = int.Parse(rd["HoaDon_TraTruocID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.GhiChu = rd["GhiChu"].ToString();
                item.TraTruoc = decimal.Parse(rd["TraTruoc"].ToString());
                item.CreatedByUser = int.Parse(rd[""].ToString());
                item.GhiChu = rd["GhiChu"].ToString();

                list.Add(item);
            }
            return list;
        }
    }
}


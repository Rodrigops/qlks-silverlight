using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class TienNghiDAL
    {
        public TienNghiDAL()
        {

        }
        public void TienNghi_Add(string TienNghiName,int TienNghi_UuTien)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TienNghiName", TienNghiName);
            SQLDB.Addparameter("@TienNghi_UuTien", TienNghi_UuTien);
            SQLDB.executenonquery("sp_TienNghi_Add", CommandType.StoredProcedure);                        
        }
        public void TienNghi_Edit(int TienNghiID,string TienNghiName, int TienNghi_UuTien)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TienNghiID", TienNghiID);
            SQLDB.Addparameter("@TienNghiName", TienNghiName);
            SQLDB.Addparameter("@TienNghi_UuTien", TienNghi_UuTien);
            SQLDB.executenonquery("sp_TienNghi_Edit", CommandType.StoredProcedure);
        }
        public void TienNghi_Delete(int TienNghiID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TienNghiID", TienNghiID);
            SQLDB.executenonquery("sp_TienNghi_Delete", CommandType.StoredProcedure);
        }
        public TienNghiInfo TienNghi_GetItem(int TienNghiID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TienNghiID", TienNghiID);
             SqlDataReader rd = SQLDB.executereader("sp_TienNghi_GetItem", CommandType.StoredProcedure);
             TienNghiInfo item = null;
            while (rd.Read())
            {
                item = new TienNghiInfo();
                item.TienNghiID = int.Parse(rd["TienNghiID"].ToString());
                item.TienNghiName = rd["TienNghiName"].ToString();
                item.TienNghi_UuTien = int.Parse(rd["TienNghi_UuTien"].ToString());
            }
            return item;
        }
        public List<TienNghiInfo> TienNghi_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_TienNghi_GetItems", CommandType.StoredProcedure);
            List<TienNghiInfo> list = new List<TienNghiInfo>();
            TienNghiInfo item = null;
            while (rd.Read())
            {
                item = new TienNghiInfo();
                item.TienNghiID = int.Parse(rd["TienNghiID"].ToString());
                item.TienNghiName = rd["TienNghiName"].ToString();
                item.TienNghi_UuTien = int.Parse(rd["TienNghi_UuTien"].ToString());
                list.Add(item);
            }
            return list;
        }
        public void TienNghi_SapXep(string ListTienNghiID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ListTienNghiID", ListTienNghiID);
            SQLDB.executenonquery("sp_TienNghi_SapXep", CommandType.StoredProcedure);
        }
    }
}


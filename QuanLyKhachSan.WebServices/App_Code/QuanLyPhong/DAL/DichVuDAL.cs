using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class DichVuDAL
    {
        public DichVuDAL()
        {

        }
        public void DichVu_Add(string DichVuName,decimal GiaTien)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@DichVuName", DichVuName);
            SQLDB.Addparameter("@GiaTien", GiaTien);
            SQLDB.executenonquery("sp_DichVu_Add", CommandType.StoredProcedure);                        
        }
        public void DichVu_Edit(int DichVuID, string DichVuName, decimal GiaTien)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.Addparameter("@DichVuName", DichVuName);
            SQLDB.Addparameter("@GiaTien", GiaTien);
            SQLDB.executenonquery("sp_DichVu_Edit", CommandType.StoredProcedure);
        }
        public void DichVu_Delete(int DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.executenonquery("sp_DichVu_Delete", CommandType.StoredProcedure);
        }
        public DichVuInfo DichVu_GetItem(int DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@DichVuID", DichVuID);
             SqlDataReader rd = SQLDB.executereader("sp_DichVu_GetItem", CommandType.StoredProcedure);
            DichVuInfo item=null;
            while (rd.Read())
            {
                item = new DichVuInfo();
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.DichVuName = rd["DichVuName"].ToString();
                item.GiaTien = decimal.Parse(rd["GiaTien"].ToString());
            }
            return item;
        }
        public List<DichVuInfo> DichVu_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_DichVu_GetItems", CommandType.StoredProcedure);
            List<DichVuInfo> list = new List<DichVuInfo>();
            DichVuInfo item = null;
            while (rd.Read())
            {
                item = new DichVuInfo();
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.DichVuName = rd["DichVuName"].ToString();
                item.GiaTien = decimal.Parse(rd["GiaTien"].ToString());
                list.Add(item);
            }
            return list;
        }
    }
}

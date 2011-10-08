using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class QuocTichDAL
    {
        public QuocTichDAL()
        {

        }
        public void QuocTich_Add(string TenQuocTich)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TenQuocTich", TenQuocTich);
            SQLDB.executenonquery("sp_QuocTich_Add", CommandType.StoredProcedure);                        
        }
        public void QuocTich_Edit(int QuocTichID,string TenQuocTich)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@QuocTichID", QuocTichID);
            SQLDB.Addparameter("@TenQuocTich", TenQuocTich);
            SQLDB.executenonquery("sp_QuocTich_Edit", CommandType.StoredProcedure);
        }
        public void QuocTich_Delete(int QuocTichID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@QuocTichID", QuocTichID);
            SQLDB.executenonquery("sp_QuocTich_Delete", CommandType.StoredProcedure);
        }
        public QuocTichInfo QuocTich_GetItem(int QuocTichID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@QuocTichID", QuocTichID);
             SqlDataReader rd = SQLDB.executereader("sp_QuocTich_GetItem", CommandType.StoredProcedure);
            QuocTichInfo item=null;
            while (rd.Read())
            {
                item = new QuocTichInfo();
                item.QuocTichID = int.Parse(rd["QuocTichID"].ToString());
                item.TenQuocTich = rd["TenQuocTich"].ToString();
            }
            return item;
        }
        public List<QuocTichInfo> QuocTich_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_QuocTich_GetItems", CommandType.StoredProcedure);
            List<QuocTichInfo> list = new List<QuocTichInfo>();
            QuocTichInfo item = null;
            while (rd.Read())
            {
                item = new QuocTichInfo();
                item.QuocTichID = int.Parse(rd["QuocTichID"].ToString());
                item.TenQuocTich = rd["TenQuocTich"].ToString();
                list.Add(item);
            }
            return list;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class LoaiPhongDAL
    {
        public LoaiPhongDAL()
        {

        }
        public void LoaiPhong_Add(string LoaiPhongName)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@LoaiPhongName", LoaiPhongName);
            SQLDB.executenonquery("sp_LoaiPhong_Add", CommandType.StoredProcedure);                        
        }
        public void LoaiPhong_Edit(int LoaiPhongID,string LoaiPhongName)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@LoaiPhongID", LoaiPhongID);
            SQLDB.Addparameter("@LoaiPhongName", LoaiPhongName);
            SQLDB.executenonquery("sp_LoaiPhong_Edit", CommandType.StoredProcedure);
        }
        public void LoaiPhong_Delete(int LoaiPhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@LoaiPhongID", LoaiPhongID);
            SQLDB.executenonquery("sp_LoaiPhong_Delete", CommandType.StoredProcedure);
        }
        public LoaiPhongInfo LoaiPhong_GetItem(int LoaiPhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@LoaiPhongID", LoaiPhongID);
             SqlDataReader rd = SQLDB.executereader("sp_LoaiPhong_GetItem", CommandType.StoredProcedure);
            LoaiPhongInfo item=null;
            while (rd.Read())
            {
                item = new LoaiPhongInfo();
                item.LoaiPhongID = int.Parse(rd["LoaiPhongID"].ToString());
                item.LoaiPhongName = rd["LoaiPhongName"].ToString();
            }
            return item;
        }
        public List<LoaiPhongInfo> LoaiPhong_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_LoaiPhong_GetItems", CommandType.StoredProcedure);
            List<LoaiPhongInfo> list = new List<LoaiPhongInfo>();
            LoaiPhongInfo item = null;
            while (rd.Read())
            {
                item = new LoaiPhongInfo();
                item.LoaiPhongID = int.Parse(rd["LoaiPhongID"].ToString());
                item.LoaiPhongName = rd["LoaiPhongName"].ToString();
                list.Add(item);
            }
            return list;
        }
    }
}

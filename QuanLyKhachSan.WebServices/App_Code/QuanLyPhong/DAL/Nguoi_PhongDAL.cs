using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class Nguoi_PhongDAL
    {
        public Nguoi_PhongDAL()
        {

        }
        public void Nguoi_Phong_Add(string ListPhongID, string ListNguoiPhongName, string ListCongThem, string CongThemTiepTheo)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ListPhongID", ListPhongID);
            SQLDB.Addparameter("@ListNguoiPhongName", ListNguoiPhongName);
            SQLDB.Addparameter("@ListCongThem", ListCongThem);
            SQLDB.Addparameter("@CongThemTiepTheo", CongThemTiepTheo);
            SQLDB.executenonquery("sp_Nguoi_Phong_Add", CommandType.StoredProcedure);                        
        }
        public List<Nguoi_PhongInfo> Nguoi_Phong_GetItemByPhongID(int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Nguoi_Phong_GetItemByPhongID", CommandType.StoredProcedure);
            List<Nguoi_PhongInfo> list = new List<Nguoi_PhongInfo>();
            Nguoi_PhongInfo item = null;
            while (rd.Read())
            {
                item = new Nguoi_PhongInfo();
                item.Nguoi_PhongID = int.Parse(rd["Nguoi_PhongID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.NguoiPhongName = rd["NguoiPhongName"].ToString();
                item.CongThem = rd["CongThem"].ToString();
                item.status = rd["Status"].ToString();
                list.Add(item);
            }
            return list;
        }
    }
}



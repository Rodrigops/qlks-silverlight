using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class Ngay_PhongDAL
    {
        public Ngay_PhongDAL()
        {

        }
        public void Ngay_Phong_Add(string ListPhongID, decimal GiaNgay, decimal GiaTuan, decimal GiaThang)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ListPhongID", ListPhongID);
            SQLDB.Addparameter("@GiaNgay", GiaNgay);
            SQLDB.Addparameter("@GiaTuan", GiaTuan);
            SQLDB.Addparameter("@GiaThang", GiaThang);
            SQLDB.executenonquery("sp_Ngay_Phong_Add", CommandType.StoredProcedure);                        
        }
        public Ngay_PhongInfo Ngay_Phong_GetItemByPhongID(int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Ngay_Phong_GetItemByPhongID", CommandType.StoredProcedure);
            Ngay_PhongInfo item = null;
            while (rd.Read())
            {
                item = new Ngay_PhongInfo();
                item.Ngay_PhongID = int.Parse(rd["Ngay_PhongID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.GiaNgay = decimal.Parse(rd["GiaNgay"].ToString());
                item.GiaTuan = decimal.Parse(rd["GiaTuan"].ToString());
                item.GiaThang = decimal.Parse(rd["GiaThang"].ToString());
            }
            return item;
        }
    }
}



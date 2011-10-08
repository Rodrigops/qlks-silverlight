using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class Gia_PhongDAL
    {
        public Gia_PhongDAL()
        {

        }
        public List<Gia_PhongInfo> Phong_GiaPhong()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_Phong_GiaPhong", CommandType.StoredProcedure);
            List<Gia_PhongInfo> list = new List<Gia_PhongInfo>();
            Gia_PhongInfo item = null;
            string s = "";
            while (rd.Read())
            {
                item = new Gia_PhongInfo();
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.PhongName = rd["PhongName"].ToString();
                s = rd["GiaGio"].ToString();
                item.GiaGio = rd["GiaGio"].ToString();
                item.GiaNgay = decimal.Parse(rd["GiaNgay"].ToString());
                item.GiaTuan = decimal.Parse(rd["GiaTuan"].ToString());
                item.GiaThang = decimal.Parse(rd["GiaThang"].ToString());
                list.Add(item);
            }
            return list;
        }    
    }
}



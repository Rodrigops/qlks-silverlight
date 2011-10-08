using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class Gio_PhongDAL
    {
        public Gio_PhongDAL()
        {

        }
        public void Gio_Phong_Add(string ListPhongID, string ListGioPhongName, int PhanTram, string ListGiaTien, string Status)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ListPhongID", ListPhongID);
            SQLDB.Addparameter("@ListGioPhongName", ListGioPhongName);
            SQLDB.Addparameter("@PhanTram", PhanTram);
            SQLDB.Addparameter("@ListGiaTien", ListGiaTien);
            SQLDB.Addparameter("@Status", Status);
            SQLDB.executenonquery("sp_Gio_Phong_Add", CommandType.StoredProcedure);                        
        }


        public void Gio_Phong_Edit(int Gio_PhongID, int PhongID, string GioPhongName, int PhanTram, decimal GiaTien, string Status)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@Gio_PhongID", Gio_PhongID);
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.Addparameter("@GioPhongName", GioPhongName);
            SQLDB.Addparameter("@PhanTram", PhanTram);
            SQLDB.Addparameter("@GiaTien", GiaTien);
            SQLDB.Addparameter("@Status", Status);
            SQLDB.executenonquery("sp_Gio_Phong_Edit", CommandType.StoredProcedure);
        }
        public void Gio_Phong_Delete(int Gio_PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@Gio_PhongID", Gio_PhongID);
            SQLDB.executenonquery("sp_Gio_Phong_Delete", CommandType.StoredProcedure);
        }
        public Gio_PhongInfo Gio_Phong_GetItem(int Gio_PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@Gio_PhongID", Gio_PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Gio_Phong_GetItem", CommandType.StoredProcedure);
            Gio_PhongInfo item = null;
            while (rd.Read())
            {
                item = new Gio_PhongInfo();
                item.Gio_PhongID = int.Parse(rd["Gio_PhongID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.GioPhongName = rd["GioPhongName"].ToString();
                item.PhanTram = int.Parse(rd["PhanTram"].ToString());
                item.GiaTien = decimal.Parse(rd["GiaTien"].ToString());
                item.status = rd["status"].ToString();
            }
            return item;
        }
        public List<Gio_PhongInfo> Gio_Phong_GetItems(int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Gio_Phong_GetItems", CommandType.StoredProcedure);
            List<Gio_PhongInfo> list = new List<Gio_PhongInfo>();
            Gio_PhongInfo item = null;
            while (rd.Read())
            {
                item = new Gio_PhongInfo();
                item.Gio_PhongID = int.Parse(rd["Gio_PhongID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.GioPhongName = rd["GioPhongName"].ToString();
                item.PhanTram = int.Parse(rd["PhanTram"].ToString());
                item.GiaTien = decimal.Parse(rd["GiaTien"].ToString());
                item.status = rd["status"].ToString();
                list.Add(item);
            }
            return list;
        }
        public decimal Gio_Phong_GiaGoc(int PhongID)
        {
            object GiaGoc;
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            GiaGoc = SQLDB.executesalar("sp_Gio_Phong_GiaGoc", CommandType.StoredProcedure);
            return decimal.Parse(GiaGoc.ToString());
        }
        public string Gio_Phong_KiemTraStatus(int PhongID)
        {
            object status;
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            status = SQLDB.executesalar("sp_Gio_Phong_KiemTraStatus", CommandType.StoredProcedure);
            return status.ToString();
        }
        public List<Gio_PhongInfo> Gio_Phong_GetItemByPhongID(int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Gio_Phong_GetItemByPhongID", CommandType.StoredProcedure);
            List<Gio_PhongInfo> list = new List<Gio_PhongInfo>();
            Gio_PhongInfo item = null;
            while (rd.Read())
            {
                item = new Gio_PhongInfo();
                item.Gio_PhongID = int.Parse(rd["Gio_PhongID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.GioPhongName = rd["GioPhongName"].ToString();
                item.PhanTram = int.Parse(rd["PhanTram"].ToString());
                item.GiaTien = decimal.Parse(rd["GiaTien"].ToString());
                item.status = rd["status"].ToString();
                list.Add(item);
            }
            return list;
        }
    }
}



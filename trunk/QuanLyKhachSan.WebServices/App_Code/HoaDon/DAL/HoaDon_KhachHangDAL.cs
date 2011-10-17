using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class HoaDon_KhachHangDAL
    {
        public HoaDon_KhachHangDAL()
        {

        }
        public void HoaDon_KhachHang_Add(string LoaiHoaDon,int KhachHangId,int PhongID,string NgayBatDau,int GioBatDau,int PhutBatDau,int NgayBatDau_So,int ThangBatDau,int NamBatDau,string NgayKetThuc)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@LoaiHoaDon", LoaiHoaDon);
            SQLDB.Addparameter("@KhachHangId", KhachHangId);
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.Addparameter("@NgayBatDau", NgayBatDau);
            SQLDB.Addparameter("@GioBatDau", GioBatDau);
            SQLDB.Addparameter("@PhutBatDau", PhutBatDau);
            SQLDB.Addparameter("@NgayBatDau_So", NgayBatDau_So);
            SQLDB.Addparameter("@ThangBatDau", ThangBatDau);
            SQLDB.Addparameter("@NamBatDau", NamBatDau);
            SQLDB.Addparameter("@NgayKetThuc", NgayKetThuc);
            SQLDB.executenonquery("sp_HoaDon_KhachHang_Add", CommandType.StoredProcedure);
        }
        public List<Phong_KhachHangInfo> Phong_KhachHang_GetItems(int HoaDonID, int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Phong_KhachHang_GetItems", CommandType.StoredProcedure);
            List<Phong_KhachHangInfo> list = new List<Phong_KhachHangInfo>();
            Phong_KhachHangInfo item = null;
            while (rd.Read())
            {
                item = new Phong_KhachHangInfo();
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.CMND = rd["CMND"].ToString();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                list.Add(item);
            }
            return list;
        }
        public List<Phong_KhachHangInfo> Phong_KhachHang_DatPhong(int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Phong_KhachHang_DatPhong", CommandType.StoredProcedure);
            List<Phong_KhachHangInfo> list = new List<Phong_KhachHangInfo>();
            Phong_KhachHangInfo item = null;
            while (rd.Read())
            {
                item = new Phong_KhachHangInfo();
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.CMND = rd["CMND"].ToString();
                item.NgayBatDau = rd["NgayBatDau"].ToString();
                item.NgayKetThuc = rd["NgayKetThuc"].ToString();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                list.Add(item);
            }
            return list;
        }
        public void Phong_KhachHang_Delete(int HoaDonID, int KhachHangID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SQLDB.executenonquery("sp_Phong_KhachHang_Delete", CommandType.StoredProcedure);
        }
    }
}




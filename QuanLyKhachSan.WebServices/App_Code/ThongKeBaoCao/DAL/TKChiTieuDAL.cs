using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class TKChiTieuDAL
    {
        public TKChiTieuDAL()
        {

        }
        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoNgay(int NgayNhapSo)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@NgayNhapSo", NgayNhapSo);
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetItems_TheoNgay", CommandType.StoredProcedure);
            List<TKChiTieuInfo> list = new List<TKChiTieuInfo>();
            TKChiTieuInfo item = null;
            while (rd.Read())
            {
                item = new TKChiTieuInfo();
                item.PhieuNhapKhoID = int.Parse(rd["PhieuNhapKhoID"].ToString());
                item.NgayNhap = rd["NgayNhap"].ToString();
                item.GhiChu = rd["GhiChu"].ToString();
                item.UserName = rd["UserName"].ToString();
                if (!String.IsNullOrEmpty(rd["TongTien"].ToString()))
                    item.TongTien = decimal.Parse(rd["TongTien"].ToString());
                else
                    item.TongTien = 0;

                list.Add(item);
            }
            return list;
        }

        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoThang(int ThangNhap, int NamNhap)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ThangNhap", ThangNhap);
            SQLDB.Addparameter("@NamNhap", NamNhap);
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetItems_TheoThang", CommandType.StoredProcedure);
            List<TKChiTieuInfo> list = new List<TKChiTieuInfo>();
            TKChiTieuInfo item = null;
            while (rd.Read())
            {
                item = new TKChiTieuInfo();
                item.PhieuNhapKhoID = int.Parse(rd["PhieuNhapKhoID"].ToString());
                item.NgayNhap = rd["NgayNhap"].ToString();
                item.GhiChu = rd["GhiChu"].ToString();
                item.UserName = rd["UserName"].ToString();
                if (!String.IsNullOrEmpty(rd["TongTien"].ToString()))
                    item.TongTien = decimal.Parse(rd["TongTien"].ToString());
                else
                    item.TongTien = 0;

                list.Add(item);
            }
            return list;
        }

        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoNam(int NamNhap)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@NamNhap", NamNhap);
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetItems_TheoNam", CommandType.StoredProcedure);
            List<TKChiTieuInfo> list = new List<TKChiTieuInfo>();
            TKChiTieuInfo item = null;
            while (rd.Read())
            {
                item = new TKChiTieuInfo();
                item.PhieuNhapKhoID = int.Parse(rd["PhieuNhapKhoID"].ToString());
                item.NgayNhap = rd["NgayNhap"].ToString();
                item.GhiChu = rd["GhiChu"].ToString();
                item.UserName = rd["UserName"].ToString();
                if (!String.IsNullOrEmpty(rd["TongTien"].ToString()))
                    item.TongTien = decimal.Parse(rd["TongTien"].ToString());
                else
                    item.TongTien = 0;

                list.Add(item);
            }
            return list;
        }

        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TuNgaySo", TuNgaySo);
            SQLDB.Addparameter("@DenNgaySo", DenNgaySo);
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetItems_TuNgayDenNgay", CommandType.StoredProcedure);
            List<TKChiTieuInfo> list = new List<TKChiTieuInfo>();
            TKChiTieuInfo item = null;
            while (rd.Read())
            {
                item = new TKChiTieuInfo();
                item.PhieuNhapKhoID = int.Parse(rd["PhieuNhapKhoID"].ToString());
                item.NgayNhap = rd["NgayNhap"].ToString();
                item.GhiChu = rd["GhiChu"].ToString();
                item.UserName = rd["UserName"].ToString();
                if (!String.IsNullOrEmpty(rd["TongTien"].ToString()))
                    item.TongTien = decimal.Parse(rd["TongTien"].ToString());
                else
                    item.TongTien = 0;

                list.Add(item);
            }
            return list;
        }
    }
}


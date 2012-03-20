using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class PhieuNhapKhoDAL
    {
        public PhieuNhapKhoDAL()
        {

        }
        public void PhieuNhapKho_Add(string NgayNhap, int ThangNhap, int NamNhap, int NgayNhapSo, string GhiChu,
            string CreatedByUser, string CreatedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@NgayNhap", NgayNhap);
            SQLDB.Addparameter("@ThangNhap", ThangNhap);
            SQLDB.Addparameter("@NamNhap", NamNhap);
            SQLDB.Addparameter("@NgayNhapSo", NgayNhapSo);
            SQLDB.Addparameter("@GhiChu", GhiChu);
            SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_PhieuNhapKho_Add", CommandType.StoredProcedure);
        }
        public void PhieuNhapKho_Edit(int PhieuNhapKhoID, string NgayNhap, int ThangNhap, int NamNhap, int NgayNhapSo, string GhiChu,
            string ModifiedByUser, string ModifiedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SQLDB.Addparameter("@NgayNhap", NgayNhap);
            SQLDB.Addparameter("@ThangNhap", ThangNhap);
            SQLDB.Addparameter("@NamNhap", NamNhap);
            SQLDB.Addparameter("@NgayNhapSo", NgayNhapSo);
            SQLDB.Addparameter("@GhiChu", GhiChu);
            SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_PhieuNhapKho_Edit", CommandType.StoredProcedure);
        }
        public void PhieuNhapKho_Delete(int PhieuNhapKhoID, string DeletedByUser, string DeletedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SQLDB.Addparameter("@DeletedByUser", DeletedByUser);
            SQLDB.Addparameter("@DeletedDate", DeletedDate);
            SQLDB.executenonquery("sp_PhieuNhapKho_Delete", CommandType.StoredProcedure);
        }
        public PhieuNhapKhoInfo PhieuNhapKho_GetItem(int PhieuNhapKhoID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetItem", CommandType.StoredProcedure);
            PhieuNhapKhoInfo item = null;
            while (rd.Read())
            {
                item = new PhieuNhapKhoInfo();
                item.PhieuNhapKhoID = int.Parse(rd["PhieuNhapKhoID"].ToString());
                item.NgayNhap = rd["NgayNhap"].ToString();
                item.ThangNhap = int.Parse(rd["ThangNhap"].ToString());
                item.NamNhap = int.Parse(rd["NamNhap"].ToString());
                item.NgayNhapSo = int.Parse(rd["NgayNhapSo"].ToString());
                item.GhiChu = rd["GhiChu"].ToString();
            }
            return item;
        }
        public List<PhieuNhapKhoInfo> PhieuNhapKho_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetItems", CommandType.StoredProcedure);
            List<PhieuNhapKhoInfo> list = new List<PhieuNhapKhoInfo>();
            PhieuNhapKhoInfo item = null;
            while (rd.Read())
            {
                item = new PhieuNhapKhoInfo();
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
        public PhieuNhapKhoInfo PhieuNhapKho_GetLatestItem()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetLatestItem", CommandType.StoredProcedure);
            PhieuNhapKhoInfo item = null;
            while (rd.Read())
            {
                item = new PhieuNhapKhoInfo();
                item.PhieuNhapKhoID = int.Parse(rd["PhieuNhapKhoID"].ToString());
            }
            return item;
        }
    }
}


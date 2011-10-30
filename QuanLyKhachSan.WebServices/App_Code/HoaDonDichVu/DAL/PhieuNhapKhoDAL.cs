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
        public void PhieuNhapKho_Add(string NgayNhap, int ThangNhap, int NamNhap, string NgayNhapSo, string GhiChu,
            int CreatedByUser, string CreatedDate)
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
        public void PhieuNhapKho_Edit(int PhieuNhapKhoID, string NgayNhap, int ThangNhap, int NamNhap, string NgayNhapSo, string GhiChu,
            int ModifiedByUser, string ModifiedDate)
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
        public void PhieuNhapKho_Delete(int PhieuNhapKhoID, int DeletedByUser, string DeletedDate)
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
        public List<PhieuNhapKhoInfo> PhieuNhapKho_GetItems([Optional, DefaultParameterValue(0)] int PhieuNhapKhoID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhieuNhapKhoID", PhieuNhapKhoID);
            SqlDataReader rd = SQLDB.executereader("sp_PhieuNhapKho_GetItems", CommandType.StoredProcedure);
            List<PhieuNhapKhoInfo> list = new List<PhieuNhapKhoInfo>();
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

                item.ChiTietPhieuNhapID = int.Parse(rd["ChiTietPhieuNhapID"].ToString());
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.DichVuName = rd["DichVuName"].ToString();

                list.Add(item);
            }
            return list;
        }
    }
}


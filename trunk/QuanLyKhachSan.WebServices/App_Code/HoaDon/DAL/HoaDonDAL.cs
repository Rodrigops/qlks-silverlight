using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;

namespace QuanLyKhachSan
{
    public class HoaDonDAL
    {
        public HoaDonDAL()
        {

        }
        public void HoaDon_Add(int LoaiThue,int Ca, string LoaiHoaDon,decimal KhuyenMai,string GhiChu,string NgayVao,int NgayVao_So,int GioVao,int PhutVao, int ThangVao,int NamVao,string NgayRa,int NgayRa_So,int GioRa,int PhutRa,int ThangRa,int NamRa,int UserID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@LoaiThue", LoaiThue);
            SQLDB.Addparameter("@Ca", Ca);
            SQLDB.Addparameter("@LoaiHoaDon", LoaiHoaDon);
            SQLDB.Addparameter("@KhuyenMai", KhuyenMai);
            SQLDB.Addparameter("@GhiChu", GhiChu);
            SQLDB.Addparameter("@NgayVao", NgayVao);
            SQLDB.Addparameter("@NgayVao_So", NgayVao_So);
            SQLDB.Addparameter("@GioVao", GioVao);
            SQLDB.Addparameter("@PhutVao", PhutVao);
            SQLDB.Addparameter("@ThangVao", ThangVao);
            SQLDB.Addparameter("@NamVao", NamVao);
            SQLDB.Addparameter("@NgayRa", NgayRa);
            SQLDB.Addparameter("@NgayRa_So", NgayRa_So);
            SQLDB.Addparameter("@GioRa", GioRa);
            SQLDB.Addparameter("@PhutRa", PhutRa);
            SQLDB.Addparameter("@ThangRa", ThangRa);
            SQLDB.Addparameter("@NamRa", NamRa);
            SQLDB.Addparameter("@UserId", UserID);
            SQLDB.executenonquery("sp_HoaDon_Add", CommandType.StoredProcedure);
        }
        public HoaDonInfo HoaDon_GetItem(int HoaDonID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_GetItem", CommandType.StoredProcedure);
            HoaDonInfo item = null;
            while (rd.Read())
            {
                item = new HoaDonInfo();
                item.NgayVao = rd["NgayVao"].ToString();
                item.NgayVao_So = int.Parse(rd["NgayVao_So"].ToString());
                item.GioVao = int.Parse(rd["GioVao"].ToString());
                item.PhutVao = int.Parse(rd["PhutVao"].ToString());
                item.NgayRa = rd["NgayRa"].ToString();
                item.NgayRa_So = int.Parse(rd["NgayRa_So"].ToString());
                item.GioRa = int.Parse(rd["GioRa"].ToString());
                item.PhutRa = int.Parse(rd["PhutRa"].ToString());
                item.KhuyenMai = decimal.Parse(rd["KhuyenMai"].ToString());
                item.KhoanKhac = decimal.Parse(rd["KhoanKhac"].ToString());
                item.GhiChu = rd["GhiChu"].ToString();
                item.DaThanhToan = int.Parse(rd["DaThanhToan"].ToString());                
            }
            return item;
        }
    }
}




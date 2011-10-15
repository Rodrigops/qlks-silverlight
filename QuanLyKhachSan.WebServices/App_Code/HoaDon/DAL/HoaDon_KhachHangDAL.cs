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
        public void HoaDon_KhachHang_Add(int KhachHangId,int PhongID,string NgayBatDau,int GioBatDau,int PhutBatDau,int NgayBatDau_So,int ThangBatDau,int NamBatDau,string NgayKetThuc)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
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
    }
}



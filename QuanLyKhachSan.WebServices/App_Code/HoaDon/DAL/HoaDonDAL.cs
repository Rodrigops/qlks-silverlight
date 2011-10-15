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
        public void HoaDon_Add(int UserId)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserId", UserId);
            SQLDB.executenonquery("sp_HoaDon_Add", CommandType.StoredProcedure);
        }
    }
}



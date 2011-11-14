using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class TKDoanhThuDAL
    {
        public TKDoanhThuDAL()
        {

        }
        public List<TKDoanhThuInfo> HoaDon_GetItems_DaThanhToan()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_GetItems_DaThanhToan", CommandType.StoredProcedure);
            List<TKDoanhThuInfo> list = new List<TKDoanhThuInfo>();
            TKDoanhThuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuInfo();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.NgayVao = rd["NgayVao"].ToString();
                item.NgayRa = rd["NgayRa"].ToString();
                item.DaThanhToan = int.Parse(rd["DaThanhToan"].ToString());
                item.LoaiThue = int.Parse(rd["LoaiThue"].ToString());
                item.Ca = int.Parse(rd["Ca"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }

        public List<TKDoanhThuInfo> HoaDon_GetItems_TheoNgay(int NgayRaSo)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@NgayRaSo", NgayRaSo);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_GetItems_TheoNgay", CommandType.StoredProcedure);
            List<TKDoanhThuInfo> list = new List<TKDoanhThuInfo>();
            TKDoanhThuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuInfo();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.NgayVao = rd["NgayVao"].ToString();
                item.NgayRa = rd["NgayRa"].ToString();
                item.DaThanhToan = int.Parse(rd["DaThanhToan"].ToString());
                item.LoaiThue = int.Parse(rd["LoaiThue"].ToString());
                item.Ca = int.Parse(rd["Ca"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }

        public List<TKDoanhThuInfo> HoaDon_GetItems_TheoThang(int ThangRa, int NamRa)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@ThangRa", ThangRa);
            SQLDB.Addparameter("@NamRa", NamRa);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_GetItems_TheoThang", CommandType.StoredProcedure);
            List<TKDoanhThuInfo> list = new List<TKDoanhThuInfo>();
            TKDoanhThuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuInfo();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.NgayVao = rd["NgayVao"].ToString();
                item.NgayRa = rd["NgayRa"].ToString();
                item.DaThanhToan = int.Parse(rd["DaThanhToan"].ToString());
                item.LoaiThue = int.Parse(rd["LoaiThue"].ToString());
                item.Ca = int.Parse(rd["Ca"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }

        public List<TKDoanhThuInfo> HoaDon_GetItems_TheoNam(int NamRa)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@NamRa", NamRa);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_GetItems_TheoNam", CommandType.StoredProcedure);
            List<TKDoanhThuInfo> list = new List<TKDoanhThuInfo>();
            TKDoanhThuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuInfo();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.NgayVao = rd["NgayVao"].ToString();
                item.NgayRa = rd["NgayRa"].ToString();
                item.DaThanhToan = int.Parse(rd["DaThanhToan"].ToString());
                item.LoaiThue = int.Parse(rd["LoaiThue"].ToString());
                item.Ca = int.Parse(rd["Ca"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }

        public List<TKDoanhThuInfo> HoaDon_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TuNgaySo", TuNgaySo);
            SQLDB.Addparameter("@DenNgaySo", DenNgaySo);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDon_GetItems_TuNgayDenNgay", CommandType.StoredProcedure);
            List<TKDoanhThuInfo> list = new List<TKDoanhThuInfo>();
            TKDoanhThuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuInfo();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.NgayVao = rd["NgayVao"].ToString();
                item.NgayRa = rd["NgayRa"].ToString();
                item.DaThanhToan = int.Parse(rd["DaThanhToan"].ToString());
                item.LoaiThue = int.Parse(rd["LoaiThue"].ToString());
                item.Ca = int.Parse(rd["Ca"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }
    }
}


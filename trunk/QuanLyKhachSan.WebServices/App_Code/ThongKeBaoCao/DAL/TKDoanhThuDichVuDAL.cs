using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class TKDoanhThuDichVuDAL
    {
        public TKDoanhThuDichVuDAL()
        {

        }
        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoNgay(int NgaySo)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@NgaySo", NgaySo);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItems_TheoNgay", CommandType.StoredProcedure);
            List<TKDoanhThuDichVuInfo> list = new List<TKDoanhThuDichVuInfo>();
            TKDoanhThuDichVuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuDichVuInfo();
                item.HoaDon_DichVuID = int.Parse(rd["HoaDon_DichVuID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.PhongName = rd["PhongName"].ToString();
                item.DichVuName = rd["DichVuName"].ToString();
                item.NgaySuDung = rd["NgaySuDung"].ToString();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }

        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoThang(int Thang, int Nam)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@Thang", Thang);
            SQLDB.Addparameter("@Nam", Nam);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItems_TheoThang", CommandType.StoredProcedure);
            List<TKDoanhThuDichVuInfo> list = new List<TKDoanhThuDichVuInfo>();
            TKDoanhThuDichVuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuDichVuInfo();
                item.HoaDon_DichVuID = int.Parse(rd["HoaDon_DichVuID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.PhongName = rd["PhongName"].ToString();
                item.DichVuName = rd["DichVuName"].ToString();
                item.NgaySuDung = rd["NgaySuDung"].ToString();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }

        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoNam(int Nam)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@Nam", Nam);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItems_TheoNam", CommandType.StoredProcedure);
            List<TKDoanhThuDichVuInfo> list = new List<TKDoanhThuDichVuInfo>();
            TKDoanhThuDichVuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuDichVuInfo();
                item.HoaDon_DichVuID = int.Parse(rd["HoaDon_DichVuID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.PhongName = rd["PhongName"].ToString();
                item.DichVuName = rd["DichVuName"].ToString();
                item.NgaySuDung = rd["NgaySuDung"].ToString();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }

        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@TuNgaySo", TuNgaySo);
            SQLDB.Addparameter("@DenNgaySo", DenNgaySo);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItems_TuNgayDenNgay", CommandType.StoredProcedure);
            List<TKDoanhThuDichVuInfo> list = new List<TKDoanhThuDichVuInfo>();
            TKDoanhThuDichVuInfo item = null;
            while (rd.Read())
            {
                item = new TKDoanhThuDichVuInfo();
                item.HoaDon_DichVuID = int.Parse(rd["HoaDon_DichVuID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.PhongName = rd["PhongName"].ToString();
                item.DichVuName = rd["DichVuName"].ToString();
                item.NgaySuDung = rd["NgaySuDung"].ToString();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());

                list.Add(item);
            }
            return list;
        }
    }
}


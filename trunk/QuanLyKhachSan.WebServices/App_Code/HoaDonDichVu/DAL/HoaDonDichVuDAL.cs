using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class HoaDonDichVuDAL
    {
        public HoaDonDichVuDAL()
        {

        }
        public void HoaDonDichVu_Add(int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int Thang, int Nam, int NgaySo,
            int SoLuong, decimal DonGia, decimal TongTien, int CreatedByUser, string CreatedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SQLDB.Addparameter("@NgaySuDung", NgaySuDung);
            SQLDB.Addparameter("@Thang", Thang);
            SQLDB.Addparameter("@Nam", Nam);
            SQLDB.Addparameter("@NgaySo", NgaySo);
            SQLDB.Addparameter("@SoLuong", SoLuong);
            SQLDB.Addparameter("@DonGia", DonGia);
            SQLDB.Addparameter("@TongTien", TongTien);
            SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_HoaDonDichVu_Add", CommandType.StoredProcedure);
        }
        public void HoaDonDichVu_Edit(int HoaDon_DichVuID, int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int Thang, int Nam, int NgaySo,
            int SoLuong, decimal DonGia, decimal TongTien, int ModifiedByUser, string ModifiedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.Addparameter("@DichVuID", DichVuID);
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SQLDB.Addparameter("@NgaySuDung", NgaySuDung);
            SQLDB.Addparameter("@Thang", Thang);
            SQLDB.Addparameter("@Nam", Nam);
            SQLDB.Addparameter("@NgaySo", NgaySo);
            SQLDB.Addparameter("@SoLuong", SoLuong);
            SQLDB.Addparameter("@DonGia", DonGia);
            SQLDB.Addparameter("@TongTien", TongTien);
            SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_HoaDonDichVu_Edit", CommandType.StoredProcedure);
        }
        public void HoaDonDichVu_Delete(int HoaDon_DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SQLDB.executenonquery("sp_HoaDonDichVu_Delete", CommandType.StoredProcedure);
        }
        public HoaDonDichVuInfo HoaDonDichVu_GetItem(int HoaDon_DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItem", CommandType.StoredProcedure);
            HoaDonDichVuInfo item = null;
            while (rd.Read())
            {
                item = new HoaDonDichVuInfo();
                item.HoaDon_DichVuID = int.Parse(rd["HoaDon_DichVuID"].ToString());
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.DichVuID = int.Parse(rd["DichVuID"].ToString());
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.NgaySuDung = rd["NgaySuDung"].ToString();
                item.SoLuong = int.Parse(rd["SoLuong"].ToString());
                item.DonGia = decimal.Parse(rd["DonGia"].ToString());
                item.TongTien = decimal.Parse(rd["TongTien"].ToString());
            }
            return item;
        }
        public List<HoaDonDichVuInfo> HoaDonDichVu_GetItems([Optional, DefaultParameterValue(0)] int HoaDon_DichVuID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDon_DichVuID", HoaDon_DichVuID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItems", CommandType.StoredProcedure);
            List<HoaDonDichVuInfo> list = new List<HoaDonDichVuInfo>();
            HoaDonDichVuInfo item = null;
            while (rd.Read())
            {
                item = new HoaDonDichVuInfo();
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
        public List<HoaDonDichVuInfo> HoaDonDichVu_GetItemsByID([Optional, DefaultParameterValue(0)] int HoaDonID, [Optional, DefaultParameterValue(0)] int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItemsByID", CommandType.StoredProcedure);
            List<HoaDonDichVuInfo> list = new List<HoaDonDichVuInfo>();
            HoaDonDichVuInfo item = null;
            while (rd.Read())
            {
                item = new HoaDonDichVuInfo();
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
        public HoaDonNgayVaoRaInfo HoaDonDichVu_GetItem_NgayVao([Optional, DefaultParameterValue(0)] int HoaDonID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SqlDataReader rd = SQLDB.executereader("sp_HoaDonDichVu_GetItem_NgayVao", CommandType.StoredProcedure);
            HoaDonNgayVaoRaInfo item = null;
            while (rd.Read())
            {
                item = new HoaDonNgayVaoRaInfo();
                item.HoaDonID = int.Parse(rd["HoaDonID"].ToString());
                item.NgayVao = rd["NgayVao"].ToString();
                item.GioVao = int.Parse(rd["GioVao"].ToString());
                item.PhutVao = int.Parse(rd["PhutVao"].ToString());
                item.NgayVao_So = int.Parse(rd["NgayVao_So"].ToString());
                item.ThangVao = int.Parse(rd["ThangVao"].ToString());
                item.NamVao = int.Parse(rd["NamVao"].ToString());

                item.NgayRa = rd["NgayRa"].ToString();
                item.GioRa = int.Parse(rd["GioRa"].ToString());
                item.PhutRa = int.Parse(rd["PhutRa"].ToString());
                item.NgayRa_So = int.Parse(rd["NgayRa_So"].ToString());
                item.ThangRa = int.Parse(rd["ThangRa"].ToString());
                item.NamRa = int.Parse(rd["NamRa"].ToString());
            }
            return item;
        }
        public void HoaDonNgayRa_Add(int HoaDonID, string NgayRa, int GioRa, int PhutRa, int NgayRa_So, int ThangRa, int NamRa)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoaDonID", HoaDonID);
            SQLDB.Addparameter("@NgayRa", NgayRa);
            SQLDB.Addparameter("@GioRa", GioRa);
            SQLDB.Addparameter("@PhutRa", PhutRa);
            SQLDB.Addparameter("@NgayRa_So", NgayRa_So);
            SQLDB.Addparameter("@ThangRa", ThangRa);
            SQLDB.Addparameter("@NamRa", NamRa);
            SQLDB.executenonquery("sp_HoaDonNgayRa_Add", CommandType.StoredProcedure);
        }
    }
}


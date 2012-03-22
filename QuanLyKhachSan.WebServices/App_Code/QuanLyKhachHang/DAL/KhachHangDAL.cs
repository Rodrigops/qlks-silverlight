using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class KhachHangDAL
    {
        public KhachHangDAL()
        {

        }
        public void KhachHang_Add(string HoTen, string DiaChi, string DienThoai, string CMND, string NgaySinh, string NoiSinh,
            string SoVisa, string ThoiHanVisa, string NguoiTiepNhan, string NgayNhapCanh, string TamTruTuNgay, string TamTruDenNgay,
            int QuocTichID, int GioiTinh, string CreatedByUser, string CreatedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@HoTen", HoTen);
            SQLDB.Addparameter("@DiaChi", DiaChi);
            SQLDB.Addparameter("@DienThoai", DienThoai);
            SQLDB.Addparameter("@CMND", CMND);
            SQLDB.Addparameter("@NgaySinh", NgaySinh);
            SQLDB.Addparameter("@NoiSinh", NoiSinh);
            SQLDB.Addparameter("@SoVisa", SoVisa);
            SQLDB.Addparameter("@ThoiHanVisa", ThoiHanVisa);
            SQLDB.Addparameter("@NguoiTiepNhan", NguoiTiepNhan);
            SQLDB.Addparameter("@NgayNhapCanh", NgayNhapCanh);
            SQLDB.Addparameter("@TamTruTuNgay", TamTruTuNgay);
            SQLDB.Addparameter("@TamTruDenNgay", TamTruDenNgay);
            SQLDB.Addparameter("@QuocTichID", QuocTichID);
            SQLDB.Addparameter("@GioiTinh", GioiTinh);
            SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_KhachHang_Add", CommandType.StoredProcedure);
        }
        public void KhachHang_Edit(int KhachHangID, string HoTen, string DiaChi, string DienThoai, string CMND, string NgaySinh, string NoiSinh,
            string SoVisa, string ThoiHanVisa, string NguoiTiepNhan, string NgayNhapCanh, string TamTruTuNgay, string TamTruDenNgay,
            int QuocTichID, int GioiTinh, string ModifiedByUser, string ModifiedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SQLDB.Addparameter("@HoTen", HoTen);
            SQLDB.Addparameter("@DiaChi", DiaChi);
            SQLDB.Addparameter("@DienThoai", DienThoai);
            SQLDB.Addparameter("@CMND", CMND);
            SQLDB.Addparameter("@NgaySinh", NgaySinh);
            SQLDB.Addparameter("@NoiSinh", NoiSinh);
            SQLDB.Addparameter("@SoVisa", SoVisa);
            SQLDB.Addparameter("@ThoiHanVisa", ThoiHanVisa);
            SQLDB.Addparameter("@NguoiTiepNhan", NguoiTiepNhan);
            SQLDB.Addparameter("@NgayNhapCanh", NgayNhapCanh);
            SQLDB.Addparameter("@TamTruTuNgay", TamTruTuNgay);
            SQLDB.Addparameter("@TamTruDenNgay", TamTruDenNgay);
            SQLDB.Addparameter("@QuocTichID", QuocTichID);
            SQLDB.Addparameter("@GioiTinh", GioiTinh);
            SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_KhachHang_Edit", CommandType.StoredProcedure);
        }
        public void KhachHang_Delete(int KhachHangID, string DeletedByUser, string DeletedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SQLDB.Addparameter("@DeletedByUser", DeletedByUser);
            SQLDB.Addparameter("@DeletedDate", DeletedDate);
            SQLDB.executenonquery("sp_KhachHang_Delete", CommandType.StoredProcedure);
        }
        public KhachHangInfo KhachHang_GetItem(int KhachHangID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SqlDataReader rd = SQLDB.executereader("sp_KhachHang_GetItem", CommandType.StoredProcedure);
            KhachHangInfo item = null;
            while (rd.Read())
            {
                item = new KhachHangInfo();
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.DiaChi = rd["DiaChi"].ToString();
                item.DienThoai = rd["DienThoai"].ToString();
                item.CMND = rd["CMND"].ToString();
                item.NgaySinh = rd["NgaySinh"].ToString();
                item.NoiSinh = rd["NoiSinh"].ToString();
                item.SoVisa = rd["SoVisa"].ToString();
                item.ThoiHanVisa = rd["ThoiHanVisa"].ToString();
                item.NguoiTiepNhan = rd["NguoiTiepNhan"].ToString();
                item.NgayNhapCanh = rd["NgayNhapCanh"].ToString();
                item.TamTruTuNgay = rd["TamTruTuNgay"].ToString();
                item.TamTruDenNgay = rd["TamTruDenNgay"].ToString();
                item.QuocTichID = int.Parse(rd["QuocTichID"].ToString());
                item.GioiTinh = int.Parse(rd["GioiTinh"].ToString());
            }
            return item;
        }
        public List<KhachHangInfo> KhachHang_GetItems([Optional, DefaultParameterValue(0)] int KhachHangID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@KhachHangID", KhachHangID);
            SqlDataReader rd = SQLDB.executereader("sp_KhachHang_GetItems", CommandType.StoredProcedure);
            List<KhachHangInfo> list = new List<KhachHangInfo>();
            KhachHangInfo item = null;
            while (rd.Read())
            {
                item = new KhachHangInfo();
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                if (int.Parse(rd["TinhTrang"].ToString()) == 0)
                {
                    item.HoTen = rd["HoTen"].ToString();
                }
                else
                {
                    item.HoTen = rd["HoTen"].ToString() + " [Đã nhận phòng]";
                }                
                item.DiaChi = rd["DiaChi"].ToString();
                item.DienThoai = rd["DienThoai"].ToString();
                item.CMND = rd["CMND"].ToString();
                item.GioiTinh = int.Parse(rd["GioiTinh"].ToString());

                list.Add(item);
            }
            return list;
        }
        public List<KhachHangInfo> KhachHang_GetItemsInPhong([Optional, DefaultParameterValue(0)] int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_KhachHang_GetItemsInPhong", CommandType.StoredProcedure);
            List<KhachHangInfo> list = new List<KhachHangInfo>();
            KhachHangInfo item = null;
            while (rd.Read())
            {
                item = new KhachHangInfo();
                item.KhachHangID = int.Parse(rd["KhachHangID"].ToString());
                item.HoTen = rd["HoTen"].ToString();
                item.DiaChi = rd["DiaChi"].ToString();
                item.DienThoai = rd["DienThoai"].ToString();
                item.CMND = rd["CMND"].ToString();
                item.GioiTinh = int.Parse(rd["GioiTinh"].ToString());

                list.Add(item);
            }
            return list;
        }
    }
}


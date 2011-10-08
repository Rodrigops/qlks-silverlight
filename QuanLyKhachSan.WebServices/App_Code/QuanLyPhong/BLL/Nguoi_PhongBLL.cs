using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class Nguoi_PhongBLL
    {
        public static void Nguoi_Phong_Add(string ListPhongID, string ListNguoiPhongName, string ListCongThem, string CongThemTiepTheo)
        {
            Nguoi_PhongDAL doit = new Nguoi_PhongDAL();
            doit.Nguoi_Phong_Add(ListPhongID, ListNguoiPhongName, ListCongThem, CongThemTiepTheo);
        }
        public static List<Nguoi_PhongInfo> Nguoi_Phong_GetItemByPhongID(int PhongID)
        {
            Nguoi_PhongDAL doit = new Nguoi_PhongDAL();
            return doit.Nguoi_Phong_GetItemByPhongID(PhongID);
        }
    }
}
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class HoaDonBAL
    {
        public static void HoaDon_Add(string LoaiHoaDon,decimal KhuyenMai,string GhiChu,string NgayVao,int NgayVao_So,int GioVao,int PhutVao, int ThangVao,int NamVao,string NgayRa,int NgayRa_So,int GioRa,int PhutRa,int ThangRa,int NamRa,int UserID)
        {
            HoaDonDAL doit = new HoaDonDAL();
            doit.HoaDon_Add(LoaiHoaDon, KhuyenMai, GhiChu, NgayVao, NgayVao_So, GioVao, PhutVao, ThangVao, NamVao, NgayRa, NgayRa_So, GioRa, PhutRa, ThangRa, NamRa, UserID);
        }
        public static HoaDonInfo HoaDon_GetItem(int HoaDonID)
        {
            HoaDonDAL doit = new HoaDonDAL();
            return doit.HoaDon_GetItem(HoaDonID);
        }
    }
}
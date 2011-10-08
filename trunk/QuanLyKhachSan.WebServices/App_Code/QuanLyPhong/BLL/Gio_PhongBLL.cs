using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class Gio_PhongBLL
    {
        public static void Gio_Phong_Add(string ListPhongID, string ListGioPhongName, int PhanTram, string ListGiaTien, string Status)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            doit.Gio_Phong_Add(ListPhongID, ListGioPhongName, PhanTram, ListGiaTien, Status);
        }
        public static void Gio_Phong_Edit(int Gio_PhongID, int PhongID, string GioPhongName, int PhanTram, decimal GiaTien, string Status)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            doit.Gio_Phong_Edit(Gio_PhongID,PhongID,GioPhongName,PhanTram,GiaTien,Status);
        }
        public static void Gio_Phong_Delete(int Gio_PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            doit.Gio_Phong_Delete(Gio_PhongID);
        }

        public static Gio_PhongInfo Gio_Phong_GetItem(int Gio_PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GetItem(Gio_PhongID);
        }

        public static List<Gio_PhongInfo> Gio_Phong_GetItems(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GetItems(PhongID);
        }
        public static decimal Gio_Phong_GiaGoc(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GiaGoc(PhongID);
        }
        public static string Gio_Phong_KiemTraStatus(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_KiemTraStatus(PhongID);
        }
        public static List<Gio_PhongInfo> Gio_Phong_GetItemByPhongID(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GetItemByPhongID(PhongID);
        }
    }
}
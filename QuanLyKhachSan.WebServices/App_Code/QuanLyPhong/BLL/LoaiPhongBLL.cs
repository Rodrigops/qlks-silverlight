using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class LoaiPhongBLL
    {
        public static void LoaiPhong_Add(string LoaiPhongName)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            doit.LoaiPhong_Add(LoaiPhongName);    
        }
        public static void LoaiPhong_Edit(int LoaiPhongID,string LoaiPhongName)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            doit.LoaiPhong_Edit(LoaiPhongID,LoaiPhongName);
        }
        public static void LoaiPhong_Delete(int LoaiPhongID)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            doit.LoaiPhong_Delete(LoaiPhongID);
        }

        public static LoaiPhongInfo LoaiPhong_GetItem(int LoaiPhongID)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            return doit.LoaiPhong_GetItem(LoaiPhongID);
        }

        public static List<LoaiPhongInfo> LoaiPhong_GetItems()
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            return doit.LoaiPhong_GetItems();
        }
    }
}
using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class Ngay_PhongBLL
    {
        public static void Ngay_Phong_Add(string ListPhongID, decimal GiaNgay, decimal GiaTuan, decimal GiaThang)
        {
            Ngay_PhongDAL doit = new Ngay_PhongDAL();
            doit.Ngay_Phong_Add(ListPhongID, GiaNgay, GiaTuan, GiaThang);
        }
        public static Ngay_PhongInfo Ngay_Phong_GetItemByPhongID(int PhongID)
        {
            Ngay_PhongDAL doit = new Ngay_PhongDAL();
            return doit.Ngay_Phong_GetItemByPhongID(PhongID);
        }
    }
}
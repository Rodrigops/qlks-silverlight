using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class Gia_PhongBLL
    {
        public static List<Gia_PhongInfo> Phong_GiaPhong()
        {
            Gia_PhongDAL doit = new Gia_PhongDAL();
            return doit.Phong_GiaPhong();
        }

    }
}
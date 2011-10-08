using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class DichVuBLL
    {
        public static void DichVu_Add(string DichVuName, decimal GiaTien)
        {
            DichVuDAL doit = new DichVuDAL();
            doit.DichVu_Add(DichVuName, GiaTien);
        }
        public static void DichVu_Edit(int DichVuID, string DichVuName, decimal GiaTien)
        {
            DichVuDAL doit = new DichVuDAL();
            doit.DichVu_Edit(DichVuID, DichVuName, GiaTien);
        }
        public static void DichVu_Delete(int DichVuID)
        {
            DichVuDAL doit = new DichVuDAL();
            doit.DichVu_Delete(DichVuID);
        }

        public static DichVuInfo DichVu_GetItem(int DichVuID)
        {
            DichVuDAL doit = new DichVuDAL();
            return doit.DichVu_GetItem(DichVuID);
        }

        public static List<DichVuInfo> DichVu_GetItems()
        {
            DichVuDAL doit = new DichVuDAL();
            return doit.DichVu_GetItems();
        }
    }
}
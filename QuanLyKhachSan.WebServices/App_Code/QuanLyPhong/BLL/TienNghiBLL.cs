using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class TienNghiBLL
    {
        public static void TienNghi_Add(string TienNghiName,int TienNghi_UuTien)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_Add(TienNghiName, TienNghi_UuTien);
        }
        public static void TienNghi_Edit(int TienNghiID, string TienNghiName, int TienNghi_UuTien)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_Edit(TienNghiID, TienNghiName, TienNghi_UuTien);
        }
        public static void TienNghi_Delete(int TienNghiID)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_Delete(TienNghiID);
        }

        public static TienNghiInfo TienNghi_GetItem(int TienNghiID)
        {
            TienNghiDAL doit = new TienNghiDAL();
            return doit.TienNghi_GetItem(TienNghiID);
        }

        public static List<TienNghiInfo> TienNghi_GetItems()
        {
            TienNghiDAL doit = new TienNghiDAL();
            return doit.TienNghi_GetItems();
        }
        public static void TienNghi_SapXep(string ListTienNghiID)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_SapXep(ListTienNghiID);
        }
    }
}
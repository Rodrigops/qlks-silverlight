using System.Collections.Generic;
using System.Data;
namespace QuanLyKhachSan
{
    public class QuocTichBLL
    {
        public static void QuocTich_Add(string TenQuocTich)
        {
            QuocTichDAL doit = new QuocTichDAL();
            doit.QuocTich_Add(TenQuocTich);    
        }
        public static void QuocTich_Edit(int QuocTichID, string TenQuocTich)
        {
            QuocTichDAL doit = new QuocTichDAL();
            doit.QuocTich_Edit(QuocTichID, TenQuocTich);
        }
        public static void QuocTich_Delete(int QuocTichID)
        {
            QuocTichDAL doit = new QuocTichDAL();
            doit.QuocTich_Delete(QuocTichID);
        }

        public static QuocTichInfo QuocTich_GetItem(int QuocTichID)
        {
            QuocTichDAL doit = new QuocTichDAL();
            return doit.QuocTich_GetItem(QuocTichID);
        }

        public static List<QuocTichInfo> QuocTich_GetItems()
        {
            QuocTichDAL doit = new QuocTichDAL();
            return doit.QuocTich_GetItems();
        }
    }
}
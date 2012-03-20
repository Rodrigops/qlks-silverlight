using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class HoaDon_TraTruocBLL
    {
        public static void HoaDon_TraTruoc_Add(int HoaDonID, string GhiChu, decimal TraTruoc, string CreatedByUser, string CreatedDate)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            doit.HoaDon_TraTruoc_Add(HoaDonID, GhiChu, TraTruoc, CreatedByUser, CreatedDate);
        }
        public static void HoaDon_TraTruoc_Edit(int HoaDon_TraTruocID, int HoaDonID, string GhiChu, decimal TraTruoc, string ModifiedByUser, string ModifiedDate)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            doit.HoaDon_TraTruoc_Edit(HoaDon_TraTruocID, HoaDonID, GhiChu, TraTruoc, ModifiedByUser, ModifiedDate);
        }
        public static void HoaDon_TraTruoc_Delete(int HoaDon_TraTruocID)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            doit.HoaDon_TraTruoc_Delete(HoaDon_TraTruocID);
        }
        public static HoaDon_TraTruocInfo HoaDon_TraTruoc_GetItem(int HoaDon_TraTruocID)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            return doit.HoaDon_TraTruoc_GetItem(HoaDon_TraTruocID);
        }
        public static List<HoaDon_TraTruocInfo> HoaDon_TraTruoc_GetItems([Optional, DefaultParameterValue(0)] int HoaDon_TraTruocID)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            return doit.HoaDon_TraTruoc_GetItems(HoaDon_TraTruocID);
        }
    }
}
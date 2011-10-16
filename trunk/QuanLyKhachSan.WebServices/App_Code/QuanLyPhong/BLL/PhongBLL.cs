﻿using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class PhongBLL
    {
        public static void Phong_Add(int LoaiPhongId, string PhongName,int TienNghiID, int SoGiuong, int SoNguoi)
        {
            PhongDAL doit = new PhongDAL();
            doit.Phong_Add(LoaiPhongId, PhongName, TienNghiID, SoGiuong, SoNguoi);
        }
        public static void Phong_Edit(int PhongID, int LoaiPhongId, string PhongName, int TienNghiID, int SoGiuong, int SoNguoi)
        {
            PhongDAL doit = new PhongDAL();
            doit.Phong_Edit(PhongID,LoaiPhongId, PhongName,TienNghiID, SoGiuong, SoNguoi);
        }
        public static void Phong_Delete(int PhongID)
        {
            PhongDAL doit = new PhongDAL();
            doit.Phong_Delete(PhongID);
        }

        public static PhongInfo Phong_GetItem(int PhongID)
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItem(PhongID);
        }

        public static List<PhongInfo> Phong_GetItems([Optional, DefaultParameterValue(0)] int PhongID)
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItems(PhongID);
        }
        public static DataTable Phong_SoDoCay()
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_SoDoCay();
        }
        public static List<TinhTrang_PhongInfo> Phong_GetItems_ByTinhTrang()
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItems_ByTinhTrang();
        }
        public static List<PhongInfo> Phong_GetItemsOnService()
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItemsOnService();
        }
        public static void TinhTrang_Phong_Add(int PhongID, int TinhTrangPhongID, int NgayBatDau_So)
        {
            PhongDAL doit = new PhongDAL();
            doit.TinhTrang_Phong_Add(PhongID, TinhTrangPhongID, NgayBatDau_So);
        }
    }
}
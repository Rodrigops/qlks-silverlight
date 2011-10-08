using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;
using System.Linq;
namespace QuanLyKhachSan
{
    public class PhongDAL
    {
        public PhongDAL()
        {

        }
        public void Phong_Add(int LoaiPhongId,string PhongName,int TienNghiID,int SoGiuong,int SoNguoi)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@LoaiPhongId", LoaiPhongId);
            SQLDB.Addparameter("@PhongName", PhongName);
            SQLDB.Addparameter("@TienNghiID", TienNghiID);
            SQLDB.Addparameter("@SoGiuong", SoGiuong);
            SQLDB.Addparameter("@SoNguoi", SoNguoi);
            SQLDB.executenonquery("sp_Phong_Add", CommandType.StoredProcedure);                        
        }
        public void Phong_Edit(int PhongID, int LoaiPhongId, string PhongName, int TienNghiID, int SoGiuong, int SoNguoi)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.Addparameter("@LoaiPhongId", LoaiPhongId);
            SQLDB.Addparameter("@PhongName", PhongName);
            SQLDB.Addparameter("@TienNghiID", TienNghiID);
            SQLDB.Addparameter("@SoGiuong", SoGiuong);
            SQLDB.Addparameter("@SoNguoi", SoNguoi);
            SQLDB.executenonquery("sp_Phong_Edit", CommandType.StoredProcedure);
        }
        public void Phong_Delete(int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SQLDB.executenonquery("sp_Phong_Delete", CommandType.StoredProcedure);
        }
        public PhongInfo Phong_GetItem(int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
             SqlDataReader rd = SQLDB.executereader("sp_Phong_GetItem", CommandType.StoredProcedure);
             PhongInfo item = null;
            while (rd.Read())
            {
                item = new PhongInfo();
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.PhongName = rd["PhongName"].ToString();
                item.LoaiPhongID = int.Parse(rd["LoaiPhongID"].ToString());
                item.TienNghiID = int.Parse(rd["TienNghiID"].ToString());
                item.SoGiuong = int.Parse(rd["SoGiuong"].ToString());
                item.SoNguoi = int.Parse(rd["SoNguoi"].ToString());
                item.TienNghiName = rd["TienNghiName"].ToString();
            }
            return item;
        }
        public List<PhongInfo> Phong_GetItems([Optional,DefaultParameterValue(0)] int PhongID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@PhongID", PhongID);
            SqlDataReader rd = SQLDB.executereader("sp_Phong_GetItems", CommandType.StoredProcedure);
            List<PhongInfo> list = new List<PhongInfo>();
            PhongInfo item = null;
            while (rd.Read())
            {
                item = new PhongInfo();
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.PhongName = rd["PhongName"].ToString();
                item.LoaiPhongID = int.Parse(rd["LoaiPhongID"].ToString());
                item.LoaiPhongName = rd["LoaiPhongName"].ToString();
                item.SoGiuong = int.Parse(rd["SoGiuong"].ToString());
                item.SoNguoi = int.Parse(rd["SoNguoi"].ToString());
                item.TienNghiName = rd["TienNghiName"].ToString();
                list.Add(item);
            }
            return list;
        }
        public DataTable Phong_SoDoCay()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader sp = SQLDB.executereader("sp_Phong_SoDoCay", CommandType.StoredProcedure);
            DataTable retData = new DataTable();
            retData.Columns.Add("PhongID");
            retData.Columns.Add("LoaiPhongID");
            retData.Columns.Add("PhongName");
            DataRow newRow;
            while (sp.Read())
            {
                newRow = retData.NewRow();
                newRow["PhongID"] = sp["PhongID"].ToString();
                newRow["LoaiPhongID"] = sp["LoaiPhongID"].ToString() == "-1" ? null : sp["LoaiPhongID"].ToString();
                if (!string.IsNullOrEmpty(newRow["LoaiPhongID"].ToString()))
                {
                    if (newRow["LoaiPhongID"].ToString() == "0")
                    {
                        newRow["PhongID"] = "LP" + newRow["PhongID"];
                    }
                    else {
                        newRow["LoaiPhongID"] = "LP" + newRow["LoaiPhongID"];
                    }
                }
                newRow["PhongName"] = sp["PhongName"].ToString();
                retData.Rows.Add(newRow);
            }
            return retData;
        }

        public List<TinhTrang_PhongInfo> Phong_GetItems_ByTinhTrang()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_Phong_GetItems_ByTinhTrang", CommandType.StoredProcedure);
            List<TinhTrang_PhongInfo> list = new List<TinhTrang_PhongInfo>();
            TinhTrang_PhongInfo item = null;
            while (rd.Read())
            {
                item = new TinhTrang_PhongInfo();
                item.PhongID = int.Parse(rd["PhongID"].ToString());
                item.PhongName = rd["PhongName"].ToString();
                item.TinhTrangPhong = rd["TinhTrangPhong"].ToString();
                item.TinhTrangPhongID = int.Parse(rd["TinhTrangPhongID"].ToString());
                item.NgayBatDau_So = int.Parse(rd["NgayBatDau_So"].ToString());                
                item.NgayGioPhut_So = long.Parse( rd["NgayBatDau_So"].ToString() + rd["GioBatDau"].ToString() + rd["PhutBatDau"].ToString());
                list.Add(item);
            }
            //xu ly 
            List<TinhTrang_PhongInfo> tempList = null;
            List<TinhTrang_PhongInfo> retList = new List<TinhTrang_PhongInfo>();
            //TinhTrang_PhongInfo itemTemp = null;
            TinhTrang_PhongInfo itemMin = null;
            for (int i = 0; i < list.Count-1; i++)
            {
                tempList = new List<TinhTrang_PhongInfo>();
                tempList.Add(list[i]);
                for (int k = i + 1; k < list.Count; k++)
                {
                    if (list[i].PhongID == list[k].PhongID)
                    {
                        tempList.Add(list[k]);
                        list.RemoveAt(k);
                    }
                }
                itemMin = tempList[0];
                for (int j = 1; j < tempList.Count; j++)
                {
                    if (tempList[j].NgayGioPhut_So < itemMin.NgayGioPhut_So)
                    {
                        itemMin = tempList[j];                   
                    }
                }
                retList.Add(itemMin);
            }
                
                //temp = new List<TinhTrang_PhongInfo>();
                //for (var j = i + 1; j < list.Count; j++)
                //{
                //    if (itemTemp.PhongID == list[j].PhongID)
                //    {
                //        temp.Add(list[j]);
                //    }
                //}
                //temp.Add(itemTemp);
                //itemMin = temp[0];     
                //for (int k = 1; k < temp.Count; k++)
                //{
                //    if (temp[i].NgayBatDau_So < itemMin.NgayBatDau_So)
                //    {
                //        itemMin = temp[i];
                //    }
                //}
                //retList.Add(itemMin);
            //}
            return retList;
        }
    }
}


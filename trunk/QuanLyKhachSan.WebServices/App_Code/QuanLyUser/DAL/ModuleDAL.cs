using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class ModuleDAL
    {
        public ModuleDAL()
        {

        }        
        public List<ModuleInfo> Module_GetItems(int GroupID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@GroupID", GroupID);
            SqlDataReader rd = SQLDB.executereader("dbo.sp_Modules_GetItems", CommandType.StoredProcedure);
            List<ModuleInfo> list = new List<ModuleInfo>();
            ModuleInfo item = null;
            while (rd.Read())
            {
                item = new ModuleInfo();
                item.ModuleID = int.Parse(rd["ModuleID"].ToString());
                item.ModuleName =  rd["ModuleName"].ToString();
                item.ModuleKey = rd["ModuleKey"].ToString();
                item.TabID = int.Parse(rd["TabID"].ToString());
                item.TabName = rd["TabName"].ToString();
                item.ViewOrder = int.Parse(rd["ViewOrder"].ToString());
                item.IsView = int.Parse(rd["IsView"].ToString());
                item.IsEdit = int.Parse(rd["IsEdit"].ToString());
                list.Add(item);
            }
            return list;
        }
        public void ModulePermission_Add(int GroupID, string ListModulePermission)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@GroupID", GroupID);
            SQLDB.Addparameter("@ListModulePermission", ListModulePermission);
            SQLDB.executenonquery("sp_ModulePermission_Add", CommandType.StoredProcedure);
            
        }
    }
}


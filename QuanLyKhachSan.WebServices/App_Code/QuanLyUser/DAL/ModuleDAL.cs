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
        public List<ModuleInfo> Module_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
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
                list.Add(item);
            }
            return list;
        }
    
    }
}


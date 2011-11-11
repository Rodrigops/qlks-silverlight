using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class ModuleBLL
    {
        public List<ModuleInfo> Module_GetItems(int GroupID)
        {
            ModuleDAL doit = new ModuleDAL();
            return doit.Module_GetItems(GroupID);
        }
        public static void ModulePermission_Add(int GroupID, string ListModulePermission)
        {
            ModuleDAL doit = new ModuleDAL();
            doit.ModulePermission_Add(GroupID, ListModulePermission);
        }
    }
}
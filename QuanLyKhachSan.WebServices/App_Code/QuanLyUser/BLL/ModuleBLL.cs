using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class ModuleBLL
    {
        public List<ModuleInfo> Module_GetItems()
        {
            ModuleDAL doit = new ModuleDAL();
           return doit.Module_GetItems();
        }
       
    }
}
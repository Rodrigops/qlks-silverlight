using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class GroupBLL
    {
        public static void Group_Add(string GroupName, string Descriptions, int IsActived, int CreatedByUser, string CreatedDate)
        {
            GroupDAL doit = new GroupDAL();
            doit.Group_Add(GroupName, Descriptions, IsActived, CreatedByUser, CreatedDate);
        }
        public static void Group_Edit(int GroupID, string GroupName, string Descriptions, int IsActived, int ModifiedByUser, string ModifiedDate)
        {
            GroupDAL doit = new GroupDAL();
            doit.Group_Edit(GroupID, GroupName, Descriptions, IsActived, ModifiedByUser, ModifiedDate);
        }
        public static void Group_Delete(int GroupID)
        {
            GroupDAL doit = new GroupDAL();
            doit.Group_Delete(GroupID);
        }
        public static GroupInfo Group_GetItem(int GroupID)
        {
            GroupDAL doit = new GroupDAL();
            return doit.Group_GetItem(GroupID);
        }
        public static List<GroupInfo> Group_GetItems()
        {
            GroupDAL doit = new GroupDAL();
            return doit.Group_GetItems();
        }
        public static List<GroupInfo> Group_GetActivedItems()
        {
            GroupDAL doit = new GroupDAL();
            return doit.Group_GetActivedItems();
        }
       
    }
}
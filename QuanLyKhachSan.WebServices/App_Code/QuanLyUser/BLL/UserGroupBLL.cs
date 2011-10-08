using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class UserGroupBLL
    {
        public static void UserGroup_Add(int UserID, string ListGroupID, string ExpiryDate, string EffectiveDate, int IsTrialUsed)
        {
            UserGroupDAL doit = new UserGroupDAL();
            doit.UserGroup_Add(UserID, ListGroupID, ExpiryDate, EffectiveDate, IsTrialUsed);
        }
        public static void UserGroup_Edit(int UserGroupID, int UserID, string ListGroupID, string ExpiryDate, string EffectiveDate, int IsTrialUsed)
        {
            UserGroupDAL doit = new UserGroupDAL();
            doit.UserGroup_Edit(UserGroupID, UserID, ListGroupID, ExpiryDate, EffectiveDate, IsTrialUsed);
        }
        public static void UserGroup_Delete(int UserGroupID)
        {
            UserGroupDAL doit = new UserGroupDAL();
            doit.UserGroup_Delete(UserGroupID);
        }
        public static List<UserGroupInfo> UserGroup_GetItem(int UserID)
        {
            UserGroupDAL doit = new UserGroupDAL();
            return doit.UserGroup_GetItem(UserID);
        }
        public static List<UserGroupInfo> UserGroup_GetItems()
        {
            UserGroupDAL doit = new UserGroupDAL();
            return doit.UserGroup_GetItems();
        }
    }
}
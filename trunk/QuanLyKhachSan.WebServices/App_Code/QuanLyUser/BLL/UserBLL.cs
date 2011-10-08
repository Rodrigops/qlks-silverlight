using System.Collections.Generic;
using System.Data;
using System;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    public class UserBLL
    {
        public static void User_Add(string UserName, string PassWord, string FullName, string DisplayName, int IsActived, int CreatedByUser, string CreatedDate)
        {
            UserDAL doit = new UserDAL();
            doit.User_Add(UserName, PassWord, FullName, DisplayName, IsActived, CreatedByUser, CreatedDate);
        }
        public static void User_Edit(int UserID, string UserName, string PassWord, string FullName, string DisplayName, int IsActived, int ModifiedByUser, string ModifiedDate)
        {
            UserDAL doit = new UserDAL();
            doit.User_Edit(UserID, UserName, PassWord, FullName, DisplayName, IsActived, ModifiedByUser, ModifiedDate);
        }
        public static void User_Delete(int UserID)
        {
            UserDAL doit = new UserDAL();
            doit.User_Delete(UserID);
        }
        public static UserInfo User_GetItem(int UserID)
        {
            UserDAL doit = new UserDAL();
            return doit.User_GetItem(UserID);
        }
        public static List<UserInfo> User_GetItems([Optional, DefaultParameterValue(0)] int UserID)
        {
            UserDAL doit = new UserDAL();
            return doit.User_GetItems(UserID);
        }
        public static List<UserInfo> User_GetActivedItems()
        {
            UserDAL doit = new UserDAL();
            return doit.User_GetActivedItems();
        }
        public static int Users_Login(string UserName, string PassWord)
        {
            UserDAL doit = new UserDAL();
            return doit.Users_Login(UserName, PassWord);
        }
    }
}
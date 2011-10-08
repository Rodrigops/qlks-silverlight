using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class UserDAL
    {
        public UserDAL()
        {

        }
        public void User_Add(string UserName, string PassWord, string FullName, string DisplayName, int IsActived, int CreatedByUser, string CreatedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserName", UserName);
            SQLDB.Addparameter("@PassWord", PassWord);
            SQLDB.Addparameter("@FullName", FullName);
            SQLDB.Addparameter("@DisplayName", DisplayName);
            SQLDB.Addparameter("@IsActived", IsActived);
            SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_User_Add", CommandType.StoredProcedure);
        }
        public void User_Edit(int UserID, string UserName, string PassWord, string FullName, string DisplayName, int IsActived, int ModifiedByUser, string ModifiedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserID", UserID);
            SQLDB.Addparameter("@UserName", UserName);
            SQLDB.Addparameter("@PassWord", PassWord);
            SQLDB.Addparameter("@FullName", FullName);
            SQLDB.Addparameter("@DisplayName", DisplayName);
            SQLDB.Addparameter("@IsActived", IsActived);
            SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_User_Edit", CommandType.StoredProcedure);
        }
        public void User_Delete(int UserID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserID", UserID);
            SQLDB.executenonquery("sp_User_Delete", CommandType.StoredProcedure);
        }
        public UserInfo User_GetItem(int UserID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserID", UserID);
            SqlDataReader rd = SQLDB.executereader("sp_User_GetItem", CommandType.StoredProcedure);
            UserInfo item = null;
            while (rd.Read())
            {
                item = new UserInfo();
                item.UserID = int.Parse(rd["UserID"].ToString());
                item.UserName = rd["UserName"].ToString();
                item.FullName = rd["FullName"].ToString();
                item.DisplayName = rd["DisplayName"].ToString();
                item.IsActived = int.Parse(rd["IsActived"].ToString());
            }
            return item;
        }
        public List<UserInfo> User_GetItems([Optional, DefaultParameterValue(0)] int UserID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserID", UserID);
            SqlDataReader rd = SQLDB.executereader("sp_User_GetItems", CommandType.StoredProcedure);
            List<UserInfo> list = new List<UserInfo>();
            UserInfo item = null;
            while (rd.Read())
            {
                item = new UserInfo();
                item.UserID = int.Parse(rd["UserID"].ToString());
                item.UserName = rd["UserName"].ToString();
                item.FullName = rd["FullName"].ToString();
                item.DisplayName = rd["DisplayName"].ToString();
                item.IsActived = int.Parse(rd["IsActived"].ToString());

                list.Add(item);
            }
            return list;
        }
        public List<UserInfo> User_GetActivedItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_User_GetActivedItems", CommandType.StoredProcedure);
            List<UserInfo> list = new List<UserInfo>();
            UserInfo item = null;
            while (rd.Read())
            {
                item = new UserInfo();
                item.UserID = int.Parse(rd["UserID"].ToString());
                item.UserName = rd["UserName"].ToString();

                list.Add(item);
            }
            return list;
        }
        public int Users_Login( string UserName,string PassWord)
        {
            object result;
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserName", UserName);
            SQLDB.Addparameter("@PassWord", PassWord);
            result = SQLDB.executesalar("sp_Users_Login", CommandType.StoredProcedure);
            return int.Parse(result.ToString());
        }
    }
}


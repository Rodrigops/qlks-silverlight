using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class UserGroupDAL
    {
        public UserGroupDAL()
        {

        }
        public void UserGroup_Add(int UserID, string ListGroupID, string ExpiryDate, string EffectiveDate, int IsTrialUsed)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserID", UserID);
            SQLDB.Addparameter("@ListGroupID", ListGroupID);
            SQLDB.Addparameter("@ExpiryDate", ExpiryDate);
            SQLDB.Addparameter("@EffectiveDate", EffectiveDate);
            SQLDB.Addparameter("@IsTrialUsed", IsTrialUsed);
            //SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            //SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_UserGroup_Add", CommandType.StoredProcedure);
        }
        public void UserGroup_Edit(int UserGroupID, int UserID, string ListGroupID, string ExpiryDate, string EffectiveDate, int IsTrialUsed)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserGroupID", UserGroupID);
            SQLDB.Addparameter("@UserID", UserID);
            SQLDB.Addparameter("@ListGroupID", ListGroupID);
            SQLDB.Addparameter("@ExpiryDate", ExpiryDate);
            SQLDB.Addparameter("@EffectiveDate", EffectiveDate);
            SQLDB.Addparameter("@IsTrialUsed", IsTrialUsed);
            //SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            //SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_UserGroup_Edit", CommandType.StoredProcedure);
        }
        public void UserGroup_Delete(int UserGroupID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserGroupID", UserGroupID);
            SQLDB.executenonquery("sp_UserGroup_Delete", CommandType.StoredProcedure);
        }
        public List<UserGroupInfo> UserGroup_GetItem(int UserID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@UserID", UserID);
            SqlDataReader rd = SQLDB.executereader("sp_UserGroup_GetItem", CommandType.StoredProcedure);
            List<UserGroupInfo> list = new List<UserGroupInfo>();
            UserGroupInfo item = null;
            while (rd.Read())
            {
                item = new UserGroupInfo();
                item.UserGroupID = int.Parse(rd["UserGroupID"].ToString());
                item.UserID = int.Parse(rd["UserID"].ToString());
                item.GroupID = int.Parse(rd["GroupID"].ToString());
                item.ExpiryDate = rd["ExpiryDate"].ToString();
                item.EffectiveDate = rd["EffectiveDate"].ToString();
                item.IsTrialUsed = int.Parse(rd["IsTrialUsed"].ToString());

                list.Add(item);
            }
            return list;
        }
        public List<UserGroupInfo> UserGroup_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_UserGroup_GetItems", CommandType.StoredProcedure);
            List<UserGroupInfo> list = new List<UserGroupInfo>();
            UserGroupInfo item = null;
            while (rd.Read())
            {
                item = new UserGroupInfo();
                item.UserGroupID = int.Parse(rd["UserGroupID"].ToString());
                item.UserID = int.Parse(rd["UserID"].ToString());
                item.UserName = rd["UserName"].ToString();
                item.FullName = rd["FullName"].ToString();
                item.DisplayName = rd["DisplayName"].ToString();
                item.GroupID = int.Parse(rd["GroupID"].ToString());
                item.GroupName = rd["GroupName"].ToString();
                item.ExpiryDate = rd["ExpiryDate"].ToString();
                item.EffectiveDate = rd["EffectiveDate"].ToString();
                item.IsTrialUsed = int.Parse(rd["IsTrialUsed"].ToString());

                list.Add(item);
            }
            return list;
        }
    }
}


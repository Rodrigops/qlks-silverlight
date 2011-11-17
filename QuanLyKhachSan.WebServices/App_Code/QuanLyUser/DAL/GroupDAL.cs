using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Runtime.InteropServices;

namespace QuanLyKhachSan
{
    public class GroupDAL
    {
        public GroupDAL()
        {

        }
        public void Group_Add(string GroupName, string Descriptions, int IsActived, int CreatedByUser, string CreatedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@GroupName", GroupName);
            SQLDB.Addparameter("@Descriptions", Descriptions);
            SQLDB.Addparameter("@IsActived", IsActived);
            SQLDB.Addparameter("@CreatedByUser", CreatedByUser);
            SQLDB.Addparameter("@CreatedDate", CreatedDate);
            SQLDB.executenonquery("sp_Group_Add", CommandType.StoredProcedure);
        }
        public void Group_Edit(int GroupID, string GroupName, string Descriptions, int IsActived, int ModifiedByUser, string ModifiedDate)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@GroupID", GroupID);
            SQLDB.Addparameter("@GroupName", GroupName);
            SQLDB.Addparameter("@Descriptions", Descriptions);
            SQLDB.Addparameter("@IsActived", IsActived);
            SQLDB.Addparameter("@ModifiedByUser", ModifiedByUser);
            SQLDB.Addparameter("@ModifiedDate", ModifiedDate);
            SQLDB.executenonquery("sp_Group_Edit", CommandType.StoredProcedure);
        }
        public void Group_Delete(int GroupID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@GroupID", GroupID);
            SQLDB.executenonquery("sp_Group_Delete", CommandType.StoredProcedure);
        }
        public GroupInfo Group_GetItem(int GroupID)
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SQLDB.Addparameter("@GroupID", GroupID);
            SqlDataReader rd = SQLDB.executereader("sp_Group_GetItem", CommandType.StoredProcedure);
            GroupInfo item = null;
            while (rd.Read())
            {
                item = new GroupInfo();
                item.GroupID = int.Parse(rd["GroupID"].ToString());
                item.GroupName = rd["GroupName"].ToString();
                item.Descriptions = rd["Descriptions"].ToString();
                item.IsActived = int.Parse(rd["IsActived"].ToString());
            }
            return item;
        }
        public List<GroupInfo> Group_GetItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_Group_GetItems", CommandType.StoredProcedure);
            List<GroupInfo> list = new List<GroupInfo>();
            GroupInfo item = null;
            while (rd.Read())
            {
                item = new GroupInfo();
                item.GroupID = int.Parse(rd["GroupID"].ToString());
                item.GroupName = rd["GroupName"].ToString();
                item.Descriptions = rd["Descriptions"].ToString();
                item.IsActived = int.Parse(rd["IsActived"].ToString());

                list.Add(item);
            }
            return list;
        }
        public List<GroupInfo> Group_GetActivedItems()
        {
            SQLDataHelper SQLDB = new SQLDataHelper();
            SqlDataReader rd = SQLDB.executereader("sp_Group_GetActivedItems", CommandType.StoredProcedure);
            List<GroupInfo> list = new List<GroupInfo>();
            GroupInfo item = null;
            while (rd.Read())
            {
                item = new GroupInfo();
                item.GroupID = int.Parse(rd["GroupID"].ToString());
                item.GroupName = rd["GroupName"].ToString();

                list.Add(item);
            }
            return list;
        }
       
    }
}


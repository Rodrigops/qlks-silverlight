using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class GroupSVC
    {
        [OperationContract]
        public void Group_Add(string GroupName, string Descriptions, int IsActived, int CreatedByUser, string CreatedDate)
        {
            GroupDAL doit = new GroupDAL();
            doit.Group_Add(GroupName, Descriptions, IsActived, CreatedByUser, CreatedDate);
        }
        [OperationContract]
        public void Group_Edit(int GroupID, string GroupName, string Descriptions, int IsActived, int ModifiedByUser, string ModifiedDate)
        {
            GroupDAL doit = new GroupDAL();
            doit.Group_Edit(GroupID, GroupName, Descriptions, IsActived, ModifiedByUser, ModifiedDate);
        }
        [OperationContract]
        public void Group_Delete(int GroupID)
        {
            GroupDAL doit = new GroupDAL();
            doit.Group_Delete(GroupID);
        }
        [OperationContract]
        public GroupInfo Group_GetItem(int GroupID)
        {
            GroupDAL doit = new GroupDAL();
            return doit.Group_GetItem(GroupID);
        }
        [OperationContract]
        public List<GroupInfo> Group_GetItems()
        {
            GroupDAL doit = new GroupDAL();
            return doit.Group_GetItems();
        }
        [OperationContract]
        public List<GroupInfo> Group_GetActivedItems()
        {
            GroupDAL doit = new GroupDAL();
            return doit.Group_GetActivedItems();
        }
    }
}

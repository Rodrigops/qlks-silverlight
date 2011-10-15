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
    public class UserGroupSVC
    {
        [OperationContract]
        public void UserGroup_Add(int UserID, string ListGroupID, string ExpiryDate, string EffectiveDate, int IsTrialUsed)
        {
            UserGroupDAL doit = new UserGroupDAL();
            doit.UserGroup_Add(UserID, ListGroupID, ExpiryDate, EffectiveDate, IsTrialUsed);
        }
        [OperationContract]
        public void UserGroup_Edit(int UserGroupID, int UserID, string ListGroupID, string ExpiryDate, string EffectiveDate, int IsTrialUsed)
        {
            UserGroupDAL doit = new UserGroupDAL();
            doit.UserGroup_Edit(UserGroupID, UserID, ListGroupID, ExpiryDate, EffectiveDate, IsTrialUsed);
        }
        [OperationContract]
        public void UserGroup_Delete(int UserGroupID)
        {
            UserGroupDAL doit = new UserGroupDAL();
            doit.UserGroup_Delete(UserGroupID);
        }
        [OperationContract]
        public List<UserGroupInfo> UserGroup_GetItem(int UserID)
        {
            UserGroupDAL doit = new UserGroupDAL();
            return doit.UserGroup_GetItem(UserID);
        }
        [OperationContract]
        public List<UserGroupInfo> UserGroup_GetItems()
        {
            UserGroupDAL doit = new UserGroupDAL();
            return doit.UserGroup_GetItems();
        }
    }
}

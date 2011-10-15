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
    public class UserSVC
    {
        [OperationContract]
        public void User_Add(string UserName, string PassWord, string FullName, string DisplayName, int IsActived, int CreatedByUser, string CreatedDate)
        {
            UserDAL doit = new UserDAL();
            doit.User_Add(UserName, PassWord, FullName, DisplayName, IsActived, CreatedByUser, CreatedDate);
        }
        [OperationContract]
        public void User_Edit(int UserID, string UserName, string PassWord, string FullName, string DisplayName, int IsActived, int ModifiedByUser, string ModifiedDate)
        {
            UserDAL doit = new UserDAL();
            doit.User_Edit(UserID, UserName, PassWord, FullName, DisplayName, IsActived, ModifiedByUser, ModifiedDate);
        }
        [OperationContract]
        public void User_Delete(int UserID)
        {
            UserDAL doit = new UserDAL();
            doit.User_Delete(UserID);
        }
        [OperationContract]
        public UserInfo User_GetItem(int UserID)
        {
            UserDAL doit = new UserDAL();
            return doit.User_GetItem(UserID);
        }
        [OperationContract]
        public List<UserInfo> User_GetItems([Optional, DefaultParameterValue(0)] int UserID)
        {
            UserDAL doit = new UserDAL();
            return doit.User_GetItems(UserID);
        }
        [OperationContract]
        public List<UserInfo> User_GetActivedItems()
        {
            UserDAL doit = new UserDAL();
            return doit.User_GetActivedItems();
        }
        [OperationContract]
        public int Users_Login(string UserName, string PassWord)
        {
            UserDAL doit = new UserDAL();
            return doit.Users_Login(UserName, PassWord);
        }
    }
}

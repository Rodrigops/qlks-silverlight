using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Runtime.InteropServices;
using System.Web.Security;
using System.Web.ApplicationServices;
using System.Web;
namespace QuanLyKhachSan
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class ManagementUserSVC
    {
        [OperationContract]
        public MembershipUserCollection GetAllUsers()
        {
            return Membership.GetAllUsers();
        }
        [OperationContract]
        public void CreateUser(string UserName, string Password, string Email)
        {
            Membership.CreateUser(UserName, Password, Email);            
        }
        [OperationContract]
        public void UpdateUser(string UserName,string Email)
        {
            MembershipUser user = Membership.GetUser(UserName);
            user.Email = Email;            
            Membership.UpdateUser(user);
        }
        [OperationContract]
        public void DeleteUser(string UserName)
        {
            Membership.DeleteUser(UserName);
        }
    }
}

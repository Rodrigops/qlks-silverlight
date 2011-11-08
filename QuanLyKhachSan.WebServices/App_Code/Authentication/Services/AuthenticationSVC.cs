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
    public class AuthenticationSVC
    {
        [OperationContract]
        public void Authentication_SetSession(string UserName)
        {
            System.Web.HttpContext.Current.Session["username"] = UserName;
        }
        [OperationContract]
        public string Authentication_CheckAccount(string UserName,string PassWord)
        {
            int result = UserBLL.Users_Login(UserName, PassWord);
            if (result == 1)
            {
                System.Web.HttpContext.Current.Session["username"] = UserName;
                return "Success";
            }
            else
            {
                return "Fail";
            }
        }
        [OperationContract]
        public string Authentication_GetSession()
        {
            if (System.Web.HttpContext.Current.Session["username"] != null)
            {
                return System.Web.HttpContext.Current.Session["username"].ToString();
            }
            else
            {
                return "";
            }
        }
    }
}
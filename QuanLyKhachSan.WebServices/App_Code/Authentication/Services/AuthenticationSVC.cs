using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace QuanLyKhachSan
{
    /// <summary>
    /// Summary description for CurrentUser
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class AuthenticationSVC : System.Web.Services.WebService
    {

        public AuthenticationSVC()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod(EnableSession = true)]
        public void Authentication_SetSession(string UserName)
        {
            System.Web.HttpContext.Current.Session["username"] = UserName;
        }
        [WebMethod(EnableSession = true)]
        public string Authentication_CheckAccount(string UserName, string PassWord)
        {
            int result = UserBLL.Users_Login(UserName, PassWord);
            if (result >= 1)
            {
                System.Web.HttpContext.Current.Session["username"] = UserName;
                return result.ToString();
            }
            else
            {
                return "Fail";
            }
        }
        [WebMethod(EnableSession = true)]
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
//namespace QuanLyKhachSan
//{
//    [ServiceContract(Namespace = "")]
//    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    
    
//    public class AuthenticationSVC
//    {
//        [OperationContract]
//        public void Authentication_SetSession(string UserName)
//        {
//            System.Web.HttpContext.Current.Session["username"] = UserName;
//        }
//        [OperationContract]
//        public string Authentication_CheckAccount(string UserName,string PassWord)
//        {
//            int result = UserBLL.Users_Login(UserName, PassWord);
//            if (result == 1)
//            {
//                System.Web.HttpContext.Current.Session["username"] = UserName;
//                return "Success";
//            }
//            else
//            {
//                return "Fail";
//            }
//        }
//        [OperationContract]        
//        public string Authentication_GetSession()
//        {
           
//            if (System.Web.HttpContext.Current.Session["username"]!=null)
//            {
//                return System.Web.HttpContext.Current.Session["username"].ToString();
//            }
//            else
//            {
//                return "";
//            }
//        }
//    }
//}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace QuanLyKhachSan
{
    /// <summary>
    /// Summary description for UserGroup
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class UserGroup : System.Web.Services.WebService
    {

        public UserGroup()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public void UserGroup_Delete(string UserGroupID)
        {
            try
            {
                UserGroupBLL.UserGroup_Delete(int.Parse(UserGroupID));
            }
            catch (Exception)
            {                
                throw;
            }
        }

    }

}
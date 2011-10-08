using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace QuanLyKhachSan
{
    /// <summary>
    /// Summary description for Group
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class Group : System.Web.Services.WebService
    {

        public Group()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public void Group_Delete(string GroupID)
        {
            try
            {
                GroupBLL.Group_Delete(int.Parse(GroupID));
            }
            catch (Exception)
            {                
                throw;
            }
        }

    }

}
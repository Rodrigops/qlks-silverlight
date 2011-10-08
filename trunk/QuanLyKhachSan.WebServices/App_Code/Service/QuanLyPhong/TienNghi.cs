using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace QuanLyKhachSan
{
    /// <summary>
    /// Summary description for TienNghi
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class TienNghi : System.Web.Services.WebService
    {

        public TienNghi()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public void TienNghi_Delete(string TienNghiID)
        {
            try
            {
                TienNghiBLL.TienNghi_Delete(int.Parse(TienNghiID));
            }
            catch (Exception ex)
            {
                
                throw ex;
            }
        }

    }
}

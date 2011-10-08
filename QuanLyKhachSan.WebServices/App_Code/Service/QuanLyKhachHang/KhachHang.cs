using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace QuanLyKhachSan
{
    /// <summary>
    /// Summary description for KhachHang
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class KhachHang : System.Web.Services.WebService
    {

        public KhachHang()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public void KhachHang_Delete(string KhachHangID)
        {
            try
            {
                KhachHangBLL.KhachHang_Delete(int.Parse(KhachHangID), 0, DateTime.Now.ToString("MM/dd/yyyy"));
            }
            catch (Exception)
            {                
                throw;
            }
        }

    }

}
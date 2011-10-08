using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
namespace QuanLyKhachSan
{
    /// <summary>
    /// Summary description for LoaiPhong
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    [System.Web.Script.Services.ScriptService]
    public class LoaiPhong : System.Web.Services.WebService
    {

        public LoaiPhong()
        {

            //Uncomment the following line if using designed components 
            //InitializeComponent(); 
        }

        [WebMethod]
        public void LoaiPhong_Delete(string LoaiPhongID)
        {
            try
            {
                LoaiPhongBLL.LoaiPhong_Delete(int.Parse(LoaiPhongID));
            }
            catch (Exception ex)
            {
                
                throw;
            }           
        }

    }
}

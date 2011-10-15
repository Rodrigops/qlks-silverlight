using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
namespace QuanLyKhachSan
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class HoaDonSVC
    {
        [OperationContract]
        public void HoaDon_Add(int UserId)
        {
            HoaDonDAL doit = new HoaDonDAL();
            doit.HoaDon_Add(UserId);
        }
    }
}

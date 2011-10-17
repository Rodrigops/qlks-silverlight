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
    public class Gia_PhongSVC
    {
        [OperationContract]
        public List<Gia_PhongInfo> Phong_GiaPhong()
        {
            Gia_PhongDAL doit = new Gia_PhongDAL();
            return doit.Phong_GiaPhong();
        }

    }
}
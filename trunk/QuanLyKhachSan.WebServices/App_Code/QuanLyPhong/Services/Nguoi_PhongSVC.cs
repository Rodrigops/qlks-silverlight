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
    public class Nguoi_PhongSVC
    {
        [OperationContract]
        public void Nguoi_Phong_Add(string ListPhongID, string ListNguoiPhongName, string ListCongThem, string CongThemTiepTheo)
        {
            Nguoi_PhongDAL doit = new Nguoi_PhongDAL();
            doit.Nguoi_Phong_Add(ListPhongID, ListNguoiPhongName, ListCongThem, CongThemTiepTheo);
        }
        [OperationContract]
        public List<Nguoi_PhongInfo> Nguoi_Phong_GetItemByPhongID(int PhongID)
        {
            Nguoi_PhongDAL doit = new Nguoi_PhongDAL();
            return doit.Nguoi_Phong_GetItemByPhongID(PhongID);
        }
    }
}
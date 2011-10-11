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
    public class Ngay_PhongSVC
    {
        [OperationContract]
        public void Ngay_Phong_Add(string ListPhongID, decimal GiaNgay, decimal GiaTuan, decimal GiaThang)
        {
            Ngay_PhongDAL doit = new Ngay_PhongDAL();
            doit.Ngay_Phong_Add(ListPhongID, GiaNgay, GiaTuan, GiaThang);
        }
        [OperationContract]
        public Ngay_PhongInfo Ngay_Phong_GetItemByPhongID(int PhongID)
        {
            Ngay_PhongDAL doit = new Ngay_PhongDAL();
            return doit.Ngay_Phong_GetItemByPhongID(PhongID);
        }
    }
}
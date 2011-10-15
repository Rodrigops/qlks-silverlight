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
    public class HoaDon_KhachHangSVC
    {
        [OperationContract]
        public void HoaDon_KhachHang_Add(int KhachHangId, int PhongID, string NgayBatDau, int GioBatDau, int PhutBatDau, int NgayBatDau_So, int ThangBatDau, int NamBatDau, string NgayKetThuc)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            doit.HoaDon_KhachHang_Add(KhachHangId, PhongID, NgayBatDau, GioBatDau, PhutBatDau, NgayBatDau_So, ThangBatDau, NamBatDau, NgayKetThuc);
        }
    }
}

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
        public void HoaDon_Add(string LoaiHoaDon,decimal KhuyenMai,string GhiChu,string NgayVao,int NgayVao_So,int GioVao,int PhutVao, int ThangVao,int NamVao,string NgayRa,int NgayRa_So,int GioRa,int PhutRa,int ThangRa,int NamRa,int UserID)
        {
            HoaDonDAL doit = new HoaDonDAL();
            doit.HoaDon_Add(LoaiHoaDon, KhuyenMai, GhiChu, NgayVao, NgayVao_So, GioVao, PhutVao, ThangVao, NamVao, NgayRa, NgayRa_So, GioRa, PhutRa, ThangRa, NamRa, UserID);
        }
        [OperationContract]
        public HoaDonInfo HoaDon_GetItem(int HoaDonID)
        {
            HoaDonDAL doit = new HoaDonDAL();
            return doit.HoaDon_GetItem(HoaDonID);
        }
    }
}

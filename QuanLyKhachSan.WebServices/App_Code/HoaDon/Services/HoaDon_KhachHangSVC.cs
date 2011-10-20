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
        public void HoaDon_KhachHang_Add(string LoaiHoaDon,int KhachHangId, int PhongID, string NgayBatDau, int GioBatDau, int PhutBatDau, int NgayBatDau_So, int ThangBatDau, int NamBatDau, string NgayKetThuc)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            doit.HoaDon_KhachHang_Add(LoaiHoaDon, KhachHangId, PhongID, NgayBatDau, GioBatDau, PhutBatDau, NgayBatDau_So, ThangBatDau, NamBatDau, NgayKetThuc);
        }
        [OperationContract]
        public List<Phong_KhachHangInfo> Phong_KhachHang_GetItems(int HoaDonID, int PhongID)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            return doit.Phong_KhachHang_GetItems(HoaDonID, PhongID);
        }
        [OperationContract]
        public void Phong_KhachHang_Delete(int HoaDonID, int KhachHangID)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            doit.Phong_KhachHang_Delete(HoaDonID, KhachHangID);
        }
        [OperationContract]
        public List<Phong_KhachHangInfo> Phong_KhachHang_DatPhong(int PhongID)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            return doit.Phong_KhachHang_DatPhong(PhongID);
        }
        [OperationContract]
        public void HoaDon_KhachHang_EditPhong(int HoaDonID, int PhongID)
        {
            HoaDon_KhachHangDAL doit = new HoaDon_KhachHangDAL();
            doit.HoaDon_KhachHang_EditPhong(HoaDonID, PhongID);
        }
    }
}

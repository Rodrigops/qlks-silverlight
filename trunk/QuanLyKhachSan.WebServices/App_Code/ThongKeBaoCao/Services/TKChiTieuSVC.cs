using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class TKChiTieuSVC
    {
        [OperationContract]
        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoNgay(int NgayNhapSo)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TheoNgay(NgayNhapSo);
        }
        [OperationContract]
        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoThang(int ThangNhap, int NamNhap)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TheoThang(ThangNhap, NamNhap);
        }
        [OperationContract]
        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TheoNam(int NamNhap)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TheoNam(NamNhap);
        }
        [OperationContract]
        public List<TKChiTieuInfo> PhieuNhapKho_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            TKChiTieuDAL doit = new TKChiTieuDAL();
            return doit.PhieuNhapKho_GetItems_TuNgayDenNgay(TuNgaySo, DenNgaySo);
        }
    }
}

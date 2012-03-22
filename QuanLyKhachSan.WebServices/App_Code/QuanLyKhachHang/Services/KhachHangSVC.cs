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
    public class KhachHangSVC
    {
        [OperationContract]
        public void KhachHang_Add(string HoTen, string DiaChi, string DienThoai, string CMND, string NgaySinh, string NoiSinh,
            string SoVisa, string ThoiHanVisa, string NguoiTiepNhan, string NgayNhapCanh, string TamTruTuNgay, string TamTruDenNgay,
            int QuocTichID, int GioiTinh, string CreatedByUser, string CreatedDate)
        {
            KhachHangDAL doit = new KhachHangDAL();
            doit.KhachHang_Add(HoTen, DiaChi, DienThoai, CMND, NgaySinh, NoiSinh, SoVisa, ThoiHanVisa, NguoiTiepNhan, NgayNhapCanh,
                TamTruTuNgay, TamTruDenNgay, QuocTichID, GioiTinh, CreatedByUser, CreatedDate);
        }
        [OperationContract]
        public void KhachHang_Edit(int KhachHangID, string HoTen, string DiaChi, string DienThoai, string CMND, string NgaySinh, string NoiSinh,
            string SoVisa, string ThoiHanVisa, string NguoiTiepNhan, string NgayNhapCanh, string TamTruTuNgay, string TamTruDenNgay,
            int QuocTichID, int GioiTinh, string ModifiedByUser, string ModifiedDate)
        {
            KhachHangDAL doit = new KhachHangDAL();
            doit.KhachHang_Edit(KhachHangID, HoTen, DiaChi, DienThoai, CMND, NgaySinh, NoiSinh, SoVisa, ThoiHanVisa, NguoiTiepNhan, NgayNhapCanh,
                TamTruTuNgay, TamTruDenNgay, QuocTichID, GioiTinh, ModifiedByUser, ModifiedDate);
        }
        [OperationContract]
        public void KhachHang_Delete(int KhachHangID, string DeletedByUser, string DeletedDate)
        {
            KhachHangDAL doit = new KhachHangDAL();
            doit.KhachHang_Delete(KhachHangID, DeletedByUser, DeletedDate);
        }
        [OperationContract]
        public KhachHangInfo KhachHang_GetItem(int KhachHangID)
        {
            KhachHangDAL doit = new KhachHangDAL();
            return doit.KhachHang_GetItem(KhachHangID);
        }
        [OperationContract]
        public List<KhachHangInfo> KhachHang_GetItems([Optional, DefaultParameterValue(0)] int KhachHangID)
        {
            KhachHangDAL doit = new KhachHangDAL();
            return doit.KhachHang_GetItems(KhachHangID);
        }
        [OperationContract]
        public List<KhachHangInfo> KhachHang_GetItemsInPhong([Optional, DefaultParameterValue(0)] int PhongID)
        {
            KhachHangDAL doit = new KhachHangDAL();
            return doit.KhachHang_GetItemsInPhong(PhongID);
        }
    }
}

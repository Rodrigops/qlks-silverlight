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
    public class PhieuNhapKhoSVC
    {
        [OperationContract]
        public void PhieuNhapKho_Add(string NgayNhap, int ThangNhap, int NamNhap, int NgayNhapSo, string GhiChu,
            string CreatedByUser, string CreatedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Add(NgayNhap, ThangNhap, NamNhap, NgayNhapSo, GhiChu, CreatedByUser, CreatedDate);
        }
        [OperationContract]
        public void PhieuNhapKho_Edit(int PhieuNhapKhoID, string NgayNhap, int ThangNhap, int NamNhap, int NgayNhapSo, string GhiChu,
            string ModifiedByUser, string ModifiedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Edit(PhieuNhapKhoID, NgayNhap, ThangNhap, NamNhap, NgayNhapSo, GhiChu, ModifiedByUser, ModifiedDate);
        }
        [OperationContract]
        public void PhieuNhapKho_Delete(int PhieuNhapKhoID, string DeletedByUser, string DeletedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Delete(PhieuNhapKhoID, DeletedByUser, DeletedDate);
        }
        [OperationContract]
        public PhieuNhapKhoInfo PhieuNhapKho_GetItem(int PhieuNhapKhoID)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            return doit.PhieuNhapKho_GetItem(PhieuNhapKhoID);
        }
        [OperationContract]
        public List<PhieuNhapKhoInfo> PhieuNhapKho_GetItems()
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            return doit.PhieuNhapKho_GetItems();
        }
        [OperationContract]
        public PhieuNhapKhoInfo PhieuNhapKho_GetLatestItem()
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            return doit.PhieuNhapKho_GetLatestItem();
        }
    }
}

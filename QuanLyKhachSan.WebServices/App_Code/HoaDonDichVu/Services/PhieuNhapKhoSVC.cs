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
        public void PhieuNhapKho_Add(string NgayNhap, int ThangNhap, int NamNhap, string NgayNhapSo, string GhiChu,
            int CreatedByUser, string CreatedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Add(NgayNhap, ThangNhap, NamNhap, NgayNhapSo, GhiChu, CreatedByUser, CreatedDate);
        }
        [OperationContract]
        public void PhieuNhapKho_Edit(int PhieuNhapKhoID, string NgayNhap, int ThangNhap, int NamNhap, string NgayNhapSo, string GhiChu,
            int ModifiedByUser, string ModifiedDate)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            doit.PhieuNhapKho_Edit(PhieuNhapKhoID, NgayNhap, ThangNhap, NamNhap, NgayNhapSo, GhiChu, ModifiedByUser, ModifiedDate);
        }
        [OperationContract]
        public void PhieuNhapKho_Delete(int PhieuNhapKhoID, int DeletedByUser, string DeletedDate)
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
        public List<PhieuNhapKhoInfo> PhieuNhapKho_GetItems([Optional, DefaultParameterValue(0)] int PhieuNhapKhoID)
        {
            PhieuNhapKhoDAL doit = new PhieuNhapKhoDAL();
            return doit.PhieuNhapKho_GetItems(PhieuNhapKhoID);
        }
    }
}

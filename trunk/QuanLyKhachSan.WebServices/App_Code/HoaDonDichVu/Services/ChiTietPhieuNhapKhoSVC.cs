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
    public class ChiTietPhieuNhapKhoSVC
    {
        [OperationContract]
        public void ChiTietPhieuNhapKho_Add(int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Add(PhieuNhapKhoID, SoLuong, DonGia, ThanhTien, DichVuID);
        }
        [OperationContract]
        public void ChiTietPhieuNhapKho_Edit(int ChiTietPhieuNhapKho, int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Edit(ChiTietPhieuNhapKho, PhieuNhapKhoID, SoLuong, DonGia, ThanhTien, DichVuID);
        }
        [OperationContract]
        public void ChiTietPhieuNhapKho_Delete(int ChiTietPhieuNhapKho)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Delete(ChiTietPhieuNhapKho);
        }
        [OperationContract]
        public ChiTietPhieuNhapKhoInfo ChiTietPhieuNhapKho_GetItem(int ChiTietPhieuNhapKho)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            return doit.ChiTietPhieuNhapKho_GetItem(ChiTietPhieuNhapKho);
        }
    }
}

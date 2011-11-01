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
        public void ChiTietPhieuNhapKho_Edit(int ChiTietPhieuNhapID, int PhieuNhapKhoID, int SoLuong, decimal DonGia, decimal ThanhTien, int DichVuID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Edit(ChiTietPhieuNhapID, PhieuNhapKhoID, SoLuong, DonGia, ThanhTien, DichVuID);
        }
        [OperationContract]
        public void ChiTietPhieuNhapKho_Delete(int ChiTietPhieuNhapID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            doit.ChiTietPhieuNhapKho_Delete(ChiTietPhieuNhapID);
        }
        [OperationContract]
        public ChiTietPhieuNhapKhoInfo ChiTietPhieuNhapKho_GetItem(int ChiTietPhieuNhapID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            return doit.ChiTietPhieuNhapKho_GetItem(ChiTietPhieuNhapID);
        }
        [OperationContract]
        public List<ChiTietPhieuNhapKhoInfo> ChiTietPhieuNhapKho_GetItems([Optional, DefaultParameterValue(0)] int PhieuNhapKhoID)
        {
            ChiTietPhieuNhapKhoDAL doit = new ChiTietPhieuNhapKhoDAL();
            return doit.ChiTietPhieuNhapKho_GetItems(PhieuNhapKhoID);
        }
    }
}

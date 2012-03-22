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
    public class HoaDonDichVuSVC
    {
        [OperationContract]
        public void HoaDonDichVu_Add(int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int Thang, int Nam, int NgaySo,
            int SoLuong, decimal DonGia, decimal TongTien, string CreatedByUser, string CreatedDate)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonDichVu_Add(HoaDonID, PhongID, DichVuID, KhachHangID, NgaySuDung, Thang, Nam, NgaySo, SoLuong, DonGia, TongTien, CreatedByUser, CreatedDate);
        }
        [OperationContract]
        public void HoaDonDichVu_Edit(int HoaDon_DichVuID, int HoaDonID, int PhongID, int DichVuID, int KhachHangID, string NgaySuDung, int Thang, int Nam, int NgaySo,
            int SoLuong, decimal DonGia, decimal TongTien, string ModifiedByUser, string ModifiedDate)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonDichVu_Edit(HoaDon_DichVuID, HoaDonID, PhongID, DichVuID, KhachHangID, NgaySuDung, Thang, Nam, NgaySo, SoLuong, DonGia, TongTien, ModifiedByUser, ModifiedDate);
        }
        [OperationContract]
        public void HoaDonDichVu_Delete(int HoaDon_DichVuID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonDichVu_Delete(HoaDon_DichVuID);
        }
        [OperationContract]
        public HoaDonDichVuInfo HoaDonDichVu_GetItem(int HoaDon_DichVuID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            return doit.HoaDonDichVu_GetItem(HoaDon_DichVuID);
        }
        [OperationContract]
        public List<HoaDonDichVuInfo> HoaDonDichVu_GetItems([Optional, DefaultParameterValue(0)] int HoaDon_DichVuID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            return doit.HoaDonDichVu_GetItems(HoaDon_DichVuID);
        }
        [OperationContract]
        public List<HoaDonDichVuInfo> HoaDonDichVu_GetItemsByID([Optional, DefaultParameterValue(0)] int HoaDonID, [Optional, DefaultParameterValue(0)] int PhongID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            return doit.HoaDonDichVu_GetItemsByID(HoaDonID, PhongID);
        }
        [OperationContract]
        public HoaDonNgayVaoRaInfo HoaDonDichVu_GetItem_NgayVao([Optional, DefaultParameterValue(0)] int HoaDonID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            return doit.HoaDonDichVu_GetItem_NgayVao(HoaDonID);
        }
        [OperationContract]
        public void HoaDonNgayRa_Add(int HoaDonID, string NgayRa, int GioRa, int PhutRa, int NgayRa_So, int ThangRa, int NamRa)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonNgayRa_Add(HoaDonID, NgayRa, GioRa, PhutRa, NgayRa_So, ThangRa, NamRa);
        }
        [OperationContract]
        public void HoaDonDichVu_ChuyenPhong(int HoaDonID, int PhongID)
        {
            HoaDonDichVuDAL doit = new HoaDonDichVuDAL();
            doit.HoaDonDichVu_ChuyenPhong(HoaDonID, PhongID);
        }
    }
}

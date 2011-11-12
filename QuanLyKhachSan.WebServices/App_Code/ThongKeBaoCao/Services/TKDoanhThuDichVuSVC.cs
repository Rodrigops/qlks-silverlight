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
    public class TKDoanhThuDichVuSVC
    {
        [OperationContract]
        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoNgay(int NgaySo)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TheoNgay(NgaySo);
        }
        [OperationContract]
        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoThang(int Thang, int Nam)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TheoThang(Thang, Nam);
        }
        [OperationContract]
        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TheoNam(int Nam)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TheoNam(Nam);
        }
        [OperationContract]
        public List<TKDoanhThuDichVuInfo> HoaDonDichVu_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            TKDoanhThuDichVuDAL doit = new TKDoanhThuDichVuDAL();
            return doit.HoaDonDichVu_GetItems_TuNgayDenNgay(TuNgaySo, DenNgaySo);
        }
    }
}

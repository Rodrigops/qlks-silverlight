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
    public class TKDoanhThuSVC
    {
        [OperationContract]
        public List<TKDoanhThuInfo> HoaDon_GetItems_DaThanhToan()
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_DaThanhToan();
        }
        [OperationContract]
        public List<TKDoanhThuInfo> HoaDon_GetItems_TheoNgay(int NgayRaSo)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TheoNgay(NgayRaSo);
        }
        [OperationContract]
        public List<TKDoanhThuInfo> HoaDon_GetItems_TheoThang(int ThangRa, int NamRa)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TheoThang(ThangRa, NamRa);
        }
        [OperationContract]
        public List<TKDoanhThuInfo> HoaDon_GetItems_TheoNam(int NamRa)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TheoNam(NamRa);
        }
        [OperationContract]
        public List<TKDoanhThuInfo> HoaDon_GetItems_TuNgayDenNgay(int TuNgaySo, int DenNgaySo)
        {
            TKDoanhThuDAL doit = new TKDoanhThuDAL();
            return doit.HoaDon_GetItems_TuNgayDenNgay(TuNgaySo, DenNgaySo);
        }
    }
}

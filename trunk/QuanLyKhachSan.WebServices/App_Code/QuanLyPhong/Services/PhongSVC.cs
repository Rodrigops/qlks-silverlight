using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
using System.Data;
using System.Runtime.InteropServices;
namespace QuanLyKhachSan
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class PhongSVC
    {
        [OperationContract]
        public void Phong_Add(int LoaiPhongId, string PhongName, int TienNghiID, int SoGiuong, int SoNguoi)
        {
            PhongDAL doit = new PhongDAL();
            doit.Phong_Add(LoaiPhongId, PhongName, TienNghiID, SoGiuong, SoNguoi);
        }
        [OperationContract]
        public void Phong_Edit(int PhongID, int LoaiPhongId, string PhongName, int TienNghiID, int SoGiuong, int SoNguoi)
        {
            PhongDAL doit = new PhongDAL();
            doit.Phong_Edit(PhongID, LoaiPhongId, PhongName, TienNghiID, SoGiuong, SoNguoi);
        }
        [OperationContract]
        public void Phong_Delete(int PhongID)
        {
            PhongDAL doit = new PhongDAL();
            doit.Phong_Delete(PhongID);
        }
        [OperationContract]
        public PhongInfo Phong_GetItem(int PhongID)
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItem(PhongID);
        }
        [OperationContract]
        public List<PhongInfo> Phong_GetItems([Optional, DefaultParameterValue(0)] int PhongID)
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItems(PhongID);
        }
        [OperationContract]
        public  DataTable Phong_SoDoCay()
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_SoDoCay();
        }
        [OperationContract]
        public List<TinhTrang_PhongInfo> Phong_GetItems_ByTinhTrang()
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItems_ByTinhTrang();
        }
        [OperationContract]
        public List<PhongInfo> Phong_GetItemsOnService()
        {
            PhongDAL doit = new PhongDAL();
            return doit.Phong_GetItemsOnService();
        }
        [OperationContract]
        public void TinhTrang_Phong_Add(int HoaDonID,int PhongID, int TinhTrangPhongID,int NgayBatDau_So)
        {
            PhongDAL doit = new PhongDAL();
            doit.TinhTrang_Phong_Add(HoaDonID,PhongID, TinhTrangPhongID, NgayBatDau_So);
        }
        /// <summary>
        /// Dùng trong trường hợp chuyển phòng
        /// </summary>
        /// <param name="HoaDonID"></param>
        /// <param name="PhongID"></param>
        [OperationContract]
        public void TinhTrang_Phong_Edit(int HoaDonID, int PhongID)
        {
            PhongDAL doit = new PhongDAL();
            doit.TinhTrang_Phong_Edit(HoaDonID, PhongID);
        }
    }
}

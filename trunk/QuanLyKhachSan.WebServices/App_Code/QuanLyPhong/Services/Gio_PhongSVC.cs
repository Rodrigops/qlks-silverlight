using System;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Activation;
using System.Collections.Generic;
namespace QuanLyKhachSan
{
    [ServiceContract(Namespace = "")]
    [AspNetCompatibilityRequirements(RequirementsMode = AspNetCompatibilityRequirementsMode.Allowed)]
    public class Gio_PhongSVC
    {
        [OperationContract]
        public void Gio_Phong_Add(string ListPhongID, string ListGioPhongName, int PhanTram, string ListGiaTien, string Status)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            doit.Gio_Phong_Add(ListPhongID, ListGioPhongName, PhanTram, ListGiaTien, Status);
        }
        [OperationContract]
        public void Gio_Phong_Edit(int Gio_PhongID, int PhongID, string GioPhongName, int PhanTram, decimal GiaTien, string Status)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            doit.Gio_Phong_Edit(Gio_PhongID,PhongID,GioPhongName,PhanTram,GiaTien,Status);
        }
        [OperationContract]
        public void Gio_Phong_Delete(int Gio_PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            doit.Gio_Phong_Delete(Gio_PhongID);
        }
        [OperationContract]
        public Gio_PhongInfo Gio_Phong_GetItem(int Gio_PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GetItem(Gio_PhongID);
        }
        [OperationContract]
        public List<Gio_PhongInfo> Gio_Phong_GetItems(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GetItems(PhongID);
        }
        [OperationContract]
        public decimal Gio_Phong_GiaGoc(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GiaGoc(PhongID);
        }
        [OperationContract]
        public string Gio_Phong_KiemTraStatus(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_KiemTraStatus(PhongID);
        }
        [OperationContract]
        public List<Gio_PhongInfo> Gio_Phong_GetItemByPhongID(int PhongID)
        {
            Gio_PhongDAL doit = new Gio_PhongDAL();
            return doit.Gio_Phong_GetItemByPhongID(PhongID);
        }
    }
}
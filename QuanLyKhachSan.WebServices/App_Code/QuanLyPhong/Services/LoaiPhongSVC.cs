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
    public class LoaiPhongSVC
    {
        [OperationContract]
        public void LoaiPhong_Add(string LoaiPhongName)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            doit.LoaiPhong_Add(LoaiPhongName);
        }
        [OperationContract]
        public void LoaiPhong_Edit(int LoaiPhongID, string LoaiPhongName)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            doit.LoaiPhong_Edit(LoaiPhongID, LoaiPhongName);
        }
        [OperationContract]
        public void LoaiPhong_Delete(int LoaiPhongID)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            doit.LoaiPhong_Delete(LoaiPhongID);
        }
        [OperationContract]
        public LoaiPhongInfo LoaiPhong_GetItem(int LoaiPhongID)
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            return doit.LoaiPhong_GetItem(LoaiPhongID);
        }
        [OperationContract]
        public List<LoaiPhongInfo> LoaiPhong_GetItems()
        {
            LoaiPhongDAL doit = new LoaiPhongDAL();
            return doit.LoaiPhong_GetItems();
        }
    }
}

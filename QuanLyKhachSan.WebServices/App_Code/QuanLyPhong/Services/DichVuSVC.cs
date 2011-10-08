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
    public class DichVuSVC
    {
        [OperationContract]
        public void DichVu_Add(string DichVuName, decimal GiaTien)
        {
            DichVuDAL doit = new DichVuDAL();
            doit.DichVu_Add(DichVuName, GiaTien);
        }
        [OperationContract]
        public void DichVu_Edit(int DichVuID, string DichVuName, decimal GiaTien)
        {
            DichVuDAL doit = new DichVuDAL();
            doit.DichVu_Edit(DichVuID, DichVuName, GiaTien);
        }
        [OperationContract]
        public void DichVu_Delete(int DichVuID)
        {
            DichVuDAL doit = new DichVuDAL();
            doit.DichVu_Delete(DichVuID);
        }
        [OperationContract]
        public DichVuInfo DichVu_GetItem(int DichVuID)
        {
            DichVuDAL doit = new DichVuDAL();
            return doit.DichVu_GetItem(DichVuID);
        }
        [OperationContract]
        public List<DichVuInfo> DichVu_GetItems()
        {
            DichVuDAL doit = new DichVuDAL();
            return doit.DichVu_GetItems();
        }
    }
}

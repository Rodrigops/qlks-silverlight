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
    public class TienNghiSVC
    {
        [OperationContract]
        public void TienNghi_Add(string TienNghiName, int TienNghi_UuTien)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_Add(TienNghiName, TienNghi_UuTien);
        }
        [OperationContract]
        public void TienNghi_Edit(int TienNghiID, string TienNghiName, int TienNghi_UuTien)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_Edit(TienNghiID, TienNghiName, TienNghi_UuTien);
        }
        [OperationContract]
        public void TienNghi_Delete(int TienNghiID)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_Delete(TienNghiID);
        }
        [OperationContract]
        public TienNghiInfo TienNghi_GetItem(int TienNghiID)
        {
            TienNghiDAL doit = new TienNghiDAL();
            return doit.TienNghi_GetItem(TienNghiID);
        }
        [OperationContract]
        public List<TienNghiInfo> TienNghi_GetItems()
        {
            TienNghiDAL doit = new TienNghiDAL();
            return doit.TienNghi_GetItems();
        }
        [OperationContract]
        public void TienNghi_SapXep(string ListTienNghiID)
        {
            TienNghiDAL doit = new TienNghiDAL();
            doit.TienNghi_SapXep(ListTienNghiID);
        }
    }
}

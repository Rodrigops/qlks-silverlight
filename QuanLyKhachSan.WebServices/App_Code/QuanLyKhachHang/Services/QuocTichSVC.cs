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
    public class QuocTichSVC
    {
        [OperationContract]
        public void QuocTich_Add(string TenQuocTich)
        {
            QuocTichDAL doit = new QuocTichDAL();
            doit.QuocTich_Add(TenQuocTich);
        }
        [OperationContract]
        public void QuocTich_Edit(int QuocTichID, string TenQuocTich)
        {
            QuocTichDAL doit = new QuocTichDAL();
            doit.QuocTich_Edit(QuocTichID, TenQuocTich);
        }
        [OperationContract]
        public void QuocTich_Delete(int QuocTichID)
        {
            QuocTichDAL doit = new QuocTichDAL();
            doit.QuocTich_Delete(QuocTichID);
        }
        [OperationContract]
        public QuocTichInfo QuocTich_GetItem(int QuocTichID)
        {
            QuocTichDAL doit = new QuocTichDAL();
            return doit.QuocTich_GetItem(QuocTichID);
        }
        [OperationContract]
        public List<QuocTichInfo> QuocTich_GetItems()
        {
            QuocTichDAL doit = new QuocTichDAL();
            return doit.QuocTich_GetItems();
        }
    }
}

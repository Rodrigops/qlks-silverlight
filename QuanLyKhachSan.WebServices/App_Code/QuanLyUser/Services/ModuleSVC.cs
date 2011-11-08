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
    public class ModuleSVC
    {
        [OperationContract]
        public List<ModuleInfo> Module_GetItems()
        {
            ModuleDAL doit = new ModuleDAL();
            return doit.Module_GetItems();
        }
    }
}

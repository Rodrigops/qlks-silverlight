﻿using System;
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
    public class HoaDon_TraTruocSVC
    {
        [OperationContract]
        public void HoaDon_TraTruoc_Add(int HoaDonID, string GhiChu, decimal TraTruoc, int CreatedByUser, string CreatedDate)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            doit.HoaDon_TraTruoc_Add(HoaDonID, GhiChu, TraTruoc, CreatedByUser, CreatedDate);
        }
        [OperationContract]
        public void HoaDon_TraTruoc_Edit(int HoaDon_TraTruocID, int HoaDonID, string GhiChu, decimal TraTruoc, int ModifiedByUser, string ModifiedDate)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            doit.HoaDon_TraTruoc_Edit(HoaDon_TraTruocID, HoaDonID, GhiChu, TraTruoc, ModifiedByUser, ModifiedDate);
        }
        [OperationContract]
        public void HoaDon_TraTruoc_Delete(int HoaDon_TraTruocID)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            doit.HoaDon_TraTruoc_Delete(HoaDon_TraTruocID);
        }
        [OperationContract]
        public HoaDon_TraTruocInfo HoaDon_TraTruoc_GetItem(int HoaDon_TraTruocID)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            return doit.HoaDon_TraTruoc_GetItem(HoaDon_TraTruocID);
        }
        [OperationContract]
        public List<HoaDon_TraTruocInfo> HoaDon_TraTruoc_GetItems([Optional, DefaultParameterValue(0)] int HoaDon_TraTruocID)
        {
            HoaDon_TraTruocDAL doit = new HoaDon_TraTruocDAL();
            return doit.HoaDon_TraTruoc_GetItems(HoaDon_TraTruocID);
        }
    }
}
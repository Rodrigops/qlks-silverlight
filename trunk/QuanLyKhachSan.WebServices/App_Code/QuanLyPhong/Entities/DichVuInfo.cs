using System;

namespace QuanLyKhachSan
{
    public class DichVuInfo 
    {
        private int _DichVuID;
        private string _DichVuName = string.Empty;
        private decimal _GiaTien;
        #region DichVuInfo
        public int DichVuID
        {
            get { return _DichVuID; }
            set { _DichVuID = value; }
        }
        public string DichVuName
        {
            get { return _DichVuName; }
            set { _DichVuName = value; }
        }
        public decimal GiaTien
        {
            get { return _GiaTien; }
            set { _GiaTien = value; }
        }
        #endregion
    }
}
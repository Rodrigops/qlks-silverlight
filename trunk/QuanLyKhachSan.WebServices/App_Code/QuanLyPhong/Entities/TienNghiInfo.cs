using System;

namespace QuanLyKhachSan
{
    public class TienNghiInfo 
    {
        private int _TienNghiID;
        private string _TienNghiName = string.Empty;
        private int _TienNghi_UuTien;
        #region TienNghiInfo
        public int TienNghiID
        {
            get { return _TienNghiID; }
            set { _TienNghiID = value; }
        }
        public string TienNghiName
        {
            get { return _TienNghiName; }
            set { _TienNghiName = value; }
        }
        public int TienNghi_UuTien
        {
            get { return _TienNghi_UuTien; }
            set { _TienNghi_UuTien = value; }
        }
        #endregion
    }
}
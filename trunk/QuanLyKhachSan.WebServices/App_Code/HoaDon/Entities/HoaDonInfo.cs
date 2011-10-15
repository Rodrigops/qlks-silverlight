using System;

namespace QuanLyKhachSan
{
    public class HoaDonInfo 
    {
        private int _HoaDonID;
        private int _KhachHangID;
        private int _CreatedByUser;
        private string _CreatedDate = string.Empty;
        private int _ModifiedByUser;
        private string _ModifiedDate = string.Empty;
        #region HoaDonInfo
        public int HoaDonID
        {
            get { return _HoaDonID; }
            set { _HoaDonID = value; }
        }
        public int KhachHangID
        {
            get { return _KhachHangID; }
            set { _KhachHangID = value; }
        }
        public int CreatedByUser
        {
            get { return _CreatedByUser; }
            set { _CreatedByUser = value; }
        }
        public string CreatedDate
        {
            get { return _CreatedDate; }
            set { _CreatedDate = value; }
        }
        public int ModifiedByUser
        {
            get { return _ModifiedByUser; }
            set { _ModifiedByUser = value; }
        }
        public string ModifiedDate
        {
            get { return _ModifiedDate; }
            set { _ModifiedDate = value; }
        }

        #endregion
    }
}
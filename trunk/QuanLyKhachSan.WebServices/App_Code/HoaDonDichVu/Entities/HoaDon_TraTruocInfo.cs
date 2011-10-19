using System;

namespace QuanLyKhachSan
{
    public class HoaDon_TraTruocInfo 
    {
        private int _HoaDon_TraTruocID;
        private int _HoaDonID;
        private decimal _TraTruoc;
        private string _GhiChu;

        private int _CreatedByUser;
        private string _CreatedDate;//DateTime
        private int _ModifiedByUser;
        private string _ModifiedDate;//DateTime
        
        #region HoaDonNgayVaoRaInfo
        public int HoaDon_TraTruocID
        {
            get { return _HoaDon_TraTruocID; }
            set { _HoaDon_TraTruocID = value; }
        }
        public int HoaDonID
        {
            get { return _HoaDonID; }
            set { _HoaDonID = value; }
        }
        public decimal TraTruoc
        {
            get { return _TraTruoc; }
            set { _TraTruoc = value; }
        }
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
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
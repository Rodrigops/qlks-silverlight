using System;

namespace QuanLyKhachSan
{
    public class HoaDon_KhachHangInfo 
    {
        private int _HoaDonID_KhachHangID;
        private int _HoaDonID;
        private int _KhachHangID;
        private int _PhongID;
        private string _NgayBatDau;
        private int _GioBatDau;
        private int _PhutBatDau;
        private int _NgayBatDau_So;
        private int _ThangBatDau;
        private int _NamBatDau;
        private string _NgayKetThuc;
        private decimal _TongTien;
        private int _CreatedByUser;
        private string _CreatedDate = string.Empty;
        private int _ModifiedByUser;
        private string _ModifiedDate = string.Empty;
        #region HoaDon_KhachHangInfo
        public int HoaDonID_KhachHangID
        {
            get { return _HoaDonID_KhachHangID; }
            set { _HoaDonID_KhachHangID = value; }
        }
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
        public int PhongID
        {
            get { return _PhongID; }
            set { _PhongID = value; }
        }
        public string NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }
        public int GioBatDau
        {
            get { return _GioBatDau; }
            set { _GioBatDau = value; }
        }
        public int PhutBatDau
        {
            get { return _PhutBatDau; }
            set { _PhutBatDau = value; }
        }
        public int NgayBatDau_So
        {
            get { return _NgayBatDau_So; }
            set { _NgayBatDau_So = value; }
        }
        public int ThangBatDau
        {
            get { return _ThangBatDau; }
            set { _ThangBatDau = value; }
        }
        public int NamBatDau
        {
            get { return _NamBatDau; }
            set { _NamBatDau = value; }
        }
        public decimal TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
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
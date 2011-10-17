using System;

namespace QuanLyKhachSan
{
    public class TinhTrang_PhongInfo 
    {
        private int _PhongID;
        private string _PhongName = string.Empty;
        private string _TinhTrangPhong = string.Empty;
        private int _TinhTrangPhongID;
        private int _NgayBatDau_So;
        private int _GioBatDau;
        private int _PhutBatDau;
        private long _NgayGioPhut_So;
        private bool _IsDeleted;
        private string _TinhTrangPhongName;
        private int _HoaDonID;
        #region TinhTrang_PhongInfo
        public int PhongID
        {
            get { return _PhongID; }
            set { _PhongID = value; }
        }
        public string PhongName
        {
            get { return _PhongName; }
            set { _PhongName = value; }
        }
        public string TinhTrangPhong
        {
            get { return _TinhTrangPhong; }
            set { _TinhTrangPhong = value; }
        }
        public int TinhTrangPhongID
        {
            get { return _TinhTrangPhongID; }
            set { _TinhTrangPhongID = value; }
        }
        public int NgayBatDau_So
        {
            get { return _NgayBatDau_So; }
            set { _NgayBatDau_So = value; }
        }
        public bool IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
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
        public long NgayGioPhut_So
        {
            get { return _NgayGioPhut_So; }
            set { _NgayGioPhut_So = value; }
        }
        public string TinhTrangPhongName
        {
            get { return _TinhTrangPhongName; }
            set { _TinhTrangPhongName = value; }
        }
        public int HoaDonID
        {
            get { return _HoaDonID; }
            set { _HoaDonID = value; }
        }
        #endregion
    }
}
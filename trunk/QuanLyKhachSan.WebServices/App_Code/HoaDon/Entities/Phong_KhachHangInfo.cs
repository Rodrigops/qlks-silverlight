using System;

namespace QuanLyKhachSan
{
    public class Phong_KhachHangInfo 
    {        
        private int _HoaDonID;
        private int _KhachHangID;
        private int _PhongID;
        private string _HoTen;
        private string _CMND;
        private string _NgayBatDau;
        private string _NgayKetThuc;
        #region Phong_KhachHangInfo
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
        public string HoTen 
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        public string NgayBatDau
        {
            get { return _NgayBatDau; }
            set { _NgayBatDau = value; }
        }
        public string NgayKetThuc
        {
            get { return _NgayKetThuc; }
            set { _NgayKetThuc = value; }
        }
        #endregion
    }
}
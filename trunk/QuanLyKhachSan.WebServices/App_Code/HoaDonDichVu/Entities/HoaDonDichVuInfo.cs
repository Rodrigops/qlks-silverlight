using System;

namespace QuanLyKhachSan
{
    public class HoaDonDichVuInfo 
    {
        private int _HoaDon_DichVuID;
        private int _HoaDonID;
        private int _PhongID;
        private int _KhachHangID;
        private int _DichVuID;
        private string _HoTen;
        private string _PhongName;
        private string _NgaySuDung;
        private int _SoLuong;
        private decimal _DonGia;
        private decimal _TongTien;
        
	    private int _CreatedByUser;
        private string _CreatedDate;//DateTime
	    private int _ModifiedByUser;
        private string _ModifiedDate;//DateTime

        #region HoaDonDichVuInfo
        public int HoaDon_DichVuID
        {
            get { return _HoaDon_DichVuID; }
            set { _HoaDon_DichVuID = value; }
        }
        public int HoaDonID
        {
            get { return _HoaDonID; }
            set { _HoaDonID = value; }
        }
        public int PhongID
        {
            get { return _PhongID; }
            set { _PhongID = value; }
        }
        public int KhachHangID
        {
            get { return _KhachHangID; }
            set { _KhachHangID = value; }
        }
        public int DichVuID
        {
            get { return _DichVuID; }
            set { _DichVuID = value; }
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string PhongName
        {
            get { return _PhongName; }
            set { _PhongName = value; }
        }
        public string NgaySuDung
        {
            get { return _NgaySuDung; }
            set { _NgaySuDung = value; }
        }
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        public decimal DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
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
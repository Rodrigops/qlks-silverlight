using System;

namespace QuanLyKhachSan
{
    public class ChiTietPhieuNhapKhoInfo 
    {
        private int _ChiTietPhieuNhapID;
        private int _PhieuNhapKhoID;
        private int _SoLuong;
        private decimal _DonGia;
        private decimal _TongTien;
        private int _DichVuID;
        private string _DichVuName;

        #region ChiTietPhieuNhapKhoInfo
        public int ChiTietPhieuNhapID
        {
            get { return _ChiTietPhieuNhapID; }
            set { _ChiTietPhieuNhapID = value; }
        }
        public int PhieuNhapKhoID
        {
            get { return _PhieuNhapKhoID; }
            set { _PhieuNhapKhoID = value; }
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
        #endregion
    }
}
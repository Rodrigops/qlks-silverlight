using System;

namespace QuanLyKhachSan
{
    public class Ngay_PhongInfo 
    {
        private int _Ngay_PhongID;
        private int _PhongID;
        private decimal _GiaNgay;
        private decimal _GiaTuan;
        private decimal _GiaThang;
        #region Ngay_PhongInfo
        public int Ngay_PhongID
        {
            get { return _Ngay_PhongID; }
            set { _Ngay_PhongID = value; }
        }
        public int PhongID
        {
            get { return _PhongID; }
            set { _PhongID = value; }
        }
        public decimal GiaNgay
        {
            get { return _GiaNgay; }
            set { _GiaNgay = value; }
        }
        public decimal GiaTuan
        {
            get { return _GiaTuan; }
            set { _GiaTuan = value; }
        }
        public decimal GiaThang
        {
            get { return _GiaThang; }
            set { _GiaThang = value; }
        }
        #endregion
    }
}
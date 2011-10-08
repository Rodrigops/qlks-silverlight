using System;

namespace QuanLyKhachSan
{
    public class Gia_PhongInfo 
    {
        private int _PhongID;
        private string _PhongName = string.Empty;
        private string _GiaGio = string.Empty;
        private decimal _GiaNgay;
        private decimal _GiaTuan;
        private decimal _GiaThang;
        #region Gia_PhongInfo
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
        public string GiaGio
        {
            get { return _GiaGio; }
            set { _GiaGio = value; }
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
using System;

namespace QuanLyKhachSan
{
    public class Nguoi_PhongInfo 
    {
        private int _Nguoi_PhongID;
        private int _PhongID;
        private string _NguoiPhongName = string.Empty;
        private int _PhanTram;
        private decimal _GiaTien;
        private string _status = string.Empty;
        private string _ImageUrl = string.Empty;
        private string _CongThem = string.Empty;
        #region Nguoi_PhongInfo
        public int Nguoi_PhongID
        {
            get { return _Nguoi_PhongID; }
            set { _Nguoi_PhongID = value; }
        }
        public int PhongID
        {
            get { return _PhongID; }
            set { _PhongID = value; }
        }
        public string NguoiPhongName
        {
            get { return _NguoiPhongName; }
            set { _NguoiPhongName = value; }
        }
        public int PhanTram
        {
            get { return _PhanTram; }
            set { _PhanTram = value; }
        }
        public decimal GiaTien
        {
            get { return _GiaTien; }
            set { _GiaTien = value; }
        }
        public string status
        {
            get { return _status; }
            set { _status = value; }
        }
        public string ImageUrl
        {
            get { return _ImageUrl; }
            set { _ImageUrl = value; }
        }
        public string CongThem
        {
            get { return _CongThem; }
            set { _CongThem = value; }
        }
        #endregion
    }
}
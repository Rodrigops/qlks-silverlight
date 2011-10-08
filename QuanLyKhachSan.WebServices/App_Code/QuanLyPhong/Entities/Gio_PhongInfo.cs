using System;

namespace QuanLyKhachSan
{
    public class Gio_PhongInfo 
    {
        private int _Gio_PhongID;
        private int _PhongID;
        private string _GioPhongName = string.Empty;
        private int _PhanTram;
        private decimal _GiaTien;
        private string _status = string.Empty;
        private string _ImageUrl = string.Empty;
        #region Gio_PhongInfo
        public int Gio_PhongID
        {
            get { return _Gio_PhongID; }
            set { _Gio_PhongID = value; }
        }
        public int PhongID
        {
            get { return _PhongID; }
            set { _PhongID = value; }
        }
        public string GioPhongName
        {
            get { return _GioPhongName; }
            set { _GioPhongName = value; }
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
        #endregion
    }
}
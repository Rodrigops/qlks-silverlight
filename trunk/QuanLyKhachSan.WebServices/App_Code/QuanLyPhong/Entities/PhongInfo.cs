using System;

namespace QuanLyKhachSan
{
    public class PhongInfo 
    {
        private int _PhongID;
        private string _PhongName;
        private int _LoaiPhongID;
        private int _TienNghiID;
        private int _SoGiuong;
        private int _SoNguoi;
        private string _TienNghiName;
        private string _LoaiPhongName;
        #region PhongInfo
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
        public int LoaiPhongID
        {
            get { return _LoaiPhongID; }
            set { _LoaiPhongID = value; }
        }
        public int TienNghiID
        {
            get { return _TienNghiID; }
            set { _TienNghiID = value; }
        }
        public int SoGiuong
        {
            get { return _SoGiuong; }
            set { _SoGiuong = value; }
        }
        public int SoNguoi
        {
            get { return _SoNguoi; }
            set { _SoNguoi = value; }
        }
        public string TienNghiName
        {
            get { return _TienNghiName; }
            set { _TienNghiName = value; }
        }
        public string LoaiPhongName
        {
            get { return _LoaiPhongName; }
            set { _LoaiPhongName = value; }
        }      

        #endregion
    }
}
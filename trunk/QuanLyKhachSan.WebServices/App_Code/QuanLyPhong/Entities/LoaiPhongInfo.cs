using System;

namespace QuanLyKhachSan
{
    public class LoaiPhongInfo 
    {
        private int _LoaiPhongID;
        private string _LoaiPhongName = string.Empty;
        #region LoaiPhongInfo
        public int LoaiPhongID
        {
            get { return _LoaiPhongID; }
            set { _LoaiPhongID = value; }
        }
        public string LoaiPhongName
        {
            get { return _LoaiPhongName; }
            set { _LoaiPhongName = value; }
        }
        #endregion
    }
}
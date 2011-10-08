using System;

namespace QuanLyKhachSan
{
    public class QuocTichInfo 
    {
        private int _QuocTichID;
        private string _TenQuocTich = string.Empty;
        #region QuocTichInfo
        public int QuocTichID
        {
            get { return _QuocTichID; }
            set { _QuocTichID = value; }
        }
        public string TenQuocTich
        {
            get { return _TenQuocTich; }
            set { _TenQuocTich = value; }
        }
        #endregion
    }
}
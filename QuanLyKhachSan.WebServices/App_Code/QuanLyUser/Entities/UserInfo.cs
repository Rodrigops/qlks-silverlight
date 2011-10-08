using System;

namespace QuanLyKhachSan
{
    public class UserInfo 
    {
        private int _UserID;
        private string _UserName;
        private string _PassWord;
        private string _FullName;
        private string _DisplayName;
        private int _IsActived;
	    private int _CreatedByUser;
        private string _CreatedDate;//DateTime
	    private int _ModifiedByUser;
        private string _ModifiedDate;//DateTime

        #region UserInfo
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
        }
        public string PassWord
        {
            get { return _PassWord; }
            set { _PassWord = value; }
        }
        public string FullName
        {
            get { return _FullName; }
            set { _FullName = value; }
        }
        public string DisplayName
        {
            get { return _DisplayName; }
            set { _DisplayName = value; }
        }
        public int IsActived
        {
            get { return _IsActived; }
            set { _IsActived = value; }
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
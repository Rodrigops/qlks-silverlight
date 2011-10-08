using System;

namespace QuanLyKhachSan
{
    public class GroupInfo 
    {
        private int _GroupID;
        private string _GroupName;
        private string _Descriptions;
        private int _IsActived;
	    private int _CreatedByUser;
        private string _CreatedDate;//DateTime
        private int _ModifiedByUser;
        private string _ModifiedDate;//DateTime

        #region GroupInfo
        public int GroupID
        {
            get { return _GroupID; }
            set { _GroupID = value; }
        }
        public string GroupName
        {
            get { return _GroupName; }
            set { _GroupName = value; }
        }
        public string Descriptions
        {
            get { return _Descriptions; }
            set { _Descriptions = value; }
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
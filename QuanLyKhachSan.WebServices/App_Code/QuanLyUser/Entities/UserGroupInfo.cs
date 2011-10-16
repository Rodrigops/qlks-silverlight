using System;

namespace QuanLyKhachSan
{
    public class UserGroupInfo 
    {
        private int _UserGroupID;
        private int _UserID;
        private int _GroupID;
        private string _ListGroupID;
        private string _UserName;
        private string _FullName;
        private string _DisplayName;
        private string _GroupName;
        private string _ExpiryDate;
        private string _EffectiveDate;
        private int _IsTrialUsed;
	    private int _CreatedByUser;
        private string _CreatedDate;//DateTime
	    private int _ModifiedByUser;
        private string _ModifiedDate;//DateTime

        #region UserGroupInfo
        public int UserGroupID
        {
            get { return _UserGroupID; }
            set { _UserGroupID = value; }
        }
        public int UserID
        {
            get { return _UserID; }
            set { _UserID = value; }
        }
        public int GroupID
        {
            get { return _GroupID; }
            set { _GroupID = value; }
        }
        public string ListGroupID
        {
            get { return _ListGroupID; }
            set { _ListGroupID = value; }
        }
        public string UserName
        {
            get { return _UserName; }
            set { _UserName = value; }
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
        public string GroupName
        {
            get { return _GroupName; }
            set { _GroupName = value; }
        }
        public string ExpiryDate
        {
            get { return _ExpiryDate; }
            set { _ExpiryDate = value; }
        }
        public string EffectiveDate
        {
            get { return _EffectiveDate; }
            set { _EffectiveDate = value; }
        }
        public int IsTrialUsed
        {
            get { return _IsTrialUsed; }
            set { _IsTrialUsed = value; }
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
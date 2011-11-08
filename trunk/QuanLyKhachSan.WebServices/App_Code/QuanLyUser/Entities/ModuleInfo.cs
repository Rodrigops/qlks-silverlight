using System;

namespace QuanLyKhachSan
{
    public class ModuleInfo 
    {
        private int _ModuleID;
        private string _ModuleName;
        private string _ModuleKey;
        private int _ViewOrder;
        private int _TabID;
        private string _TabName;
	    private int _CreatedByUser;
        private string _CreatedDate;
        private int _ModifiedByUser;
        private string _ModifiedDate;
        #region ModuleInfo
        public int ModuleID
        {
            get { return _ModuleID; }
            set { _ModuleID = value; }
        }
        public string ModuleName
        {
            get { return _ModuleName; }
            set { _ModuleName = value; }
        }
        public string ModuleKey
        {
            get { return _ModuleKey; }
            set { _ModuleKey = value; }
        }
        public int ViewOrder
        {
            get { return _ViewOrder; }
            set { _ViewOrder = value; }
        }
        public string TabName
        {
            get { return _TabName; }
            set { _TabName = value; }
        }
        public int TabID
        {
            get { return _TabID; }
            set { _TabID = value; }
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
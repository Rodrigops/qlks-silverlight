using System;

namespace QuanLyKhachSan
{
    public class KhachHangInfo 
    {
        private int _KhachHangID;
        private string _HoTen;
        private string _DiaChi;
        private string _DienThoai;
        private string _CMND;
        private string _NgaySinh;//DateTime
        private string _NoiSinh;
        private string _SoVisa;
        private string _ThoiHanVisa;//DateTime
        private string _NguoiTiepNhan;
        private string _NgayNhapCanh;//DateTime
        private string _TamTruTuNgay;//DateTime
        private string _TamTruDenNgay;//DateTime
        private int _QuocTichID;
        private int _GioiTinh;
        private int _IsDeleted;
	    private int _CreatedByUser;
        private string _CreatedDate;//DateTime
	    private int _ModifiedByUser;
        private string _ModifiedDate;//DateTime
	    private int _DeletedByUser;
        private string _DeletedDate;//DateTime

        #region KhachHangInfo
        public int KhachHangID
        {
            get { return _KhachHangID; }
            set { _KhachHangID = value; }
        }
        public string HoTen
        {
            get { return _HoTen; }
            set { _HoTen = value; }
        }
        public string DiaChi
        {
            get { return _DiaChi; }
            set { _DiaChi = value; }
        }
        public string DienThoai
        {
            get { return _DienThoai; }
            set { _DienThoai = value; }
        }
        public string CMND
        {
            get { return _CMND; }
            set { _CMND = value; }
        }
        public string NgaySinh
        {
            get { return _NgaySinh; }
            set { _NgaySinh = value; }
        }
        public string NoiSinh
        {
            get { return _NoiSinh; }
            set { _NoiSinh = value; }
        }
        public string SoVisa
        {
            get { return _SoVisa; }
            set { _SoVisa = value; }
        }
        public string ThoiHanVisa
        {
            get { return _ThoiHanVisa; }
            set { _ThoiHanVisa = value; }
        }
        public string NguoiTiepNhan
        {
            get { return _NguoiTiepNhan; }
            set { _NguoiTiepNhan = value; }
        }
        public string NgayNhapCanh
        {
            get { return _NgayNhapCanh; }
            set { _NgayNhapCanh = value; }
        }
        public string TamTruTuNgay
        {
            get { return _TamTruTuNgay; }
            set { _TamTruTuNgay = value; }
        }
        public string TamTruDenNgay
        {
            get { return _TamTruDenNgay; }
            set { _TamTruDenNgay = value; }
        }
        public int QuocTichID
        {
            get { return _QuocTichID; }
            set { _QuocTichID = value; }
        }
        public int GioiTinh
        {
            get { return _GioiTinh; }
            set { _GioiTinh = value; }
        }
        public int IsDeleted
        {
            get { return _IsDeleted; }
            set { _IsDeleted = value; }
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
        public int DeletedByUser
        {
            get { return _DeletedByUser; }
            set { _DeletedByUser = value; }
        }
        public string DeletedDate
        {
            get { return _DeletedDate; }
            set { _DeletedDate = value; }
        }
        #endregion
    }
}
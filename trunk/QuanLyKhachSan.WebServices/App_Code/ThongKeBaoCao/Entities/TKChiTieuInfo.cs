using System;

namespace QuanLyKhachSan
{
    public class TKChiTieuInfo 
    {
        private int _PhieuNhapKhoID;
        private string _NgayNhap;
        private int _ThangNhap;
        private int _NamNhap;
        private int _NgayNhapSo;
        private string _GhiChu;

        private int _ChiTietPhieuNhapID;
        private int _SoLuong;
        private decimal _DonGia;
        private decimal _TongTien;

        private int _DichVuID;
        private string _DichVuName;

        private int _CreatedByUser;
        private string _CreatedDate;//DateTime
        private int _ModifiedByUser;
        private string _ModifiedDate;//DateTime
        private int _DeletedByUser;
        private string _DeletedDate;//DateTime

        #region PhieuNhapKhoInfo
        public int PhieuNhapKhoID
        {
            get { return _PhieuNhapKhoID; }
            set { _PhieuNhapKhoID = value; }
        }
        public string NgayNhap
        {
            get { return _NgayNhap; }
            set { _NgayNhap = value; }
        }
        public int ThangNhap
        {
            get { return _ThangNhap; }
            set { _ThangNhap = value; }
        }
        public int NamNhap
        {
            get { return _NamNhap; }
            set { _NamNhap = value; }
        }
        public int NgayNhapSo
        {
            get { return _NgayNhapSo; }
            set { _NgayNhapSo = value; }
        }
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }

        public int ChiTietPhieuNhapID
        {
            get { return _ChiTietPhieuNhapID; }
            set { _ChiTietPhieuNhapID = value; }
        }
        public int SoLuong
        {
            get { return _SoLuong; }
            set { _SoLuong = value; }
        }
        public decimal DonGia
        {
            get { return _DonGia; }
            set { _DonGia = value; }
        }
        public decimal TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }

        public int DichVuID
        {
            get { return _DichVuID; }
            set { _DichVuID = value; }
        }
        public string DichVuName
        {
            get { return _DichVuName; }
            set { _DichVuName = value; }
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
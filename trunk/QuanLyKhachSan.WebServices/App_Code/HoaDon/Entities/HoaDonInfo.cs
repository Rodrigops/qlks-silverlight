using System;

namespace QuanLyKhachSan
{
    public class HoaDonInfo 
    {
        private int _HoaDonID;
        private string _NgayVao;
        private int _NgayVao_So;
        private int _GioVao;
        private int _PhutVao;
        private string _NgayRa;
        private int _NgayRa_So;
        private int _GioRa;
        private int _PhutRa;
        private decimal _KhuyenMai;
        private decimal _KhoanKhac;
        private string _GhiChu;
        private int _DaThanhToan;
        private int _CreatedByUser;
        private string _CreatedDate = string.Empty;
        private int _ModifiedByUser;
        private string _ModifiedDate = string.Empty;
        private int _LoaiThue;
        private int _Ca;
        private string _TenKhachHang;
        #region HoaDonInfo
        public int HoaDonID
        {
            get { return _HoaDonID; }
            set { _HoaDonID = value; }
        }
        public string NgayVao
        {
            get { return _NgayVao; }
            set { _NgayVao = value; }
        }
        public int NgayVao_So
        {
            get { return _NgayVao_So; }
            set { _NgayVao_So = value; }
        }
        public int GioVao
        {
            get { return _GioVao; }
            set { _GioVao = value; }
        }
        public int PhutVao
        {
            get { return _PhutVao; }
            set { _PhutVao = value; }
        }
        public string NgayRa
        {
            get { return _NgayRa; }
            set { _NgayRa = value; }
        }
        public int NgayRa_So
        {
            get { return _NgayRa_So; }
            set { _NgayRa_So = value; }
        }
        public int GioRa
        {
            get { return _GioRa; }
            set { _GioRa = value; }
        }
        public int PhutRa
        {
            get { return _PhutRa; }
            set { _PhutRa = value; }
        }
        public decimal KhuyenMai
        {
            get { return _KhuyenMai; }
            set { _KhuyenMai = value; }
        }
        public decimal KhoanKhac
        {
            get { return _KhoanKhac; }
            set { _KhoanKhac = value; }
        }
        public string GhiChu
        {
            get { return _GhiChu; }
            set { _GhiChu = value; }
        }
        public int DaThanhToan
        {
            get { return _DaThanhToan; }
            set { _DaThanhToan = value; }
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
        public int LoaiThue
        {
            get { return _LoaiThue; }
            set { _LoaiThue = value; }
        }
        public int Ca
        {
            get { return _Ca; }
            set { _Ca = value; }
        }
        public string TenKhachHang
        {
            get { return _TenKhachHang; }
            set { _TenKhachHang = value; }
        }
        #endregion
    }
}

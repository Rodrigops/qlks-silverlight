using System;

namespace QuanLyKhachSan
{
    public class TKDoanhThuInfo 
    {
        private int _HoaDonID;
        private string _NgayVao;
        private string _NgayRa;
        private decimal _TongTien;
        private int _DaThanhToan;
        private int _LoaiThue;
        private int _Ca;
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
        public string NgayRa
        {
            get { return _NgayRa; }
            set { _NgayRa = value; }
        }
        public decimal TongTien
        {
            get { return _TongTien; }
            set { _TongTien = value; }
        }
        public int DaThanhToan
        {
            get { return _DaThanhToan; }
            set { _DaThanhToan = value; }
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
        #endregion
    }
}
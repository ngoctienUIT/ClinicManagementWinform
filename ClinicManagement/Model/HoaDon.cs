using System;

namespace ClinicManagement.Model
{
    class HoaDon
    {
        private String _maHoaDon;
        private String _maPhieuKhamBenh;
        private int _giaTriHoaDon;
        private String _maNhanVien;

        public HoaDon()
        {
        }

        public HoaDon(string maHoaDon, string maPhieuKhamBenh, int giaTriHoaDon, string maNhanVien)
        {
            _maHoaDon = maHoaDon;
            _maPhieuKhamBenh = maPhieuKhamBenh;
            _giaTriHoaDon = giaTriHoaDon;
            _maNhanVien = maNhanVien;
        }

        public string maHoaDon { get => _maHoaDon; set => _maHoaDon = value; }
        public string maPhieuKhamBenh { get => _maPhieuKhamBenh; set => _maPhieuKhamBenh = value; }
        public int giaTriHoaDon { get => _giaTriHoaDon; set => _giaTriHoaDon = value; }
        public string maNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
    }
}

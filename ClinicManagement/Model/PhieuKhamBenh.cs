using System;

namespace ClinicManagement.Model
{
    class PhieuKhamBenh
    {
        private String _maPhieuKhamBenh;
        private String _maBenhNhan;
        private DateTime _ngayKham;
        private String _maLoaiBenh;
        private String _trieuChung;
        private int _tienKham;
        private int _tienThuoc;
        private String _maNhanVien;

        public PhieuKhamBenh(string maPhieuKhamBenh, string maBenhNhan, DateTime ngayKham,
            string maLoaiBenh, string trieuChung, int tienKham, int tienThuoc, string maNhanVien)
        {
            _maPhieuKhamBenh = maPhieuKhamBenh;
            _maBenhNhan = maBenhNhan;
            _ngayKham = ngayKham;
            _maLoaiBenh = maLoaiBenh;
            _trieuChung = trieuChung;
            _tienKham = tienKham;
            _tienThuoc = tienThuoc;
            _maNhanVien = maNhanVien;
        }

        public string maPhieuKhamBenh { get => _maPhieuKhamBenh; set => _maPhieuKhamBenh = value; }
        public string maBenhNhan { get => _maBenhNhan; set => _maBenhNhan = value; }
        public DateTime ngayKham { get => _ngayKham; set => _ngayKham = value; }
        public string maLoaiBenh { get => _maLoaiBenh; set => _maLoaiBenh = value; }
        public string trieuChung { get => _trieuChung; set => _trieuChung = value; }
        public int tienKham { get => _tienKham; set => _tienKham = value; }
        public int tienThuoc { get => _tienThuoc; set => _tienThuoc = value; }
        public string maNhanVien { get => _maNhanVien; set => _maNhanVien = value; }
    }
}

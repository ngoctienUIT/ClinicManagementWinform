using System;

namespace ClinicManagement.Model
{
    class NhanVien
    {
        private String _maNV;
        private String _tenNV;
        private String _gioiTinh;
        private DateTime _ngaySinh;
        private String _diaChi;
        private String _sdt;
        private String _chucVu;
        private String _matKhau;
        private String _hinhAnh;
        private int _luongCB;
        private int _heSo;

        public NhanVien()
        {
        }

        public NhanVien(string maNV, string tenNV, string gioiTinh,
            DateTime ngaySinh, string diaChi, string sdt, string chucVu,
            string matKhau, string hinhAnh, int luongCB, int heSo)
        {
            _maNV = maNV;
            _tenNV = tenNV;
            _gioiTinh = gioiTinh;
            _ngaySinh = ngaySinh;
            _diaChi = diaChi;
            _sdt = sdt;
            _chucVu = chucVu;
            _matKhau = matKhau;
            _hinhAnh = hinhAnh;
            _luongCB = luongCB;
            _heSo = heSo;
        }

        public string maNV { get => _maNV; set => _maNV = value; }
        public string tenNV { get => _tenNV; set => _tenNV = value; }
        public string gioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public DateTime ngaySinh { get => _ngaySinh; set => _ngaySinh = value; }
        public string diaChi { get => _diaChi; set => _diaChi = value; }
        public string sdt { get => _sdt; set => _sdt = value; }
        public string chucVu { get => _chucVu; set => _chucVu = value; }
        public string matKhau { get => _matKhau; set => _matKhau = value; }
        public string hinhAnh { get => _hinhAnh; set => _hinhAnh = value; }
        public int luongCB { get => _luongCB; set => _luongCB = value; }
        public int heSo { get => _heSo; set => _heSo = value; }
    }
}

using System;

namespace ClinicManagement.Model
{
    class BenhNhan
    {
        private string _maBenhNhan;
        private string _tenBenhNhan;
        private string _gioiTinh;
        private int _namSinh;
        private string _diaChi;
        private string _soDienThoai;

        public BenhNhan(string maBenhNhan, string tenBenhNhan, string gioiTinh,
            int namSinh, string diaChi, string soDienThoai)
        {
            _maBenhNhan = maBenhNhan;
            _tenBenhNhan = tenBenhNhan;
            _gioiTinh = gioiTinh;
            _namSinh = namSinh;
            _diaChi = diaChi;
            _soDienThoai = soDienThoai;
        }

        public string maBenhNhan { get => _maBenhNhan; set => _maBenhNhan = value; }
        public string tenBenhNhan { get => _tenBenhNhan; set => _tenBenhNhan = value; }
        public string gioiTinh { get => _gioiTinh; set => _gioiTinh = value; }
        public int namSinh { get => _namSinh; set => _namSinh = value; }
        public string diaChi { get => _diaChi; set => _diaChi = value; }
        public string soDienThoai { get => _soDienThoai; set => _soDienThoai = value; }
    }
}

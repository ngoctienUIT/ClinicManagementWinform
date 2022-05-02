using System;

namespace ClinicManagement.Model
{
    class CTPhieuKhamBenh
    {
        private String _maPhieuKhamBenh;
        private String _maThuoc;
        private int _soLuongDung;
        private int _donGiaThuoc;

        public CTPhieuKhamBenh()
        {
        }

        public CTPhieuKhamBenh(string maPhieuKhamBenh, string maThuoc, int soLuongDung, int donGiaThuoc)
        {
            _maPhieuKhamBenh = maPhieuKhamBenh;
            _maThuoc = maThuoc;
            _soLuongDung = soLuongDung;
            _donGiaThuoc = donGiaThuoc;
        }

        public string maPhieuKhamBenh { get => _maPhieuKhamBenh; set => _maPhieuKhamBenh = value; }
        public string maThuoc { get => _maThuoc; set => _maThuoc = value; }
        public int soLuongDung { get => _soLuongDung; set => _soLuongDung = value; }
        public int donGiaThuoc { get => _donGiaThuoc; set => _donGiaThuoc = value; }
    }
}

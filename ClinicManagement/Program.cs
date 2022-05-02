using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            //Application.Run(new DatLaiMatKhau());
            Application.Run(new ThemMoiNhanVien());
            Application.Run(new PhieuKhamBenh());
            Application.Run(new DanhSachHoaDon());
            Application.Run(new TraCuuBenhNhan());
            Application.Run(new ThongTinNhanVien());
        }
    }
}

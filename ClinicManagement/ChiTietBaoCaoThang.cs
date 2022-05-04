using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClinicManagement
{
    public partial class ChiTietBaoCaoThang : Form
    {
        public ChiTietBaoCaoThang()
        {
            InitializeComponent();
        }

        private void ChiTietBaoCaoThang_Paint(object sender, PaintEventArgs e)
        {
            System.Drawing.SolidBrush myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightPink);
            System.Drawing.Graphics formGraphics;
            formGraphics = this.CreateGraphics();
            formGraphics.FillEllipse(myBrush, new Rectangle(90, 250, 230, 230));
            myBrush = new System.Drawing.SolidBrush(System.Drawing.Color.LightBlue);
            formGraphics.FillEllipse(myBrush, new Rectangle(430, 250, 230, 230));
            myBrush.Dispose();
            formGraphics.Dispose();
        }
    }
}

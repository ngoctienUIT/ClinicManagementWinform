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
    public partial class Home : Form
    {

        private bool UserPanelVisible = false;
        public Home()
        {
            InitializeComponent();
        }


        private void UserControlButton_Click(object sender, EventArgs e)
        {
            if (UserPanelVisible == false) {
                UserPanel.Visible = true;
                UserPanelVisible = true;
                UserControlButton.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                UserControlButton.Refresh();
            }
            else
            {
                UserPanel.Visible = false;
                UserPanelVisible = false;
                UserControlButton.Image.RotateFlip(RotateFlipType.Rotate180FlipX);
                UserControlButton.Refresh();
            }
        }

        private void button_ThongTinCaNhan_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                double percent = 0.60;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, this.ClientRectangle);
                }
            }
            using (Panel p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = this.ClientRectangle.Size;
                p.BackgroundImage = bmp;
                this.Controls.Add(p);
                p.BringToFront();
                UserInformation tt = new UserInformation();
                tt.StartPosition = FormStartPosition.CenterParent;
                tt.ShowDialog();
            }
        }

        private void button_DoiMatKhau_Click(object sender, EventArgs e)
        {
            Bitmap bmp = new Bitmap(this.ClientRectangle.Width, this.ClientRectangle.Height);
            using (Graphics G = Graphics.FromImage(bmp))
            {
                G.CompositingMode = System.Drawing.Drawing2D.CompositingMode.SourceOver;
                G.CopyFromScreen(this.PointToScreen(new Point(0, 0)), new Point(0, 0), this.ClientRectangle.Size);
                double percent = 0.60;
                Color darken = Color.FromArgb((int)(255 * percent), Color.Black);
                using (Brush brsh = new SolidBrush(darken))
                {
                    G.FillRectangle(brsh, this.ClientRectangle);
                }
            }
            using (Panel p = new Panel())
            {
                p.Location = new Point(0, 0);
                p.Size = this.ClientRectangle.Size;
                p.BackgroundImage = bmp;
                this.Controls.Add(p);
                p.BringToFront();
                DatLaiMatKhau tt = new DatLaiMatKhau();
                tt.StartPosition = FormStartPosition.CenterParent;
                tt.ShowDialog();
            }
        }

        private void button_DangXuat_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Visible = false;
            login.ShowDialog();
            this.Close();
        }
    }
}

using System;
using System.Windows.Forms;
using ClinicManagement.View;

namespace ClinicManagement
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PatientLookup pl = new PatientLookup();
            pl.Show();
        }
    }
}

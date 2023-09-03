using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Metodo_Hamming
{
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            mostrar.Controls.Clear();
            Form1 conver = new Form1();
            conver.TopLevel = false;
            mostrar.Controls.Add(conver);
            conver.Dock = DockStyle.Fill;

            conver.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            mostrar.Controls.Clear();
            Hamming hm = new Hamming();
            hm.TopLevel = false;
            mostrar.Controls.Add(hm);
            hm.Dock = DockStyle.Fill;

            hm.Show();
        }
    }
}

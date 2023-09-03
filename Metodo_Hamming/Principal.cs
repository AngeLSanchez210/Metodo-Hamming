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
            button2.Enabled= true;
            button2.Cursor = Cursors.Hand;
            button2.BackColor = Color.FromArgb(0, 120, 215);
            mostrar.Controls.Clear();
            Form1 conver = new Form1();
            conver.TopLevel = false;
            mostrar.Controls.Add(conver);
            conver.Dock = DockStyle.Fill;
            button1.BackColor = Color.FromArgb(0, 160, 215);
            button1.Enabled = false;
            button1.Cursor = Cursors.Default;
            conver.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button1.Cursor = Cursors.Hand;
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button2.BackColor = Color.FromArgb(0, 160, 215);
            mostrar.Controls.Clear();
            Hamming hm = new Hamming();
            hm.TopLevel = false;
            mostrar.Controls.Add(hm);
            hm.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.Cursor = Cursors.Default;
            hm.Show();
        }
    }
}

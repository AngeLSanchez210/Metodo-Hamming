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
            button1.Enabled = false;
            button2.Enabled = true;
            button3.Enabled = true;
            button1.Cursor = Cursors.Hand;
            button2.BackColor = Color.FromArgb(0, 120, 215);
            button3.BackColor = Color.FromArgb(0, 120, 215);
            mostrar.Controls.Clear();
            ConversionBin conver = new ConversionBin();
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
            button2.Enabled = false;
            button3.Enabled = true;
            button2.Cursor = Cursors.Hand;
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button3.BackColor = Color.FromArgb(0, 120, 215);
            mostrar.Controls.Clear();
            Hamming conver = new Hamming();
            conver.TopLevel = false;
            mostrar.Controls.Add(conver);
            conver.Dock = DockStyle.Fill;
            button2.BackColor = Color.FromArgb(0, 160, 215);
            button2.Enabled = false;
            button2.Cursor = Cursors.Default;
            conver.Show();
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = false;
            button2.Cursor = Cursors.Hand;
            button1.BackColor = Color.FromArgb(0, 120, 215);
            button2.BackColor = Color.FromArgb(0, 120, 215);
            mostrar.Controls.Clear();
            Pariedad conver = new Pariedad();
            conver.TopLevel = false;
            mostrar.Controls.Add(conver);
            conver.Dock = DockStyle.Fill;
            button3.BackColor = Color.FromArgb(0, 160, 215);
            button3.Enabled = false;
            button3.Cursor = Cursors.Default;
            conver.Show();
        }

        private void mostrar_Paint(object sender, PaintEventArgs e)
        {

        }


    }
}

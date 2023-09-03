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
    public partial class Hamming : Form
    {
        public Hamming()
        {
            InitializeComponent();
        }
        logicaMetodoHamming logic = new logicaMetodoHamming();

        private void btnEnviar_Click(object sender, EventArgs e)
        {
            if (txtBits.Text != "")
            {
                if (txtBits.TextLength == 6)
                {
                    lblErrorInput.Text = "";
                    int[] binario = new int[6];

                    for (int i = 0; i < txtBits.TextLength; i++)
                    {
                        if (txtBits.Text[i] == '1')
                        {
                            binario[i] = 1;
                        }
                        else if (txtBits.Text[i] == '0')
                        {
                            binario[i] = 0;
                        }
                    }
                    int[] numeroCodificado = logic.codificarBinario(binario);

                    foreach (var item in numeroCodificado)
                    {
                        lblNumeroCodi.Text += " " + item;
                    }
                }
                else
                {
                    lblErrorInput.Text = "Ingrese un numero binario de 6 bits, no de "+txtBits.TextLength+" bits";
                }
            }
            else
            {
                lblErrorInput.Text = "Por favor llene el campo con un numero de 6 bits";
            }

        }
    }
}

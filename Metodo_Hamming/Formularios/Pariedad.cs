using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Metodo_Hamming.Logica;

namespace Metodo_Hamming
{
    public partial class Pariedad : Form

    {
        public Pariedad()
        {
            InitializeComponent();
        }

        logicaMetodoHamming logic = new logicaMetodoHamming();


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void Pariedad_Load(object sender, EventArgs e)
        {

        }


        private void button1_Click(object sender, EventArgs e)
        {
            string numeroBinario = dato.Text.Trim();

          

            // Calcular la paridad contando los unos en el número binario.
            int unos = ContarUnos(numeroBinario);

            // Determinar si la paridad es par o impar.
            string resultadoParidad = (unos % 2 == 0) ? "0" : "1";

            // Mostrar el resultado en el Label junto con el número binario original.
            resultado.Text = "Número binario con paridad: " + numeroBinario + resultadoParidad;
        }

        // Función para verificar si el número binario ingresado es válido.
        private bool EsNumeroBinarioValido(string numeroBinario)
        {
            return System.Text.RegularExpressions.Regex.IsMatch(numeroBinario, "^[01]{1,6}$");
        }

        // Función para contar los unos en el número binario.
        private int ContarUnos(string numeroBinario)
        {
            int unos = 0;
            foreach (char bit in numeroBinario)
            {
                if (bit == '1')
                {
                    unos++;
                }
            }
            return unos;
        }

        private void dato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!logic.validacion(e, error))
            {
                
            }
            else
            {
                if (!char.IsDigit(e.KeyChar) || dato.Text.Length >= 6)
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        error.Text = "Ya ha ingresado el número máximo de bits.";
                    }
                    else
                    {
                        error.Text = "";
                    }
                }
                else
                {
                    error.Text = "";
                }
            }

        }



        private void dato_TextChanged(object sender, EventArgs e)
        {

        }
    }
}


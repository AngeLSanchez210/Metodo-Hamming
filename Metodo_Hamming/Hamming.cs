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
            //Se verifica que el campo no este vacio
            if (txtBits.Text != "")
            {
                //Tambien se verifica que la cantidad de caracteres sea de 6
                if (txtBits.TextLength == 6)
                {
                    //Se limpia el label que muestra errores
                    lblErrorInput.Text = "";
                    int[] binario = new int[6];//Se crea un arreglo que contendra los valores binarios

                    for (int i = 0; i < txtBits.TextLength; i++)//Se realiza un for para ir recorriendo el TextField
                    {
                        //Se verifica que el dato en la posicion i es 1 o 0 y se guarda en el arreglo
                        if (txtBits.Text[i] == '1')
                        {
                            binario[i] = 1;
                        }
                        else if (txtBits.Text[i] == '0')
                        {
                            binario[i] = 0;
                        }
                    }
                    //Luego se crea un arrelo que almacenara el dato ya codificado
                    int[] numeroCodificado = logic.codificarBinario(binario);//Se manda el arreglo de bits para que se codifique
                    lblNumeroCodi.Text = "";

                    foreach (var item in numeroCodificado)//Con el foreach se recorre el arreglo del numero codificado para que se muestre en el Label
                    {
                        lblNumeroCodi.Text += " " + item;
                    }
                }
                else//Este else es para cuando se ingresan 1 y 0 pero estos no cumplen los 6 bits
                {
                    lblErrorInput.Text = "Ingrese un numero binario de 6 bits, no de " + txtBits.TextLength + " bits";
                }
            }
            else // Y este por si acaso trata de mandar el campo vacio
            {
                lblErrorInput.Text = "Por favor llene el campo con un numero de 6 bits";
            }

        }

        private void txtBits_KeyPress(object sender, KeyPressEventArgs e)
        {
            //Se valida que la tecla que este precionando sea la correspondiente a 1 o 0
            if (logic.validacion(e, lblErrorInput))
            {

            }
        }

        private void Hamming_Load(object sender, EventArgs e)
        {

        }
    }
}

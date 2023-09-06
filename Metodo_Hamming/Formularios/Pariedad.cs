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
            string input = dato.Text; //creamos una variable que contendra el dato que el usuario ingrese en el textbox

            if (input.Length != 6 || !EsBinario(input))  //hacemos una validacion para cuando el usuario de al boton sin tener nada 
            {
                MessageBox.Show("Entrada inválida. Debe ser un número binario de 6 bits.");
            }
            else
            {
                int unos = ContarUnos(input); // Contamos la cantidad de unos en el número binario ingresado
                int paridadDeseada = (unos % 2 == 0) ? 0 : 1; //verificamos si la cantidad de unos es un numero par entonces la pariedad deseada sera 0 y si no lo contrario

                pari.Text = (paridadDeseada == 0) ? "PAR" : "IMPAR"; //hacemos la verificacion solamente esto nos indicara que tipo de pariedad es
                resultado.Text = input + paridadDeseada; // en un label guardamos esto y concatenamos el binario ingresado ya con su´pariedad es decir seran 7 bits

            }
        }

        private bool EsBinario(string str) //definimos esta funcion que toma una cadena string
        {
            foreach (char c in str) //por medio del foreach va checando los datos de cadena uno por uno
            {
                if (c != '0' && c != '1') //verifica que la cadena contenga 0 o 1 y si hay uno diferente retorna false
                {
                    return false;
                }
            }
            return true;
        }

        private int ContarUnos(string str) //definimos otra funcion para contar los unos
        {
            int count = 0;  // inicializamos una variable contador en 0 
            foreach (char c in str) //recorremos con el foreach nuestra cadena 
            {
                if (c == '1')  // y con un if los 1 que encontramos los iremos aumentando en nuestro contador
                {
                    count++;
                }
            }
            return count; //retornamos


        }



        private void dato_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!logic.validacion(e, error)) // importamos las validacion de nuestra carpeta logica , validaciones
            {

            }
            else
            {
                if (!char.IsDigit(e.KeyChar) || dato.Text.Length >= 6) //validacion para ingresar max 6 bits
                {
                    if (e.KeyChar != (char)Keys.Back)
                    {
                        e.Handled = true;
                        error.Text = "Ya ha ingresado el número máximo de bits.";
                        error.ForeColor = Color.Green;
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
    }
}









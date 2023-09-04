using System.Xml.Serialization;

namespace Metodo_Hamming
{
    public partial class Form1 : Form
    {
        public string seleccion = "";
        Validaciones Validar = new();
        Conversiones Convertir = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void txtDatoIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (seleccion)
            {
                case "Entero sin signo":
                    Validar.NumerosSinSigno(e);
                    break;
                case"Entero con signo (Complemento 1)":
                    Validar.NumerosConSigno(e, txtDatoIngresado);
                    break;
                case "Entero con signo (Bit mas representativo)":
                    Validar.NumerosConSigno(e, txtDatoIngresado);
                    break;
                case "Flotante":
                    Validar.NumerosFlotantes(e, txtDatoIngresado.Text);
                    break;
                case "Caracter":
                    break;
                case "Cadena de caracteres":
                default:
                    MessageBox.Show("Seleccione el tipo de dato");
                    e.Handled = true;
                    break;
            }
        }

        private void cbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            seleccion = cbTipoDato.Text;
        }

        private void btnConvertir_Click(object sender, EventArgs e)
        {
            if (txtDatoIngresado.Text != "")
            {
                switch (seleccion)
                {
                    case "Entero sin signo":
                        string resultado = Convertir.EnterosSinSigno(txtDatoIngresado.Text);
                        if (resultado == "")
                        {
                            MessageBox.Show("Error, el dato es de una dimension que no puede ser representada en 16 bits");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    case "Entero con signo (Complemento 1)":
                        resultado = Convertir.EnterosConSigno(txtDatoIngresado.Text, cbTipoDato.Text);
                        if (resultado == "")
                        {
                            MessageBox.Show("Error, el dato es de una dimension que no puede ser representada en 16 bits");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    case "Entero con signo (Bit mas representativo)":
                        resultado = Convertir.EnterosConSigno(txtDatoIngresado.Text,cbTipoDato.Text);
                        if (resultado == "")
                        {
                            MessageBox.Show("Error, el dato es de una dimension que no puede ser representada en 16 bits");
                        }
                        else
                        {
                            lblResultado.Text = resultado;
                        }
                        break;

                    case "Flotante":
                        break;

                    case "Caracter":
                        break;

                    case "Cadena de caracteres":
                        break;

                    default:
                        MessageBox.Show("Seleccione el tipo de dato");
                        break;
                }

            }
            else
            {
                MessageBox.Show("Ingrese el dato a convertir");
            }
        }
    }
}
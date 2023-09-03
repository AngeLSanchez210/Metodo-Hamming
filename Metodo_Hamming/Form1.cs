using System.Xml.Serialization;

namespace Metodo_Hamming
{
    public partial class Form1 : Form
    {
        public string seleccion = "";

        Validaciones Validar = new();

        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void txtDatoIngresado_KeyPress(object sender, KeyPressEventArgs e)
        {
            switch (seleccion)
            {
                case "Entero sin signo":
                        Validar.NumerosSinSigno(e);
                    break;
                case "Entero con signo":
                        Validar.NumerosConSigno(e, txtDatoIngresado.Text);
                    break;
                case "Flotante":
                        Validar.NumerosFlotantes(e, txtDatoIngresado.Text);
                    break;
                case "Caracter":
                    break;
                case "Cadena de caracteres":
                    break;
                default:
                    errorConversion.SetError(cbTipoDato,"Seleccione el tipo de dato");
                    e.Handled = true;
                    break;
            }
        }

        private void cbTipoDato_SelectedIndexChanged(object sender, EventArgs e)
        {
            txtDatoIngresado.Text = "";
            seleccion = cbTipoDato.Text;
        }


        private void btnConversion_Click(object sender, EventArgs e)
        {
            if (txtDatoIngresado.Text != "")
            {
                switch (seleccion)
                {
                    case "Entero sin signo":
                        break;
                    case "Entero con signo":
                        break;
                    case "Flotante":
                        break;
                    case "Caracter":
                        break;
                    case "Cadena de caracteres":
                        break;
                    default:
                        errorConversion.SetError(cbTipoDato, "Seleccione el tipo de dato");
                        break;
                }
            }
            else
            {
                errorConversion.SetError(txtDatoIngresado, "Llene el campo con el dato a convertir");
            }
        }
    }
}
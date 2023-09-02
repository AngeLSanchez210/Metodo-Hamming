using System.Xml.Serialization;

namespace Metodo_Hamming
{
    public partial class Form1 : Form
    {
        public string seleccion = "";
        public bool signo = false;
        public bool validarTexto(KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (e.KeyChar == ' ')
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo letras");
                return false;
            }
        }
        public bool validarNumerosFlotantes(KeyPressEventArgs e, string cadena)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (e.KeyChar == '.')
            {
                e.Handled = false;
                return true;
            }
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros");
                return false;
            }
        }
        public bool validarNumerosSinSigno(KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros");
                return false;
            }
        }

        public bool validarNumerosConSigno(KeyPressEventArgs e,string cadena)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (e.KeyChar == '+' || e.KeyChar == '-')
            {
                if (!signo && cadena=="")
                {

                    signo = true;
                    e.Handled = false;
                    return true;
                }
                else
                {
                    e.Handled = true;
                    return false;
                }
            }
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros y signo +/-");
                return false;
            }
        }
        public bool txtvacio(TextBox texto)
        {
            if (texto.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public bool comboboxVacio(ComboBox texto)
        {
            if (texto.Text == "")
            {
                return false;
            }
            else
            {
                return true;
            }
        }

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
                   
                    if (validarNumerosSinSigno(e))
                    {

                    }
                    break;
                case "Entero con signo":
                    if (validarNumerosConSigno(e, txtDatoIngresado.Text))
                    {

                    }
                    break;
                case "Flotante":
                    if (validarNumerosFlotantes(e,txtDatoIngresado.Text))
                    {

                    }
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
    }
}
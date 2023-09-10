using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming.Logica
{
    public class Validaciones
    {
        // Declaraciones de variables miembro para gestionar errores y controles de interfaz.
        ErrorProvider error;
        TextBox texto;
        ComboBox combo;

        // Constructor que inicializa las variables de la clase.
        public Validaciones(ErrorProvider error, TextBox texto, ComboBox combo)
        {
            this.error = error;  // Inicializa el ErrorProvider.
            this.texto = texto;  // Inicializa el TextBox.
            this.combo = combo;  // Inicializa el ComboBox.
        }

        // Método que valida si la entrada es un texto.
        public bool Texto(KeyPressEventArgs e)
        {
            if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else if (e.KeyChar == ' ')  // Espacios no permitidos.
            {
                e.Handled = true;
                error.SetError(texto, "Ingrese solo caracteres que no sean nulos");
                return false;
            }
            else
            {
                return true;
            }
        }

        // Método que valida si la entrada es un número flotante, mostrando un mensaje de error si no es válido.
        public bool NumerosFlotantes(KeyPressEventArgs e, string cadena1, TextBox cadena)
        {
            int banderaPunto = 0;
            int banderaSigno = 0;

            // Verifica cuántos puntos hay en el texto.
            foreach (char c in cadena1)
            {
                if (c == '.')
                {
                    banderaPunto++;
                }
            }

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
                if (banderaPunto == 1)
                {
                    e.Handled = true;
                    return false;
                }
                else
                {
                    e.Handled = false;
                    return true;
                }
            }
            else if (e.KeyChar == '-')
            {
                if (banderaSigno == 1)  // Si ya hay un signo.
                {
                    e.Handled = true;
                    return false;
                }
                else if (cadena.SelectionStart == 0)  // Si es el primer carácter.
                {
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
                error.SetError(texto, "Ingrese solo numeros y .");
                return false;
            }
        }

        // Método que valida si la entrada es un número sin signo.
        public bool NumerosSinSigno(KeyPressEventArgs e)
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
                error.SetError(texto, "Ingrese solo numeros");
                return false;
            }
        }

        // Método que valida si la entrada es un número con signo.
        public bool NumerosConSigno(KeyPressEventArgs e, TextBox cadena)
        {
            int banderaSigno = 0;

            // Verifica cuántos signos negativos hay en el texto.
            foreach (char c in cadena.Text)
            {
                if (c == '-')
                {
                    banderaSigno++;
                }
            }

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
            else if (e.KeyChar == '-')
            {
                if (banderaSigno == 1)  // Si ya hay un signo.
                {
                    e.Handled = true;
                    return false;
                }
                else if (cadena.SelectionStart == 0)  // Si es el primer carácter.
                {
                    e.Handled = false;
                    return true;
                }
                else
                {
                    e.Handled = true;
                    return false;
                }
            }
            else  // Otros caracteres no permitidos.
            {
                e.Handled = true;
                error.SetError(texto, "Ingrese solo numeros y el signo '-'");
                return false;
            }
        }
    }

}

﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming
{
    public class Validaciones
    {
        public bool Flotantes(KeyPressEventArgs e, string texto)
        {
            int banderaPunto = 0;
            foreach (char c in texto)
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
            else
            {
                e.Handled = true;
                return false;
            }
        }
        public bool Texto(KeyPressEventArgs e)
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
        public bool NumerosFlotantes(KeyPressEventArgs e, string cadena)
        {
            int banderaPunto = 0;
            foreach (char c in cadena)
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
            else
            {
                e.Handled = true;
                return false;
            }
        }
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
                MessageBox.Show("Ingrese solo numeros");
                return false;
            }
        }

        public bool NumerosConSigno(KeyPressEventArgs e, string cadena)
        {
            int banderaSigno = 0;
            foreach (char c in cadena)
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
                if (banderaSigno == 1)
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
            else
            {
                e.Handled = true;
                MessageBox.Show("Ingrese solo numeros y signo el signo '-'");
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
    }
}

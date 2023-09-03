using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming
{
    public class Conversiones
    {
        public static string ABinario(short valor,ushort? valor1)
        {
            string conversion = Convert.ToString(valor, 2).PadLeft(16, '0');
            string resultado = string.Format("{0} {1} {2} {3}",
                conversion.Substring(0, 4),
                conversion.Substring(4, 4),
                conversion.Substring(8, 4),
                conversion.Substring(12, 4));
            return resultado;

        }

        public string EnterosConSigno(string dato)
        {
            short entero;
            if (short.TryParse(dato, out entero))
            {
                string conversion = Convert.ToString(entero, 2).PadLeft(16, '0');
                string resultado = string.Format("{0} {1} {2} {3}",
                    conversion.Substring(0, 4),
                    conversion.Substring(4, 4),
                    conversion.Substring(8, 4),
                    conversion.Substring(12, 4));
                return resultado;
            }
            else
            {
                return "No es posible la conversion";
            }
        }

        public string EnterosSinSigno(string dato)
        {
            ushort entero;
            if (ushort.TryParse(dato, out entero))
            {
                string conversion = Convert.ToString(entero, 2).PadLeft(16, '0');
                string resultado = string.Format("{0} {1} {2} {3}",
                    conversion.Substring(0, 4),
                    conversion.Substring(4, 4),
                    conversion.Substring(8, 4),
                    conversion.Substring(12, 4));
                return resultado;
            } 
            else
            {
                return "No es posible la conversion";
            }
        }
    }
}

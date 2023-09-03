using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming
{
    public class Conversiones
    {
        public static string ABinario(short valor)
        {
            return Convert.ToString(valor, 2).PadLeft(16, '0');
        }

        public string EnterosConSigno(string dato)
        {
            short entero;
            if (short.TryParse(dato, out entero))
            {
                string DatoBinario = ABinario(entero);
                return DatoBinario;
            }
            else
            {
                return "No es posible la conversion";
            }
        }
    }
}

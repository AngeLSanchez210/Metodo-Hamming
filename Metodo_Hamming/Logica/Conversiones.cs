using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming.Logica
{
    public class Conversiones
    {
        static string C1(string binary)
        {

            char[] complemento = new char[binary.Length];

            for (int i = 0; i < binary.Length; i++)
            {
                complemento[i] = binary[i] == '0' ? '1' : '0';
            }

            return new string(complemento);
        }
        public string EnterosConSigno(string dato, string opcion)
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
                if (opcion == "Entero con signo (Bit mas representativo)")
                {
                    return resultado;
                }
                else
                {
                    if (dato[0] == '-')
                    {
                        string complemento = C1(conversion);
                        resultado = string.Format("{0} {1} {2} {3}",
                            complemento.Substring(0, 4),
                            complemento.Substring(4, 4),
                            complemento.Substring(8, 4),
                            complemento.Substring(12, 4));
                        return resultado;
                    }
                    else
                    {
                        return resultado;
                    }
                }
            }
            else
            {
                return "";
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
                return "";
            }
        }
    }
}

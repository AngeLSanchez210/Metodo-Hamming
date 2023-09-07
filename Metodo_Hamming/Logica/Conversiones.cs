using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming.Logica
{
    public class Conversiones /*Clase que contiene todas las conversiones de tipo de dato a binario
                                y sus diferentes representaciones.*/
    {
        /*Metodo para convertir cualquier tipo de dato a un binario de 16 bits, recibe un parametro
        de tipo dynamic, este tipo de dato almecena cualquier tipo de dato desde un string a un flotante
        esto para permite una mayor utilidad del metodo (Los datos ingresados estan previamente validados)*/
        public string ConversionBin(dynamic numero)
        {
            string conversion = Convert.ToString(numero, 2).PadLeft(16, '0');
            return conversion;
        }

        /*Funcion para dar un formato de separacion al binario resultante de la conversion del dato
         que ingreso el usuario, se muestra en formato de 4 bits en 4 bits (0000 0000 0000 0000) esto
        con el fin de facilitar la lectura del binario resultante*/
        public string DarFormato(string conversion)
        {
            string resultado = string.Format("{0} {1} {2} {3}",
                conversion.Substring(0, 4),
                conversion.Substring(4, 4),
                conversion.Substring(8, 4),
                conversion.Substring(12, 4));
            return resultado;
        }

        public string ComplementoC1(string binario)
        {
            char[] invertido = new char[binario.Length];

            for (int i = 0; i < binario.Length; i++)
            {
                invertido[i] = binario[i] == '0' ? '1' : '0';
            }

            string resultado = new string(invertido);
            return resultado;
        }
        public string EnterosConSigno(string dato, string opcion)
        {
            short numero;
            if (short.TryParse(dato, out numero))
            {
                string conversion = ConversionBin(numero);
                MessageBox.Show(conversion);
                string resultado = DarFormato(conversion);

                if (opcion == "Entero con signo (Bit mas representativo)")
                {
                    return resultado;
                }
                else
                {
                    if (dato[0] == '-')
                    {   
                        string complemento = ComplementoC1(ConversionBin(ushort.Parse(dato.Substring(1))));
                        MessageBox.Show(complemento);
                        resultado = DarFormato(complemento);
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
            ushort numero;
            if (ushort.TryParse(dato, out numero))
            {
                string conversion = ConversionBin(numero);
                string resultado = DarFormato(conversion);
                return resultado;
            }
            else
            {
                return "";
            }
        }

        public string FloatToBinary(float number)
        {
            int integerPart = (int)number;
            float fractionalPart = number - integerPart;

            string integerBinary = Convert.ToString(integerPart, 2);

            string fractionalBinary = "";
            while (fractionalPart > 0 && fractionalBinary.Length < 10)
            {
                fractionalPart *= 2;
                int fractionalBit = (int)fractionalPart;
                fractionalBinary += fractionalBit;
                fractionalPart -= fractionalBit;
            }

            return integerBinary + "." + fractionalBinary;
        }

        //public string Flotantes16Bits(string dato)
        //{
        //    try
        //    {
        //        MessageBox.Show($"{Half.Parse(dato)}");
        //        string resultado = DarFormato(ConversionBin(dato));
        //        return resultado;
        //    }
        //    catch (Exception)
        //    {
        //        return "";
        //    }
        //}
    }
}
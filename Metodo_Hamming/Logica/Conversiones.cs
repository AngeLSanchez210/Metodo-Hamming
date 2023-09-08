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

        //public string FloatToBinary(float number)
        //{
        //    int integerPart = (int)number;
        //    float fractionalPart = number - integerPart;

        //    string integerBinary = Convert.ToString(integerPart, 2);

        //    string fractionalBinary = "";
        //    while (fractionalPart > 0 && fractionalBinary.Length < 10)
        //    {
        //        fractionalPart *= 2;
        //        int fractionalBit = (int)fractionalPart;
        //        fractionalBinary += fractionalBit;
        //        fractionalPart -= fractionalBit;
        //    }

        //    return integerBinary + "." + fractionalBinary;
        //}

        //public string Flotantes(float value)
        //{
        //    // Paso 1: Casos especiales (NaN, Infinito, -Infinito, 0)
        //    if (float.IsNaN(value))
        //        return "0111111111110000";  // Representación estándar de NaN en 16 bits
        //    if (float.IsPositiveInfinity(value))
        //        return "0111110000000000";  // Representación estándar de Infinito en 16 bits
        //    if (float.IsNegativeInfinity(value))
        //        return "1111110000000000";  // Representación estándar de -Infinito en 16 bits
        //    if (value == 0)
        //        return "0000000000000000";  // Representación estándar de 0 en 16 bits

        //    // Paso 2: Determinar el signo
        //    string sign = value < 0 ? "1" : "0";
        //    value = Math.Abs(value);

        //    // Paso 3: Convertir la parte entera y decimal a binario
        //    int integerPart = (int)value;
        //    float decimalPart = value - integerPart;

        //    string binaryInteger = Convert.ToString(integerPart, 2);
        //    string binaryDecimal = "";

        //    for (int i = 0; i < 23; i++)  // Usamos más bits para obtener una representación más precisa que luego se redondeará
        //    {
        //        decimalPart *= 2;
        //        int bit = (int)decimalPart;
        //        binaryDecimal += bit.ToString();
        //        decimalPart -= bit;
        //    }

        //    string binaryRepresentation = binaryInteger + "." + binaryDecimal;

        //    // Paso 4: Normalizar el número
        //    int normalizedExponent;
        //    if (integerPart != 0)
        //    {
        //        normalizedExponent = binaryInteger.Length - 1;
        //    }
        //    else
        //    {
        //        normalizedExponent = -binaryDecimal.IndexOf("1") - 1;
        //    }

        //    // Paso 5: Calcular el exponente con sesgo de 15
        //    int biasedExponent = normalizedExponent + 15;
        //    string exponentRepresentation;

        //    if (biasedExponent <= 0) // Número subnormal
        //    {
        //        exponentRepresentation = "00000";
        //    }
        //    else if (biasedExponent >= 31) // Overflow, considerado infinito
        //    {
        //        return sign == "1" ? "1111110000000000" : "0111110000000000";
        //    }
        //    else
        //    {
        //        exponentRepresentation = Convert.ToString(biasedExponent, 2).PadLeft(5, '0');
        //    }

        //    // Paso 6: Representar el número en formato IEEE 754 de 16 bits
        //    string mantissa;
        //    if (integerPart != 0)
        //    {
        //        // La mantisa toma el bit implícito (el bit a la izquierda del punto) y los bits que siguen
        //        mantissa = binaryRepresentation.Split('.')[1].Substring(0, 10);
        //    }
        //    else
        //    {
        //        // Tomar los bits después del primer 1 encontrado en la representación binaria
        //        mantissa = binaryDecimal.Substring(binaryDecimal.IndexOf("1") + 1, 10);
        //    }

        //    string ieee754Representation = sign + exponentRepresentation + mantissa;

        //    return ieee754Representation;
        //}

        public string ConvertToHalfPrecision(float value)
        {
            if (value < -2048 || value > 2048)
            {
                return "";
            }

            int intBits = BitConverter.ToInt32(BitConverter.GetBytes(value), 0);
            int s = (intBits >> 31) & 0x1;
            int e = (intBits >> 23) & 0xFF;
            int f = intBits & 0x7FFFFF;

            int halfS = s;
            int halfE = e - 127 + 15;  // Ajuste del exponente al formato half-precision
            int halfF = f >> 13;      // Solo tomamos los 10 bits más significativos

            if (halfE <= 0)  // Underflow
            {
                halfE = 0;
                halfF = 0;
            }
            else if (halfE >= 31)  // Overflow
            {
                halfE = 31;
                halfF = 0;
            }

            int halfBits = (halfS << 15) | (halfE << 10) | halfF;

            char[] bits = new char[16];
            for (int i = 0; i < 16; i++)
            {
                bits[15 - i] = (halfBits & (1 << i)) != 0 ? '1' : '0';
            }

            return new string(bits);
        }

        public float ConvertFromHalfPrecision(string binary)
        {
            if (binary.Length != 16)
            {
                throw new ArgumentException("La cadena binaria debe tener 16 bits.");
            }

            int halfBits = Convert.ToInt32(binary, 2);
            int halfS = (halfBits >> 15) & 0x1;
            int halfE = (halfBits >> 10) & 0x1F;
            int halfF = halfBits & 0x3FF;

            int s = halfS;
            int e = (halfE == 0) ? 0 : halfE + 127 - 15;
            int f = halfF << 13;

            int intBits = (s << 31) | (e << 23) | f;

            return BitConverter.ToSingle(BitConverter.GetBytes(intBits), 0);
        }
    }
}
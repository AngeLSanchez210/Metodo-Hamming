using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming.Logica
{
    /*Clase que contiene todas las conversiones de tipo de dato a binari y sus diferentes representaciones.*/
    public class Conversiones 
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
            // Formatea el string 'conversion' dividiendo en bloques de 4 caracteres separados por espacios.
            string resultado = string.Format("{0} {1} {2} {3}",
                conversion.Substring(0, 4),
                conversion.Substring(4, 4),
                conversion.Substring(8, 4),
                conversion.Substring(12, 4));

            // Retorna el string formateado
            return resultado;
        }

        /*Funcion que permite convertir un binario a su equivalente complemento 1*/
        public string ComplementoC1(string binario)
        {
            // Crea un arreglo de caracteres del mismo tamaño que el string 'binario'
            char[] invertido = new char[binario.Length];

            // Itera sobre cada carácter del string 'binario'
            for (int i = 0; i < binario.Length; i++)
            {
                // Si el carácter actual es '0', coloca '1' en el arreglo 'invertido' y viceversa
                invertido[i] = binario[i] == '0' ? '1' : '0';
            }

            // Convierte el arreglo de caracteres 'invertido' de nuevo a un string
            string resultado = new string(invertido);

            // Retorna el string invertido
            return resultado;
        }


        /*Funcion que permite la con*/
        public string EnterosConSigno(string dato, string opcion)
        {
            // Intenta convertir el dato (string) a un número de tipo short
            if (short.TryParse(dato, out short numero))
            {
                // Convierte el número (de tipo short) a su representación binaria (la función ConversionBin no está dada, pero asumo que convierte un número a su forma binaria)
                string conversion = ConversionBin(numero);

                // Si la opción especificada es "Entero con signo (Bit mas representativo)", simplemente regresa el número en formato binario
                if (opcion == "Entero con signo (Bit mas representativo)")
                {
                    return DarFormato(conversion);
                }

                // Si el dato tiene un signo negativo en su primera posición
                if (dato[0] == '-')
                {
                    // Toma la parte numérica del dato (sin el signo), lo convierte a ushort, luego a binario y finalmente obtiene su complemento
                    string complemento = ComplementoC1(ConversionBin(ushort.Parse(dato.Substring(1))));

                    // Regresa el complemento en formato adecuado
                    return DarFormato(complemento);
                }

                // Si ninguna de las condiciones anteriores se cumple, simplemente regresa el número en formato binario
                return DarFormato(conversion);
            }

            // Si el dato no puede ser convertido a un número de tipo short, regresa un string vacío
            return "";
        }

        public string EnterosSinSigno(string dato)
        {
            // Intenta convertir el dato (string) a un número de tipo ushort (sin signo)
            if (ushort.TryParse(dato, out ushort numero))
            {
                // Convierte el número (de tipo ushort) a su representación binaria 
                string conversion = ConversionBin(numero);

                // Retorna el número convertido a binario en un formato específico (dividido en bloques de 4 caracteres separados por espacios)
                return DarFormato(conversion);
            }

            // Si el dato no puede ser convertido a un número de tipo ushort, regresa un string vacío
            return "";
        }


        public string ConvertirAHalfPrecision(float valor)
        {
            // Convierte directamente el valor flotante a una representación entera de 32 bits
            int bitsEnteros = BitConverter.SingleToInt32Bits(valor);

            // Si el valor está fuera del rango permitido para la representación de media precisión, devuelve una cadena vacía
            if (valor < -2048 || valor > 2048)
            {
                return "";
            }

            // Extrae el bit de signo del valor flotante
            int signo = (bitsEnteros >> 31) & 0x1;
            // Extrae el exponente (8 bits) del valor flotante
            int exponente = (bitsEnteros >> 23) & 0xFF;
            // Extrae la fracción (23 bits) del valor flotante
            int fraccion = bitsEnteros & 0x7FFFFF;

            // El bit de signo para la media precisión es el mismo que el bit de signo del valor flotante
            int medioSigno = signo;
            // Ajusta el exponente para la representación de media precisión
            int medioExponente = exponente - 127 + 15;
            // Solo toma los 10 bits más significativos de la fracción para la representación de media precisión
            int medioFraccion = fraccion >> 13;

            // En caso de subflujo (underflow), ajusta el exponente y la fracción a 0
            if (medioExponente <= 0)
            {
                medioExponente = 0;
                medioFraccion = 0;
            }
            // En caso de sobre flujo (overflow), ajusta el exponente a 31 y la fracción a 0
            else if (medioExponente >= 31)
            {
                medioExponente = 31;
                medioFraccion = 0;
            }

            // Combina el bit de signo, el exponente y la fracción en una representación entera de 16 bits
            int bitsMedios = (medioSigno << 15) | (medioExponente << 10) | medioFraccion;

            // Convierte la representación entera a una cadena binaria de 16 caracteres y la devuelve
            return DarFormato(Convert.ToString(bitsMedios, 2).PadLeft(16, '0'));
        }

        public float ConvertirDeHalfPrecision(string binario)
        {
            // Verifica que la cadena tenga exactamente 16 caracteres, en caso contrario, lanza una excepción
            if (binario.Length != 16)
            {
                throw new ArgumentException("La cadena binaria debe tener 16 bits.");
            }

            // Convierte la cadena binaria a un valor entero
            int bitsMedios = Convert.ToInt32(binario, 2);

            // Extrae el bit de signo de la representación de media precisión
            int medioSigno = (bitsMedios >> 15) & 0x1;
            // Extrae el exponente (5 bits) de la representación de media precisión
            int medioExponente = (bitsMedios >> 10) & 0x1F;
            // Extrae la fracción (10 bits) de la representación de media precisión
            int medioFraccion = bitsMedios & 0x3FF;

            // El bit de signo para la precisión simple es el mismo que el bit de signo de la media precisión
            int signo = medioSigno;
            // Ajusta el exponente para la representación de precisión simple
            int exponente = (medioExponente == 0) ? 0 : medioExponente + 127 - 15;
            // Ajusta la fracción para la representación de precisión simple (toma los 10 bits y los desplaza a la posición correcta)
            int fraccion = medioFraccion << 13;

            // Combina el bit de signo, el exponente y la fracción en una representación entera de 32 bits
            int bitsEnteros = (signo << 31) | (exponente << 23) | fraccion;

            // Convierte la representación entera a un valor flotante y lo devuelve
            return BitConverter.Int32BitsToSingle(bitsEnteros);
        }

        public string CaracterABinario(string cadena)
        {
            try
            {
                char caracter = char.Parse(cadena);
                if (caracter > 127)
                {
                    return "";
                }
                return Convert.ToString(caracter, 2).PadLeft(16, '0');
            }
            catch (Exception)
            {

                return "";
            }
        }

        public string CadenaABinario(string cadena)
        {
            StringBuilder resultado = new StringBuilder(cadena.Length * 16);

            if (cadena.Length > 2)
            {
                return "";
            }

            foreach (char caracter in cadena)
            {
                if (caracter > 127)
                {
                    return "";
                }
                resultado.Append(Convert.ToString(caracter, 2).PadLeft(8, '0'));
            }

            return DarFormato(resultado.ToString());
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Metodo_Hamming
{
    public class logicaMetodoHamming
    {
        public int[] codificarBinario(int[] nBinario)
        {
            int[] numeroCodificado = new int[10];
            int[] bits_Paridad = new int[4];

            //Se hace el xor de b5 xor b4 para encontrar el bit de paridad 0
            bits_Paridad[0] = nBinario[0] ^ nBinario[1];//P0
            //b3 xor b2 xor b1
            bits_Paridad[1] = nBinario[2] ^ nBinario[3] ^ nBinario[4];//P1
            //b5 xor b3 xor b2 xor b0
            bits_Paridad[2] = nBinario[0] ^ nBinario[2] ^ nBinario[3] ^ nBinario[5];//P2
            //b4 xor b3 xor b1 xor b0
            bits_Paridad[3] = nBinario[1] ^ nBinario[2] ^ nBinario[4] ^ nBinario[5];//P3

            //Se construye el codigo en base al orden b5 b4 p3 b2 b1  p2 b0 p1 p0
            numeroCodificado[0] = nBinario[0];//b5
            numeroCodificado[1] = nBinario[1];//b4
            numeroCodificado[2] = bits_Paridad[3];//p3
            numeroCodificado[3] = nBinario[2];//b3
            numeroCodificado[4] = nBinario[3];//b2
            numeroCodificado[5] = nBinario[4];//b1
            numeroCodificado[6] = bits_Paridad[2];//p2
            numeroCodificado[7] = nBinario[5];//b0
            numeroCodificado[8] = bits_Paridad[1];//p1
            numeroCodificado[9] = bits_Paridad[0];//p0

            return numeroCodificado;
        }

        public bool validacion(KeyPressEventArgs e, Label lblError)
        {
            if (char.IsDigit(e.KeyChar))
            {
                if(e.KeyChar == '1' || e.KeyChar == '0')
                {
                    lblError.Text = "";
                    e.Handled = false;
                    return true;
                }
                else
                {
                    e.Handled = true;
                    lblError.Text = "Solo se permite ingresar 1 y 0";
                    return false;
                }
            }
            else if (char.IsControl(e.KeyChar))
            {
                e.Handled = false;
                return true;
            }
            else
            {
                e.Handled = true;
                lblError.Text = "Solo se permiten numeros de 1 y 0";
                return false;
            }
        }
    }
}

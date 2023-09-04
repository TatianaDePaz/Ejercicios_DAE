using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio10
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("Ingrese un número binario entero (0s y 1s): ");
                string input = Console.ReadLine();

                if (EsNumeroBinario(input))
                {
                    int decimalValue = ConvertirABinarioDecimal(input);
                    string hexadecimalValue = ConvertirABinarioHexadecimal(input);
                    string octalValue = ConvertirABinarioOctal(input);

                    Console.WriteLine("Decimal: "+decimalValue);
                    Console.WriteLine("Hexadecimal: "+hexadecimalValue);
                    Console.WriteLine("Octal: "+octalValue);
                }
                else
                {
                    Console.WriteLine("Numero no válida. Por favor, ingrese un número binario válido.");
                }

                Console.WriteLine("Presione Enter para continuar o escriba 'salir' para salir.");
                string continuar = Console.ReadLine();
                if (continuar.Equals("salir", StringComparison.OrdinalIgnoreCase))
                    break;
            }
        }

        static bool EsNumeroBinario(string input)
        {
            foreach (char digito in input)
            {
                if (digito != '0' && digito != '1')
                {
                    return false;
                }
            }
            return true;
        }
        //decimal
        static int ConvertirABinarioDecimal(string binario)
        {
            int resultado = 0;
            int longitud = binario.Length;
            for (int i = 0; i < longitud; i++)
            {
                int digito = binario[i] - '0'; 
                int potencia = longitud - i - 1;
                resultado += digito * (int)Math.Pow(2, potencia);
            }
            return resultado;
        }

        //hexadecimal
        static string ConvertirABinarioHexadecimal(string binario)
        {
            int decimalValue = ConvertirABinarioDecimal(binario);
            return decimalValue.ToString("X");
        }

        //octal
        static string ConvertirABinarioOctal(string binario)
        {
            int decimalValue = ConvertirABinarioDecimal(binario);
            return Convert.ToString(decimalValue, 8);
        }
    }
}
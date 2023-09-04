using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercici8
{
    internal class Program
    {
        static bool EsNumeroPerfecto(int numero)
        {
            int sumaDivisores = 0;
            for (int i = 1; i < numero; i++)
            {
                if (numero % i == 0)
                {
                    sumaDivisores += i;
                }
            }
            return sumaDivisores == numero;
        }

        static List<int> EncontrarNumerosPerfectos()
        {
            List<int> numerosPerfectos = new List<int>();
            for (int i = 2; i <= 1000; i++)
            {
                if (EsNumeroPerfecto(i))
                {
                    numerosPerfectos.Add(i);
                }
            }
            return numerosPerfectos;
        }

        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número para verificar si es perfecto:");
            int numeroUsuario = int.Parse(Console.ReadLine());

            if (EsNumeroPerfecto(numeroUsuario))
            {
                Console.WriteLine($"{numeroUsuario} es un número perfecto.");
            }
            else
            {
                Console.WriteLine($"{numeroUsuario} no es un número perfecto.");
            }

            Console.WriteLine("Números perfectos entre 1 y 1000:");
            List<int> numerosPerfectos = EncontrarNumerosPerfectos();
            foreach (int numeroPerfecto in numerosPerfectos)
            {
                Console.Write($"{numeroPerfecto}: ");
                for (int i = 1; i < numeroPerfecto; i++)
                {
                    if (numeroPerfecto % i == 0)
                    {
                        Console.Write($"{i} ");
                    }
                }
                Console.WriteLine();
            }
            Console.ReadKey();
        }
    }
}

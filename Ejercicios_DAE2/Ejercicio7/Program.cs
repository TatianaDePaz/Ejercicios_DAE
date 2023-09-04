using System;

namespace suma_de_pares
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Suma de los numeros pares del 0 hasta el : ");
            int num1 = Convert.ToInt32(Console.ReadLine());

            int i, suma = 0;
    
            for (i = 0; i <= num1; i+=2)
            {
                suma += i;
            }

            Console.WriteLine("La suma delos numeros pares es " + suma);

            Console.Read();
        }
    }
}

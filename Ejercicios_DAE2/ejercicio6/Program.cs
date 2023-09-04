using System;

namespace Ejercicio_Foreach
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] num = { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 };

            foreach(int i in num)
            {
                Console.Write(i + " ");
            }
            Console.ReadLine();
        }
    }
}

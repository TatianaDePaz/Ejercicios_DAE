using System.Runtime.InteropServices;

namespace ejercicio4
{
    class program
    {
        static void Main(string[] args)
        {
            double num1, num2, num3;

            Console.WriteLine("Ingrese el primer numero");
            num1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el segundo numero");
            num2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese el tercer numero");
            num3 = double.Parse(Console.ReadLine());

            if (num1 > num2)
            {
                Console.WriteLine("Numero 1 es mayor")
            }
            else if (num2>num3)
            {
                Console.WriteLine("El numero 2 es mayor")
            }
            else if (num3 > num1)
            {
                Console.WriteLine("El numero 3 es mayor")
            }
            else
            {
                Console.WriteLine("los tres numeros son iguales")
            }

        }

          
    }
}

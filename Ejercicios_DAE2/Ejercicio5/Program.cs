using System.Timers;

namespace ejercicio_5
{
    class program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("Ingrese un numero");
            int num =Convert.ToInt32(Console.ReadLine());

            int i, contador=0;

            for (i=2; i<num; i++)
            {
                if (num % i == 0)
                {
                    contador++;
                    i = num;
                    i++;
                }
               
            }

            if (contador == 0)
            {
                Console.WriteLine("El numero " + num + " si es Primo");
            }
            else
            {
                Console.WriteLine("El numero " + num + " no es primo");
            }
        }
    }
}

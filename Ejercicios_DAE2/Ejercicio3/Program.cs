
namespace ejercicio_3
{
    class program
    {
        static void Main(string[] args)
        {
            int num, sobrante;

            Console.WriteLine("Ingrese un número");
            num = int.Parse(Console.ReadLine());

            sobrante = num % 2;
            
            if (sobrante==0)
            {
                Console.WriteLine("El número "+ num + " es par");

            }
            else
            {
                Console.WriteLine("El número " + num + " no es par");
            }
        }
    }

}
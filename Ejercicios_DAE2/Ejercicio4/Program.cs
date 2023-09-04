namespace ejercicio_4
{
    class program
    {
        static void Main(string[] args)
        {
            int contador = 1, num_mayor=int.MinValue, num_menor=int.MaxValue;

            while (contador <= 3)
            {
                Console.WriteLine($"Ingrese el número {contador} ");
                int numIngresado = Convert.ToInt32(Console.ReadLine());

                if (numIngresado > num_mayor)
                {
                    num_mayor = numIngresado;
                }
                if (numIngresado < num_menor)
                {
                    num_menor = numIngresado;
                }
                contador++
            }
            Console.WriteLine($"El numero mayor es: {num_mayor}");
            Console.WriteLine($"El numero menor es: {num_menor}");

            Console.ReadKey();

        }
    }
}





  
using System;

class Program
{
    static void Main()
    {
        int n = 100000; // Número de términos a utilizar en la serie (cuantos más términos, mayor precisión)
        double pi = CalcularPi(n);

        Console.WriteLine($"El valor estimado de Pi con {n} términos es: {pi}");
    }

    static double CalcularPi(int n)
    {
        double pi = 0.0;
        for (int i = 0; i < n; i++)
        {
            double termino = 4.0 / (2 * i + 1);
            if (i % 2 == 0)
            {
                pi += termino;
            }
            else
            {
                pi -= termino;
            }
        }
        return pi;
    }
}

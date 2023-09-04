using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;//permite utilizar la clase proces

namespace apagadoDePC
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int tiempo;
            int segundos;
            int opcion;
            Console.WriteLine("Programando apagado de pc");
            Console.Write("Ingrese el tiempo de apagado en minutos: ");
            tiempo = int.Parse(Console.ReadLine());
            segundos = tiempo * 60;
            Process.Start("shutdown", "-s -t " + segundos);
            Console.Write("Desea cancelar el apagado de la pc?");
            Console.WriteLine("\n 1. Detener \n 2. Continuar");
            opcion = int.Parse(Console.ReadLine());
            if (opcion == 1)
            {
                Process.Start("shutdown", "-a");
            }
            Console.ReadKey();
        }
    }
}

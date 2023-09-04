using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            // Declaración de variables 
            string n1, n2, n3, n4, n5;
            string d1, d2, d3, d4, d5;
            string nit1, nit2, nit3, nit4, nit5;
            double sph1, sph2, sph3, sph4, sph5;
            int ht1, ht2, ht3, ht4, ht5;
            double totaldeplania;
            double st1, st2, st3, st4, st5;

            // Registro de los 5 empleados
            {
                Console.WriteLine("Ingrese los datos del empleado:");
                Console.WriteLine("Empleado 1");
                Console.Write("Nombre completo: ");
                n1 = Console.ReadLine();
                Console.Write("DUI: ");
                d1 = Console.ReadLine();
                Console.Write("NIT: ");
                nit1 = Console.ReadLine();
                Console.Write("Salario por Hora: $");
                sph1 = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                ht1 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese los datos del empleado:");
                Console.WriteLine("Empleado 2");
                Console.Write("Nombre completo: ");
                n2 = Console.ReadLine();
                Console.Write("DUI: ");
                d2 = Console.ReadLine();
                Console.Write("NIT: ");
                nit2 = Console.ReadLine();
                Console.Write("Salario por Hora: $");
                sph2 = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                ht2 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese los datos del empleado:");
                Console.WriteLine("Empleado 3");
                Console.Write("Nombre completo: ");
                n3 = Console.ReadLine();
                Console.Write("DUI: ");
                d3 = Console.ReadLine();
                Console.Write("NIT: ");
                nit3 = Console.ReadLine();
                Console.Write("Salario por Hora: $");
                sph3 = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                ht3 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese los datos del empleado:");
                Console.WriteLine("Empleado 4");
                Console.Write("Nombre completo: ");
                n4 = Console.ReadLine();
                Console.Write("DUI: ");
                d4 = Console.ReadLine();
                Console.Write("NIT: ");
                nit4 = Console.ReadLine();
                Console.Write("Salario por Hora: $");
                sph4 = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                ht4 = int.Parse(Console.ReadLine());

                Console.WriteLine("\nIngrese los datos del empleado:");
                Console.WriteLine("Empleado 5");
                Console.Write("Nombre completo: ");
                n5 = Console.ReadLine();
                Console.Write("DUI: ");
                d5 = Console.ReadLine();
                Console.Write("NIT: ");
                nit5 = Console.ReadLine();
                Console.Write("Salario por Hora: $");
                sph5 = double.Parse(Console.ReadLine());
                Console.Write("Horas trabajadas: ");
                ht5 = int.Parse(Console.ReadLine());

            }

            // Mostrar el listado de empleados ingresados
            Console.WriteLine("\nListado de empleados:");
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.WriteLine("\n|  | Nombre Completo | DUI      | NIT       | Salario Hora | Horas Trabajadas |");
            Console.WriteLine("\n----------------------------------------------------------------------------------");

            st1 = sph1 * ht1;
            Console.Write("\n|  |" + n1 + "  |  " + d1 + "  |  " + nit1 + "  |  " + " $ " + sph1 + "  |  " + ht1);

            st2 = sph2 * ht2;
            Console.Write("\n|  |" + n2 + "  |  " + d2 + "  |  " + nit2 + "  |  " + " $ " + sph2 + "  |  " + ht2);

            st3 = sph3 * ht3;
            Console.Write("\n|  |" + n3 + "  |  " + d3 + "  |  " + nit3 + "  |  " + " $ " + sph3 + "  |  " + ht3);

            st4 = sph4 * ht4;
            Console.Write("\n|  |" + n4 + "  |  " + d4 + "  |  " + nit4 + "  |  " + " $ " + sph4 + "  |  " + ht4);

            st5 = sph5 * ht5;
            Console.Write("\n|  |" + n5 + "  |  " + d5 + "  |  " + nit5 + "  |  " + " $ " + sph5 + "  |  " + ht5);



            Console.WriteLine("\n----------------------------------------------------------------------------------");
            totaldeplania = st1 + st2 + st3 + st4 + st5;
            Console.WriteLine("\nTotal de planilla: $" + totaldeplania);
            Console.WriteLine("\n----------------------------------------------------------------------------------");
            Console.ReadKey();
        }
    }
}

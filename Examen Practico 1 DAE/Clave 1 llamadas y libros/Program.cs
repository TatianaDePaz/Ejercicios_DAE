using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clave1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool continuar = true;

            while (continuar)
            {
                Console.WriteLine("Menú Principal");
                Console.WriteLine("1. Ejercicio de llamada");
                Console.WriteLine("2. Ejercicio de Libros");
                Console.WriteLine("3. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Ejercicio1();
                        break;
                    case 2:
                        ejercicio2();
                        break;
                    case 3:
                        continuar = false;
                        break;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }

                Console.WriteLine();
            }

        }

        static void Ejercicio1()
        {
            // Código del ejercicio 1
            do
            {
                Console.WriteLine("12 América del norte \r\n15 América central \r\n18 América del sur \r\n19 Europa \r\n23 Asia ");
                Console.Write("Ingrese la clave de la zona(o enter para salir): ");
                string input = Console.ReadLine();

                if (string.IsNullOrEmpty(input))
                {
                    break;
                }

                if (!int.TryParse(input, out int clave))
                {
                    Console.WriteLine("¡Ingrese una clave válida!");
                    continue;
                }

                double costoPorMinuto = 0;
                string nombreZona = "";

                switch (clave)
                {
                    case 12:
                        nombreZona = "América del norte";
                        costoPorMinuto = 2.0;
                        break;
                    case 15:
                        nombreZona = "América central";
                        costoPorMinuto = 2.2;
                        break;
                    case 18:
                        nombreZona = "América del sur";
                        costoPorMinuto = 4.5;
                        break;
                    case 19:
                        nombreZona = "Europa";
                        costoPorMinuto = 3.5;
                        break;
                    case 23:
                        nombreZona = "Asia";
                        costoPorMinuto = 6.0;
                        break;
                    default:
                        Console.WriteLine("Clave de zona no válida.");
                        continue;
                }

                Console.Write("Ingrese el número de minutos hablados: ");
                double minutos = Convert.ToDouble(Console.ReadLine());

                double costoTotal = costoPorMinuto * minutos;

                Console.WriteLine($"Zona: {nombreZona}");
                Console.WriteLine($"Costo por minuto: {costoPorMinuto:C}");
                Console.WriteLine($"Número de minutos: {minutos}");
                Console.WriteLine($"Costo total: {costoTotal:C}");
            } while (true);
        }

        static void ejercicio2()
        {
             //Codigo del segundo Ejercicio
            const int maxLibros = 100;

           
            int[] codigoLibro = new int[maxLibros];
            string[] tituloLibro = new string[maxLibros];
            string[] isbnLibro = new string[maxLibros];
            int[] edicionLibro = new int[maxLibros];
            string[] autorLibro = new string[maxLibros];

            int cantidadLibros = 0; 

            bool continuar = true;
            while (continuar)
            {
                Console.WriteLine("Menú Principal:");
                Console.WriteLine("1. Agregar un libro.");
                Console.WriteLine("2. Mostrar listado de libros.");
                Console.WriteLine("3. Buscar libro por código.");
                Console.WriteLine("4. Editar información de un libro por código.");
                Console.WriteLine("5. Salir");
                Console.Write("Seleccione una opción: ");

                int opcion = int.Parse(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        if (cantidadLibros < maxLibros)
                        {
                            AgregarLibro(codigoLibro, tituloLibro, isbnLibro, edicionLibro, autorLibro, ref cantidadLibros);
                        }
                        else
                        {
                            Console.WriteLine("La biblioteca está llena. No se pueden agregar más libros.");
                        }
                        break;

                    case 2:
                        MostrarListadoLibros(codigoLibro, tituloLibro, isbnLibro, edicionLibro, autorLibro, cantidadLibros);
                        break;

                    case 3:
                        BuscarLibroPorCodigo(codigoLibro, tituloLibro, isbnLibro, edicionLibro, autorLibro, cantidadLibros);
                        break;

                    case 4:
                        EditarLibroPorCodigo(codigoLibro, tituloLibro, isbnLibro, edicionLibro, autorLibro, cantidadLibros);
                        break;

                    case 5:
                        continuar = false;
                        break;

                    default:
                        Console.WriteLine("Opción no válida. Intente de nuevo.");
                        break;
                }
            }
        }

        static void AgregarLibro(int[] codigo, string[] titulo, string[] isbn, int[] edicion, string[] autor, ref int cantidadLibros)
        {
            Console.WriteLine("\nIngrese los datos del libro:");

            Console.Write("Código: ");
            codigo[cantidadLibros] = int.Parse(Console.ReadLine());

            Console.Write("Título: ");
            titulo[cantidadLibros] = Console.ReadLine();

            Console.Write("ISBN: ");
            isbn[cantidadLibros] = Console.ReadLine();

            Console.Write("Edición: ");
            edicion[cantidadLibros] = int.Parse(Console.ReadLine());

            Console.Write("Autor: ");
            autor[cantidadLibros] = Console.ReadLine();

            cantidadLibros++;

            Console.WriteLine("Libro agregado con éxito.");
        }

        static void MostrarListadoLibros(int[] codigo, string[] titulo, string[] isbn, int[] edicion, string[] autor, int cantidadLibros)
        {
            if (cantidadLibros == 0)
            {
                Console.WriteLine("No hay libros registrados.");
            }
            else
            {
                Console.WriteLine("\nListado de Libros:");
                Console.WriteLine("Código | Título       | ISBN          | Edición | Autor");
                for (int i = 0; i < cantidadLibros; i++)
                {
                    Console.WriteLine($"{codigo[i]} | {titulo[i]} | {isbn[i]} | {edicion[i]} | {autor[i]}");
                }
            }
        }

        static void BuscarLibroPorCodigo(int[] codigo, string[] titulo, string[] isbn, int[] edicion, string[] autor, int cantidadLibros)
        {
            Console.Write("Ingrese el código del libro a buscar: ");
            int codigoBuscar = int.Parse(Console.ReadLine());

            int indiceLibro = -1; 

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (codigo[i] == codigoBuscar)
                {
                    indiceLibro = i;
                    break; 
                }
            }

            if (indiceLibro != -1)
            {
                Console.WriteLine("\nLibro encontrado:");
                Console.WriteLine($"Código: {codigo[indiceLibro]}");
                Console.WriteLine($"Título: {titulo[indiceLibro]}");
                Console.WriteLine($"ISBN: {isbn[indiceLibro]}");
                Console.WriteLine($"Edición: {edicion[indiceLibro]}");
                Console.WriteLine($"Autor: {autor[indiceLibro]}");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }

        static void EditarLibroPorCodigo(int[] codigo, string[] titulo, string[] isbn, int[] edicion, string[] autor, int cantidadLibros)
        {
            Console.Write("Ingrese el código del libro a editar: ");
            int codigoEditar = int.Parse(Console.ReadLine());

            int indiceLibro = -1; 

            for (int i = 0; i < cantidadLibros; i++)
            {
                if (codigo[i] == codigoEditar)
                {
                    indiceLibro = i;
                    break; 
                }
            }

            if (indiceLibro != -1)
            {
                Console.WriteLine("\nIngrese los nuevos datos del libro:");

                Console.Write("Nuevo Título: ");
                titulo[indiceLibro] = Console.ReadLine();

                Console.Write("Nuevo ISBN: ");
                isbn[indiceLibro] = Console.ReadLine();

                Console.Write("Nueva Edición: ");
                edicion[indiceLibro] = int.Parse(Console.ReadLine());

                Console.Write("Nuevo Autor: ");
                autor[indiceLibro] = Console.ReadLine();

                Console.WriteLine("Libro editado con éxito.");
            }
            else
            {
                Console.WriteLine("Libro no encontrado.");
            }
        }





    }  
}

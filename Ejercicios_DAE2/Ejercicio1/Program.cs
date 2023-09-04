using System;
using System.Collections;
using System.Collections.Generic;

namespace EjercicioCombinado
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.WriteLine("Seleccione una opción:");
                Console.WriteLine("1. Ejercicio de Llamadas");
                Console.WriteLine("2. Ejercicio de Matrices");
                Console.WriteLine("3. Ejercicio de Libros");
                Console.WriteLine("4. Salir");

                int opcion = int.Parse(Console.ReadLine());
                switch (opcion)
                {
                    case 1:
                        EjercicioLlamadas();
                        break;
                    case 2:
                        EjercicioMatrices();
                        break;
                    case 3:
                        EjercicioLibros();
                        break;
                    case 4:
                        return;
                    default:
                        Console.WriteLine("Opción inválida.");
                        break;
                }
            }
        }

        static void EjercicioLlamadas()
        {
            // Código del ejercicio de Llamadas
            // ...
            double clave, costo_de_la_llamada, costo_del_minuto, tiempo_en_minuto;
            Console.WriteLine("12 América del norte \r\n15 América central \r\n18 América del sur \r\n19 Europa \r\n23 Asia ");
            Console.Write("Ingresa la clave de la  región: ");
            clave = double.Parse(Console.ReadLine());
            Console.Write("Ingresa el valor de tiempo en minuto: ");
            tiempo_en_minuto = double.Parse(Console.ReadLine());
            costo_del_minuto = 0;
            if (clave == 12)
            {
                Console.WriteLine("America del Norte");
                costo_del_minuto = 2;
            }
            if (clave == 15)
            {
                Console.WriteLine("America Central");
                costo_del_minuto = 2.2;
            }
            if (clave == 18)
            {
                Console.WriteLine("America del Sur");
                costo_del_minuto = 4.5;
            }
            if (clave == 19)
            {
                Console.WriteLine("Europa");
                costo_del_minuto = 3.5;
            }
            if (clave == 23)
            {
                Console.WriteLine("Asia");
                costo_del_minuto = 6;
            }

            costo_de_la_llamada = tiempo_en_minuto * costo_del_minuto;
            Console.WriteLine("Costo de la llamada: " + costo_de_la_llamada);
            Console.WriteLine("Costo del minuto: " + costo_del_minuto);
            Console.WriteLine();
            Console.Write("Precione cualuier tecla para terminar");
            Console.ReadKey();
        }

        static void EjercicioMatrices()
        {
            int[,] matriz = LlenarMatriz();
            MostrarMatriz(matriz);

            Console.ReadKey();
        }

        static int ValidarNumero()
        {
            int numero;
            while (true)
            {
                Console.WriteLine("Ingrese un número entre 5 y 15: ");
                if (int.TryParse(Console.ReadLine(), out numero))
                {
                    if (numero >= 5 && numero <= 15)
                    {
                        return numero;
                    }
                }
                Console.WriteLine("El número ingresado no está dentro del rango permitido.");
            }
        }

        static int[,] LlenarMatriz()
        {
            int[,] matriz = new int[5, 4];
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matriz[i, j] = ValidarNumero();
                }
            }
            return matriz;
        }

        static void MostrarMatriz(int[,] matrizMostrar)
        {
            Console.WriteLine("Matriz completa:");
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(matrizMostrar[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }

        static void EjercicioLibros()
        { }
             // Código del ejercicio de Libros
            // ...
            class Libro
            {
            
            public int Codigo { get; set; }
            public string Titulo { get; set; }
            public string ISBN { get; set; }
            public int Edicion { get; set; }
            public string Autor { get; set; }

            public Libro(int codigo, string titulo, string isbn, int edicion, string autor)
            {
                Codigo = codigo;
                Titulo = titulo;
                ISBN = isbn;
                Edicion = edicion;
                Autor = autor;
            }

            public override string ToString()
            {
                return string.Format("{0}\t{1}\t{2}\t{3}\t{4}", Codigo, Titulo, ISBN, Edicion, Autor);
            }

        }

    }
           
        

        class Program
        {
            static List<Libro> libros = new List<Libro>();

            static void AgregarLibro()
            {
                Console.WriteLine("Agregar libro:");
                Console.Write("Código: ");
                int codigo = int.Parse(Console.ReadLine());
                Console.Write("Título: ");
                string titulo = Console.ReadLine();
                Console.Write("ISBN: ");
                string isbn = Console.ReadLine();
                Console.Write("Edición: ");
                int edicion = int.Parse(Console.ReadLine());
                Console.Write("Autor: ");
                string autor = Console.ReadLine();
                libros.Add(new Libro(codigo, titulo, isbn, edicion, autor));
                Console.WriteLine("Libro agregado exitosamente.");
                Console.ReadKey();
            }

            static void MostrarListado()
            {
                Console.WriteLine("Listado de libros:");
                Console.WriteLine("Código\tTítulo\tISBN\tEdición\tAutor");
                foreach (Libro libro in libros)
                {
                    Console.WriteLine(libro.ToString());
                }
                Console.ReadKey();
            }

            static void BuscarPorCodigo()
            {
                Console.Write("Ingrese el código del libro que desea buscar: ");
                int codigo = int.Parse(Console.ReadLine());
                Libro libro = libros.Find(l => l.Codigo == codigo);
                if (libro != null)
                {
                    Console.WriteLine("Libro encontrado:");
                    Console.WriteLine("Código\tTítulo\tISBN\tEdición\tAutor");
                    Console.WriteLine(libro.ToString());
                }
                else
                {
                    Console.WriteLine("No se encontró ningún libro con el código ingresado.");
                }
                Console.ReadKey();
            }

            static void EditarPorCodigo()
            {
                Console.Write("Ingrese el código del libro que desea editar: ");
                int codigo = int.Parse(Console.ReadLine());
                Libro libro = libros.Find(l => l.Codigo == codigo);
                if (libro != null)
                {
                    Console.WriteLine("Libro encontrado:");
                    Console.WriteLine("Código\tTítulo\tISBN\tEdición\tAutor");
                    Console.WriteLine(libro.ToString());

                    Console.WriteLine("Edite la información del libro:");
                    Console.Write("Nuevo título (presione enter para no cambiar): ");
                    string titulo = Console.ReadLine();
                    Console.Write("Nuevo ISBN (presione enter para no cambiar): ");
                    string isbn = Console.ReadLine();
                    Console.Write("Nueva edición (presione enter para no cambiar): ");
                    string input = Console.ReadLine();
                    int edicion;
                    if (int.TryParse(input, out edicion))
                    {
                        libro.Edicion = edicion;
                    }
                    Console.Write("Nuevo autor (presione enter para no cambiar): ");
                    string autor = Console.ReadLine();

                    if (!string.IsNullOrEmpty(titulo))
                    {
                        libro.Titulo = titulo;
                    }
                    if (!string.IsNullOrEmpty(isbn))
                    {
                        libro.ISBN = isbn;
                    }
                    if (!string.IsNullOrEmpty(autor))
                    {
                        libro.Autor = autor;
                    }

                    Console.WriteLine("Información del libro actualizada exitosamente:");
                    Console.WriteLine("Código\tTítulo\tISBN\tEdición\tAutor");
                    Console.WriteLine(libro.ToString());
                }
                else
                {
                    Console.WriteLine("No se encontró ningún libro con el código ingresado.");
                }
                Console.ReadKey();
            }

            static void Main(string[] args)
            {
                while (true)
                {
                    Console.WriteLine("Seleccione una opción:");
                    Console.WriteLine("1. Agregar libro");
                    Console.WriteLine("2. Mostrar listado de libros");
                    Console.WriteLine("3. Buscar libro por código");
                    Console.WriteLine("4. Editar libro por código");
                    Console.WriteLine("5. Salir");

                    int opcion = int.Parse(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            AgregarLibro();
                            break;
                        case 2:
                            MostrarListado();
                            break;
                        case 3:
                            BuscarPorCodigo();
                            break;
                        case 4:
                            EditarPorCodigo();
                            break;
                        case 5:
                            return;
                        default:
                            Console.WriteLine("Opción inválida.");
                            break;
                    }
                }
            }
        }
}




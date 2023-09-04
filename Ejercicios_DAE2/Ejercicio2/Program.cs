using System.Net;

namespace Ejercicio2
{
    class program
    {
        static void Main(string[] args)
        {
            //Programa que pida el ingreso del precio de un articulo y la cantidad que lleva el cliente. Mostrar lo que debe pagar el comprador

            string nombreProducto;
            int cantidad;
            double precio, cantidadPagar;

            Console.WriteLine("Ingrese el nombre del producto");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio del producto: $");
            precio = double.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantad a llevar");
            cantidad = int.Parse(Console.ReadLine());

            cantidadPagar = cantidad * precio;

            Console.WriteLine("Cantidad a pagar por el producto: " + nombreProducto +" es de $" + cantidadPagar);

        }
    }
}


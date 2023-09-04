string nombreProducto;
int cantidadxproducto, cantidadDeProducto = 2;
double precio, total, totalAcumulado = 0;

for (int i = 1; i <= cantidadDeProducto; i++)
{
    Console.WriteLine("Nombre producto" + i + ":");
    nombreProducto=Console.ReadLine();
    Console.WriteLine("Cantidad producto" + i + ":");
    cantidadxproducto=int.Parse(Console.ReadLine());
    Console.WriteLine("Precio producto" + i + ":");
    precio=double.Parse(Console.ReadLine());
    total = (cantidadxproducto * precio) * 1.13;
    totalAcumulado = totalAcumulado + total;
    Console.Clear();
}

Console.WriteLine("El total a pagar es: " + totalAcumulado);

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1programacion
{
    class Impuestodelosproductos
    {
        static void Main(string[] args)
        {
            double precio, iva;
            string tipop, cadena;

            Console.WriteLine("Ingrese el precio del producto ");
            cadena = Console.ReadLine();
            Console.WriteLine("Ingrese el tipo del producto ");
            tipop = Console.ReadLine();
            precio = double.Parse(cadena);
            if(tipop!="medicina")
            {
                iva = precio * 0.13;
                Console.WriteLine("El impuesto es de " + iva + "$");
                Console.ReadKey();
            }
            else
            {
                iva = 0;
                Console.WriteLine("El impuesto es de " + iva + "$");
                Console.ReadKey();
            }
        }
    }
}

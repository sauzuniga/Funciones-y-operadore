using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1programacion
{
    class _2doejerciodigitos
    {
        static void Main(string[] args)
        {
            double numero1, numero2, operacion1, operacion2;
            string cadena;
            Console.WriteLine("Ingrese el primer numero ");
            cadena = Console.ReadLine();
            numero1 = double.Parse(cadena);

            Console.WriteLine("Ingrese el segundo numero ");
            cadena = Console.ReadLine();
            numero2 = double.Parse(cadena);
            operacion1 = (numero1 + numero2) * (numero1 - numero2);
            operacion2 = numero1 * 2 - numero2;
            Console.WriteLine("El resustado de (a+b)*(a-b) es: " + operacion1);
            Console.WriteLine("El resultado de a2-b es: " + operacion2);
            Console.ReadKey();
        }

    }
}

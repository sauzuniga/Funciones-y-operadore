using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1programacion
{
    class Tercerejercicio_condicional
    {
        static void Main(string[] args)
        {
            int num1, num2;
            double division;
            string cadena;
            Console.WriteLine("Ingrese el primer numero ");
            cadena = Console.ReadLine();
            num1 = int.Parse(cadena);

            Console.WriteLine("Ingrese el segundo numero ");
            cadena = Console.ReadLine();
            num2 = int.Parse(cadena);
            if (num2 != 0)
            {
                division = num1 / num2;
                Console.WriteLine("El resultado de la division es: " + division);
                Console.ReadKey();
            }
                else
            {
                Console.WriteLine("Error: No se puede dividir entre cero ");
                Console.ReadKey();
            }
        }
    }
}

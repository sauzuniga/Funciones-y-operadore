using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1programacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;

            Console.WriteLine("Cual es tu nombre");
            nombre = Console.ReadLine();
            Console.WriteLine("Bienvenido al ID " + nombre);
            Console.ReadKey();
        }
    }
}

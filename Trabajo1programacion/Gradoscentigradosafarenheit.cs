using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1programacion
{
    class Gradoscentigradosafarenheit
    {
        static void Main(string[] args)
        {
            double centigrados, farenheit;
            string cadena;
            Console.WriteLine("Ingrese los grados centigrados que desea connvertir a farenheit");
            cadena = Console.ReadLine();
            centigrados = double.Parse(cadena);
            farenheit = centigrados / 5 * 9 + 32;
            Console.WriteLine("Los " + centigrados + " °C equivalen a: " + farenheit + " °F ");
            Console.ReadKey();
        }
    }
}

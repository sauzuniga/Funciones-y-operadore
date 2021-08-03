using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trabajo1programacion
{
    class calificacionesdeestudiante
    {
        static void Main(string[] args)
        {
            double nota1, nota2, nota3, notapor1, notapor2, notapor3, notafin;
            string cadena1, cadena2, cadena3;
            Console.WriteLine("Ingrese la primera nota");
            cadena1 = Console.ReadLine();
            Console.WriteLine("Ingrese la segunda nota ");
            cadena2 = Console.ReadLine();
            Console.WriteLine("Ingrese la tercera nota ");
            cadena3= Console.ReadLine();
            nota1 = double.Parse(cadena1);
            nota2 = double.Parse(cadena2);
            nota3 = double.Parse(cadena3);
            notapor1 = nota1 * 0.3;
            notapor2 = nota2 * 0.35;
            notapor3 = nota3 * 0.25;
            notafin = notapor1 + notapor2 + notapor3;
            Console.WriteLine("nota 1: " + nota1 + "Nota porcentaje: " + notapor1);
            Console.WriteLine("nota 2: " + nota2 + " Nota porcentaje " + notapor2);
            Console.WriteLine(" nota 3: " + nota3 + "Nota pocentaje " + notapor3);
            Console.WriteLine("Nota final: " + notafin);
            Console.ReadLine();
        }
    }
}

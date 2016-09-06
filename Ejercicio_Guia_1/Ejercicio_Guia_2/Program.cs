using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia_2
{
    class Ejercicio_2
    {
        static void Main(string[] args)
        {
            int num;

            Console.Title = "Ejercicio Nro 02";

            Console.WriteLine("Ingrese un numero por favor");
            num = int.Parse(Console.ReadLine());
            while (num == 0)
            {
                Console.WriteLine("ERROR. Reingresar número!!!");
                num = int.Parse(Console.ReadLine());
            }
            Console.WriteLine("El cuadrado del numero " + num + " es: " + (num * num));
            Console.WriteLine("El cubo del numero " + num + " es: " + (num * num * num));
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia_1
{
    class Ejercicio_1
    {
        static void Main(string[] args)
        {
            int num,contador,acumulador=0,max=0,min=0,flag=0;

            Console.Title = "Ejercicio Nro 01";

            for (contador = 0; contador < 5; contador++)
            {
                Console.WriteLine("Ingrese un numero por favor");
                num = int.Parse(Console.ReadLine());
                acumulador += num;

                if (flag == 0 || max < num)
                {
                    max = num;
                }

                if (flag == 0 || min > num)
                {
                    min = num;
                    flag = 1;
                }

            }

            Console.WriteLine("Minimo : " + min);
            Console.WriteLine("Máximo : " + max);
            Console.WriteLine("Promedio : " + acumulador/5);
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey();

        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad,acumulado = 0,promedio,contador;
            Console.Title = "Nicolas Stellisano";
            Console.Write("Hola Mundo");
            Console.ReadKey();
            

            for (contador = 0; contador < 5; contador++)
            {
                edad = int.Parse(Console.ReadLine());
                acumulado = edad + acumulado;
            }

            promedio = acumulado / 5;
            Console.Write("El acumulado es " + acumulado);
            Console.Write("El promedio es " + promedio);
            Console.ReadKey();

            Ejercicio3.Calculadora.Sumar(1,2);

        }
    }
}

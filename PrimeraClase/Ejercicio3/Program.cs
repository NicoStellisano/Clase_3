using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            
            Console.WriteLine(Ejercicio3.Calculadora.Sumar(6,6));
            Console.WriteLine(Ejercicio3.Calculadora.Dividir(0, 0));
            Console.ReadKey();
            Calculadora.EsMayorQue(1, 5);

            Alumno alguien;
            alguien = new Alumno();

            Alumno otro = new Alumno();

            otro.nombre = "Jorge";
            alguien.nombre = "Nico";
            otro.nota = 5;
            alguien.nota = 10;

            otro.MostrarDatos();
            alguien.MostrarDatos();


            
        }
    }
}

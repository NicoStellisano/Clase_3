using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
          /*  EFabricante fabricante;
            fabricante = EFabricante.Honda;
            Console.WriteLine(fabricante);
            fabricante = (EFabricante)1;
            Console.WriteLine(fabricante);
            //Creacion de objetos
            Rueda nuevaRueda;
            nuevaRueda = new Rueda();

            Auto nuevoAuto;
            nuevoAuto = new Auto();
            Auto auto2;
            auto2 = new Auto();
            Auto auto3;
            auto3 = new Auto();
            Auto auto4;
            auto4 = new Auto();
            */
            Carrera race;
            race = new Carrera();
            race.MostrarCarrera();
            Console.ReadKey();

        }
    }
}

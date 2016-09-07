using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    class Program
    {
        static void Main(string[] args)
        {
         /*   List<Auto> listAuto = new List<Auto>();
            ArrayList arrayL = new ArrayList();
            arrayL.Add("Hola");
            arrayL.Add(new Auto());
            listAuto.Add(new Auto());
            //listAuto.Add("Hola");
            //Stack = Pila
            Stack<Auto> stk = new Stack<Auto>();
            stk.Push(new Auto());
            stk.Pop();
            stk.Count();
            stk.Peek();
            Queue<Auto> queue = new Queue<Auto>();
            Hashtable hash = new Hashtable();
          */
            ArrayList arrayL = new ArrayList();
            arrayL.Add("Hola");
            arrayL.Add(new Auto());
            
            Rueda otras = new Rueda("papa",3);
            Auto auto1 = new Auto();
           
            Tiempo tmp;
            tmp = 2;
            Kilometros km;
            km = 2;

           
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
            Console.ForegroundColor = ConsoleColor.Yellow;
            Carrera race;
            race = new Carrera();
            race += new Auto();
            race += new Auto();
            race += new Auto();
            race += new Auto();
            race += new Auto();



           
            race.CorrerCarrera(tmp);

            race.CorrerCarrera(km);
            Console.ReadKey();

        }
    }
}

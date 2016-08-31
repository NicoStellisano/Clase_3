using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    class Program
    {
        static void Main(string[] args)
        {
            /*Producto prod1 = (Producto)33;
            int resultado;
            resultado = prod1 + prod1;
            Console.WriteLine(resultado);
            Console.ReadKey();
             */ 

            Dolar und;
            Peso unp;
            und = 1;
            unp = (Peso)1;
            und = und + unp;
            Console.WriteLine("Un Dolar = 1 + 1Peso :" + "{0:n2}",(float)und);
            unp = unp + und;
            Console.WriteLine("Un Peso = 1 + 1Dolar :" + "{0:n2}", (float)unp);
            Console.ReadKey();




        }
    }
}

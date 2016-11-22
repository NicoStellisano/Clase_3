using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    class Program
    {
       

        static void Main(string[] args)
        {
           /* ClaseEv clase = new ClaseEv("Carlitos");

            clase.eventoNombre += new DelegadoClaseEv(eventoMostrarNombre);
            clase.MostrarNombre();
            */ 
            string minombre = "Nicolás";
            minombre.MiMetodo();
            Console.ReadKey();
        }

        public static void eventoMostrarNombre(string nombre)
        {
            
            Console.WriteLine(nombre);
        }
    }
}

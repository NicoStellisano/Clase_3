using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    class Program
    {
        static void Main(string[] args)
        {
            Persona pers = new Persona("Nico");
           // pers.nombre = "Nico";
            Serializador.SerializarPersona(pers);
           // Console.ReadKey();
        }
    }
}

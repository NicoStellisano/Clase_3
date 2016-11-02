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
            Persona pers2 = new Persona("Tomas");
             Persona pers3 = new Persona("Octavio");


            List<Persona> listadoPersonas = new List<Persona>();
            listadoPersonas.Add(pers);
            listadoPersonas.Add(pers2);
            Alumno alum = new Alumno(45645,"Carlo");
            listadoPersonas.Add(alum);
            Aula aula = new Aula(listadoPersonas, pers3, 123,"Aula1");

           // pers.nombre = "Nico";
            Serializador.SerializarPersona(pers);
            Serializador.SerializarListaPersonas(listadoPersonas);
            Serializador.SerializarAula(aula);
           // Console.ReadKey();
        }
    }
}

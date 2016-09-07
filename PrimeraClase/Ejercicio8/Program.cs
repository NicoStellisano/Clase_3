using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    class Program
    {
        static void Main(string[] args)
        {
            Aula miPrimerAula = new Aula();
            Alumno alum1 = new Alumno();
            Alumno alum2 = new Alumno();
            Alumno alum3 = new Alumno();
            Alumno alum4 = new Alumno();

            alum1.nombre = "Jorge";
            alum1.legajo = 1500;
            alum2.nombre = "Nico";
            alum2.legajo = 1501;
            alum3.nombre = "Mati";
            alum3.legajo = 1502;
            alum4.nombre = "Mari";
            alum4.legajo = 1503;

            miPrimerAula = miPrimerAula + alum1;
          //  miPrimerAula.AgregarAlumno(alum1);
          //  miPrimerAula.AgregarAlumno(alum2);
          //  miPrimerAula.AgregarAlumno(alum3);

            Aula.MostrarAlumno(miPrimerAula);
          /*  miPrimerAula.BorrarAlumno(alum1);
            miPrimerAula.AgregarAlumno(alum4);
            miPrimerAula.AgregarAlumno(alum1);
            miPrimerAula.AgregarAlumno(alum1);




           // miPrimerAula.listaDeAlumnos[0].nombre = "lalala";

            Aula.MostrarAlumno(miPrimerAula);
            

            /*Alumno A = new Alumno();
            Alumno B = new Alumno();
            Alumno C = new Alumno();

            A = B;
            B.nombre = "lalala";
            A = C;
            A.nombre = "maria";
            C.nombre = "octavio";

            Console.WriteLine("A: " + A.nombre);
            Console.WriteLine("B: " + B.nombre);
            Console.WriteLine("C: " + C.nombre);
             */ 


           


            Console.ReadKey();

            
         
        }
    }
}

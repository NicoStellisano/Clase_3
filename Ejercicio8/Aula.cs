using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Aula
    {
        public int numero;
        public Alumno[] listaDeAlumnos;
        public static int length = 10;
        

        public Aula()
        {
          this.listaDeAlumnos = new Alumno[10];

          for (int i = 0; i < length; i++)
          {
              //this.listaDeAlumnos[i] = new Alumno();
              //this.listaDeAlumnos[i].nombre = "NN";
          }


          /*foreach (Alumno objAlum in this.listaDeAlumnos)
          {
              objAlum.nombre = "NN";
          }
           */ 
        }

        public static void MostrarAlumno(Aula aula)
        {
            Console.WriteLine();
            foreach (Alumno objAlum in aula.listaDeAlumnos)
            {
                if(objAlum !=null)
                Console.WriteLine(objAlum.nombre);
            }
        }

        public int Indice()
        {
            int i;
            for (i = 0; i < length; i++)
            {
                if (this.listaDeAlumnos[i] == null)
                {
                    break;
                }
            }

            if(i<10)
                return i;
            return -1;

        }

        public void AgregarAlumno(Alumno alum)
        {
            int indice = Indice();
            if (indice != -1)
                this.listaDeAlumnos[indice] = alum;
            else
                Console.WriteLine("No hay Espacio");
        }

        public void BorrarAlumno(Alumno alu)
        {
            int i;
            for (i = 0; i < length; i++)
            {
                if (this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i].legajo == alu.legajo)
                {
                    break;
                }
            }         
                this.listaDeAlumnos[i] = null;
        }

        public bool ExisteAlumno(Alumno alum)
        {
            int i;
            for (i = 0; i < length; i++)
            {
                if (this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i].legajo == alum.legajo)
                {
                    return true;
                }
            }
            return false;
        }
    }
}

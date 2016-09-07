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

         /* for (int i = 0; i < length; i++)
          {
              //this.listaDeAlumnos[i] = new Alumno();
              //this.listaDeAlumnos[i].nombre = "NN";
          }*/


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
                if ((object)objAlum != null)
                    Console.WriteLine(objAlum.nombre);
                else
                    Console.WriteLine("NULL");
            }
        }
        /// <summary>
        /// Devuelve el Indice del Primer elemento NULL, de lo contrario retorna -1
        /// </summary>
        /// <returns></returns>
        public int obtenerIndice()
        {
            int i;
            for (i = 0; i < length; i++)
            {
                if ((object)this.listaDeAlumnos[i] == null)
                {
                    break;
                }
            }

            if(i<10)
                return i;
            return -1;

        }
        /// <summary>
        /// Retorna el índice del objeto, de lo contrario retorna -1. 
        /// </summary>
        /// <param name="alum"></param>
        /// <returns></returns>
        public int obtenerIndice(Alumno alum)
        {
            int i;
            for (i = 0; i < length; i++)
            {
                if ((object)this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i].legajo == alum.legajo)
                {
                    break;
                }
            }

            if (i < 10)
                return i;
            return -1;
        }


        public Aula AgregarAlumno(Alumno alum)
        {
            int indice = obtenerIndice();
            if (ExisteAlumno(alum) == false)
            {
                if (indice != -1)
                {
                    this.listaDeAlumnos[indice] = alum;
                }
                else
                    Console.WriteLine("No hay Espacio");
            }
            else
                Console.WriteLine("Ya está este alumno");

            return this;
        }

        public Aula BorrarAlumno(Alumno alu)
        {
            int indice = obtenerIndice();
            if (ExisteAlumno(alu) == true)
            {
                if (indice != -1)
                {
                    this.listaDeAlumnos[indice] = null;   
                }
                
                    
            }
            else
                Console.WriteLine("No existe este alumno");        
                return this;
        }

        public bool ExisteAlumno(Alumno alum)
        {
            /*int i;
            for (i = 0; i < length; i++)
            {
                if (this.listaDeAlumnos[i] != null && this.listaDeAlumnos[i].legajo == alum.legajo)
                {
                    return true;
                }
            }
            return false;
             */
            if (obtenerIndice(alum) != -1)
                return true;
            return false;
        }

        public static Aula operator +(Aula aula, Alumno alum)
        {
           return aula.AgregarAlumno(alum);
        }

        public static Aula operator -(Aula aula, Alumno alum)
        {
            return aula.BorrarAlumno(alum);
        }

     


    }
}

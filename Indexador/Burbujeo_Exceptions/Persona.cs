using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo_Exceptions
{
    public class Persona
    {
        private string _nombre;
        private int num;
        private Persona aux;
        public static void MostrarP(Persona per)
        {
            throw new ExceptionPerson(per._nombre);
        }
        public Persona(string nombre)
        {
            this._nombre = nombre;
            //if (this._nombre == "Pedro")
          //  throw new ExceptionName(("Nombre: " + this._nombre));
        }

        public static void Algo()
        {
            throw new ExceptionName("Ahi te va");
        }

        public void AsignarNumero()
        {
            throw new ExceptionName("Alo Polisia");
            //3.Instancia - Static - Constructor - Program
            //4.3 Metodos - Static - Program
            //5.3 Instancia - Static - Constructor - Program
            /*try
            {
               //aux = new Persona("Pedro");
               Algo();

            }
            catch (ExceptionName exN)
            {
                //aux.num = new Random().Next(0, 11);

                throw new ExceptionPerson(exN.Message + "1");
            }*/
        }

        
    }
}

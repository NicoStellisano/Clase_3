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

        //3.Instancia - Static - Constructor - Program
        public Persona(int num)
        {
            this.num = num;
            //if (this._nombre == "Pedro")
            try
            {
                Algo(this);
            }
            catch (ExceptionPerson exP)
            {

                throw new ExceptionName(exP.Message+("Nombre: " + this._nombre));
            }

            //Algo(this);
        }

        public static void Algo(Persona per)
        {
            try
            {
                per.AsignarNumero();
            }
            catch (ExceptionName exN)
            {
                throw new ExceptionPerson(exN.Message +" Static2");
              //  new Persona(15);

                //throw;
            }
        }

        public void AsignarNumero()
        {
            throw new ExceptionName("Instancia1");
            
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

      
        //4.3 Metodos - Static - Program
        public void A()
        {
            throw new ExceptionName("1");

        }
        public void B()
        {
            try
            {
                this.A();
            }
            catch (ExceptionName exN)
            {

                throw new ExceptionName(exN.Message + ", 2");
            }

        }
        public void C()
        {
            try
            {
                this.B();
            }
            catch (ExceptionName exN)
            {

                throw new ExceptionName(exN.Message + ", 3");
                
            }
            throw new ExceptionName("Instancia1");

        }
        public static void Statik(Persona per)
        {
            try
            {
                per.C();
            }
            catch (ExceptionName exN)
            {

                throw new ExceptionPerson(exN.Message + ", 4S");
            }
        }

        
    }
}

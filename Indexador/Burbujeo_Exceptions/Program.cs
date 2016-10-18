using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo_Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Persona per1 = new Persona("Alejandro");
               // per1.AsignarNumero();
                per1.AsignarNumero();

            }

           catch(ExceptionPerson exP)
           {
               Console.WriteLine(exP.Message);

           }

            catch (ExceptionName exN)
            {

                Console.WriteLine(exN.Message);
            }
            Console.ReadKey();
        }
    }
}

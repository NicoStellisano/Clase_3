using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio_Guia_22
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Ejercicio Nro 22";
            Mediciones.Celsius celsius1 = new Mediciones.Celsius(5);
            Mediciones.Fahrenheit fahrenheit = new Mediciones.Fahrenheit(41.00000);
            Mediciones.Kelvin kelvin1 = new Mediciones.Kelvin(278.1500);
            Mediciones.Celsius celsius2 = new Mediciones.Celsius(5);
            Mediciones.Kelvin kelvin2 = new Mediciones.Kelvin(278.1500);
            Mediciones.Fahrenheit fahrenheit1 = new Mediciones.Fahrenheit(41.00000);
            Mediciones.Fahrenheit fahrenheit2 = new Mediciones.Fahrenheit(41.00000);





            
           
             if (kelvin1 == kelvin2)
            {
                Console.WriteLine("Funciona");
            }

            /* Suma
             * celsius1 = kelvin1 + celsius1;
            Console.WriteLine("Celsius : " + celsius.cant);
             */
           /* Convertido
            * kelvin1.cant = celsius1.CCelsius(kelvin);
            Console.WriteLine(kelvin1.cant);
       
            fahrenheit1.cant = kelvin1.CKelvin(fahrenheit1);
            Console.WriteLine(fahrenheit1.cant);
            */ 
            Console.ReadKey();
            
           
        }
    }
}





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
            Mediciones.Celsius celsius = new Mediciones.Celsius(5);
            Mediciones.Fahrenheit fahrenheit = new Mediciones.Fahrenheit(41.00000);
            Mediciones.Kelvin kelvin = new Mediciones.Kelvin(278.1500);

            switch (Validaciones1.Menu.MenuV())
            {
                case 1:
                    Mediciones.Suma.Sumas();
                    break;
            }

           /* Comparacion
            * if (kelvin == fahrenheit)
            {
                Console.WriteLine("Funciona");
            }
*/
            /* Suma
             * celsius = kelvin + celsius;
            Console.WriteLine("Celsius : " + celsius.cant);
             */
           /* Convertido
            * kelvin.cant = celsius.CCelsius(kelvin);
            Console.WriteLine(kelvin.cant);
       
            fahrenheit.cant = kelvin.CKelvin(fahrenheit);
            Console.WriteLine(fahrenheit.cant);
            */ 
            Console.ReadKey();
            
           
        }
    }
}

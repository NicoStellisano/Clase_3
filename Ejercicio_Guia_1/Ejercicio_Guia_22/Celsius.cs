using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediciones
{
    public class Celsius
    {
        public double cant;
        public static double aux;

            public Celsius(double cantidad)
        {
            this.cant = cantidad;
        }

            public double CCelsius(Kelvin kelvin)
            {
                aux = this.cant * 9 / 5 + 32;
                aux = (aux + 459.67) * 5 / 9;
                return aux;
            }

            public double CCelsius(Fahrenheit fahrenheit)
            {

                aux = this.cant * 9 / 5 + 32;
                return aux;
            }

            public static Celsius operator ++(Celsius celsius)
            {
                celsius.cant++;
                return celsius;
            }

            public static Celsius operator --(Celsius celsius)
            {
                celsius.cant--;
                return celsius;
            }

        public static Celsius operator +(Fahrenheit fahrenheit,Celsius celsius)
        {
            celsius.cant += (fahrenheit.cant - 32) * 5 / 9;
            return celsius;
        }

        public static Celsius operator -(Fahrenheit fahrenheit, Celsius celsius)
        {
            celsius.cant -= (fahrenheit.cant - 32) * 5 / 9;
            return celsius;
        }

        public static bool operator ==(Fahrenheit fahrenheit, Celsius celsius)
        {
            if(celsius.cant == (fahrenheit.cant - 32) * 5 / 9)
            return true;
            return false;
        }

        public static bool operator !=(Fahrenheit fahrenheit, Celsius celsius)
        {
            if (celsius.cant != (fahrenheit.cant - 32) * 5 / 9)
                return true;
            return false;
        }

        public static Celsius operator +(Celsius celsius, double valor)
        {
            celsius.cant = celsius.cant+ valor;
            return celsius;
        }


             public static Celsius operator -(Celsius celsius, double valor)
        {
            celsius.cant = celsius.cant+ valor;
            return celsius;
        }

             public static Celsius operator +(Kelvin kelvin, Celsius celsius)
             {
                 aux = kelvin.cant * 9 / 5 - 459.67;
                 celsius.cant += (aux - 32) *5 / 9;
                 return celsius;
             }

             public static Celsius operator -(Kelvin kelvin, Celsius celsius)
             {
                 aux = kelvin.cant * 9 / 5 - 459.67;
                 celsius.cant -= (aux - 32) * 5 / 9;
                 return celsius;
             }

             public static bool operator ==(Kelvin kelvin, Celsius celsius)
             {
                 aux = kelvin.cant * 9 / 5 - 459.67;
                 if (celsius.cant == Math.Round((aux - 32) * 5 / 9))
                     return true;
                 return false;
             }

             public static bool operator !=(Kelvin kelvin, Celsius celsius)
             {
                 aux = kelvin.cant * 9 / 5 - 459.67;
                 if (celsius.cant != Math.Round((aux - 32) * 5 / 9))
                     return true;
                 return false;
             }

             public static implicit operator Celsius(int valor)
             {
                 return new Celsius(valor);
             }


    }
}

/*      public static Celsius operator ++(Celsius celsius, int valor)
 {
     celsius.cant = celsius.cant+ valor;
     return celsius;
 }

      public static Celsius operator --(Celsius celsius, int valor)
 {
     celsius.cant = celsius.cant+ valor;
     return celsius;
 }
*/

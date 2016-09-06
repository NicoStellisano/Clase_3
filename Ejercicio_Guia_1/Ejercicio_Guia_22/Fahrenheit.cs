using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediciones
{
    public class Fahrenheit
    {
        public double cant;
        public static double aux;
        public Fahrenheit(double cantidad)
        {
            this.cant = cantidad;
        }

        public double CFahrenheit(Kelvin kelvin)
        {          
            aux = (this.cant + 459.67) * 5 / 9;
            return aux;
        }

        public double CFahrenheit(Celsius celsius)
        {

            aux = (this.cant - 32) * 5 / 9;
            return aux;
        }

        public static Fahrenheit operator ++(Fahrenheit fahrenheit)
        {
            fahrenheit.cant++;
            return fahrenheit;
        }

        public static Fahrenheit operator --(Fahrenheit fahrenheit)
        {
            fahrenheit.cant--;
            return fahrenheit;
        }

        public static Fahrenheit operator +(Celsius celsius,Fahrenheit fahrenheit)
        {
            fahrenheit.cant += celsius.cant * 9 / 5 + 32;
            return fahrenheit;
        }

        public static Fahrenheit operator -(Celsius celsius, Fahrenheit fahrenheit)
        {
            fahrenheit.cant -= celsius.cant * 9 / 5 + 32;
            return fahrenheit;
        }

        public static bool operator ==(Celsius celsius, Fahrenheit fahrenheit)
        {
            if(celsius.cant == Math.Round((fahrenheit.cant - 32) * 5 / 9))
            return true;
            return false;
        }

        public static bool operator !=(Celsius celsius, Fahrenheit fahrenheit)
        {
            if (celsius.cant != Math.Round((fahrenheit.cant - 32) * 5 / 9))
                return true;
            return false;
        }

        public static Fahrenheit operator +(Fahrenheit fahrenheit, double valor)
        {
            fahrenheit.cant = fahrenheit.cant+ valor;
            return fahrenheit;
        }


        public static Fahrenheit operator -(Fahrenheit fahrenheit, double valor)
        {
            fahrenheit.cant = fahrenheit.cant - valor;
            return fahrenheit;
        }

        public static Fahrenheit operator +(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            fahrenheit.cant += kelvin.cant * 9 / 5 - 459.67;
            return fahrenheit;
        }

        public static Fahrenheit operator -(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            fahrenheit.cant -= kelvin.cant * 9 / 5 - 459.67;
            return fahrenheit;
        }

        public static bool operator ==(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            if (fahrenheit.cant == Math.Round(kelvin.cant * 9 / 5 - 459.67))
                return true;
            return false;
        }

        public static bool operator !=(Kelvin kelvin, Fahrenheit fahrenheit)
        {
            if (fahrenheit.cant != Math.Round(kelvin.cant * 9 / 5 - 459.67))
                return true;
            return false;
        }

        public static implicit operator Fahrenheit(int valor)
        {
            return new Fahrenheit(valor);
        }

        public static Fahrenheit operator +(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            fahrenheit1.cant += fahrenheit2.cant - 32;
            return fahrenheit1;
        }

        public static Fahrenheit operator -(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            fahrenheit1.cant -= fahrenheit2.cant - 32;
            return fahrenheit1;
        }

        public static bool operator ==(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            if (fahrenheit1.cant == fahrenheit2.cant)
                return true;
            return false;
        }

        public static bool operator !=(Fahrenheit fahrenheit1, Fahrenheit fahrenheit2)
        {
            if (fahrenheit1.cant != (fahrenheit2.cant))
                return true;
            return false;
        }
    }
}

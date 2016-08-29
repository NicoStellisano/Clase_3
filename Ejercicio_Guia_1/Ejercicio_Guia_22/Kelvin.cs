using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mediciones
{
    public class Kelvin
    {
        public double cant;
        public static double aux;

        public Kelvin(double cantidad)
        {
            this.cant = cantidad;
        }

        public double CKelvin(Fahrenheit fahrenheit)
        {
            aux = this.cant * 9 / 5 - 459.67;
            return aux;
        }

        public double CKelvin(Celsius celsius)
        {

            aux = this.cant * 9 / 5 - 459.67;
            aux = (aux - 32) * 5 / 9;
            return aux;
        }

        public static Kelvin operator +(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            kelvin.cant += (fahrenheit.cant + 459.67) * 5 / 9;
            return kelvin;
        }

        public static Kelvin operator -(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            kelvin.cant -= (fahrenheit.cant + 459.67) * 5 / 9;
            return kelvin;
        }

        public static bool operator ==(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            if (kelvin.cant == ((fahrenheit.cant + 459.67)* 5/9))
                return true;
            return false;
        }

        public static bool operator !=(Fahrenheit fahrenheit, Kelvin kelvin)
        {
            if (kelvin.cant != ((fahrenheit.cant + 459.67) * 5 / 9))
                return true;
            return false;
        }

        public static Kelvin operator +(Kelvin kelvin, double valor)
        {
            kelvin.cant = kelvin.cant + valor;
            return kelvin;
        }


        public static Kelvin operator -(Kelvin kelvin, double valor)
        {
            kelvin.cant = kelvin.cant - valor;
            return kelvin;
        }

        public static Kelvin operator +(Celsius celsius, Kelvin kelvin)
        {
            aux = celsius.cant * (9 / 5) + 32;
            kelvin.cant += (aux + 459.67) * 5 / 9;
            return kelvin;
        }

        public static Kelvin operator -(Celsius celsius, Kelvin kelvin)
        {
            aux = celsius.cant * (9 / 5) + 32;
            kelvin.cant -= (aux + 459.67) * 5 / 9;
            return kelvin;
        }

        public static bool operator ==(Celsius celsius, Kelvin kelvin)
        {
            aux = celsius.cant * 9 / 5 + 32;
            if (kelvin.cant == (aux + 459.67) * 5 / 9)
                return true;
            return false;
        }

        public static bool operator !=(Celsius celsius, Kelvin kelvin)
        {
            aux = celsius.cant * 9 / 5 + 32;
            if (kelvin.cant != (aux + 459.67) * 5 / 9)
                return true;
            return false;
        }
    }
}

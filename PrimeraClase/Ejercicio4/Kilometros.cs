using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Kilometros
    {
        private int _cantidad;
         private Kilometros(int cant)
        {
            this._cantidad = cant;
        }

         public static Kilometros operator +(Kilometros kilometros, int valor)
         {
             kilometros._cantidad = kilometros._cantidad + valor;
             return kilometros;
         }

         public static Kilometros operator +(Kilometros kilometros, Kilometros kilometros2)
         {
             kilometros._cantidad += kilometros2._cantidad;
             return kilometros;
         }

         public static Kilometros operator -(Kilometros kilometros, int valor)
         {
             kilometros._cantidad -= kilometros._cantidad + valor;
             return kilometros;
         }

         public static Kilometros operator -(Kilometros kilometros, Kilometros kilometros2)
         {
             kilometros._cantidad -= kilometros2._cantidad;
             return kilometros;
         }

         public static bool operator ==(Kilometros kilometros, int valor)
         {
             if (kilometros._cantidad == valor)
                 return true;
             return false;
         }

         public static bool operator ==(Kilometros kilometros, Kilometros kilometros2)
         {
             if (kilometros._cantidad == kilometros2._cantidad)
                 return true;
             return false;
         }

         public static bool operator !=(Kilometros kilometros, int valor)
         {
             if (kilometros._cantidad != valor)
                 return true;
             return false;
         }

         public static bool operator !=(Kilometros kilometros, Kilometros kilometros2)
         {
             if (kilometros._cantidad != kilometros2._cantidad)
                 return true;
             return false;
         }
         public static Kilometros operator ++(Kilometros kilometros)
         {
             kilometros._cantidad++;
             return kilometros;
         }

         public static Kilometros operator --(Kilometros kilometros)
         {
             kilometros._cantidad--;
             return kilometros;
         }
         public static implicit operator Kilometros(int valor)
         {
             return new Kilometros(valor);
         }

         public static explicit operator int(Kilometros km)
         {
             return km._cantidad;
         }

         public static bool operator <(Kilometros km, int valor)
         {
             if (km._cantidad < valor)
                 return true;
             return false;
         }

         public static bool operator >(Kilometros km, int valor)
         {
             if (km._cantidad > valor)
                 return true;
             return false;
         }

         public static bool operator <(Kilometros km, Kilometros km2)
         {
             if (km._cantidad < km2._cantidad)
                 return true;
             return false;
         }

         public static bool operator >(Kilometros km, Kilometros km2)
         {
             if (km._cantidad > km2._cantidad)
                 return true;
             return false;
         }

    }
}

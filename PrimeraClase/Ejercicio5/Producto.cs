using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Producto
    {

         private int _cantidad;

        private Producto(int cant)
        {
            this._cantidad = cant;
        }

        public static int operator +(Producto prod1, Producto prod2)
        {
           return prod1._cantidad += prod2._cantidad;   

        }

        public static implicit operator Producto(int valor)
        {
            return new Producto(valor);
        }

    }
}

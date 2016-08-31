using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Peso
    {

        private double _cantidad;

        public Peso(double cant)
        {
            this._cantidad = cant;
        }

        public static explicit operator Peso(double valor)
        {
            return new Peso(valor);
        }

        public static Peso operator +(Peso Peso, Dolar Dolar)
        {
            Peso._cantidad += (double)Dolar * 15;
            return Peso;
        }

        public static explicit operator double(Peso Peso)
        {
            return Peso._cantidad;
        }
    }
}

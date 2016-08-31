using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio5
{
    public class Dolar
    {
        private double _cantidad;

        public Dolar(double cant)
        {
            this._cantidad = cant;
        }

        public static implicit operator Dolar(double valor)
        {
            return new Dolar(valor);
        }

        public static Dolar operator +(Dolar Dolar,Peso Peso)
        {
            Dolar._cantidad += (double)Peso / 15;
            return Dolar;
        }

        public static explicit operator double(Dolar Dolar)
        {
            return Dolar._cantidad;
        }
    }

}

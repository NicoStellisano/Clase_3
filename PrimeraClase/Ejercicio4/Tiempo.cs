using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Tiempo
    {
        public int cantidad;

        public Tiempo(int cant)
        {
            this.cantidad = cant;
        }

        public static Tiempo Sumar(Tiempo tiempoaux, int valor)
        {
            tiempoaux.cantidad = tiempoaux.cantidad + valor;
            return tiempoaux;
        }
    }
}

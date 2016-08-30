using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Tiempo
    {
        private int _cantidad;

        private Tiempo(int cant)
        {
            this._cantidad = cant;
        }
        // Sumar = operator +
        public static Tiempo operator +(Tiempo tiempoaux, int valor)
        {
            tiempoaux._cantidad = tiempoaux._cantidad + valor;
            return tiempoaux;
        }

        public static Tiempo operator +(Tiempo tiempoaux, Tiempo tiempoaux2)
        {
            tiempoaux._cantidad += tiempoaux2._cantidad;
            return tiempoaux;
        }

        public static Tiempo operator -(Tiempo tiempoaux, int valor)
        {
            tiempoaux._cantidad -= tiempoaux._cantidad + valor;
            return tiempoaux;
        }


        public static Tiempo operator -(Tiempo tiempoaux, Tiempo tiempoaux2)
        {
            tiempoaux._cantidad -= tiempoaux2._cantidad;
            return tiempoaux;
        }

        public static bool operator ==(Tiempo tiempoaux, int valor)
        {
            if(tiempoaux._cantidad == valor)
            return true;
            return false;
        }

        public static bool operator ==(Tiempo tiempoaux, Tiempo tiempoaux2)
        {
            if (tiempoaux._cantidad == tiempoaux2._cantidad)
                return true;
            return false;
        }

        public static bool operator !=(Tiempo tiempoaux, int valor)
        {
            if (tiempoaux._cantidad != valor)
                return true;
            return false;
        }

        public static bool operator !=(Tiempo tiempoaux, Tiempo tiempoaux2)
        {
            if (tiempoaux._cantidad != tiempoaux2._cantidad)
                return true;
            return false;
        }

        public static Tiempo operator ++(Tiempo tiempo)
        {
            tiempo._cantidad++;
            return tiempo;
        }

        public static Tiempo operator --(Tiempo tiempo)
        {
            tiempo._cantidad--;
            return tiempo;
        }

        //Si es explicita : (int) "33"
        //Si es implicita : "33"
        public static implicit operator Tiempo(int valor)
        {
            return new Tiempo(valor);
        }
        public static explicit operator int(Tiempo tiempo)
        {
            return tiempo._cantidad;
        }

        public static bool operator <(Tiempo tiempoaux, int valor)
        {
            if (tiempoaux._cantidad < valor)
                return true;
            return false;
        }

        public static bool operator >(Tiempo tiempoaux, int valor)
        {
            if (tiempoaux._cantidad > valor)
                return true;
            return false;
        }

        public static bool operator <(Tiempo tiempoaux, Tiempo tiempoaux2)
        {
            if (tiempoaux._cantidad < tiempoaux2._cantidad)
                return true;
            return false;
        }

        public static bool operator >(Tiempo tiempoaux, Tiempo tiempoaux2)
        {
            if (tiempoaux._cantidad > tiempoaux2._cantidad)
                return true;
            return false;
        }

    }
}

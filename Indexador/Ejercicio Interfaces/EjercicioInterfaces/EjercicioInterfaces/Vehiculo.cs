using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public abstract class Vehiculo
    {
        protected double _precio;
       
        

        public Vehiculo(double precio)
        {
            this._precio = precio;

        }

        public abstract double Precio
        {
            get;
            set;
        }

        public void MostrarPrecio()
        {
            Console.WriteLine("Precio: " + this._precio);

        }
    }
}

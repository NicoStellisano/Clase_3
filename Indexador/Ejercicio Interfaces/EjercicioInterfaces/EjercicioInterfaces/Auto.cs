using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public abstract class Auto : Vehiculo
    {
        public override double Precio
        {
            get
            {
                return this._precio;
            }
            set
            {
                this._precio = value;
            }
        }
        protected string _patente;

        public Auto(double precio, string patente):base(precio)

        {
            this._patente = patente;

        }

        public void MostrarPatente()
        {
            Console.WriteLine("Patente: " + this._patente);
        }

         
    }
}

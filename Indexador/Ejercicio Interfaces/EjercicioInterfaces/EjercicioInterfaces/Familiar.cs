using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    public class Familiar : Auto
    {
        private int _cantAsiento;
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
        public Familiar(double precio, string patente, int cantidadAsientos):base(precio,patente)
        {
            this._cantAsiento = cantidadAsientos;
        }
    }
}

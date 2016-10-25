using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Privado:Avion
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
        public Privado(double precio,double velMax):base(precio,velMax)
            {

            }
    }
}

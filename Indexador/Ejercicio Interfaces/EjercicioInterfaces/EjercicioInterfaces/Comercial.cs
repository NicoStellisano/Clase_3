using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Comercial : Avion, IARBA
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
            public Comercial(double precio,double velMax):base(precio,velMax)
            {

            }

             double IARBA.CalcularImpuesto()
            {
                return this._precio * 1.25;
            }
        }
    
}

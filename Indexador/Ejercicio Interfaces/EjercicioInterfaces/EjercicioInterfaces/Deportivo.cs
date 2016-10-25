using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Deportivo : Auto, IAFIP, IARBA
    {
        protected int _caballosFuerza;
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
        public Deportivo(double precio, string patente, int hp):base(precio,patente)

        {
            this._caballosFuerza = hp;
        }

         double IAFIP.CalcularImpuesto()
    {
        return this._precio * 1.28;
    }

         double IARBA.CalcularImpuesto()
        {
            return this._precio * 1.23;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
   public class Carreta : Vehiculo,IARBA
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
        public Carreta(double precio):base(precio)
        {
            //throw new System.NotImplementedException();
        }

        public double CalcularImpuesto()
        {
            return this._precio * 1.18;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Producto
    {
        public int _codigo;
        public float _precioDeVenta;

        public static bool operator ==(Producto p1, Producto p2)
        {
            if (p1._codigo == p2._codigo)
                return true;
            return false;          
        }

        public static bool operator !=(Producto p1, Producto p2)
        {
            if (p1 == p2)
                return false;
            return true;
        }

        public override string ToString()
        {
            return ("Codigo: " + this._codigo + " Precio Venta: " + this._precioDeVenta);
        }

        public override bool Equals(object obj)
        {
            bool flag = false;
            try
            {
                if (this== (Producto)obj)
                {
                    flag = true;
                }
            }
            catch (Exception)
            {
                
               // throw;
            }
          
            return flag;
        }
    }
}

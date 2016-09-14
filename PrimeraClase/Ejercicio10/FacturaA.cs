using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class FacturaA:Factura
    {
        public int iva;
        public FacturaA(int iva,Factura fact):base(fact.numero,fact.fecha,fact._numeroDeControl)
        {
            this.iva = iva;
        }
    }
}

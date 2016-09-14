using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class FacturaAPagada:FacturaA
    {
        public string fechaDePago;
        public FacturaAPagada(string fechaDePago, FacturaA factA):base(factA.iva,factA)
        {
            this.fechaDePago = fechaDePago;
        }
    }
}

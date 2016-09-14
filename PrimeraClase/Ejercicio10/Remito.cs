using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Remito:Documento
    {
        public string fecha;

        public Remito(int numero):base(numero)
        {

        }

        public Remito(int numero, string fecha, int numeroDeControl): base(numero, fecha, numeroDeControl)
        {

        }
    }
}

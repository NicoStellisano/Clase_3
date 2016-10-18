using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Basica
{
    public class AutoException:MiExcepcion
    {
        private Auto _auto;

        public AutoException(string mensaje, DateTime tiempo, Auto auto)
            : this(mensaje, tiempo,auto,null)
        {

        }

        public AutoException(string mensaje, DateTime tiempo, Auto auto,Exception excepAnterior)
            : base(mensaje, tiempo,excepAnterior)
        {
            this._auto = auto;
        }
    }
}

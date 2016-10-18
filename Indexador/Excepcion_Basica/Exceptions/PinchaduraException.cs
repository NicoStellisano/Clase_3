using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Basica
{
    public class PinchaduraException:MiExcepcion
    {
        private string _marca;
       
        public PinchaduraException(string mensaje, DateTime tiempo, string marca)
            : this(mensaje, tiempo,marca,null)
        {

        }

        public PinchaduraException(string mensaje, DateTime tiempo, string marca,Exception excepAnterior)
            : base(mensaje, tiempo,excepAnterior)
        {
            this._marca = marca;
        }

    }
}

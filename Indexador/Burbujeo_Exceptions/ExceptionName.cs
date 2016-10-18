using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo_Exceptions
{
    public class ExceptionName:Exception
    {
        public ExceptionName(string mensaje)
            :base(mensaje)
        {
            
        }
    }
}

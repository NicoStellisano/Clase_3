using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Burbujeo_Exceptions
{
    public class ExceptionPerson:Exception
    {
        public ExceptionPerson(string mensaje)
            :base(mensaje)
        {
            
        }
    }
}

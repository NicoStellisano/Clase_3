using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Persona
    {
        public string nombre;
        public long dni;

        public Persona(string nombre, long dni)
        {
            this.nombre = nombre;
            this.dni = dni;
        }
    }
}

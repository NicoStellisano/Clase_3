using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Mascota
    {
        public string nombre;
        public string raza;

        public Mascota(string nombre, string raza)
        {
            this.nombre = nombre;
            this.raza = raza;
        }

        public override string ToString()
        {
            return ("Nombre: " + this.nombre + " Raza: " + this.raza);
        }

    }
}

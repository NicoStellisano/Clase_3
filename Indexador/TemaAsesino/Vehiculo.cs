using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Vehiculo
    {
        public string marca;
        public string color;
        public string patente;

        public Vehiculo(string marca, string color, string patente)
        {
            this.marca = marca;
            this.color = color;
            this.patente = patente;
        }
    }
}

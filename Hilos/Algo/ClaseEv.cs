using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algo
{
    public delegate void DelegadoClaseEv(string nombre);
    public class ClaseEv
    {
       
        public string nombre;
        public event DelegadoClaseEv eventoNombre;

        public ClaseEv(string nom)
        {
            this.nombre = nom;
        }

        public void MostrarNombre()
        {
            this.eventoNombre(this.nombre);
        }
    }
}

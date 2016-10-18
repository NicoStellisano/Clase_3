using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Basica
{
    public class Carrera
    {
        public List<Auto> listaDeAutos;
        public string autodromo;

        public Carrera(string autodromo)
        {
            this.autodromo = autodromo;
            this.listaDeAutos = new List<Auto>();
        }

        public void CorrerCarrera()
        {
            if (this.listaDeAutos.Count > 0)
            {
                foreach (Auto item in this.listaDeAutos)
                {
                    item.Andar();
                }
            }
            else
            {
                throw new MiExcepcion("No hay autos",DateTime.Today);
            }
        }
    }
}

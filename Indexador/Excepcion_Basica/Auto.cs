using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Basica
{
    public class Auto
    {
        public string marca;
        public int numero;
        public List<Rueda> listadoRuedas;

        public Auto(string marca, int numero)
        {
            this.marca = marca;
            this.numero = numero;
            this.listadoRuedas = new List<Rueda>();
            

        }

        public void Andar()
        {
            if (this.listadoRuedas.Count < 4)
            {
                throw new MiExcepcion("Faltan Ruedas", DateTime.Now);
            }
            else
            {
                try
                {
                    foreach (Rueda item in this.listadoRuedas)
                    {
                        item.Rodar();
                    }

                }
                catch (PinchaduraException pinchex)
                {
                    
                    AutoException autoex = new AutoException("El auto pinchó una rueda",pinchex.horaDeLaExcepcion,this,pinchex);
                    throw autoex;
                }
                
            }
        }
    }
}

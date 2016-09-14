using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    public class Documento
    {
        public int numero;
        protected string fecha;
        private int _numeroDeControl;
  
        public Documento(int numero)
        {
            this.numero = numero;
            
        }

        public Documento(int numero, string fecha, int numeroDeControl):this(numero)
        {
            this.fecha = fecha;
            this._numeroDeControl = numeroDeControl;
        }
            public void Mostrar()
        {
            Console.WriteLine(this.numero);
            Console.WriteLine(this.fecha);
            Console.WriteLine(this._numeroDeControl);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
    public class PC
    {
        public string marca;
        public string SO;
        public static int contadorPC;
        public int numero;

       /* public PC(string marca, string SO):this(marca)
        {
           // this.marca = marca;
            this.SO = SO;
        }
        */
        static PC()
        {
            contadorPC = 1;
        }
        public PC(string marca)
        {
            this.marca = marca;
            this.SO = "Windows";
            this.numero = contadorPC;
            contadorPC++;
        }

        public static implicit operator PC (string marca)
    {
        return new PC(marca);
    }
    
}
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Basica
{
    public class Rueda
    {
        public string marca;
        public static Random rnd;

         static Rueda()
        {
            rnd = new Random();
        }

        public Rueda(string marca)
        {
            this.marca = marca;
        }

        public void Pinchar()
        {
            throw new PinchaduraException("Pinchó la rueda", DateTime.Now, this.marca);
        }

        public void Rodar()
        {
            
            int numero;
            numero = rnd.Next(1, 10);

            if (numero == 5)
            {
                this.Pinchar();
            }
            else
            {
                Console.WriteLine(numero);
            }
        }
    }
}

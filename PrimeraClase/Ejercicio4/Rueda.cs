using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Rueda
    {
        public string Marca;
        public float Tamaño;
        //Constructor de instancia
        public Rueda()
        {
            this.Marca = "Sin Marca";
        }

        public void MostrarRueda()
        {
            Console.WriteLine("El tamaño de la rueda es: " + this.Tamaño);
        }
        

        
    }
}

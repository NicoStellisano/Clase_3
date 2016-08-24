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
        /// <summary>
        /// Este es el Constructor por defecto, va a iniciar el tamaño en 0 y la marca en 'Sin Marca'.
        /// </summary>
        public Rueda()
        {
            this.Marca = "Sin Marca";
        }
        /// <summary>
        /// Constructor que pide como parametro una marca en forma de string.
        /// </summary>
        /// <param name="marca">Nombre de la Marca.</param>
        public Rueda(string marca)
        {
            this.Marca = marca;
        }
        /// <summary>
        /// Constructor que pide como parametro un tamaño en forma de int.
        /// </summary>
        /// <param name="tamaño">Tamaño de la Rueda</param>
        public Rueda(int tamaño):this()
        {
            this.Tamaño = tamaño;
           
            
        }
        /// <summary>
        /// Constructor que pide como parametro una marca y un tamaño de rueda.
        /// </summary>
        /// <param name="marca">Nombre de la Marca.</param>
        /// <param name="tamaño">Tamaño de la Rueda.</param>
        public Rueda(string marca, int tamaño):this(tamaño)
        {
            this.Marca = marca;
            
           
        }
/// <summary>
/// Constructor que pide como parametro una marca y un tamaño de rueda.
/// </summary>
        /// <param name="tamaño">Tamaño de la Rueda.</param>
        /// <param name="marca">Nombre de la Marca.</param>
        public Rueda(int tamaño,string marca):this(marca,tamaño)
        {
           
        }



        public void MostrarRueda()
        {
            Console.WriteLine("El tamaño de la rueda es: " + this.Tamaño);
        }
        

        
    }
}

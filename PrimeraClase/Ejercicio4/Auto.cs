using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Auto
    {
        private EFabricante fabricante;
        public Rueda ruedaDI;
        public Rueda ruedaDD;
        public Rueda ruedaTI;
        public Rueda ruedaTD;
        public static int contadorDeObjetos;
        private static Random rnd;
        
        private int kmRecorridos;
        

        public Auto()
        {
            //Random rnd = new Random();
            int random = rnd.Next(0, 3);
            this.fabricante = (EFabricante)random;
            this.ruedaDI = new Rueda();
            this.ruedaDD = new Rueda();
            this.ruedaTI = new Rueda();
            this.ruedaTD = new Rueda();
            Auto.contadorDeObjetos++;
        }

        public static bool CompararAuto(Auto a1 ,Auto a2)
        {
            if (a1.fabricante == a2.fabricante)
                return true;
            return false;
        }

        //No se puede public,private . Solo de la forma static Nombre_Clase()
         static Auto()
        {
            Auto.contadorDeObjetos = 0;
            Auto.rnd = new Random();
        }

         public void MostrarAuto()
         {           
             Console.WriteLine("El fabricante es: " + this.fabricante + " Kilometros: " + this.kmRecorridos +"km");
             Console.WriteLine("******************************************************************************");
         }

         public void VolverACero()
         {
             this.kmRecorridos = 0;
         }

         public void AgregarKm(int kilometros)
         {
             this.kmRecorridos += kilometros;
         }

         public int KmRecorrido()
         {
             return this.kmRecorridos;
         }

         public EFabricante Fabricante()
         {
             return this.fabricante;
         }
    }
}

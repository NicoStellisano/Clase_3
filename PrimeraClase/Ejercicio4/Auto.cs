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
        
        private Kilometros kmRecorridos;
        private Tiempo tiempoDemorado;
        

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
            this.kmRecorridos = 0;
            this.tiempoDemorado = 0;
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
             retornarString();
         }

        public string retornarString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("El fabricante es: " + this.fabricante + " Kilometros: " + (int)this.kmRecorridos + "km en: " + (int)this.tiempoDemorado + " minutos");

            return sb.ToString();
        }

         public void VolverACero()
         {
             this.kmRecorridos = 0;
             this.tiempoDemorado = 0;
         }
        //Deprecated por sobrecarga de metodos
         public void AgregarKm(int kilometros, int tiempo)
         {
             this.kmRecorridos += kilometros;
             this.tiempoDemorado = tiempo;
         }

         public void AgregarTiempo(int tiempo,int km)
         {
             this.kmRecorridos = km;
             this.tiempoDemorado += tiempo;
         }

         public Kilometros KmRecorrido()
         {
             return this.kmRecorridos;
         }

         public Tiempo TiempoDemora()
         {
             return this.tiempoDemorado;
         }

         public EFabricante Fabricante()
         {
             return this.fabricante;
         }

         public void Agregar(Tiempo tiempo, int km)
         {
             this.tiempoDemorado += tiempo;
             this.kmRecorridos = km;
         }

         public void Agregar(Kilometros kilometros, int tiempo)
         {
             this.kmRecorridos += kilometros;
             this.tiempoDemorado = tiempo;
         }
    }
}

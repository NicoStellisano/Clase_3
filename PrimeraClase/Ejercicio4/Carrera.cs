using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    public class Carrera
    {
        public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
        private static Random rnd;

        public void PorTiempo(int minutos)
        {
            for (int i = 0; i < minutos; i++)
            {
                this.auto1.AgregarKm(rnd.Next(10, 100));
                this.auto2.AgregarKm(rnd.Next(10, 100));
                this.auto3.AgregarKm(rnd.Next(10, 100));
                this.auto4.AgregarKm(rnd.Next(10, 100));
                this.auto5.AgregarKm(rnd.Next(10, 100));
                this.auto6.AgregarKm(rnd.Next(10, 100));
            }
        }

        public Carrera()
        {
            this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
            rnd = new Random();

        }

        public void MostrarCarrera()
        {
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
        }
    }
}

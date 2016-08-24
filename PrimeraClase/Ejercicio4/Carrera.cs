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
        private int auxMay, max, auxMen, min = 1000000;
        private EFabricante auxFabricanteMay, auxFabricanteMen;

        public void PorTiempo(int minutos)
        {
            for (int i = 0; i < minutos; i++)
            {
                this.auto1.AgregarKm(rnd.Next(10, 100),minutos);
                this.auto2.AgregarKm(rnd.Next(10, 100), minutos);
                this.auto3.AgregarKm(rnd.Next(10, 100), minutos);
                this.auto4.AgregarKm(rnd.Next(10, 100), minutos);
                this.auto5.AgregarKm(rnd.Next(10, 100), minutos);
                this.auto6.AgregarKm(rnd.Next(10, 100), minutos);

            }
        }

        public void PorKilometros(int km)
        {
            for (int i = 0; i < km; i++)
            {
                this.auto1.AgregarTiempo(rnd.Next(10, 100),km);
                this.auto2.AgregarTiempo(rnd.Next(10, 100),km);
                this.auto3.AgregarTiempo(rnd.Next(10, 100),km);
                this.auto4.AgregarTiempo(rnd.Next(10, 100),km);
                this.auto5.AgregarTiempo(rnd.Next(10, 100),km);
                this.auto6.AgregarTiempo(rnd.Next(10, 100),km);

            }
        }

        public void CorrerCarrera(Tiempo tiempo)
        {
            this.PorTiempo(tiempo.cantidad);
            this.MostrarCarrera();
        }

        public void CorrerCarrera(Kilometros kilometros)
        {
            this.PorKilometros(kilometros.cantidad);
            
            this.MostrarCarreraTiempo();
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

            auxMay = this.auto1.KmRecorrido();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto1.Fabricante();
            }
            auxMay = this.auto2.KmRecorrido();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto2.Fabricante();
            }
            auxMay = this.auto3.KmRecorrido();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto3.Fabricante();
            }
            auxMay = this.auto4.KmRecorrido();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto4.Fabricante();
            }
            auxMay = this.auto5.KmRecorrido();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto5.Fabricante();
            }
            auxMay = this.auto6.KmRecorrido();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto6.Fabricante();
            }

            auxMen = this.auto1.KmRecorrido();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto1.Fabricante();
            }
            auxMen = this.auto2.KmRecorrido();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto2.Fabricante();
            }
            auxMen = this.auto3.KmRecorrido();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto3.Fabricante();
            }
            auxMen = this.auto4.KmRecorrido();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto4.Fabricante();
            }
            auxMen = this.auto5.KmRecorrido();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto5.Fabricante();
            }
            auxMen = this.auto6.KmRecorrido();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto6.Fabricante();
            }
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El mayor recorrido(Ganador): " + max + "km" + " Hecho por: " + auxFabricanteMay);
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El menor recorrido: " + min + "km" + " Hecho por: " + auxFabricanteMen);

        }



        public void MostrarCarreraTiempo()
        {
            
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();

            auxMay = this.auto1.TiempoDemora();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto1.Fabricante();
            }
            auxMay = this.auto2.TiempoDemora();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto2.Fabricante();
            }
            auxMay = this.auto3.TiempoDemora();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto3.Fabricante();
            }
            auxMay = this.auto4.TiempoDemora();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto4.Fabricante();
            }
            auxMay = this.auto5.TiempoDemora();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto5.Fabricante();
            }
            auxMay = this.auto6.TiempoDemora();
            if (auxMay > max)
            {
                max = auxMay;
                auxFabricanteMay = this.auto6.Fabricante();
            }

            auxMen = this.auto1.TiempoDemora();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto1.Fabricante();
            }
            auxMen = this.auto2.TiempoDemora();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto2.Fabricante();
            }
            auxMen = this.auto3.TiempoDemora();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto3.Fabricante();
            }
            auxMen = this.auto4.TiempoDemora();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto4.Fabricante();
            }
            auxMen = this.auto5.TiempoDemora();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto5.Fabricante();
            }
            auxMen = this.auto6.TiempoDemora();
            if (auxMen < min)
            {
                min = auxMen;
                auxFabricanteMen = this.auto6.Fabricante();
            }
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El mayor tiempo: " + max + " minutos" + " Hecho por: " + auxFabricanteMay );
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El menor tiempo(Ganador): " + min + " minutos" + " Hecho por: " + auxFabricanteMen);
            
        }
    }
}


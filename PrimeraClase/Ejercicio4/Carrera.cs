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
        private static Random _rnd;
        private int _auxMay, _max, _auxMen, _min = 1000000;
        private EFabricante _auxFabricanteMay, _auxFabricanteMen;
        private Kilometros _km;
        private Tiempo _tiempo;

        public void PorTiempo(Tiempo minutos)
        {
            for (int i = 0; i < (int)minutos; i++)
            {

                this.auto1.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto2.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto3.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto4.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto5.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto6.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
            }
        }

        public void PorKilometros(Kilometros km)
        {
            for (int i = 0; i < (int)km; i++)
            {
               
                this.auto1.Agregar((Tiempo)_rnd.Next(10, 100),(int)km);
                this.auto2.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto3.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto4.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto5.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto6.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);

            }
        }

        public void CorrerCarrera(Tiempo tiempo)
        {
            this.PorTiempo(tiempo);
            this.MostrarCarrera();
        }

        public void CorrerCarrera(Kilometros kilometros)
        {
            this.PorKilometros(kilometros);
            
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
            _rnd = new Random();

        }

        public void MostrarCarrera()
        {
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");

            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();

            _auxMay = (int)this.auto1.KmRecorrido();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto1.Fabricante();
            }
            _auxMay = (int)this.auto2.KmRecorrido();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto2.Fabricante();
            }
            _auxMay = (int)this.auto3.KmRecorrido();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto3.Fabricante();
            }
            _auxMay = (int)this.auto4.KmRecorrido();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto4.Fabricante();
            }
            _auxMay = (int)this.auto5.KmRecorrido();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto5.Fabricante();
            }
            _auxMay = (int)this.auto6.KmRecorrido();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto6.Fabricante();
            }

            _auxMen = (int)this.auto1.KmRecorrido();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto1.Fabricante();
            }
            _auxMen = (int)this.auto2.KmRecorrido();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto2.Fabricante();
            }
            _auxMen = (int)this.auto3.KmRecorrido();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto3.Fabricante();
            }
            _auxMen = (int)this.auto4.KmRecorrido();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto4.Fabricante();
            }
            _auxMen = (int)this.auto5.KmRecorrido();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto5.Fabricante();
            }
            _auxMen = (int)this.auto6.KmRecorrido();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto6.Fabricante();
            }
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El mayor recorrido(Ganador): " + _max + "km" + " Hecho por: " + _auxFabricanteMay);
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El menor recorrido: " + _min + "km" + " Hecho por: " + _auxFabricanteMen);

        }



        public void MostrarCarreraTiempo()
        {

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("*******************************************************************************");
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();

            _auxMay = (int)this.auto1.TiempoDemora();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto1.Fabricante();
            }
            _auxMay = (int)this.auto2.TiempoDemora();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto2.Fabricante();
            }
            _auxMay = (int)this.auto3.TiempoDemora();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto3.Fabricante();
            }
            _auxMay = (int)this.auto4.TiempoDemora();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto4.Fabricante();
            }
            _auxMay = (int)this.auto5.TiempoDemora();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto5.Fabricante();
            }
            _auxMay = (int)this.auto6.TiempoDemora();
            if (_auxMay > _max)
            {
                _max = _auxMay;
                _auxFabricanteMay = this.auto6.Fabricante();
            }

            _auxMen = (int)this.auto1.TiempoDemora();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto1.Fabricante();
            }
            _auxMen = (int)this.auto2.TiempoDemora();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto2.Fabricante();
            }
            _auxMen = (int)this.auto3.TiempoDemora();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto3.Fabricante();
            }
            _auxMen = (int)this.auto4.TiempoDemora();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto4.Fabricante();
            }
            _auxMen = (int)this.auto5.TiempoDemora();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto5.Fabricante();
            }
            _auxMen = (int)this.auto6.TiempoDemora();
            if (_auxMen < _min)
            {
                _min = _auxMen;
                _auxFabricanteMen = this.auto6.Fabricante();
            }
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El mayor tiempo: " + _max + " minutos" + " Hecho por: " + _auxFabricanteMay );
            Console.WriteLine("*******************************************************************************");
            Console.WriteLine("El menor tiempo(Ganador): " + _min + " minutos" + " Hecho por: " + _auxFabricanteMen);
            
        }
    }
}


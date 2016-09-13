using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio4
{
    #region Clase
    public class Carrera
    {
        #region Atributos
        #region Depreticated

        //Depreticated por Colección
        /*public Auto auto1;
        public Auto auto2;
        public Auto auto3;
        public Auto auto4;
        public Auto auto5;
        public Auto auto6;
         */
        #endregion
        public List<Auto> listaDeAutos;
        private static Random _rnd;
        private int _auxMay, _max, _auxMen, _min = 100000;
        private EFabricante _auxFabricanteMay, _auxFabricanteMen;
        private Kilometros _km;
        private Tiempo _tiempo;
        private string _nombre;
        private string _fecha;
        private string _lugar;
    
        
        

        #endregion

        #region CorrerCarrera
        public void PorTiempo(Tiempo minutos)
        {
            for (int i = 0; i < (int)minutos; i++)
            {
                foreach (Auto item in this.listaDeAutos)
	            {
                    item.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
		 
	            }

                /*this.auto1.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto2.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto3.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto4.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto5.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                this.auto6.Agregar((Kilometros)_rnd.Next(10, 100), (int)minutos);
                 */ 
            }
        }

        public void PorKilometros(Kilometros km)
        {
            for (int i = 0; i < (int)km; i++)
            {
                foreach (Auto item in this.listaDeAutos)
	            {
		             item.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);

	            }

               
                /*this.auto1.Agregar((Tiempo)_rnd.Next(10, 100),(int)km);
                this.auto2.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto3.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto4.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto5.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                this.auto6.Agregar((Tiempo)_rnd.Next(10, 100), (int)km);
                 */ 

            }
        }

        public string CorrerCarrera(Tiempo tiempo)
        {
            StringBuilder sb = new StringBuilder();

            this.PorTiempo(tiempo);
            sb.AppendLine();
            sb.AppendLine("Carrera por " + (int)tiempo + " Minutos: ");
            sb.AppendLine();
            sb.AppendLine(this.MostrarCarrera(tiempo));
            return sb.ToString();

           
        }

        public string CorrerCarrera(Kilometros kilometros)
        {
          StringBuilder sb = new StringBuilder();

            this.PorKilometros(kilometros);
        
            sb.AppendLine();
            sb.AppendLine("Carrera por " + (int)kilometros + " Kilometros: ");
            sb.AppendLine();

            sb.AppendLine(this.MostrarCarrera(kilometros));
            return sb.ToString();

           

        }
        #endregion

        #region Constructores

        public Carrera()
        {
            //Depreticated por Colecciones
           /* this.auto1 = new Auto();
            this.auto2 = new Auto();
            this.auto3 = new Auto();
            this.auto4 = new Auto();
            this.auto5 = new Auto();
            this.auto6 = new Auto();
            */

            this.listaDeAutos = new List<Auto>();
            _rnd = new Random();

        }

        public Carrera(string nombre, string fecha, string lugar):this()
        {
            this._fecha = fecha;
            this._nombre = nombre;
            this._lugar = lugar;
        }
        #endregion

        
        #region Mostrar

        public string MostrarCarrera(Tiempo tiempo)
        {
            StringBuilder sb = new StringBuilder();
     

            foreach (Auto car in this.listaDeAutos)
            {
               sb.AppendLine(car.retornarString());
            }
            #region Depreticated

            /*this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto(); */
            #endregion

            for (int i = 0; i < this.listaDeAutos.Count; i++)
            {
                if (i == 0)
                {
                   _max = (int)this.listaDeAutos[i].KmRecorrido();
                   _min = (int)this.listaDeAutos[i].KmRecorrido();
                   _auxFabricanteMay = this.listaDeAutos[i].Fabricante();
                   _auxFabricanteMen = this.listaDeAutos[i].Fabricante();
                   continue;
                }

                _auxMay = (int)this.listaDeAutos[i].KmRecorrido();

                if (_auxMay > _max)
                {
                    _max = _auxMay;
                    _auxFabricanteMay = this.listaDeAutos[i].Fabricante();
                }

                _auxMen = (int)this.listaDeAutos[i].KmRecorrido();
                if (_auxMen < _min)
                {
                    _min = _auxMen;
                    _auxFabricanteMen = this.listaDeAutos[i].Fabricante();
                }
            }
            #region Depreticated
            /*_auxMay = (int)this.auto1.KmRecorrido();
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
             * */
            #endregion
            sb.AppendLine("El mayor recorrido(Ganador): " + _max + "km" + " Por: " + _auxFabricanteMay);
            sb.AppendLine("El menor recorrido: " + _min + "km" + " Por: " + _auxFabricanteMen);

            foreach (Auto item in this.listaDeAutos)
            {
                item.VolverACero();
            }
            return sb.ToString();
        }



        public string MostrarCarrera(Kilometros km)
        {
            StringBuilder sb = new StringBuilder();
     
            #region Depreticated
/*
            this.auto1.MostrarAuto();
            this.auto2.MostrarAuto();
            this.auto3.MostrarAuto();
            this.auto4.MostrarAuto();
            this.auto5.MostrarAuto();
            this.auto6.MostrarAuto();
 */
#endregion
            foreach (Auto car in this.listaDeAutos)
            {
                sb.AppendLine(car.retornarString());
            }

            for (int i = 0; i < this.listaDeAutos.Count; i++)
            {
                if (i == 0)
                {
                    _max = (int)this.listaDeAutos[i].TiempoDemora();
                    _min = (int)this.listaDeAutos[i].TiempoDemora();
                    _auxFabricanteMay = this.listaDeAutos[i].Fabricante();
                    _auxFabricanteMen = this.listaDeAutos[i].Fabricante();
                    continue;
                }

                _auxMay = (int)this.listaDeAutos[i].TiempoDemora();

                if (_auxMay > _max)
                {
                    _max = _auxMay;
                    _auxFabricanteMay = this.listaDeAutos[i].Fabricante();
                }

                _auxMen = (int)this.listaDeAutos[i].TiempoDemora();
                if (_auxMen < _min)
                {
                    _min = _auxMen;
                    _auxFabricanteMen = this.listaDeAutos[i].Fabricante();
                }
            }
            #region Depreticated
            /*
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
 */
            #endregion
            sb.AppendLine("El mayor tiempo: " + _max + " minutos" + " Por: " + _auxFabricanteMay );
            sb.AppendLine("El menor tiempo(Ganador): " + _min + " minutos" + " Por: " + _auxFabricanteMen);

            foreach (Auto item in this.listaDeAutos)
            {
                item.VolverACero();
            }


            return sb.ToString();
        }

        
        #endregion

        #region Colecciones

        private bool agregarAuto(Auto unAuto)
        {
            this.listaDeAutos.Add(unAuto);
            return true;
        }

        public static Carrera operator +(Carrera race, Auto unAuto)
        {
             race.agregarAuto(unAuto);
             return race;
        }

        #endregion

    }
    #endregion
}


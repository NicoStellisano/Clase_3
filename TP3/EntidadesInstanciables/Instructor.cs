using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public class Instructor:PersonaGimnasio
    {
        private Queue<Gimnasio.EClases> _clasesDelDia;        
        private static Random _random;

        /// <summary>
        /// Genera 2 clases random
        /// </summary>
        private void _randomClases()
        {
            int aux=0;
            aux = _random.Next(1, 4);
            this._clasesDelDia.Enqueue((Gimnasio.EClases)_random.Next(1,4));
            this._clasesDelDia.Enqueue((Gimnasio.EClases)aux);

        }
        /// <summary>
        /// Inicializa el random
        /// </summary>
        static Instructor ()
	    {
           _random = new Random();
	    }

        /// <summary>
        /// Constructor para serializar
        /// </summary>
        public Instructor(){}
       
        /// <summary>
        /// Nueva instancia con los datos de PersonaGimnasio, y clases del día
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Instructor(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(id,nombre,apellido,dni,nacionalidad)
        {
            this._clasesDelDia = new Queue<Gimnasio.EClases>(2);
            this._randomClases();

        }

        /// <summary>
        /// Devuelve los datos de PersonaGimnasio y los propios
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine(base.MostrarDatos());
            sb.AppendLine(this.ParticiparEnClase());

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve true sí el instructor no da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Instructor i, Gimnasio.EClases clase)
        {
            return !(i == clase);
        }

        /// <summary>
        /// Devuelve true sí el instructor da esa clase
        /// </summary>
        /// <param name="i"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Instructor i, Gimnasio.EClases clase)
        {
            foreach (Gimnasio.EClases item in i._clasesDelDia)
            {
                if (item == clase)
                {
                    return true;
                }
            }
            return false;
        }

        /// <summary>
        /// Devuelve un string con las clases del día del instructor
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            StringBuilder sb = new StringBuilder();

            sb.AppendLine("CLASES DEL DIA: ");
            foreach (Gimnasio.EClases item in this._clasesDelDia)
            {
                sb.AppendLine(item.ToString());
            }
            return sb.ToString();
        }

        /// <summary>
        /// Devuelve string ejecutando MostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return this.MostrarDatos();
        }


    }
}

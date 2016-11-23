using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Archivos;
using Excepciones;

namespace EntidadesInstanciables
{
    public class Jornada
    {
        private List<Alumno> _alumnos;

        public List<Alumno> Alumnos
        {
            get { return _alumnos; }
           
        }
        private Gimnasio.EClases _clase;

        public Gimnasio.EClases Clase
        {
            get { return _clase; }
            set { _clase = value; }
        }
        private Instructor _instructor;

        public Instructor Instructor
        {
            get { return _instructor; }
            set { _instructor = value; }
        }

      
        /// <summary>
        /// Guarda en .txr
        /// </summary>
        /// <param name="jornada"></param>
        /// <returns></returns>
        public static bool Guardar(Jornada jornada)
        {
            Texto text = new Texto();

            return text.guardar("Jornada.txt", jornada.ToString());
        }

        /// <summary>
        /// Lee .txt
        /// </summary>
        /// <param name="datos"></param>
        /// <returns></returns>
        public static bool Leer(out string datos)
        {
            Texto text = new Texto();
            datos = null;
            return text.leer("Jornada.txt", out datos);
        }

        /// <summary>
        /// Constructor para serializar e inicializar la lista de alumnos
        /// </summary>
        private Jornada()
        {
            this._alumnos = new List<Alumno>();
        }
        /// <summary>
        /// Constructor que pide las clases y el instructor
        /// </summary>
        /// <param name="clase"></param>
        /// <param name="instructor"></param>
        public Jornada(Gimnasio.EClases clase, Instructor instructor)
            : this()
        {
            this._clase = clase;
            this._instructor = instructor;
        }

        /// <summary>
        /// Devuelve true sí el alumno no está en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Jornada j, Alumno a)
        {
            return !(j == a);
        }

        /// <summary>
        /// Agrega un alumno a la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Jornada operator +(Jornada j, Alumno a)
        {
            if (j==a)
            {
                j._alumnos.Add(a);
            }

            return j;
        }

        /// <summary>
        /// Devuelve true sí el alumno está en la jornada
        /// </summary>
        /// <param name="j"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Jornada j, Alumno a)
        {
            if (a == j._clase)
            {
                return true;
            }
            else return false;
        }

        /// <summary>
        /// Devuelve string con los datos de la jornada
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append("CLASE DE " + this._clase + " ");
            sb.AppendLine(this._instructor.ToString());
            if (this._alumnos.Count == 0)
            {
                sb.AppendLine("NO HAY ALUMNOS");
            }
            else
            {
                sb.AppendLine("ALUMNOS: ");
                foreach (Alumno item in this._alumnos)
                {
                    sb.AppendLine(item.ToString());
                }
            }
            return sb.ToString();
        }

    }
}

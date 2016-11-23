using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using Excepciones;
using System.Xml;
using System.Xml.Serialization;
using Archivos;

namespace EntidadesInstanciables
{
   
    public class Gimnasio
    {
        public List<Alumno> _alumnos;

        public List<Alumno> Alumnos
        {
            get { return this._alumnos; }
        }
        public List<Instructor> _instructores;

        public List<Instructor> Instructores
        {
            get { return this._instructores; }
        }
        public List<Jornada> _jornada;

        public List<Jornada> Jornada
        {
            get { return this._jornada; }
        }

        /// <summary>
        /// Constructor para Serializar e Inicializar las listas
        /// </summary>
        public Gimnasio()
        {
            this._instructores = new List<Instructor>();
            this._alumnos = new List<Alumno>();      
            this._jornada = new List<Jornada>();
        }
        public enum EClases
        {
            CrossFit = 1, Natacion = 2, Pilates = 3, Yoga = 4
        }
       
      public Jornada this[int i]
        {
            get
            {
                if (i >= 0 && i < this._jornada.Count)
                {
                    return this._jornada[i];
                }
                else
                {
                    return null;
                }
            }
        }

        /// <summary>
        /// Guarda Gimnasio en XML
        /// </summary>
        /// <param name="gim"></param>
        /// <returns></returns>
        public static bool Guardar(Gimnasio gim)
        {
           Xml<Gimnasio> xml = new Xml<Gimnasio>();
            xml.guardar("Gimnasio.xml", gim);
            return true;
        }

        /// <summary>
        /// Lee un Gimnasio de XML
        /// </summary>
        /// <returns></returns>
        public static Gimnasio Leer()
        {
            Archivos.Xml<Gimnasio> xml = new Archivos.Xml<Gimnasio>();
            Gimnasio aux;
            if (xml.leer("Gimnasio.xml", out aux))
                return aux;

            return null;
        }

        /// <summary>
        /// Devuelve en string los datos del gimnasio pasado por parámetro
        /// </summary>
        /// <param name="gim"></param>
        /// <returns></returns>
        protected static string MostrarDatos(Gimnasio gim)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("JORNADA:");

            foreach (Jornada item in gim._jornada)
            {
                sb.AppendLine(item.ToString());
            }

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve verdadero sí el alumno no pertence al gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator !=(Gimnasio g, Alumno a)
        {
            return !(g == a);
        }

        /// <summary>
        /// Retorna el primer instructor que no pueda dar la clase
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Instructor operator !=(Gimnasio g, Gimnasio.EClases clase)
        {
            foreach (Instructor item in g._instructores)
            {
                if (item != clase)
                    return item;
            }

            return null;
        }

        /// <summary>
        /// Retorna true sí no está dando clases
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator !=(Gimnasio g, Instructor i)
        {
 
            return !(g == i);
        
        }
        /// <summary>
        /// Agrega un alumno al gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static Gimnasio operator +(Gimnasio g, Alumno a)
        {
            if (g == a)
                throw new AlumnoRepetidoException();

            g._alumnos.Add(a);
            return g;
        }

        /// <summary>
        /// Agrega nueva jornada con clases
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Gimnasio operator +(Gimnasio g, EClases clase)
        {
            Jornada nuevaJornada = new Jornada(clase, (g == clase));
            foreach (Alumno item in g._alumnos)
            {
                if (item == clase)
                {
                    nuevaJornada = nuevaJornada + item;
                }
            }
            g._jornada.Add(nuevaJornada);
            return g;
        }

        /// <summary>
        /// Agrega un instructor al gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static Gimnasio operator +(Gimnasio g, Instructor i)
        {
            bool estado = true;
            foreach (Instructor item in g._instructores)
            {
                if (item == i)
                {
                    estado = false;
                    break;
                }
            }
            if (estado)
            {
                g._instructores.Add(i);
            }
            return g;
        }

        /// <summary>
        /// Devuelve true sí existe el alumno en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="a"></param>
        /// <returns></returns>
        public static bool operator ==(Gimnasio g, Alumno a)
        {
            foreach (Alumno item in g._alumnos)
            {
                if (item.Equals(a))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Devuelve el primer instructor capaz de dar la clase 
        /// </summary>
        /// <param name="g"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static Instructor operator ==(Gimnasio g, EClases clase)
        {
            foreach (Instructor item in g._instructores)
            {
                if (item == clase)
                    return item;
            }

            throw new SinInstructorException();
        }

        /// <summary>
        /// Devuelve true sí el instructor está en el gimnasio
        /// </summary>
        /// <param name="g"></param>
        /// <param name="i"></param>
        /// <returns></returns>
        public static bool operator ==(Gimnasio g, Instructor i)
        {
            foreach (Instructor item in g._instructores)
            {
                if (item.Equals(i))
                    return true;
            }

            return false;
        }

        /// <summary>
        /// Devuelve string ejecutando MostrarDatos
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            return Gimnasio.MostrarDatos(this);
        }
    }
}

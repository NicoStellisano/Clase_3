using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;

namespace EntidadesInstanciables
{
    public sealed class Alumno:PersonaGimnasio
    {


        private Gimnasio.EClases _claseQueToma;
        private EEstadoCuenta _estadoCuenta;

        /// <summary>
        /// Constructor para Serializar
        /// </summary>
        public Alumno()
        {

        }

        /// <summary>
        /// Instancia de alumno con datos de PersonaGimnasio y clases que toma
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma)
            : base(id, nombre, apellido, dni, nacionalidad) 
        {
            this._claseQueToma = claseQueToma;
        }

        /// <summary>
        /// Instancia de alumno con datos de PersonaGimnasio,clases y estado de cuenta
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        /// <param name="claseQueToma"></param>
        /// <param name="estadoCuenta"></param>
        public Alumno(int id, string nombre, string apellido, string dni, ENacionalidad nacionalidad, Gimnasio.EClases claseQueToma, EEstadoCuenta estadoCuenta)
            : this(id, nombre, apellido, dni, nacionalidad, claseQueToma)
        {
            this._estadoCuenta = estadoCuenta;
        }

        /// <summary>
        /// Retorna string con datos de PersonaGimnasio y datos propios de la clase
        /// </summary>
        /// <returns></returns>
        protected override string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.Append(base.MostrarDatos());
            sb.AppendLine("Clase que toma: " + this._claseQueToma.ToString());
            sb.AppendLine("Estado de Cuenta: " + this._estadoCuenta.ToString());

            return sb.ToString();
        }

        /// <summary>
        /// Devuelve verdadero, sí el alumno no toma la clase
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator !=(Alumno a, Gimnasio.EClases clase)
        {
            if (a._claseQueToma != clase)
                return true;
            return false;
        }

        /// <summary>
        /// Devuelve verdadero sí el alumno, toma la clase y su estado de cuenta no es Deudor
        /// </summary>
        /// <param name="a"></param>
        /// <param name="clase"></param>
        /// <returns></returns>
        public static bool operator ==(Alumno a, Gimnasio.EClases clase)
        {
            if (a._claseQueToma == clase && a._estadoCuenta!= EEstadoCuenta.Deudor)
            {
                return true;
            }
            else
                return false;
        }

        /// <summary>
        /// Devuelve un string con las clases que toma el alumno
        /// </summary>
        /// <returns></returns>
        protected override string ParticiparEnClase()
        {
            return ("TOMA CLASE DE " + this._claseQueToma.ToString());

        }

        public enum EEstadoCuenta
        {
            AlDia, MesPrueba, Deudor
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

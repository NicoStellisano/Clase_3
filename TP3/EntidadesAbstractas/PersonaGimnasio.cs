using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EntidadesAbstractas
{
    public abstract class PersonaGimnasio:Persona
    {
        private int _identificador;
        /// <summary>
        /// Retorna verdadero, sí los objetos tienen el mismo tipo(PersonaGimnasio)
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if (obj.GetType() == this.GetType() && this==(PersonaGimnasio)obj)
            {
                return true;
            }
            else
            return false;
        }

        /// <summary>
        /// Devuelve string con ID y datos base de Persona
        /// </summary>
        /// <returns></returns>
        protected virtual string MostrarDatos()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine(base.ToString());
            sb.AppendLine("CARNET NUMERO: " + this._identificador);
            return sb.ToString();

        }

        protected abstract string ParticiparEnClase();
       
        /// <summary>
        /// Devuelve verdadero sí no son la misma persona
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator !=(PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            return !(pg1 == pg2);
        }

        /// <summary>
        /// Devuelve verdadero sí son la misma persona
        /// </summary>
        /// <param name="pg1"></param>
        /// <param name="pg2"></param>
        /// <returns></returns>
        public static bool operator ==(PersonaGimnasio pg1, PersonaGimnasio pg2)
        {
            if (pg1.GetType() == pg2.GetType() && (pg1.DNI == pg2.DNI || pg1._identificador == pg2._identificador))
            {
                return true;
            }
            else
                return false;
        }
        /// <summary>
        /// Constructor para Serializar
        /// </summary>
        public PersonaGimnasio()
        {

        }

        /// <summary>
        /// Nueva instancia con datos de Persona e ID
        /// </summary>
        /// <param name="id"></param>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public PersonaGimnasio(int id,string nombre,string apellido,string dni,ENacionalidad nacionalidad):base(nombre,apellido,dni,nacionalidad)
        {
            this._identificador = id;
        }

    }
}

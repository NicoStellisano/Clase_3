using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Excepciones;

namespace EntidadesAbstractas
{
    public abstract class Persona
    {
        private string _apellido;

        public string Apellido
        {
            get { return this._apellido; }
            set { this._apellido = value; }
        }
        
        private int _dni;
        public int DNI
        {
            get
            {
                return this._dni;
            }
            set
            {
                try
                {
                    switch (this.Nacionalidad)
                    {
                        case ENacionalidad.Argentino:
                            this._dni = ValidarDni(ENacionalidad.Argentino, value);
                            break;
                        case ENacionalidad.Extranjero:
                            this._dni = ValidarDni(ENacionalidad.Extranjero, value);
                            break;
                        default:
                            break;
                    }
                }
                catch (DniInvalidoException)
                {

                    throw new NacionalidadInvalidaException("La nacionalidad no se coincide con el Número de DNI");
                }
            }
        }

        private ENacionalidad _nacionalidad;
        public ENacionalidad Nacionalidad
        {
            get { return this._nacionalidad; }
            set {this._nacionalidad= value; }
        }

        private string _nombre;
        public string Nombre
        {
            get { return this._nombre; }
            set { this._nombre = value; }
        }

        public string StringToDNI
        {
            set
            {
                try
                {
                    switch (this.Nacionalidad)
                    {
                        case ENacionalidad.Argentino:
                            this._dni = ValidarDni(ENacionalidad.Argentino, value);
                            break;
                        case ENacionalidad.Extranjero:
                            this._dni = ValidarDni(ENacionalidad.Extranjero, value);
                            break;
                        default:
                            break;
                    }
                }
                catch (DniInvalidoException)
                {

                    throw new NacionalidadInvalidaException("La nacionalidad no se condice con el número de DNI");
                }
            }
        }

        public enum ENacionalidad
        {
            Argentino,Extranjero
        }

        /// <summary>
        /// Constructor para Serializar
        /// </summary>
        public Persona()
        {

        }
        /// <summary>
        /// Nueva persona con nombre,apellido,nacionalidad
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre,string apellido, ENacionalidad nacionalidad)
        {
            this._apellido = apellido;
            this.Nombre = nombre;
            this._nacionalidad = nacionalidad;
        }

        /// <summary>
        /// Nueva persona con nombre,apellido,nacionalidad,dni entero
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido,int dni, ENacionalidad nacionalidad):this(nombre,apellido,nacionalidad)
        {
            this.DNI = dni;
        }

        /// <summary>
        /// Nueva persona con nombre,apellido,nacionalidad, dni string
        /// </summary>
        /// <param name="nombre"></param>
        /// <param name="apellido"></param>
        /// <param name="dni"></param>
        /// <param name="nacionalidad"></param>
        public Persona(string nombre, string apellido, string dni, ENacionalidad nacionalidad)
            : this(nombre, apellido, nacionalidad)

        {
            this.StringToDNI = dni;

        }

        /// <summary>
        /// Devuelve un string con todos los datos de un objeto Persona
        /// </summary>
        /// <returns></returns>
        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("POR NOMBRE COMPLETO: " + this.Apellido + "," + this.Nombre);
            sb.AppendLine("Nacionalidad: " + this.Nacionalidad);
            sb.AppendLine("DNI: " + this._dni);
            return sb.ToString();
            
        }

        /// <summary>
        /// Valida DNI entero
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, int dato)
        {
            if (Nacionalidad == ENacionalidad.Argentino && dato >= 1 && dato <= 89999999 || Nacionalidad == ENacionalidad.Extranjero && dato >= 90000000)
                return dato;
            throw new DniInvalidoException();
        }

        /// <summary>
        /// Valida DNI string
        /// </summary>
        /// <param name="nacionalidad"></param>
        /// <param name="dato"></param>
        /// <returns></returns>
        private int ValidarDni(ENacionalidad nacionalidad, string dato)
        {
           return ValidarDni(Nacionalidad, int.Parse(dato));

        }
        
        /// <summary>
        /// Valida Nombre y Apellido
        /// </summary>
        /// <param name="dato"></param>
        /// <returns></returns>
        private string ValidarNombreApellido(string dato)
        {
            if (string.IsNullOrEmpty(dato))
            {
                return null;
            }

            for (int i = 0; i < dato.Length; i++)
            {
                if (!char.IsLetter(dato[i]))
                {
                    return null;
                }
            }
            return dato;
        }
    }
}

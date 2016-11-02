using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;


namespace Serializacion
{
[XmlInclude(typeof(Alumno))]
    public class Persona:ISerializable2016
    {
        public string nombre;
        public Persona()
        {

        }
        public Persona(string nombre)
        {
            this.nombre = nombre;
        }

        public bool Serializar()
        {
            return Serializador.SerializarPersona(this);
        }


        public bool Deserializar()
        {
            bool flag = false;
            try
            {
                Persona aux = Serializador.DeserializarPersona();
                flag = true;
                this.nombre = aux.nombre;
            }
            catch (Exception)
            {
                flag = false;
                throw;
            }
            return flag;
        }
    }
}

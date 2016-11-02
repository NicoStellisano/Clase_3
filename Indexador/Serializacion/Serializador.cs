using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml;
using System.Xml.Serialization;

namespace Serializacion
{
    public static class Serializador
    {
        public static bool SerializarPersona(Persona per)
        {
            bool flag = false;
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    serializador.Serialize(escritor, per);
                    flag = true;
                }
            }
            catch (Exception)
            {
                flag = false;
               // throw;
            }
            return flag;
        }

        public static Persona DeserializarPersona()
        {
           // bool flag = false;
            Persona person = null;

            try
            {
                using (XmlTextReader lector = new XmlTextReader("Persona.xml"))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    person = (Persona)serializador.Deserialize(lector);
                   // flag = true;
                }
            }
            catch (Exception)
            {
              //  flag = false;
                //throw;
            }
            return person;
        }


        public static void SerializarListaPersonas(List<Persona> listadoPer)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("ListadoPersonas.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(List<Persona>));
                    serializador.Serialize(escritor, listadoPer);
                }
            }
            catch (Exception)
            {

                // throw;
            }

        }

        public static void SerializarAula(Aula aula)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Aula.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Aula));
                    serializador.Serialize(escritor, aula);
                }
            }
            catch (Exception)
            {

                throw;
            }

        }

        public static bool SerializarGenerico(ISerializable2016 Iseria)
        {
            return Iseria.Serializar();
        }
    }
}

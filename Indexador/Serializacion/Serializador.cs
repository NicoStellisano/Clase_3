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
        public static void SerializarPersona(Persona per)
        {
            try
            {
                using (XmlTextWriter escritor = new XmlTextWriter("Persona.xml", Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(Persona));
                    serializador.Serialize(escritor, per);
                }
            }
            catch (Exception)
            {
                
               // throw;
            }
         
        }
    }
}

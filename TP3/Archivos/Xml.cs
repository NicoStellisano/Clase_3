using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Serialization;
using Excepciones;
namespace Archivos
{
    public class Xml<T>:IArchivo<T>
    {
        /// <summary>
        /// Guarda archivo xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool guardar(string archivo, T datos)
        {
            bool flag = true;
            try
            {

                using (XmlTextWriter escritor = new XmlTextWriter(archivo, Encoding.UTF8))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    serializador.Serialize(escritor, datos);
                }
            }
            catch (Exception e)
            {
                flag = false;
                throw new ArchivosException(e);
            }
            return flag;
        }
        /// <summary>
        /// Lee un archivo xml
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool leer(string archivo, out T datos)
        {
            bool flag = true;
            try
            {
                using (XmlTextReader lector = new XmlTextReader(archivo))
                {
                    XmlSerializer serializador = new XmlSerializer(typeof(T));
                    datos = (T)serializador.Deserialize(lector);
                }
            }
            catch (Exception e)
            {
                flag = false;
                throw new ArchivosException(e);
            }
            return flag;
        }
    }
}

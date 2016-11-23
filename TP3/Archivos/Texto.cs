using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Excepciones;

namespace Archivos
{
    public class Texto: IArchivo<string>
    {
        /// <summary>
        /// Guardar en archivo .txt
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool guardar(string archivo, string datos)
        {
            bool flag = false;

            if (archivo != null && datos != null)
            {
                try
                {
                    using (StreamWriter escritor = new StreamWriter(archivo, true))
                    {
                        escritor.Write(datos);
                        flag = true;
                    }
                }
                catch (Exception e)
                {
                    throw new ArchivosException(e);
                }
            }

            return flag;
        }

        /// <summary>
        /// Leer archivo .txt
        /// </summary>
        /// <param name="archivo"></param>
        /// <param name="datos"></param>
        /// <returns></returns>
        public bool leer(string archivo, out string datos)
        {
            bool flag = false;
            datos = null;

            if (archivo != null)
            {
                try
                {
                    using (StreamReader lector = new StreamReader(archivo))
                    {
                        datos = lector.ReadToEnd();
                        flag = true;
                    }
                }
                catch (Exception exc)
                {
                    throw new ArchivosException(exc);
                }
            }

            return flag;
        }
    }
}

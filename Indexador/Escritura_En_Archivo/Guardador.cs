using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Escritura_En_Archivo
{
    public static class Guardador
    {
        public static bool GuardarPersona(Persona per)
        {
            StreamWriter sw = null;

            bool flag = false;

            try
            {
                sw = new StreamWriter("Personas.txt", true);
                sw.WriteLine(per.ToString());
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
                throw;
            }
            finally
            {
                sw.Close();
            }
            return flag;
        }
    }
}

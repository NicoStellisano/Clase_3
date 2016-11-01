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
                sw.Write(per.ToString());
                flag = true;
            }
            catch (Exception)
            {
                flag = false;
                //throw;
            }
            finally
            {
                sw.Close();
            }
            return flag;
        }

        public static Persona LeerUnaPersona()
        {
            Persona pers = null;
            StreamReader lector = null;
            bool flag = false;
            string aux;
            string[] arraystring;

            try
            {
                lector = new StreamReader("Personas.txt");
                aux = lector.ReadLine();
                arraystring = aux.Split(',');
                pers = new Persona(arraystring[0], arraystring[1]);
                flag = true;

            }
            catch (Exception)
            {
                flag = false;
                //throw;
            }
            finally
            {
                lector.Close();
            }

            return pers;
        }

        public static List<Persona> RetornarListado()
        {
            List<Persona> miLista;
            try
            {
                string renglon;
                string[] aux;
                miLista = new List<Persona>();

                using (StreamReader lector = new StreamReader("Personas.txt"))
                {

                    while ((renglon = lector.ReadLine()) != null)
                    {
                        aux = renglon.Split(',');
                        miLista.Add(new Persona(aux[0], aux[1]));

                    }
                }
            }
            catch (Exception)
            {

                throw;
            }
                return miLista;
            
        }
    }
}

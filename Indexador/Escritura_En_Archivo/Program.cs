using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura_En_Archivo
{
    class Program
    {
        static void Main(string[] args)
        {
           /* StreamWriter escritor = new StreamWriter("Archivo.txt",true);
            escritor.WriteLine("Hello");
            escritor.Close();
            StreamReader lector = new StreamReader("Archivo.txt");
            */ 

            Persona per = new Persona("Robert", "asd123");
            Guardador.GuardarPersona(per);
        }
    }
}

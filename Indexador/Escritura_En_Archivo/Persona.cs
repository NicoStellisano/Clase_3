using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Escritura_En_Archivo
{
   public class Persona
    {
       private string _nombre;
       private string _clave;

       public Persona(string nombre, string clave)
       {
           this._nombre = nombre;
           this._clave = clave;
       }

       public override string ToString()
       {
           StringBuilder sb = new StringBuilder();
           sb.AppendLine("Nombre: " + this._nombre + " Clave: " + this._clave);
           return sb.ToString();   
       }
    }
}

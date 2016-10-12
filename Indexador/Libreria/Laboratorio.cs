using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Libreria
{
   public class Laboratorio
    {
       public string nombre;
       public List<PC> listaPC;

       public Laboratorio(string nombre)
       {
           this.nombre = nombre;
           this.listaPC = new List<PC>();
       }
       public PC this[int indice]//Indexador, trata la clase como array
       {
           get
           {
               if (indice >= 0 && indice < this.listaPC.Count)
               {
                   return this.listaPC[indice];
               }
               else
               {
                   return null;
               }
           }

           set
           {
               if (indice == this.listaPC.Count)
               {
                   this.listaPC.Add(value);
               }
               else
               {
                   if (indice >= 0 && indice < this.listaPC.Count)
                   {
                       this.listaPC[indice] = value;
                       value.numero = indice;


                   }                     
               }
           }
       }
    }
}

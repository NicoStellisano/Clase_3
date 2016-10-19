using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
   public class DepositoDePintura
    {
       public List<Producto> listaProductos;
       public int cantMax;

       public DepositoDePintura(int cantidadM)
       {
           this.listaProductos = new List<Producto>();
           this.cantMax = cantidadM;
       }

       public bool Agregar(Producto prod)
       {
           return this + prod;
       }

       public bool NoHayLugar()
       {
           return this.cantMax == this.listaProductos.Count;
       }

       public bool existeElElemento(Producto prod)
       {
           foreach (Producto item in this.listaProductos)
           {
               if (item==prod)
               {
                   return true;
               }
           }
           return false;
       }
       public static bool operator +(DepositoDePintura dep, Producto prod)
       {
           if (!dep.NoHayLugar() && !dep.existeElElemento(prod))
           {
               dep.listaProductos.Add(prod);
               return true;
           }
           return false;
       }
    }
}
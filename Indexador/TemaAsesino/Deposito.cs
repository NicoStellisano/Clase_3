using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    public class Deposito<T>:IEnumerable<T>
    {
        public List<T> listaAlgo;
       public int cantMax;

       public Deposito(int cantidadM)
       {
           this.listaAlgo = new List<T>();
           this.cantMax = cantidadM;
       }

       public bool Agregar(T algo)
       {
           return this + algo;
       }

       public bool NoHayLugar()
       {
           return this.cantMax == this.listaAlgo.Count;
       }

       public bool existeElElemento(T algo)
       {
           foreach (T item in this.listaAlgo)
           {
               if (item.Equals(algo))
               {
                   return true;
               }
           }
           return false;
       }
       public static bool operator +(Deposito<T> dep, T algo)
       {
           if (!dep.NoHayLugar() && !dep.existeElElemento(algo))
           {
               dep.listaAlgo.Add(algo);
               return true;
           }
           return false;
       }



       public IEnumerator<T> GetEnumerator()
       {
           for (int i = 0; i < this.listaAlgo.Count; i++)
           {
               T item = this.listaAlgo[i];
               yield return item;
           }
       }



      // System.Collections.IEnumerator System.Collections.IEnumerable.GetEnumerator()
      // {
          // throw new NotImplementedException();
      // }
    }
}

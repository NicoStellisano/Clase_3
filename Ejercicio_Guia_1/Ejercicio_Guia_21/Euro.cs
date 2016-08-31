using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Euro
    {
         public double cant;
        public static double aux;

            public Euro(double cantidad)
        {
            this.cant = cantidad;
        }

            public double CAEuro(Dolar Dolar)
            {
               return Dolar.cant * 1.3642;
            }



            public static Euro operator ++(Euro Euro)
            {
                Euro.cant++;
                return Euro;
            }

            public static Euro operator --(Euro Euro)
            {
                Euro.cant--;
                return Euro;
            }

            public static Euro operator +(Dolar Dolar, Euro Euro)
        {
            Euro.cant += (Dolar.cant - 32) * 5 / 9;
            return Euro;
        }

            public static Euro operator -(Dolar Dolar, Euro Euro)
        {
            Euro.cant -= (Dolar.cant - 32) * 5 / 9;
            return Euro;
        }

            public static bool operator ==(Dolar Dolar, Euro Euro)
        {
            if(Euro.cant == (Dolar.cant - 32) * 5 / 9)
            return true;
            return false;
        }

            public static bool operator !=(Dolar Dolar, Euro Euro)
        {
            if (Euro.cant != (Dolar.cant - 32) * 5 / 9)
                return true;
            return false;
        }

            public static Euro operator +(Euro Euro, double valor)
        {
            Euro.cant = Euro.cant+ valor;
            return Euro;
        }


            public static Euro operator -(Euro Euro, double valor)
        {
            Euro.cant = Euro.cant+ valor;
            return Euro;
        }



            public static implicit operator Euro(int valor)
             {
                 return new Euro(valor);
             }


            public static Euro operator +(Euro Euro, Euro Euro2)
             {
                 Euro.cant += Euro2.cant - 32;
                 return Euro;
             }

            public static Euro operator -(Euro Euro, Euro Euro2)
             {
                 Euro.cant -= Euro2.cant;
                 return Euro;
             }

            public static bool operator ==(Euro Euro, Euro Euro2)
             {
                 if (Euro.cant == Euro2.cant)
                     return true;
                 return false;
             }

            public static bool operator !=(Euro Euro, Euro Euro2)
             {
                 if (Euro.cant != (Euro2.cant))
                     return true;
                 return false;
             }


    }
    }


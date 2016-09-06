using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monedas
{
    public class Dolar
    {
         public double cant;
        public static double aux;

            public Dolar(double cantidad)
        {
            this.cant = cantidad;
        }

            public double CADolar(Euro Euro)
            {
                return Euro.cant / 1.3642;
            }

         

            public static Dolar operator ++(Dolar Dolar)
            {
                Dolar.cant++;
                return Dolar;
            }

            public static Dolar operator --(Dolar Dolar)
            {
                Dolar.cant--;
                return Dolar;
            }

        public static Dolar operator +(Euro Euro,Dolar Dolar)
        {
            Dolar.cant += (Euro.cant - 32) * 5 / 9;
            return Dolar;
        }

        public static Dolar operator -(Euro Euro, Dolar Dolar)
        {
            Dolar.cant -= (Euro.cant - 32) * 5 / 9;
            return Dolar;
        }

        public static bool operator ==(Euro Euro, Dolar Dolar)
        {
            if(Dolar.cant == (Euro.cant - 32) * 5 / 9)
            return true;
            return false;
        }

        public static bool operator !=(Euro Euro, Dolar Dolar)
        {
            if (Dolar.cant != (Euro.cant - 32) * 5 / 9)
                return true;
            return false;
        }

        public static Dolar operator +(Dolar Dolar, double valor)
        {
            Dolar.cant = Dolar.cant+ valor;
            return Dolar;
        }


             public static Dolar operator -(Dolar Dolar, double valor)
        {
            Dolar.cant = Dolar.cant+ valor;
            return Dolar;
        }

   

             public static implicit operator Dolar(int valor)
             {
                 return new Dolar(valor);
             }


             public static Dolar operator +(Dolar Dolar, Dolar Dolar2)
             {
                 Dolar.cant += Dolar2.cant - 32;
                 return Dolar;
             }

             public static Dolar operator -(Dolar Dolar, Dolar Dolar2)
             {
                 Dolar.cant -= Dolar2.cant;
                 return Dolar;
             }

             public static bool operator ==(Dolar Dolar, Dolar Dolar2)
             {
                 if (Dolar.cant == Dolar2.cant)
                     return true;
                 return false;
             }

             public static bool operator !=(Dolar Dolar, Dolar Dolar2)
             {
                 if (Dolar.cant != (Dolar2.cant))
                     return true;
                 return false;
             }


    }
    }


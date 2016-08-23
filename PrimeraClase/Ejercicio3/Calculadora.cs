using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio3
{
    public class Calculadora
    {
        public static int Sumar(int n1 ,int n2)
        {
            return n1 + n2;    
        }

        public static int Dividir(int n1, int n2)
        {
            if (ValidarSiEsZero(n2))
            {
                return 0;
            }
            else
            {
                return n1 / n2;
            }
        }
        private static bool ValidarSiEsZero(int num)
        {
            if (num == 0)
            {
                return true;
            }
            else
            {
                return false;
            }
            //if(num ==0)
            // return true;
            // return false;
        }

        private static bool ValidarSiEsPar(int num)
        {
            if (num %2 == 0)
                return true;
                return false;
            
        }

        /// <summary>
        /// Me devuelve true si el numero es mayor que el limite.
        /// </summary>
        /// <param name="lim"></param> Limite que se debe superar.
        /// <param name="num"></param> Numero a verificar.
        /// <returns></returns>
        public static bool EsMayorQue(int lim, int num)
        {
            if (num > lim)
                return true;
                return false;
        }
    
    }

 
}



namespace Otro
{
    public class Calculadora
    {
        public static void Sumar()
        {

        }
    }
}
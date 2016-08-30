using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Validaciones1
{
    public class Menu
    {
        public static int num;

        public static int MenuV()
        {
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("********************");
            Console.WriteLine("* 1- Sumar         *");
            Console.WriteLine("* 2- Restar        *");
            Console.WriteLine("* 3- Comparar      *");
            Console.WriteLine("* 4- Convertir     *");
            Console.WriteLine("* 5- Salir         *");
            Console.WriteLine("********************");
            num = int.Parse(Console.ReadLine());

            return num;
        }
    }
}

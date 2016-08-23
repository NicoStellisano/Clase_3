using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {

            int num,contador;
            int cont0 = 0, cont1 = 0, cont2 = 0, cont3 = 0, cont4 = 0, cont5 = 0, cont6 = 0, cont7 = 0, cont8 = 0, cont9 = 0,cont10 = 0;
            Random rnd;
            int total = 100;
            rnd = new Random();
            for (contador = 0; contador < 100; contador++)
            {
               
                num = rnd.Next(1, 11);
                switch (num)
                {
                    
                    case 1:
                        cont1++;
                        break;
                    case 2:
                        cont2++;
                        break;
                    case 3:
                        cont3++;
                        break;
                    case 4:
                        cont4++;
                        break;
                    case 5:
                        cont5++;
                        break;
                    case 6:
                        cont6++;
                        break;
                    case 7:
                        cont7++;
                        break;
                    case 8:
                        cont8++;
                        break;
                    case 9:
                        cont9++;
                        break;
                    case 10:
                        cont10++;
                        break;
                }
                Console.Write(num);
                
            }
            Console.WriteLine();
            Console.WriteLine();

            Console.Write("Cantidad de 1: " + ((cont1*100)/total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 2: " + ((cont2 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 3: " + ((cont3 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 4: " + ((cont4 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 5: " + ((cont5 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 6 " + ((cont6 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 7: " + ((cont7 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 8: " + ((cont8 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 9 " + ((cont9 * 100) / total) + "%");
            Console.WriteLine();

            Console.Write("Cantidad de 10: " + ((cont10 * 100) / total) + "%");
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}

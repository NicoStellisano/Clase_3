using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Libreria;
namespace Indexador
{
    class Program
    {
        static void Main(string[] args)
        {
           // PC pc1 = new PC("LG");
            //PC pc2 = new PC("Sony");
            //PC pc3 = new PC("GameShark");


            Laboratorio lab = new Laboratorio("LAB_I");
            lab[0] = "LG";
            lab[1] = "Sony";
            lab[2] = "GameShark";
            lab[0] = "XD";



            for (int i = 0; i < lab.listaPC.Count; i++)
            {
                Console.WriteLine("PC:" + lab[i].numero + " Marca: " + lab[i].marca + " SO: " + lab[i].SO);
            }

            Console.ReadKey();
        }
    }
}

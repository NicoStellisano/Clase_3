using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjercicioInterfaces
{
    class Program
    {
        static void Main(string[] args)
        {
           // Gestion gest = new Gestion();
            Deportivo dep = new Deportivo(15000, "KPM-541", 100);

            Console.WriteLine("Deportivo con Impuesto Nacional: " +Gestion.MostrarImpuestoNacional((IAFIP)dep));
            Console.WriteLine("Deportivo con Impuesto Provincial: " + Gestion.MostrarImpuestoProvincial((IARBA)dep));
           

            Console.ReadKey();
        }
    }
}

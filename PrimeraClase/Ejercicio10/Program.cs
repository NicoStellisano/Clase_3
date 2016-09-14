using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio10
{
    class Program
    {
        static void Main(string[] args)
        {
            Factura factura = new Factura(666,"mañana",999);
            FacturaA factA = new FacturaA(21, factura);
            FacturaAPagada factAP = new FacturaAPagada("12/12/12", factA);
            
            List<Documento> miListado = new List<Documento>();
            Remito remito = new Remito(999);
            miListado.Add(factura);
            miListado.Add(remito);
            miListado.Add(factA);
            miListado.Add(factAP);
            foreach (Documento item in miListado)
            {
                item.Mostrar();
            }
            Console.ReadKey();
//            factura.Mostrar();
        }
    }
}


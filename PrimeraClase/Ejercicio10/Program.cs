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
            Factura factura = new Factura();
            
            List<Documento> miListado = new List<Documento>();
            Remito remito = new Remito();
            miListado.Add(factura);
            miListado.Add(remito);
            foreach (Documento item in miListado)
            {
                item.Mostrar();
            }
//            factura.Mostrar();
        }
    }
}

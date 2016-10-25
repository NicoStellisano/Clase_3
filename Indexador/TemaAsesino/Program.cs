using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Generics
{
    class Program
    {
        static void Main(string[] args)
        {
           // string cod = "2fa134";
            //Console.WriteLine(cod.ToUpper());
            Deposito<Producto> depositoP = new Deposito<Producto>(5);
            Deposito<Persona> depositoPer = new Deposito<Persona>(5);
            Deposito<Vehiculo> depositoVeh = new Deposito<Vehiculo>(5);
            Deposito<Mascota> depositoMas = new Deposito<Mascota>(5);

            Persona p1 = new Persona("Felipe",41012321);
            Persona p2 = new Persona("Fede",41017921);
            Persona p3 = new Persona("Jorge",41042351);

            Vehiculo v1 = new Vehiculo("Ford","Negro","KPM-541");
            Vehiculo v2 = new Vehiculo("Fiat","Blanco","ASD-451");
            Vehiculo v3 = new Vehiculo("Citroen","Amarillo","HUE-770");

            Mascota m1 = new Mascota("Fluke","Desconocida");
            Mascota m2 = new Mascota("Titu","Desconocida");
            Mascota m3 = new Mascota("Firulai","Labrador");



            depositoPer.Agregar(p1);
            depositoPer.Agregar(p2);
            depositoPer.Agregar(p3);

            depositoVeh.Agregar(v1);
            depositoVeh.Agregar(v2);
            depositoVeh.Agregar(v3);

            depositoMas.Agregar(m1);
            depositoMas.Agregar(m2);
            depositoMas.Agregar(m3);

            foreach (Mascota item in depositoMas.listaAlgo)
            {
                item.ToString();
            }


            Console.ReadKey();
           
        }
    }
}

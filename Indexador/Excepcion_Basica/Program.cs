using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Basica
{
    class Program
    {
       
        static void Main(string[] args)
        {
             int aux;
            Carrera race = new Carrera("Poli");
            Auto auto = new Auto("Ford", 1);
            Auto auto2 = new Auto("Chevrolet", 2);
            Auto auto3 = new Auto("Fiat", 3);
            Auto auto4 = new Auto("Citroen", 4);
            race.listaDeAutos.Add(auto);
            race.listaDeAutos.Add(auto2);
            race.listaDeAutos.Add(auto3);
            race.listaDeAutos.Add(auto4);

            foreach (Auto item in race.listaDeAutos)
            {
                item.listadoRuedas.Add(new Rueda("Michelin" + RandomNumber(0,31).ToString()));
                    //                   (aux = new Random().Next(1,30)).ToString()));
                item.listadoRuedas.Add(new Rueda("Michelin2" + RandomNumber(0, 31).ToString()));
                item.listadoRuedas.Add(new Rueda("Michelin3" + RandomNumber(0, 31).ToString()));
                item.listadoRuedas.Add(new Rueda("Michelin4" + RandomNumber(0, 31).ToString()));
            }
            race.CorrerCarrera();



           // auto.Andar();

/*
            try
            {
                LanzarError();
                Operar();
            }
            catch (FormatException ex)
            {
                Console.WriteLine("Error de Formato"); 
                Console.WriteLine(ex.Message);
            }
            catch (DivideByZeroException ex)
            {
                Console.WriteLine("Dividido por Cero");
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);

                //throw;
            }
            finally
            {
                Console.WriteLine("Proceso terminado");
            }
            Console.ReadKey();
        }

        public static void Operar()
        {
            string dato;
            int numero;
            try
            {
                dato = Console.ReadLine();
                numero = int.Parse(dato);
                numero = numero / numero;
            }
            catch (Exception ex)
            {
                //Operaciones para guardar informacion de la excepcion
                throw new Exception("Se quedo sin internet");
            }
          */
            Console.ReadKey();
        }
 

        public static void LanzarError()
        {
            throw new Exception("Se quedó sin Memoria RAM");
        }

        public static int RandomNumber(int min, int max)
        {        
            return new Random().Next(min,max);        
        }

    }
}

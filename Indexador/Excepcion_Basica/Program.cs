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
          
        }

        public static void LanzarError()
        {
            throw new Exception("Se quedó sin Memoria RAM");
        }
    }
}

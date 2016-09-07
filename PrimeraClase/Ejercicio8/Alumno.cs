using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ejercicio8
{
    public class Alumno
    {
        public string nombre;
        public int legajo;

        public static bool operator ==(Alumno alum1, Alumno alum2)
        {
            if (alum1.legajo == alum2.legajo)
                return true;
            return false;
        }

        public static bool operator !=(Alumno alum1, Alumno alum2)
        {
            if (alum1.legajo != alum2.legajo)
                return true;
            return false;
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Excepcion_Basica
{
    public class MiExcepcion:Exception
    {
        public DateTime horaDeLaExcepcion;
        public string textoHoraDeLaExcepcion;

        public MiExcepcion(string mensaje, DateTime hora, Exception excepAnterior)
            : base(mensaje,excepAnterior)
        {
            this.horaDeLaExcepcion = hora;
            this.textoHoraDeLaExcepcion = hora.ToString();
        }

        public MiExcepcion(string mensaje, DateTime hora)
            : this(mensaje,hora,null)
        {
            
        }
    }
}

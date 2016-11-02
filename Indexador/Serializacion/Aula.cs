using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public class Aula
    {
        public int numero;
        public List<Persona> listadoPersona;
        Persona profesor;

        public Aula(List<Persona> listado,Persona profesor,int numero)
        {
            this.listadoPersona = listado;
            this.profesor = profesor;
            this.numero = numero;
        }
    }
}

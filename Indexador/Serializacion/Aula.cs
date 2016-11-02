using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Serializacion
{
    public class Aula
    {
        public int numero;
        private List<Persona> _listadoPersona;
        public List<Persona> ListaPersonas
        {
            get { return this._listadoPersona; }
        }
        Persona profesor;
        private string _nombreAula;
       

        public string NombreAula
        {
            get { return this._nombreAula; }
            set { this._nombreAula = value; }
        }
        

        public Aula()
        {

        }

        public Aula(List<Persona> listado,Persona profesor,int numero,string nombreAula)
        {
            this._listadoPersona = listado;
            this.profesor = profesor;
            this.numero = numero;
            this._nombreAula = nombreAula;
        }
    }
}

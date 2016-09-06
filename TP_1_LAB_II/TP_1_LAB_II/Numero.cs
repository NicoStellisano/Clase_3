using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TP_1_LAB_II
{
    public class Numero
    {
        private double _numero;
        private double _aux;

        public double getNumero()
        {
            return this._numero;
        }

        public void Numero()
        {
            this._numero = 0;
        }

        public void Numero(string numero)
        {
            if (double.TryParse(numero, out _aux))           
                this._numero = _aux;           
        }

        public void Numero(double numero)
        {
            this._numero = numero;
        }

        private void setNumero(string numero)
        {
            this._numero = validarNumero(numero);
            
        }

        private double validarNumero(string numeroString)
        {
            if (double.TryParse(numeroString, out _aux))
                return _aux;          
                return 0;
        }

    }
}

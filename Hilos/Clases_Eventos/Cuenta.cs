using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clases_Eventos
{
    public delegate void CuentaDelegado(float dinero);

    
    public class Cuenta
    {
        public Cuenta()
        {

        }
        public float saldo;
        public event CuentaDelegado SaldoNegativo;
        public void SacarDinero(float dinero)
        {
            if (dinero > this.saldo)
            {
                //Sì estuvieramos en aplicacion de consola, Console.Write
                //Sì estuvieramos en Windows Form, MessageBox.Show()
                //Si estuvieramos en una pagina web, seria un alert()
                this.SaldoNegativo(dinero);//Eventos son genéricos para delegar la forma que se muestra
            }
        }
    }
}

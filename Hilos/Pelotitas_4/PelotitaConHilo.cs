using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
namespace Pelotitas_4
{
    public class PelotitaConHilo
    {
        public Pelotita_Con_Threads.Pelotita pelotita;
        public Thread hilo;

        public PelotitaConHilo(Pelotita_Con_Threads.Pelotita pelo,Thread hil)
        {
            this.pelotita = pelo;
            this.hilo = hil;
        }
    }
}

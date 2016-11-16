using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Threading.Tasks;
using System.Threading;

namespace Pelotita_3
{
    public partial class Form1 : Form
    {
        private Thread _miHilo;
        public Form1()
        {
            InitializeComponent();
            
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            Pelotita_Con_Threads.Pelotita pelotita = new Pelotita_Con_Threads.Pelotita(this.pictureBox1);
            this._miHilo = new Thread(pelotita.DoWork);
            this._miHilo.Start();
            this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);
        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
           // MessageBox.Show("Pausado");
          //  this.btnPausar.Click -= new System.EventHandler(this.btnPausar_Click);
            this._miHilo.Suspend();
         
        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {
            this._miHilo.Abort();
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            this._miHilo.Resume();

        }


    }
}

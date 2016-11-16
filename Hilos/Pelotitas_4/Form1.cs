using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;


namespace Pelotitas_4
{
    public partial class Form1 : Form
    {
        private List<PelotitaConHilo> _listaPH;
        public Form1()
        {
            InitializeComponent();
            _listaPH = new List<PelotitaConHilo>();
        }

        private void btnCrear_Click(object sender, EventArgs e)
        {
            try
            {
                Pelotita_Con_Threads.Pelotita pelotita = new Pelotita_Con_Threads.Pelotita(this.pictureBox1);
                Thread th = new Thread(pelotita.DoWork);
                PelotitaConHilo ph = new PelotitaConHilo(pelotita, th);
                th.Start();

                this._listaPH.Add(ph);
             //   this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);
            }
            catch (Exception)
            {

            }

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            try
            {
                this._listaPH[this._listaPH.Count - 1].hilo.Suspend();

                

            }
            catch (Exception)
            {


            }

        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {
            try
            {
                this._listaPH[this._listaPH.Count-1].hilo.Abort();
                this._listaPH.RemoveAt(this._listaPH.Count - 1);
                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
            }
            catch (Exception)
            {


            }

        }



        private void btnRenaudar_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._listaPH[this._listaPH.Count - 1].hilo.ThreadState == ThreadState.Suspended)
                    this._listaPH[this._listaPH.Count - 1].hilo.Resume();

            }
            catch (Exception)
            {


            }

        }

    }
}

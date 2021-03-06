﻿using System;
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
            try
            {
                Pelotita_Con_Threads.Pelotita pelotita = new Pelotita_Con_Threads.Pelotita(this.pictureBox1);
                this._miHilo = new Thread(pelotita.DoWork);
                this._miHilo.Start();
                this.btnCrear.Click -= new System.EventHandler(this.btnCrear_Click);
            }
            catch (Exception)
            {
              
            }

        }

        private void btnPausar_Click(object sender, EventArgs e)
        {
            try
            {
                this._miHilo.Suspend();

            }
            catch (Exception)
            {
                
                
            }
         
        }

        private void btnDestruir_Click(object sender, EventArgs e)
        {
            try
            {
                this._miHilo.Abort();
                Graphics g = this.pictureBox1.CreateGraphics();
                g.Clear(this.pictureBox1.BackColor);
            }
            catch (Exception)
            {
                
                
            }
   
        }

    

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (this._miHilo.ThreadState == ThreadState.Suspended)
                    this._miHilo.Resume();

            }
            catch (Exception)
            {
                
                
            }
            
        }


    }
}

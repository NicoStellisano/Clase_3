﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Ejercicio4;

namespace Ejercicio9_UI
{
    public partial class Form1 : Form
    {

        private Carrera race;
        public string metodo;
        public int cantidad;
        private int aux;

        public Form1()
        {
            InitializeComponent();

            
            foreach (EFabricante item in Enum.GetValues(typeof(EFabricante)))
            {
                this.cmbFabricante.Items.Add(item);
            }
            this.cmbFabricante.SelectedIndex = 1;
            this.cmbFabricante.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbCorrer.SelectedIndex = 1;
            this.cmbCorrer.DropDownStyle = ComboBoxStyle.DropDownList;

            this.cmbOrdenar.SelectedIndex = 1;
            this.cmbOrdenar.DropDownStyle = ComboBoxStyle.DropDownList;
       
            
            this.txtFecha.Text = DateTime.Today.ToString();
            this.txtLugar.Text = "Avellaneda";
            this.txtNombre.Text = "Carrera 1";
            this.gpbAutos.Enabled = false;
            this.gbpOrdenar.Enabled = false;
            this.gpbListado.Enabled = false;
            this.gbpResultado.Enabled = false;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.race = new Carrera(this.txtNombre.Text, this.txtFecha.Text, this.txtLugar.Text);
            this.gpbCarrera.Enabled = false;
            this.gpbAutos.Enabled = true;
            this.gpbListado.Enabled = true;

        }

      

     
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            
           Auto auto = new Auto(this.txtNombreP.Text, (EFabricante)cmbFabricante.SelectedItem);
            this.race += auto;
            this.gbpResultado.Enabled = true;
            this.gbpOrdenar.Enabled = true;

            cargarListado();
        }

        private void cargarListado()
        {
            this.lbsListado.Items.Clear();
            foreach (Auto item in this.race.listaDeAutos)
            {
                this.lbsListado.Items.Add(item.DatosEnString);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCorrer_Click(object sender, EventArgs e)
        {
            this.txtResultado.Clear();
            cantidad = (int)this.numericUpDown1.Value;//int.TryParse(this.txtCantidad.Text, out cantidad))
            
            metodo = this.cmbCorrer.Text;
          
            if (metodo == "Kilometros")
            {
                this.txtResultado.Text = this.race.CorrerCarrera((Kilometros)cantidad);
            }
            else
            {
                this.txtResultado.Text = this.race.CorrerCarrera((Tiempo)cantidad);

            }
        }

        private void lblCantidad_Click(object sender, EventArgs e)
        {

        }

        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            this.txtResultado.Clear();
            this.lbsListado.Items.Clear();
            this.race.listaDeAutos.Clear();
            this.txtNombreP.Clear();
            this.numericUpDown1.Value = 0;
            this.gpbAutos.Enabled = false;
            this.gbpResultado.Enabled = false;
            this.gpbCarrera.Enabled = true;
            this.gbpOrdenar.Enabled = false;
            this.gpbListado.Enabled = false;


            
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            if (this.cmbOrdenar.Text == "Piloto" && this.radioButton1.Checked == true)
                aux = 1;
            if (this.cmbOrdenar.Text == "Piloto" && this.radioButton1.Checked == false)
                aux = 2;
            if (this.cmbOrdenar.Text == "Fabricante" && this.radioButton1.Checked == true)
                aux = 3;
            if (this.cmbOrdenar.Text == "Fabricante" && this.radioButton1.Checked == false)
                aux = 4;
            switch(aux)
            {
                case 1:
                    this.race.listaDeAutos.Sort(Auto.OrdenarPorPiloto);
                    cargarListado();
                    break;
                case 2:
                    this.race.listaDeAutos.Sort(Auto.OrdenarPorPilotoD);
                    cargarListado();
                    break;
                case 3:
                    this.race.listaDeAutos.Sort(Auto.OrdenarPorMarca);
                    cargarListado();
                    break;
                case 4:
                    this.race.listaDeAutos.Sort(Auto.OrdenarPorMarcaD);
                    cargarListado();
                    break;

            }
            
        }

        private void btnOrdenarP_Click(object sender, EventArgs e)
        {
            
        }
    }
}

using System;
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
       
            
            this.txtFecha.Text = DateTime.Today.ToString();
            this.txtLugar.Text = "Avellaneda";
            this.txtNombre.Text = "Carrera 1";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.race = new Carrera(this.txtNombre.Text, this.txtFecha.Text, this.txtLugar.Text);
            this.gpbCarrera.Enabled = false;    
        }

      

     
        private void btnAgregarAuto_Click(object sender, EventArgs e)
        {
            
           Auto auto = new Auto(this.txtNombreP.Text, (EFabricante)cmbFabricante.SelectedItem);
            this.race += auto;

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
            if (int.TryParse(this.txtCantidad.Text, out cantidad))
                cantidad = cantidad;
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
    }
}

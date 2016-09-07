using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio7_FerreteFacturacion
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void txtBox1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void txtBox2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void txtBox3_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void btrSumar_Click(object sender, EventArgs e)
        {
            float aux, aux2, aux3;
            aux = float.Parse(this.txtBox1.Text);
            aux2 = float.Parse(this.txtBox2.Text);
            aux3 = float.Parse(this.txtBox3.Text);

            MessageBox.Show((aux+aux2+aux3).ToString());

        }

        private void btrPromedio_Click(object sender, EventArgs e)
        {
            float aux, aux2, aux3;
            aux = float.Parse(this.txtBox1.Text);
            aux2 = float.Parse(this.txtBox2.Text);
            aux3 = float.Parse(this.txtBox3.Text);

            MessageBox.Show(((aux + aux2 + aux3)/3).ToString());
        }

        private void btrPrecioFinal_Click(object sender, EventArgs e)
        {
            float aux, aux2, aux3;
            aux = float.Parse(this.txtBox1.Text);
            aux2 = float.Parse(this.txtBox2.Text);
            aux3 = float.Parse(this.txtBox3.Text);

            MessageBox.Show(((aux + aux2 + aux3) * 1.21).ToString());
        }
    }
}

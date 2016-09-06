namespace Ejercicio7_FerreteFacturacion
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtBox1 = new System.Windows.Forms.TextBox();
            this.txtBox2 = new System.Windows.Forms.TextBox();
            this.txtBox3 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btrSumar = new System.Windows.Forms.Button();
            this.btrPromedio = new System.Windows.Forms.Button();
            this.btrPrecioFinal = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // txtBox1
            // 
            this.txtBox1.Location = new System.Drawing.Point(95, 24);
            this.txtBox1.Name = "txtBox1";
            this.txtBox1.Size = new System.Drawing.Size(100, 20);
            this.txtBox1.TabIndex = 0;
            this.txtBox1.TextChanged += new System.EventHandler(this.txtBox1_TextChanged);
            // 
            // txtBox2
            // 
            this.txtBox2.Location = new System.Drawing.Point(95, 59);
            this.txtBox2.Name = "txtBox2";
            this.txtBox2.Size = new System.Drawing.Size(100, 20);
            this.txtBox2.TabIndex = 1;
            this.txtBox2.TextChanged += new System.EventHandler(this.txtBox2_TextChanged);
            // 
            // txtBox3
            // 
            this.txtBox3.Location = new System.Drawing.Point(95, 95);
            this.txtBox3.Name = "txtBox3";
            this.txtBox3.Size = new System.Drawing.Size(100, 20);
            this.txtBox3.TabIndex = 2;
            this.txtBox3.TextChanged += new System.EventHandler(this.txtBox3_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "Ingrese Precio";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(95, 43);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(75, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ingrese Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(95, 82);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(75, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Ingrese Precio";
            // 
            // btrSumar
            // 
            this.btrSumar.Location = new System.Drawing.Point(98, 132);
            this.btrSumar.Name = "btrSumar";
            this.btrSumar.Size = new System.Drawing.Size(97, 23);
            this.btrSumar.TabIndex = 6;
            this.btrSumar.Text = "Sumar";
            this.btrSumar.UseVisualStyleBackColor = true;
            this.btrSumar.Click += new System.EventHandler(this.btrSumar_Click);
            // 
            // btrPromedio
            // 
            this.btrPromedio.Location = new System.Drawing.Point(98, 152);
            this.btrPromedio.Name = "btrPromedio";
            this.btrPromedio.Size = new System.Drawing.Size(97, 23);
            this.btrPromedio.TabIndex = 7;
            this.btrPromedio.Text = "Promedio";
            this.btrPromedio.UseVisualStyleBackColor = true;
            this.btrPromedio.Click += new System.EventHandler(this.btrPromedio_Click);
            // 
            // btrPrecioFinal
            // 
            this.btrPrecioFinal.Location = new System.Drawing.Point(98, 172);
            this.btrPrecioFinal.Name = "btrPrecioFinal";
            this.btrPrecioFinal.Size = new System.Drawing.Size(97, 23);
            this.btrPrecioFinal.TabIndex = 8;
            this.btrPrecioFinal.Text = "Precio Final";
            this.btrPrecioFinal.UseVisualStyleBackColor = true;
            this.btrPrecioFinal.Click += new System.EventHandler(this.btrPrecioFinal_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 262);
            this.Controls.Add(this.btrPrecioFinal);
            this.Controls.Add(this.btrPromedio);
            this.Controls.Add(this.btrSumar);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtBox3);
            this.Controls.Add(this.txtBox2);
            this.Controls.Add(this.txtBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtBox1;
        private System.Windows.Forms.TextBox txtBox2;
        private System.Windows.Forms.TextBox txtBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btrSumar;
        private System.Windows.Forms.Button btrPromedio;
        private System.Windows.Forms.Button btrPrecioFinal;
    }
}


namespace Ejercicio9_UI
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
            this.btnCrearCarrera = new System.Windows.Forms.Button();
            this.gpbCarrera = new System.Windows.Forms.GroupBox();
            this.txtLugar = new System.Windows.Forms.TextBox();
            this.lblLugar = new System.Windows.Forms.Label();
            this.txtFecha = new System.Windows.Forms.TextBox();
            this.lblFecha = new System.Windows.Forms.Label();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.lblNombre = new System.Windows.Forms.Label();
            this.gpbAutos = new System.Windows.Forms.GroupBox();
            this.cmbFabricante = new System.Windows.Forms.ComboBox();
            this.lblFabricante = new System.Windows.Forms.Label();
            this.txtNombreP = new System.Windows.Forms.TextBox();
            this.lblNombreP = new System.Windows.Forms.Label();
            this.btnAgregarAuto = new System.Windows.Forms.Button();
            this.gpbListado = new System.Windows.Forms.GroupBox();
            this.lbsListado = new System.Windows.Forms.ListBox();
            this.gbpResultado = new System.Windows.Forms.GroupBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.cmbCorrer = new System.Windows.Forms.ComboBox();
            this.lblCorrer = new System.Windows.Forms.Label();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.numericUpDown1 = new System.Windows.Forms.NumericUpDown();
            this.btnLimpiar = new System.Windows.Forms.Button();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.gbpOrdenar = new System.Windows.Forms.GroupBox();
            this.cmbOrdenar = new System.Windows.Forms.ComboBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            this.gpbCarrera.SuspendLayout();
            this.gpbAutos.SuspendLayout();
            this.gpbListado.SuspendLayout();
            this.gbpResultado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).BeginInit();
            this.gbpOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCrearCarrera
            // 
            this.btnCrearCarrera.Location = new System.Drawing.Point(168, 59);
            this.btnCrearCarrera.Name = "btnCrearCarrera";
            this.btnCrearCarrera.Size = new System.Drawing.Size(100, 29);
            this.btnCrearCarrera.TabIndex = 0;
            this.btnCrearCarrera.Text = "Crear Carrera";
            this.btnCrearCarrera.UseVisualStyleBackColor = true;
            this.btnCrearCarrera.Click += new System.EventHandler(this.button1_Click);
            // 
            // gpbCarrera
            // 
            this.gpbCarrera.Controls.Add(this.txtLugar);
            this.gpbCarrera.Controls.Add(this.lblLugar);
            this.gpbCarrera.Controls.Add(this.txtFecha);
            this.gpbCarrera.Controls.Add(this.lblFecha);
            this.gpbCarrera.Controls.Add(this.txtNombre);
            this.gpbCarrera.Controls.Add(this.lblNombre);
            this.gpbCarrera.Controls.Add(this.btnCrearCarrera);
            this.gpbCarrera.Location = new System.Drawing.Point(19, 15);
            this.gpbCarrera.Name = "gpbCarrera";
            this.gpbCarrera.Size = new System.Drawing.Size(436, 112);
            this.gpbCarrera.TabIndex = 1;
            this.gpbCarrera.TabStop = false;
            this.gpbCarrera.Text = "Carrera";
            // 
            // txtLugar
            // 
            this.txtLugar.Location = new System.Drawing.Point(309, 33);
            this.txtLugar.Name = "txtLugar";
            this.txtLugar.Size = new System.Drawing.Size(100, 20);
            this.txtLugar.TabIndex = 6;
            // 
            // lblLugar
            // 
            this.lblLugar.AutoSize = true;
            this.lblLugar.Location = new System.Drawing.Point(306, 16);
            this.lblLugar.Name = "lblLugar";
            this.lblLugar.Size = new System.Drawing.Size(34, 13);
            this.lblLugar.TabIndex = 5;
            this.lblLugar.Text = "Lugar";
            // 
            // txtFecha
            // 
            this.txtFecha.Location = new System.Drawing.Point(168, 33);
            this.txtFecha.Name = "txtFecha";
            this.txtFecha.Size = new System.Drawing.Size(100, 20);
            this.txtFecha.TabIndex = 4;
            // 
            // lblFecha
            // 
            this.lblFecha.AutoSize = true;
            this.lblFecha.Location = new System.Drawing.Point(165, 16);
            this.lblFecha.Name = "lblFecha";
            this.lblFecha.Size = new System.Drawing.Size(37, 13);
            this.lblFecha.TabIndex = 3;
            this.lblFecha.Text = "Fecha";
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(30, 33);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(100, 20);
            this.txtNombre.TabIndex = 2;
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(27, 16);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(44, 13);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // gpbAutos
            // 
            this.gpbAutos.Controls.Add(this.cmbFabricante);
            this.gpbAutos.Controls.Add(this.lblFabricante);
            this.gpbAutos.Controls.Add(this.txtNombreP);
            this.gpbAutos.Controls.Add(this.lblNombreP);
            this.gpbAutos.Controls.Add(this.btnAgregarAuto);
            this.gpbAutos.Location = new System.Drawing.Point(22, 133);
            this.gpbAutos.Name = "gpbAutos";
            this.gpbAutos.Size = new System.Drawing.Size(241, 166);
            this.gpbAutos.TabIndex = 2;
            this.gpbAutos.TabStop = false;
            this.gpbAutos.Text = "Autos";
            // 
            // cmbFabricante
            // 
            this.cmbFabricante.FormattingEnabled = true;
            this.cmbFabricante.Location = new System.Drawing.Point(27, 104);
            this.cmbFabricante.Name = "cmbFabricante";
            this.cmbFabricante.Size = new System.Drawing.Size(121, 21);
            this.cmbFabricante.TabIndex = 10;
            // 
            // lblFabricante
            // 
            this.lblFabricante.AutoSize = true;
            this.lblFabricante.Location = new System.Drawing.Point(24, 87);
            this.lblFabricante.Name = "lblFabricante";
            this.lblFabricante.Size = new System.Drawing.Size(57, 13);
            this.lblFabricante.TabIndex = 9;
            this.lblFabricante.Text = "Fabricante";
            // 
            // txtNombreP
            // 
            this.txtNombreP.Location = new System.Drawing.Point(27, 41);
            this.txtNombreP.Name = "txtNombreP";
            this.txtNombreP.Size = new System.Drawing.Size(100, 20);
            this.txtNombreP.TabIndex = 8;
            // 
            // lblNombreP
            // 
            this.lblNombreP.AutoSize = true;
            this.lblNombreP.Location = new System.Drawing.Point(24, 24);
            this.lblNombreP.Name = "lblNombreP";
            this.lblNombreP.Size = new System.Drawing.Size(73, 13);
            this.lblNombreP.TabIndex = 7;
            this.lblNombreP.Text = "Nombre Piloto";
            // 
            // btnAgregarAuto
            // 
            this.btnAgregarAuto.Location = new System.Drawing.Point(27, 131);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(100, 29);
            this.btnAgregarAuto.TabIndex = 7;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // gpbListado
            // 
            this.gpbListado.Controls.Add(this.lbsListado);
            this.gpbListado.Location = new System.Drawing.Point(272, 133);
            this.gpbListado.Name = "gpbListado";
            this.gpbListado.Size = new System.Drawing.Size(182, 166);
            this.gpbListado.TabIndex = 3;
            this.gpbListado.TabStop = false;
            this.gpbListado.Text = "Listado de Autos";
            // 
            // lbsListado
            // 
            this.lbsListado.FormattingEnabled = true;
            this.lbsListado.Location = new System.Drawing.Point(6, 19);
            this.lbsListado.Name = "lbsListado";
            this.lbsListado.Size = new System.Drawing.Size(170, 134);
            this.lbsListado.TabIndex = 0;
            // 
            // gbpResultado
            // 
            this.gbpResultado.Controls.Add(this.btnLimpiar);
            this.gbpResultado.Controls.Add(this.numericUpDown1);
            this.gbpResultado.Controls.Add(this.lblCantidad);
            this.gbpResultado.Controls.Add(this.txtResultado);
            this.gbpResultado.Controls.Add(this.cmbCorrer);
            this.gbpResultado.Controls.Add(this.lblCorrer);
            this.gbpResultado.Controls.Add(this.btnCorrer);
            this.gbpResultado.Location = new System.Drawing.Point(23, 413);
            this.gbpResultado.Name = "gbpResultado";
            this.gbpResultado.Size = new System.Drawing.Size(431, 239);
            this.gbpResultado.TabIndex = 4;
            this.gbpResultado.TabStop = false;
            this.gbpResultado.Text = "Resultado";
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(24, 65);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(108, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad de KM/MIN";
            this.lblCantidad.Click += new System.EventHandler(this.lblCantidad_Click);
            // 
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(164, 41);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(261, 211);
            this.txtResultado.TabIndex = 13;
            // 
            // cmbCorrer
            // 
            this.cmbCorrer.FormattingEnabled = true;
            this.cmbCorrer.Items.AddRange(new object[] {
            "Kilometros",
            "Tiempo"});
            this.cmbCorrer.Location = new System.Drawing.Point(26, 41);
            this.cmbCorrer.Name = "cmbCorrer";
            this.cmbCorrer.Size = new System.Drawing.Size(121, 21);
            this.cmbCorrer.TabIndex = 12;
            // 
            // lblCorrer
            // 
            this.lblCorrer.AutoSize = true;
            this.lblCorrer.Location = new System.Drawing.Point(23, 24);
            this.lblCorrer.Name = "lblCorrer";
            this.lblCorrer.Size = new System.Drawing.Size(80, 13);
            this.lblCorrer.TabIndex = 11;
            this.lblCorrer.Text = "Tipo de Carrera";
            // 
            // btnCorrer
            // 
            this.btnCorrer.Location = new System.Drawing.Point(26, 114);
            this.btnCorrer.Name = "btnCorrer";
            this.btnCorrer.Size = new System.Drawing.Size(100, 34);
            this.btnCorrer.TabIndex = 0;
            this.btnCorrer.Text = "Correr Carrera";
            this.btnCorrer.UseVisualStyleBackColor = true;
            this.btnCorrer.Click += new System.EventHandler(this.btnCorrer_Click);
            // 
            // numericUpDown1
            // 
            this.numericUpDown1.Location = new System.Drawing.Point(27, 88);
            this.numericUpDown1.Name = "numericUpDown1";
            this.numericUpDown1.Size = new System.Drawing.Size(120, 20);
            this.numericUpDown1.TabIndex = 14;
            this.numericUpDown1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // btnLimpiar
            // 
            this.btnLimpiar.Location = new System.Drawing.Point(26, 204);
            this.btnLimpiar.Name = "btnLimpiar";
            this.btnLimpiar.Size = new System.Drawing.Size(100, 34);
            this.btnLimpiar.TabIndex = 15;
            this.btnLimpiar.Text = "Limpiar Todo";
            this.btnLimpiar.UseVisualStyleBackColor = true;
            this.btnLimpiar.Click += new System.EventHandler(this.btnLimpiar_Click);
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(292, 33);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(100, 37);
            this.btnOrdenar.TabIndex = 11;
            this.btnOrdenar.Text = "Ordenar";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // gbpOrdenar
            // 
            this.gbpOrdenar.Controls.Add(this.radioButton2);
            this.gbpOrdenar.Controls.Add(this.radioButton1);
            this.gbpOrdenar.Controls.Add(this.cmbOrdenar);
            this.gbpOrdenar.Controls.Add(this.btnOrdenar);
            this.gbpOrdenar.Location = new System.Drawing.Point(19, 305);
            this.gbpOrdenar.Name = "gbpOrdenar";
            this.gbpOrdenar.Size = new System.Drawing.Size(435, 102);
            this.gbpOrdenar.TabIndex = 5;
            this.gbpOrdenar.TabStop = false;
            this.gbpOrdenar.Text = "Ordenar";
            // 
            // cmbOrdenar
            // 
            this.cmbOrdenar.FormattingEnabled = true;
            this.cmbOrdenar.Items.AddRange(new object[] {
            "Piloto",
            "Fabricante"});
            this.cmbOrdenar.Location = new System.Drawing.Point(31, 42);
            this.cmbOrdenar.Name = "cmbOrdenar";
            this.cmbOrdenar.Size = new System.Drawing.Size(121, 21);
            this.cmbOrdenar.TabIndex = 13;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Checked = true;
            this.radioButton1.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.Location = new System.Drawing.Point(168, 42);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(46, 17);
            this.radioButton1.TabIndex = 14;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ASC";
            this.radioButton1.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.ImageAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.Location = new System.Drawing.Point(220, 43);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.Size = new System.Drawing.Size(47, 17);
            this.radioButton2.TabIndex = 15;
            this.radioButton2.Text = "DES";
            this.radioButton2.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 664);
            this.Controls.Add(this.gbpOrdenar);
            this.Controls.Add(this.gbpResultado);
            this.Controls.Add(this.gpbListado);
            this.Controls.Add(this.gpbAutos);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbAutos.ResumeLayout(false);
            this.gpbAutos.PerformLayout();
            this.gpbListado.ResumeLayout(false);
            this.gbpResultado.ResumeLayout(false);
            this.gbpResultado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDown1)).EndInit();
            this.gbpOrdenar.ResumeLayout(false);
            this.gbpOrdenar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCrearCarrera;
        private System.Windows.Forms.GroupBox gpbCarrera;
        private System.Windows.Forms.TextBox txtLugar;
        private System.Windows.Forms.Label lblLugar;
        private System.Windows.Forms.TextBox txtFecha;
        private System.Windows.Forms.Label lblFecha;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.GroupBox gpbAutos;
        private System.Windows.Forms.GroupBox gpbListado;
        private System.Windows.Forms.GroupBox gbpResultado;
        private System.Windows.Forms.Button btnAgregarAuto;
        private System.Windows.Forms.Label lblFabricante;
        private System.Windows.Forms.TextBox txtNombreP;
        private System.Windows.Forms.Label lblNombreP;
        private System.Windows.Forms.ComboBox cmbFabricante;
        private System.Windows.Forms.ListBox lbsListado;
        private System.Windows.Forms.ComboBox cmbCorrer;
        private System.Windows.Forms.Label lblCorrer;
        private System.Windows.Forms.Button btnCorrer;
        private System.Windows.Forms.TextBox txtResultado;
        private System.Windows.Forms.Label lblCantidad;
        private System.Windows.Forms.NumericUpDown numericUpDown1;
        private System.Windows.Forms.Button btnLimpiar;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.GroupBox gbpOrdenar;
        private System.Windows.Forms.RadioButton radioButton2;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.ComboBox cmbOrdenar;
    }
}


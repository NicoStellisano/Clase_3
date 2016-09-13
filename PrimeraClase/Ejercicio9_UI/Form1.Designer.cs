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
            this.gpbResultado = new System.Windows.Forms.GroupBox();
            this.lbsListado = new System.Windows.Forms.ListBox();
            this.gbpResultado = new System.Windows.Forms.GroupBox();
            this.btnCorrer = new System.Windows.Forms.Button();
            this.cmbCorrer = new System.Windows.Forms.ComboBox();
            this.lblCorrer = new System.Windows.Forms.Label();
            this.txtResultado = new System.Windows.Forms.TextBox();
            this.txtCantidad = new System.Windows.Forms.TextBox();
            this.lblCantidad = new System.Windows.Forms.Label();
            this.gpbCarrera.SuspendLayout();
            this.gpbAutos.SuspendLayout();
            this.gpbResultado.SuspendLayout();
            this.gbpResultado.SuspendLayout();
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
            this.gpbAutos.Size = new System.Drawing.Size(241, 246);
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
            this.btnAgregarAuto.Location = new System.Drawing.Point(27, 155);
            this.btnAgregarAuto.Name = "btnAgregarAuto";
            this.btnAgregarAuto.Size = new System.Drawing.Size(100, 29);
            this.btnAgregarAuto.TabIndex = 7;
            this.btnAgregarAuto.Text = "Agregar Auto";
            this.btnAgregarAuto.UseVisualStyleBackColor = true;
            this.btnAgregarAuto.Click += new System.EventHandler(this.btnAgregarAuto_Click);
            // 
            // gpbResultado
            // 
            this.gpbResultado.Controls.Add(this.lbsListado);
            this.gpbResultado.Location = new System.Drawing.Point(272, 133);
            this.gpbResultado.Name = "gpbResultado";
            this.gpbResultado.Size = new System.Drawing.Size(182, 246);
            this.gpbResultado.TabIndex = 3;
            this.gpbResultado.TabStop = false;
            this.gpbResultado.Text = "Listado de Autos";
            // 
            // lbsListado
            // 
            this.lbsListado.FormattingEnabled = true;
            this.lbsListado.Location = new System.Drawing.Point(6, 19);
            this.lbsListado.Name = "lbsListado";
            this.lbsListado.Size = new System.Drawing.Size(170, 212);
            this.lbsListado.TabIndex = 0;
            // 
            // gbpResultado
            // 
            this.gbpResultado.Controls.Add(this.txtCantidad);
            this.gbpResultado.Controls.Add(this.lblCantidad);
            this.gbpResultado.Controls.Add(this.txtResultado);
            this.gbpResultado.Controls.Add(this.cmbCorrer);
            this.gbpResultado.Controls.Add(this.lblCorrer);
            this.gbpResultado.Controls.Add(this.btnCorrer);
            this.gbpResultado.Location = new System.Drawing.Point(23, 394);
            this.gbpResultado.Name = "gbpResultado";
            this.gbpResultado.Size = new System.Drawing.Size(431, 258);
            this.gbpResultado.TabIndex = 4;
            this.gbpResultado.TabStop = false;
            this.gbpResultado.Text = "Resultado";
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
            // txtResultado
            // 
            this.txtResultado.Location = new System.Drawing.Point(164, 41);
            this.txtResultado.Multiline = true;
            this.txtResultado.Name = "txtResultado";
            this.txtResultado.Size = new System.Drawing.Size(261, 211);
            this.txtResultado.TabIndex = 13;
            // 
            // txtCantidad
            // 
            this.txtCantidad.Location = new System.Drawing.Point(26, 79);
            this.txtCantidad.Name = "txtCantidad";
            this.txtCantidad.Size = new System.Drawing.Size(100, 20);
            this.txtCantidad.TabIndex = 8;
            // 
            // lblCantidad
            // 
            this.lblCantidad.AutoSize = true;
            this.lblCantidad.Location = new System.Drawing.Point(23, 62);
            this.lblCantidad.Name = "lblCantidad";
            this.lblCantidad.Size = new System.Drawing.Size(108, 13);
            this.lblCantidad.TabIndex = 7;
            this.lblCantidad.Text = "Cantidad de KM/MIN";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(470, 664);
            this.Controls.Add(this.gbpResultado);
            this.Controls.Add(this.gpbResultado);
            this.Controls.Add(this.gpbAutos);
            this.Controls.Add(this.gpbCarrera);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.gpbCarrera.ResumeLayout(false);
            this.gpbCarrera.PerformLayout();
            this.gpbAutos.ResumeLayout(false);
            this.gpbAutos.PerformLayout();
            this.gpbResultado.ResumeLayout(false);
            this.gbpResultado.ResumeLayout(false);
            this.gbpResultado.PerformLayout();
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
        private System.Windows.Forms.GroupBox gpbResultado;
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
        private System.Windows.Forms.TextBox txtCantidad;
        private System.Windows.Forms.Label lblCantidad;
    }
}


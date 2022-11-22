namespace EdicionDatos
{
    partial class fmEdicion
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.laTitulo = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.tbNombre = new System.Windows.Forms.TextBox();
            this.btIntroduceDatos = new System.Windows.Forms.Button();
            this.laNombreOtro = new System.Windows.Forms.Label();
            this.laLocalidadX = new System.Windows.Forms.Label();
            this.laCodPostalX = new System.Windows.Forms.Label();
            this.laTelefonoX = new System.Windows.Forms.Label();
            this.laDireccionX = new System.Windows.Forms.Label();
            this.laEmailX = new System.Windows.Forms.Label();
            this.laDniCifX = new System.Windows.Forms.Label();
            this.laNombreX = new System.Windows.Forms.Label();
            this.laDireccion = new System.Windows.Forms.Label();
            this.laEmail = new System.Windows.Forms.Label();
            this.laDniCif = new System.Windows.Forms.Label();
            this.laCodPostal = new System.Windows.Forms.Label();
            this.laLocalidad = new System.Windows.Forms.Label();
            this.laTelefono = new System.Windows.Forms.Label();
            this.laNombre = new System.Windows.Forms.Label();
            this.laConvierte = new System.Windows.Forms.Label();
            this.laEuros = new System.Windows.Forms.Label();
            this.laDolares = new System.Windows.Forms.Label();
            this.tbEuros = new System.Windows.Forms.TextBox();
            this.tbDolares = new System.Windows.Forms.TextBox();
            this.btCambiar = new System.Windows.Forms.Button();
            this.gbUltimaCotizacion = new System.Windows.Forms.GroupBox();
            this.tbEuroDolar = new System.Windows.Forms.TextBox();
            this.tbDolarEuro = new System.Windows.Forms.TextBox();
            this.laEuroDolar = new System.Windows.Forms.Label();
            this.laDolarEuro = new System.Windows.Forms.Label();
            this.btAcercaDe = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            this.gbUltimaCotizacion.SuspendLayout();
            this.SuspendLayout();
            // 
            // laTitulo
            // 
            this.laTitulo.AutoSize = true;
            this.laTitulo.Font = new System.Drawing.Font("Segoe UI", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laTitulo.Location = new System.Drawing.Point(181, 8);
            this.laTitulo.Name = "laTitulo";
            this.laTitulo.Size = new System.Drawing.Size(599, 32);
            this.laTitulo.TabIndex = 0;
            this.laTitulo.Text = "DATOS INTRODUCIDOS DESDE OTRO FORMULARIO";
            // 
            // panel1
            // 
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Controls.Add(this.tbNombre);
            this.panel1.Controls.Add(this.btIntroduceDatos);
            this.panel1.Controls.Add(this.laNombreOtro);
            this.panel1.Controls.Add(this.laLocalidadX);
            this.panel1.Controls.Add(this.laCodPostalX);
            this.panel1.Controls.Add(this.laTelefonoX);
            this.panel1.Controls.Add(this.laDireccionX);
            this.panel1.Controls.Add(this.laEmailX);
            this.panel1.Controls.Add(this.laDniCifX);
            this.panel1.Controls.Add(this.laNombreX);
            this.panel1.Controls.Add(this.laDireccion);
            this.panel1.Controls.Add(this.laEmail);
            this.panel1.Controls.Add(this.laDniCif);
            this.panel1.Controls.Add(this.laCodPostal);
            this.panel1.Controls.Add(this.laLocalidad);
            this.panel1.Controls.Add(this.laTelefono);
            this.panel1.Controls.Add(this.laNombre);
            this.panel1.Controls.Add(this.laTitulo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(1011, 298);
            this.panel1.TabIndex = 1;
            // 
            // tbNombre
            // 
            this.tbNombre.Location = new System.Drawing.Point(399, 236);
            this.tbNombre.Name = "tbNombre";
            this.tbNombre.ReadOnly = true;
            this.tbNombre.Size = new System.Drawing.Size(299, 34);
            this.tbNombre.TabIndex = 17;
            // 
            // btIntroduceDatos
            // 
            this.btIntroduceDatos.Location = new System.Drawing.Point(831, 231);
            this.btIntroduceDatos.Name = "btIntroduceDatos";
            this.btIntroduceDatos.Size = new System.Drawing.Size(167, 45);
            this.btIntroduceDatos.TabIndex = 16;
            this.btIntroduceDatos.Text = "Introduce Datos";
            this.btIntroduceDatos.UseVisualStyleBackColor = true;
            this.btIntroduceDatos.Click += new System.EventHandler(this.btIntroduceDatos_Click);
            // 
            // laNombreOtro
            // 
            this.laNombreOtro.AutoSize = true;
            this.laNombreOtro.Location = new System.Drawing.Point(11, 239);
            this.laNombreOtro.Name = "laNombreOtro";
            this.laNombreOtro.Size = new System.Drawing.Size(382, 28);
            this.laNombreOtro.TabIndex = 15;
            this.laNombreOtro.Text = "Nombre Mostrado Desde Otro Formulario";
            // 
            // laLocalidadX
            // 
            this.laLocalidadX.AutoSize = true;
            this.laLocalidadX.Location = new System.Drawing.Point(822, 95);
            this.laLocalidadX.Name = "laLocalidadX";
            this.laLocalidadX.Size = new System.Drawing.Size(21, 28);
            this.laLocalidadX.TabIndex = 14;
            this.laLocalidadX.Text = "x";
            // 
            // laCodPostalX
            // 
            this.laCodPostalX.AutoSize = true;
            this.laCodPostalX.Location = new System.Drawing.Point(595, 95);
            this.laCodPostalX.Name = "laCodPostalX";
            this.laCodPostalX.Size = new System.Drawing.Size(21, 28);
            this.laCodPostalX.TabIndex = 13;
            this.laCodPostalX.Text = "x";
            // 
            // laTelefonoX
            // 
            this.laTelefonoX.AutoSize = true;
            this.laTelefonoX.Location = new System.Drawing.Point(595, 123);
            this.laTelefonoX.Name = "laTelefonoX";
            this.laTelefonoX.Size = new System.Drawing.Size(21, 28);
            this.laTelefonoX.TabIndex = 12;
            this.laTelefonoX.Text = "x";
            // 
            // laDireccionX
            // 
            this.laDireccionX.AutoSize = true;
            this.laDireccionX.Location = new System.Drawing.Point(169, 95);
            this.laDireccionX.Name = "laDireccionX";
            this.laDireccionX.Size = new System.Drawing.Size(21, 28);
            this.laDireccionX.TabIndex = 11;
            this.laDireccionX.Text = "x";
            // 
            // laEmailX
            // 
            this.laEmailX.AutoSize = true;
            this.laEmailX.Location = new System.Drawing.Point(169, 123);
            this.laEmailX.Name = "laEmailX";
            this.laEmailX.Size = new System.Drawing.Size(21, 28);
            this.laEmailX.TabIndex = 10;
            this.laEmailX.Text = "x";
            // 
            // laDniCifX
            // 
            this.laDniCifX.AutoSize = true;
            this.laDniCifX.Location = new System.Drawing.Point(595, 67);
            this.laDniCifX.Name = "laDniCifX";
            this.laDniCifX.Size = new System.Drawing.Size(21, 28);
            this.laDniCifX.TabIndex = 9;
            this.laDniCifX.Text = "x";
            // 
            // laNombreX
            // 
            this.laNombreX.AutoSize = true;
            this.laNombreX.Location = new System.Drawing.Point(169, 67);
            this.laNombreX.Name = "laNombreX";
            this.laNombreX.Size = new System.Drawing.Size(21, 28);
            this.laNombreX.TabIndex = 8;
            this.laNombreX.Text = "x";
            // 
            // laDireccion
            // 
            this.laDireccion.AutoSize = true;
            this.laDireccion.Location = new System.Drawing.Point(69, 95);
            this.laDireccion.Name = "laDireccion";
            this.laDireccion.Size = new System.Drawing.Size(94, 28);
            this.laDireccion.TabIndex = 7;
            this.laDireccion.Text = "Dirección";
            // 
            // laEmail
            // 
            this.laEmail.AutoSize = true;
            this.laEmail.Location = new System.Drawing.Point(69, 123);
            this.laEmail.Name = "laEmail";
            this.laEmail.Size = new System.Drawing.Size(59, 28);
            this.laEmail.TabIndex = 6;
            this.laEmail.Text = "email";
            // 
            // laDniCif
            // 
            this.laDniCif.AutoSize = true;
            this.laDniCif.Location = new System.Drawing.Point(455, 67);
            this.laDniCif.Name = "laDniCif";
            this.laDniCif.Size = new System.Drawing.Size(81, 28);
            this.laDniCif.TabIndex = 5;
            this.laDniCif.Text = "DNI/CIF";
            // 
            // laCodPostal
            // 
            this.laCodPostal.AutoSize = true;
            this.laCodPostal.Location = new System.Drawing.Point(455, 95);
            this.laCodPostal.Name = "laCodPostal";
            this.laCodPostal.Size = new System.Drawing.Size(134, 28);
            this.laCodPostal.TabIndex = 4;
            this.laCodPostal.Text = "Código Postal";
            // 
            // laLocalidad
            // 
            this.laLocalidad.AutoSize = true;
            this.laLocalidad.Location = new System.Drawing.Point(720, 95);
            this.laLocalidad.Name = "laLocalidad";
            this.laLocalidad.Size = new System.Drawing.Size(96, 28);
            this.laLocalidad.TabIndex = 3;
            this.laLocalidad.Text = "Localidad";
            // 
            // laTelefono
            // 
            this.laTelefono.AutoSize = true;
            this.laTelefono.Location = new System.Drawing.Point(455, 123);
            this.laTelefono.Name = "laTelefono";
            this.laTelefono.Size = new System.Drawing.Size(86, 28);
            this.laTelefono.TabIndex = 2;
            this.laTelefono.Text = "Teléfono";
            // 
            // laNombre
            // 
            this.laNombre.AutoSize = true;
            this.laNombre.Location = new System.Drawing.Point(69, 67);
            this.laNombre.Name = "laNombre";
            this.laNombre.Size = new System.Drawing.Size(85, 28);
            this.laNombre.TabIndex = 1;
            this.laNombre.Text = "Nombre";
            // 
            // laConvierte
            // 
            this.laConvierte.AutoSize = true;
            this.laConvierte.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laConvierte.Location = new System.Drawing.Point(82, 320);
            this.laConvierte.Name = "laConvierte";
            this.laConvierte.Size = new System.Drawing.Size(312, 20);
            this.laConvierte.TabIndex = 9;
            this.laConvierte.Text = "Convierte Euros a Dólares y Dólares a Euros";
            // 
            // laEuros
            // 
            this.laEuros.AutoSize = true;
            this.laEuros.Location = new System.Drawing.Point(114, 354);
            this.laEuros.Name = "laEuros";
            this.laEuros.Size = new System.Drawing.Size(57, 20);
            this.laEuros.TabIndex = 10;
            this.laEuros.Text = "Euros €";
            // 
            // laDolares
            // 
            this.laDolares.AutoSize = true;
            this.laDolares.Location = new System.Drawing.Point(279, 354);
            this.laDolares.Name = "laDolares";
            this.laDolares.Size = new System.Drawing.Size(72, 20);
            this.laDolares.TabIndex = 11;
            this.laDolares.Text = "Dólares $";
            // 
            // tbEuros
            // 
            this.tbEuros.Location = new System.Drawing.Point(114, 377);
            this.tbEuros.Name = "tbEuros";
            this.tbEuros.Size = new System.Drawing.Size(80, 27);
            this.tbEuros.TabIndex = 18;
            this.tbEuros.Text = "0";
            this.tbEuros.TextChanged += new System.EventHandler(this.tbEuros_TextChanged);
            // 
            // tbDolares
            // 
            this.tbDolares.Location = new System.Drawing.Point(279, 377);
            this.tbDolares.Name = "tbDolares";
            this.tbDolares.Size = new System.Drawing.Size(80, 27);
            this.tbDolares.TabIndex = 19;
            this.tbDolares.Text = "0";
            this.tbDolares.TextChanged += new System.EventHandler(this.tbDolares_TextChanged);
            // 
            // btCambiar
            // 
            this.btCambiar.Location = new System.Drawing.Point(192, 421);
            this.btCambiar.Name = "btCambiar";
            this.btCambiar.Size = new System.Drawing.Size(86, 28);
            this.btCambiar.TabIndex = 18;
            this.btCambiar.Text = "Cambiar";
            this.btCambiar.UseVisualStyleBackColor = true;
            this.btCambiar.Click += new System.EventHandler(this.btCambiar_Click);
            // 
            // gbUltimaCotizacion
            // 
            this.gbUltimaCotizacion.Controls.Add(this.tbEuroDolar);
            this.gbUltimaCotizacion.Controls.Add(this.tbDolarEuro);
            this.gbUltimaCotizacion.Controls.Add(this.laEuroDolar);
            this.gbUltimaCotizacion.Controls.Add(this.laDolarEuro);
            this.gbUltimaCotizacion.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.gbUltimaCotizacion.Location = new System.Drawing.Point(619, 320);
            this.gbUltimaCotizacion.Name = "gbUltimaCotizacion";
            this.gbUltimaCotizacion.Size = new System.Drawing.Size(333, 102);
            this.gbUltimaCotizacion.TabIndex = 20;
            this.gbUltimaCotizacion.TabStop = false;
            this.gbUltimaCotizacion.Text = "Última cotización";
            // 
            // tbEuroDolar
            // 
            this.tbEuroDolar.Location = new System.Drawing.Point(216, 64);
            this.tbEuroDolar.Name = "tbEuroDolar";
            this.tbEuroDolar.Size = new System.Drawing.Size(80, 27);
            this.tbEuroDolar.TabIndex = 23;
            this.tbEuroDolar.Text = "0.984";
            // 
            // tbDolarEuro
            // 
            this.tbDolarEuro.Location = new System.Drawing.Point(216, 31);
            this.tbDolarEuro.Name = "tbDolarEuro";
            this.tbDolarEuro.Size = new System.Drawing.Size(80, 27);
            this.tbDolarEuro.TabIndex = 21;
            this.tbDolarEuro.Text = "1.016";
            // 
            // laEuroDolar
            // 
            this.laEuroDolar.AutoSize = true;
            this.laEuroDolar.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laEuroDolar.Location = new System.Drawing.Point(6, 67);
            this.laEuroDolar.Name = "laEuroDolar";
            this.laEuroDolar.Size = new System.Drawing.Size(212, 20);
            this.laEuroDolar.TabIndex = 22;
            this.laEuroDolar.Text = "Un Euro en Dólares es igual a";
            // 
            // laDolarEuro
            // 
            this.laDolarEuro.AutoSize = true;
            this.laDolarEuro.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.laDolarEuro.Location = new System.Drawing.Point(6, 34);
            this.laDolarEuro.Name = "laDolarEuro";
            this.laDolarEuro.Size = new System.Drawing.Size(204, 20);
            this.laDolarEuro.TabIndex = 21;
            this.laDolarEuro.Text = "Un Dólar en Euros es igual a";
            // 
            // btAcercaDe
            // 
            this.btAcercaDe.Location = new System.Drawing.Point(913, 438);
            this.btAcercaDe.Name = "btAcercaDe";
            this.btAcercaDe.Size = new System.Drawing.Size(86, 28);
            this.btAcercaDe.TabIndex = 21;
            this.btAcercaDe.Text = "Acerca De";
            this.btAcercaDe.UseVisualStyleBackColor = true;
            // 
            // fmEdicion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 478);
            this.Controls.Add(this.btAcercaDe);
            this.Controls.Add(this.gbUltimaCotizacion);
            this.Controls.Add(this.btCambiar);
            this.Controls.Add(this.tbDolares);
            this.Controls.Add(this.tbEuros);
            this.Controls.Add(this.laDolares);
            this.Controls.Add(this.laEuros);
            this.Controls.Add(this.laConvierte);
            this.Controls.Add(this.panel1);
            this.Name = "fmEdicion";
            this.Text = "Edición Datos";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.gbUltimaCotizacion.ResumeLayout(false);
            this.gbUltimaCotizacion.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label laTitulo;
        private Panel panel1;
        private TextBox tbNombre;
        private Button btIntroduceDatos;
        private Label laNombreOtro;
        private Label laLocalidadX;
        private Label laCodPostalX;
        private Label laTelefonoX;
        private Label laDireccionX;
        private Label laEmailX;
        private Label laDniCifX;
        private Label laNombreX;
        private Label laDireccion;
        private Label laEmail;
        private Label laDniCif;
        private Label laCodPostal;
        private Label laLocalidad;
        private Label laTelefono;
        private Label laNombre;
        private Label laConvierte;
        private Label laEuros;
        private Label laDolares;
        private TextBox tbEuros;
        private TextBox tbDolares;
        private Button btCambiar;
        private GroupBox gbUltimaCotizacion;
        private TextBox tbEuroDolar;
        private TextBox tbDolarEuro;
        private Label laEuroDolar;
        private Label laDolarEuro;
        private Button btAcercaDe;
    }
}
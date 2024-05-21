namespace BancoFuerte
{
    partial class Prestamos
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Prestamos));
            this.saludo = new System.Windows.Forms.Label();
            this.btnCerrarSesion = new System.Windows.Forms.Button();
            this.btnConfirmarSolicitud = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.datosPersonales = new System.Windows.Forms.Panel();
            this.ocupacion = new System.Windows.Forms.ComboBox();
            this.ciudad = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datosPrestamos = new System.Windows.Forms.Panel();
            this.monto = new System.Windows.Forms.TextBox();
            this.cuotas = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.datosPersonales.SuspendLayout();
            this.datosPrestamos.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // saludo
            // 
            this.saludo.AutoSize = true;
            this.saludo.Font = new System.Drawing.Font("Segoe UI Historic", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saludo.Location = new System.Drawing.Point(23, 20);
            this.saludo.Name = "saludo";
            this.saludo.Size = new System.Drawing.Size(184, 40);
            this.saludo.TabIndex = 0;
            this.saludo.Text = "Bienvenido, ";
            // 
            // btnCerrarSesion
            // 
            this.btnCerrarSesion.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.btnCerrarSesion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCerrarSesion.ForeColor = System.Drawing.SystemColors.ControlText;
            this.btnCerrarSesion.Location = new System.Drawing.Point(717, 407);
            this.btnCerrarSesion.Name = "btnCerrarSesion";
            this.btnCerrarSesion.Size = new System.Drawing.Size(75, 42);
            this.btnCerrarSesion.TabIndex = 6;
            this.btnCerrarSesion.Text = "Cerrar sesion";
            this.btnCerrarSesion.UseVisualStyleBackColor = false;
            this.btnCerrarSesion.Click += new System.EventHandler(this.btnCerrarSesion_Click);
            // 
            // btnConfirmarSolicitud
            // 
            this.btnConfirmarSolicitud.BackColor = System.Drawing.SystemColors.Info;
            this.btnConfirmarSolicitud.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmarSolicitud.Location = new System.Drawing.Point(331, 355);
            this.btnConfirmarSolicitud.Name = "btnConfirmarSolicitud";
            this.btnConfirmarSolicitud.Size = new System.Drawing.Size(138, 52);
            this.btnConfirmarSolicitud.TabIndex = 7;
            this.btnConfirmarSolicitud.Text = "Confirmar Solicitud";
            this.btnConfirmarSolicitud.UseVisualStyleBackColor = false;
            this.btnConfirmarSolicitud.Click += new System.EventHandler(this.btnConfirmarSolicitud_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label1.Location = new System.Drawing.Point(41, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(144, 21);
            this.label1.TabIndex = 8;
            this.label1.Text = "Datos personales:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Tai Le", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.Highlight;
            this.label2.Location = new System.Drawing.Point(427, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(173, 21);
            this.label2.TabIndex = 9;
            this.label2.Text = "Detalle del prestamo:";
            // 
            // datosPersonales
            // 
            this.datosPersonales.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.datosPersonales.Controls.Add(this.ocupacion);
            this.datosPersonales.Controls.Add(this.ciudad);
            this.datosPersonales.Controls.Add(this.label4);
            this.datosPersonales.Controls.Add(this.label3);
            this.errorProvider1.SetIconAlignment(this.datosPersonales, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.datosPersonales.Location = new System.Drawing.Point(45, 154);
            this.datosPersonales.Name = "datosPersonales";
            this.datosPersonales.Size = new System.Drawing.Size(325, 133);
            this.datosPersonales.TabIndex = 10;
            // 
            // ocupacion
            // 
            this.ocupacion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ocupacion.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ocupacion.FormattingEnabled = true;
            this.ocupacion.Location = new System.Drawing.Point(108, 77);
            this.ocupacion.Name = "ocupacion";
            this.ocupacion.Size = new System.Drawing.Size(154, 21);
            this.ocupacion.TabIndex = 3;
            // 
            // ciudad
            // 
            this.ciudad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ciudad.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ciudad.FormattingEnabled = true;
            this.ciudad.Location = new System.Drawing.Point(108, 25);
            this.ciudad.Name = "ciudad";
            this.ciudad.Size = new System.Drawing.Size(154, 21);
            this.ciudad.TabIndex = 2;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(8, 77);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(94, 18);
            this.label4.TabIndex = 1;
            this.label4.Text = "Ocupacion:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(37, 25);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 18);
            this.label3.TabIndex = 0;
            this.label3.Text = "Ciudad:";
            // 
            // datosPrestamos
            // 
            this.datosPrestamos.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.datosPrestamos.Controls.Add(this.monto);
            this.datosPrestamos.Controls.Add(this.cuotas);
            this.datosPrestamos.Controls.Add(this.label6);
            this.datosPrestamos.Controls.Add(this.label5);
            this.datosPrestamos.Location = new System.Drawing.Point(431, 154);
            this.datosPrestamos.Name = "datosPrestamos";
            this.datosPrestamos.Size = new System.Drawing.Size(325, 133);
            this.datosPrestamos.TabIndex = 11;
            // 
            // monto
            // 
            this.monto.Location = new System.Drawing.Point(108, 28);
            this.monto.Name = "monto";
            this.monto.Size = new System.Drawing.Size(154, 20);
            this.monto.TabIndex = 3;
            // 
            // cuotas
            // 
            this.cuotas.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cuotas.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cuotas.FormattingEnabled = true;
            this.cuotas.Location = new System.Drawing.Point(108, 79);
            this.cuotas.Name = "cuotas";
            this.cuotas.Size = new System.Drawing.Size(154, 21);
            this.cuotas.TabIndex = 2;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(35, 78);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(67, 18);
            this.label6.TabIndex = 1;
            this.label6.Text = "Cuotas:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(41, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(61, 18);
            this.label5.TabIndex = 0;
            this.label5.Text = "Monto:";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Prestamos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.HighlightText;
            this.ClientSize = new System.Drawing.Size(804, 461);
            this.Controls.Add(this.datosPrestamos);
            this.Controls.Add(this.datosPersonales);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnConfirmarSolicitud);
            this.Controls.Add(this.btnCerrarSesion);
            this.Controls.Add(this.saludo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Prestamos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prestamos";
            this.Load += new System.EventHandler(this.Prestamos_Load);
            this.datosPersonales.ResumeLayout(false);
            this.datosPersonales.PerformLayout();
            this.datosPrestamos.ResumeLayout(false);
            this.datosPrestamos.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label saludo;
        private System.Windows.Forms.Button btnCerrarSesion;
        private System.Windows.Forms.Button btnConfirmarSolicitud;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Panel datosPersonales;
        private System.Windows.Forms.Panel datosPrestamos;
        private System.Windows.Forms.ComboBox ocupacion;
        private System.Windows.Forms.ComboBox ciudad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox monto;
        private System.Windows.Forms.ComboBox cuotas;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
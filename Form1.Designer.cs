namespace FUSIIN_S2_Ejercicio1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        private void InitializeComponent()
        {
            this.groupBoxAlbum = new System.Windows.Forms.GroupBox();
            this.btnRegistrarAlbum = new System.Windows.Forms.Button();
            this.txtNombreAlbum = new System.Windows.Forms.TextBox();
            this.txtCodigoAlbum = new System.Windows.Forms.TextBox();
            this.lblNombreAlbum = new System.Windows.Forms.Label();
            this.lblCodigoAlbum = new System.Windows.Forms.Label();
            this.groupBoxCancion = new System.Windows.Forms.GroupBox();
            this.cboAlbumCancion = new System.Windows.Forms.ComboBox();
            this.lblAlbumCancion = new System.Windows.Forms.Label();
            this.btnRegistrarCancion = new System.Windows.Forms.Button();
            this.txtDuracionCancion = new System.Windows.Forms.TextBox();
            this.txtNombreCancion = new System.Windows.Forms.TextBox();
            this.txtCodigoCancion = new System.Windows.Forms.TextBox();
            this.lblDuracionCancion = new System.Windows.Forms.Label();
            this.lblNombreCancion = new System.Windows.Forms.Label();
            this.lblCodigoCancion = new System.Windows.Forms.Label();
            this.groupBoxListas = new System.Windows.Forms.GroupBox();
            this.btnVerCancionesAlbum = new System.Windows.Forms.Button();
            this.cboAlbumConsulta = new System.Windows.Forms.ComboBox();
            this.lblAlbumConsulta = new System.Windows.Forms.Label();
            this.btnMostrarCanciones = new System.Windows.Forms.Button();
            this.btnMostrarAlbumes = new System.Windows.Forms.Button();
            this.lstResultados = new System.Windows.Forms.ListBox();
            this.groupBoxConsultas = new System.Windows.Forms.GroupBox();
            this.btnAlbumesPorCancion = new System.Windows.Forms.Button();
            this.cboCancionConsulta = new System.Windows.Forms.ComboBox();
            this.lblCancionConsulta = new System.Windows.Forms.Label();
            this.btnDuraciones = new System.Windows.Forms.Button();
            this.btnAlbumConMasCanciones = new System.Windows.Forms.Button();
            this.groupBoxAlbum.SuspendLayout();
            this.groupBoxCancion.SuspendLayout();
            this.groupBoxListas.SuspendLayout();
            this.groupBoxConsultas.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBoxAlbum
            // 
            this.groupBoxAlbum.Controls.Add(this.btnRegistrarAlbum);
            this.groupBoxAlbum.Controls.Add(this.txtNombreAlbum);
            this.groupBoxAlbum.Controls.Add(this.txtCodigoAlbum);
            this.groupBoxAlbum.Controls.Add(this.lblNombreAlbum);
            this.groupBoxAlbum.Controls.Add(this.lblCodigoAlbum);
            this.groupBoxAlbum.Location = new System.Drawing.Point(12, 12);
            this.groupBoxAlbum.Name = "groupBoxAlbum";
            this.groupBoxAlbum.Size = new System.Drawing.Size(357, 149);
            this.groupBoxAlbum.TabIndex = 0;
            this.groupBoxAlbum.TabStop = false;
            this.groupBoxAlbum.Text = "Registro de álbum";
            // 
            // btnRegistrarAlbum
            // 
            this.btnRegistrarAlbum.Location = new System.Drawing.Point(114, 102);
            this.btnRegistrarAlbum.Name = "btnRegistrarAlbum";
            this.btnRegistrarAlbum.Size = new System.Drawing.Size(222, 30);
            this.btnRegistrarAlbum.TabIndex = 4;
            this.btnRegistrarAlbum.Text = "Registrar álbum";
            this.btnRegistrarAlbum.UseVisualStyleBackColor = true;
            this.btnRegistrarAlbum.Click += new System.EventHandler(this.btnRegistrarAlbum_Click);
            // 
            // txtNombreAlbum
            // 
            this.txtNombreAlbum.Location = new System.Drawing.Point(114, 64);
            this.txtNombreAlbum.Name = "txtNombreAlbum";
            this.txtNombreAlbum.Size = new System.Drawing.Size(222, 22);
            this.txtNombreAlbum.TabIndex = 3;
            // 
            // txtCodigoAlbum
            // 
            this.txtCodigoAlbum.Location = new System.Drawing.Point(114, 30);
            this.txtCodigoAlbum.Name = "txtCodigoAlbum";
            this.txtCodigoAlbum.Size = new System.Drawing.Size(222, 22);
            this.txtCodigoAlbum.TabIndex = 2;
            // 
            // lblNombreAlbum
            // 
            this.lblNombreAlbum.AutoSize = true;
            this.lblNombreAlbum.Location = new System.Drawing.Point(18, 67);
            this.lblNombreAlbum.Name = "lblNombreAlbum";
            this.lblNombreAlbum.Size = new System.Drawing.Size(56, 16);
            this.lblNombreAlbum.TabIndex = 1;
            this.lblNombreAlbum.Text = "Nombre";
            // 
            // lblCodigoAlbum
            // 
            this.lblCodigoAlbum.AutoSize = true;
            this.lblCodigoAlbum.Location = new System.Drawing.Point(18, 33);
            this.lblCodigoAlbum.Name = "lblCodigoAlbum";
            this.lblCodigoAlbum.Size = new System.Drawing.Size(52, 16);
            this.lblCodigoAlbum.TabIndex = 0;
            this.lblCodigoAlbum.Text = "Código";
            // 
            // groupBoxCancion
            // 
            this.groupBoxCancion.Controls.Add(this.cboAlbumCancion);
            this.groupBoxCancion.Controls.Add(this.lblAlbumCancion);
            this.groupBoxCancion.Controls.Add(this.btnRegistrarCancion);
            this.groupBoxCancion.Controls.Add(this.txtDuracionCancion);
            this.groupBoxCancion.Controls.Add(this.txtNombreCancion);
            this.groupBoxCancion.Controls.Add(this.txtCodigoCancion);
            this.groupBoxCancion.Controls.Add(this.lblDuracionCancion);
            this.groupBoxCancion.Controls.Add(this.lblNombreCancion);
            this.groupBoxCancion.Controls.Add(this.lblCodigoCancion);
            this.groupBoxCancion.Location = new System.Drawing.Point(12, 167);
            this.groupBoxCancion.Name = "groupBoxCancion";
            this.groupBoxCancion.Size = new System.Drawing.Size(357, 228);
            this.groupBoxCancion.TabIndex = 1;
            this.groupBoxCancion.TabStop = false;
            this.groupBoxCancion.Text = "Registro de canción";
            // 
            // cboAlbumCancion
            // 
            this.cboAlbumCancion.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlbumCancion.FormattingEnabled = true;
            this.cboAlbumCancion.Location = new System.Drawing.Point(114, 136);
            this.cboAlbumCancion.Name = "cboAlbumCancion";
            this.cboAlbumCancion.Size = new System.Drawing.Size(222, 24);
            this.cboAlbumCancion.TabIndex = 8;
            // 
            // lblAlbumCancion
            // 
            this.lblAlbumCancion.AutoSize = true;
            this.lblAlbumCancion.Location = new System.Drawing.Point(18, 139);
            this.lblAlbumCancion.Name = "lblAlbumCancion";
            this.lblAlbumCancion.Size = new System.Drawing.Size(45, 16);
            this.lblAlbumCancion.TabIndex = 7;
            this.lblAlbumCancion.Text = "Álbum";
            // 
            // btnRegistrarCancion
            // 
            this.btnRegistrarCancion.Location = new System.Drawing.Point(114, 180);
            this.btnRegistrarCancion.Name = "btnRegistrarCancion";
            this.btnRegistrarCancion.Size = new System.Drawing.Size(222, 30);
            this.btnRegistrarCancion.TabIndex = 6;
            this.btnRegistrarCancion.Text = "Registrar canción";
            this.btnRegistrarCancion.UseVisualStyleBackColor = true;
            this.btnRegistrarCancion.Click += new System.EventHandler(this.btnRegistrarCancion_Click);
            // 
            // txtDuracionCancion
            // 
            this.txtDuracionCancion.Location = new System.Drawing.Point(114, 100);
            this.txtDuracionCancion.Name = "txtDuracionCancion";
            this.txtDuracionCancion.Size = new System.Drawing.Size(222, 22);
            this.txtDuracionCancion.TabIndex = 5;
            // 
            // txtNombreCancion
            // 
            this.txtNombreCancion.Location = new System.Drawing.Point(114, 64);
            this.txtNombreCancion.Name = "txtNombreCancion";
            this.txtNombreCancion.Size = new System.Drawing.Size(222, 22);
            this.txtNombreCancion.TabIndex = 4;
            // 
            // txtCodigoCancion
            // 
            this.txtCodigoCancion.Location = new System.Drawing.Point(114, 30);
            this.txtCodigoCancion.Name = "txtCodigoCancion";
            this.txtCodigoCancion.Size = new System.Drawing.Size(222, 22);
            this.txtCodigoCancion.TabIndex = 3;
            // 
            // lblDuracionCancion
            // 
            this.lblDuracionCancion.AutoSize = true;
            this.lblDuracionCancion.Location = new System.Drawing.Point(18, 103);
            this.lblDuracionCancion.Name = "lblDuracionCancion";
            this.lblDuracionCancion.Size = new System.Drawing.Size(62, 16);
            this.lblDuracionCancion.TabIndex = 2;
            this.lblDuracionCancion.Text = "Duración";
            // 
            // lblNombreCancion
            // 
            this.lblNombreCancion.AutoSize = true;
            this.lblNombreCancion.Location = new System.Drawing.Point(18, 67);
            this.lblNombreCancion.Name = "lblNombreCancion";
            this.lblNombreCancion.Size = new System.Drawing.Size(56, 16);
            this.lblNombreCancion.TabIndex = 1;
            this.lblNombreCancion.Text = "Nombre";
            // 
            // lblCodigoCancion
            // 
            this.lblCodigoCancion.AutoSize = true;
            this.lblCodigoCancion.Location = new System.Drawing.Point(18, 33);
            this.lblCodigoCancion.Name = "lblCodigoCancion";
            this.lblCodigoCancion.Size = new System.Drawing.Size(52, 16);
            this.lblCodigoCancion.TabIndex = 0;
            this.lblCodigoCancion.Text = "Código";
            // 
            // groupBoxListas
            // 
            this.groupBoxListas.Controls.Add(this.btnVerCancionesAlbum);
            this.groupBoxListas.Controls.Add(this.cboAlbumConsulta);
            this.groupBoxListas.Controls.Add(this.lblAlbumConsulta);
            this.groupBoxListas.Controls.Add(this.btnMostrarCanciones);
            this.groupBoxListas.Controls.Add(this.btnMostrarAlbumes);
            this.groupBoxListas.Controls.Add(this.lstResultados);
            this.groupBoxListas.Location = new System.Drawing.Point(390, 12);
            this.groupBoxListas.Name = "groupBoxListas";
            this.groupBoxListas.Size = new System.Drawing.Size(534, 300);
            this.groupBoxListas.TabIndex = 2;
            this.groupBoxListas.TabStop = false;
            this.groupBoxListas.Text = "Listas";
            // 
            // btnVerCancionesAlbum
            // 
            this.btnVerCancionesAlbum.Location = new System.Drawing.Point(355, 257);
            this.btnVerCancionesAlbum.Name = "btnVerCancionesAlbum";
            this.btnVerCancionesAlbum.Size = new System.Drawing.Size(159, 30);
            this.btnVerCancionesAlbum.TabIndex = 5;
            this.btnVerCancionesAlbum.Text = "Ver canciones";
            this.btnVerCancionesAlbum.UseVisualStyleBackColor = true;
            this.btnVerCancionesAlbum.Click += new System.EventHandler(this.btnVerCancionesAlbum_Click);
            // 
            // cboAlbumConsulta
            // 
            this.cboAlbumConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboAlbumConsulta.FormattingEnabled = true;
            this.cboAlbumConsulta.Location = new System.Drawing.Point(120, 260);
            this.cboAlbumConsulta.Name = "cboAlbumConsulta";
            this.cboAlbumConsulta.Size = new System.Drawing.Size(219, 24);
            this.cboAlbumConsulta.TabIndex = 4;
            // 
            // lblAlbumConsulta
            // 
            this.lblAlbumConsulta.AutoSize = true;
            this.lblAlbumConsulta.Location = new System.Drawing.Point(18, 263);
            this.lblAlbumConsulta.Name = "lblAlbumConsulta";
            this.lblAlbumConsulta.Size = new System.Drawing.Size(94, 16);
            this.lblAlbumConsulta.TabIndex = 3;
            this.lblAlbumConsulta.Text = "Álbum elegido";
            // 
            // btnMostrarCanciones
            // 
            this.btnMostrarCanciones.Location = new System.Drawing.Point(273, 28);
            this.btnMostrarCanciones.Name = "btnMostrarCanciones";
            this.btnMostrarCanciones.Size = new System.Drawing.Size(241, 30);
            this.btnMostrarCanciones.TabIndex = 2;
            this.btnMostrarCanciones.Text = "Mostrar nombres de canciones";
            this.btnMostrarCanciones.UseVisualStyleBackColor = true;
            this.btnMostrarCanciones.Click += new System.EventHandler(this.btnMostrarCanciones_Click);
            // 
            // btnMostrarAlbumes
            // 
            this.btnMostrarAlbumes.Location = new System.Drawing.Point(21, 28);
            this.btnMostrarAlbumes.Name = "btnMostrarAlbumes";
            this.btnMostrarAlbumes.Size = new System.Drawing.Size(237, 30);
            this.btnMostrarAlbumes.TabIndex = 1;
            this.btnMostrarAlbumes.Text = "Mostrar álbumes";
            this.btnMostrarAlbumes.UseVisualStyleBackColor = true;
            this.btnMostrarAlbumes.Click += new System.EventHandler(this.btnMostrarAlbumes_Click);
            // 
            // lstResultados
            // 
            this.lstResultados.FormattingEnabled = true;
            this.lstResultados.ItemHeight = 16;
            this.lstResultados.Location = new System.Drawing.Point(21, 72);
            this.lstResultados.Name = "lstResultados";
            this.lstResultados.Size = new System.Drawing.Size(493, 164);
            this.lstResultados.TabIndex = 0;
            // 
            // groupBoxConsultas
            // 
            this.groupBoxConsultas.Controls.Add(this.btnAlbumesPorCancion);
            this.groupBoxConsultas.Controls.Add(this.cboCancionConsulta);
            this.groupBoxConsultas.Controls.Add(this.lblCancionConsulta);
            this.groupBoxConsultas.Controls.Add(this.btnDuraciones);
            this.groupBoxConsultas.Controls.Add(this.btnAlbumConMasCanciones);
            this.groupBoxConsultas.Location = new System.Drawing.Point(390, 318);
            this.groupBoxConsultas.Name = "groupBoxConsultas";
            this.groupBoxConsultas.Size = new System.Drawing.Size(534, 151);
            this.groupBoxConsultas.TabIndex = 3;
            this.groupBoxConsultas.TabStop = false;
            this.groupBoxConsultas.Text = "Consultas";
            // 
            // btnAlbumesPorCancion
            // 
            this.btnAlbumesPorCancion.Location = new System.Drawing.Point(355, 99);
            this.btnAlbumesPorCancion.Name = "btnAlbumesPorCancion";
            this.btnAlbumesPorCancion.Size = new System.Drawing.Size(159, 30);
            this.btnAlbumesPorCancion.TabIndex = 4;
            this.btnAlbumesPorCancion.Text = "Buscar álbumes";
            this.btnAlbumesPorCancion.UseVisualStyleBackColor = true;
            this.btnAlbumesPorCancion.Click += new System.EventHandler(this.btnAlbumesPorCancion_Click);
            // 
            // cboCancionConsulta
            // 
            this.cboCancionConsulta.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCancionConsulta.FormattingEnabled = true;
            this.cboCancionConsulta.Location = new System.Drawing.Point(120, 102);
            this.cboCancionConsulta.Name = "cboCancionConsulta";
            this.cboCancionConsulta.Size = new System.Drawing.Size(219, 24);
            this.cboCancionConsulta.TabIndex = 3;
            // 
            // lblCancionConsulta
            // 
            this.lblCancionConsulta.AutoSize = true;
            this.lblCancionConsulta.Location = new System.Drawing.Point(18, 105);
            this.lblCancionConsulta.Name = "lblCancionConsulta";
            this.lblCancionConsulta.Size = new System.Drawing.Size(99, 16);
            this.lblCancionConsulta.TabIndex = 2;
            this.lblCancionConsulta.Text = "Canción (cód.)";
            // 
            // btnDuraciones
            // 
            this.btnDuraciones.Location = new System.Drawing.Point(273, 33);
            this.btnDuraciones.Name = "btnDuraciones";
            this.btnDuraciones.Size = new System.Drawing.Size(241, 36);
            this.btnDuraciones.TabIndex = 1;
            this.btnDuraciones.Text = "Canción de mayor y menor duración";
            this.btnDuraciones.UseVisualStyleBackColor = true;
            this.btnDuraciones.Click += new System.EventHandler(this.btnDuraciones_Click);
            // 
            // btnAlbumConMasCanciones
            // 
            this.btnAlbumConMasCanciones.Location = new System.Drawing.Point(21, 33);
            this.btnAlbumConMasCanciones.Name = "btnAlbumConMasCanciones";
            this.btnAlbumConMasCanciones.Size = new System.Drawing.Size(237, 36);
            this.btnAlbumConMasCanciones.TabIndex = 0;
            this.btnAlbumConMasCanciones.Text = "Álbum con más canciones";
            this.btnAlbumConMasCanciones.UseVisualStyleBackColor = true;
            this.btnAlbumConMasCanciones.Click += new System.EventHandler(this.btnAlbumConMasCanciones_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(938, 481);
            this.Controls.Add(this.groupBoxConsultas);
            this.Controls.Add(this.groupBoxListas);
            this.Controls.Add(this.groupBoxCancion);
            this.Controls.Add(this.groupBoxAlbum);
            this.Name = "Form1";
            this.Text = "Gestión de álbumes musicales";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxAlbum.ResumeLayout(false);
            this.groupBoxAlbum.PerformLayout();
            this.groupBoxCancion.ResumeLayout(false);
            this.groupBoxCancion.PerformLayout();
            this.groupBoxListas.ResumeLayout(false);
            this.groupBoxListas.PerformLayout();
            this.groupBoxConsultas.ResumeLayout(false);
            this.groupBoxConsultas.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxAlbum;
        private System.Windows.Forms.Button btnRegistrarAlbum;
        private System.Windows.Forms.TextBox txtNombreAlbum;
        private System.Windows.Forms.TextBox txtCodigoAlbum;
        private System.Windows.Forms.Label lblNombreAlbum;
        private System.Windows.Forms.Label lblCodigoAlbum;
        private System.Windows.Forms.GroupBox groupBoxCancion;
        private System.Windows.Forms.ComboBox cboAlbumCancion;
        private System.Windows.Forms.Label lblAlbumCancion;
        private System.Windows.Forms.Button btnRegistrarCancion;
        private System.Windows.Forms.TextBox txtDuracionCancion;
        private System.Windows.Forms.TextBox txtNombreCancion;
        private System.Windows.Forms.TextBox txtCodigoCancion;
        private System.Windows.Forms.Label lblDuracionCancion;
        private System.Windows.Forms.Label lblNombreCancion;
        private System.Windows.Forms.Label lblCodigoCancion;
        private System.Windows.Forms.GroupBox groupBoxListas;
        private System.Windows.Forms.Button btnVerCancionesAlbum;
        private System.Windows.Forms.ComboBox cboAlbumConsulta;
        private System.Windows.Forms.Label lblAlbumConsulta;
        private System.Windows.Forms.Button btnMostrarCanciones;
        private System.Windows.Forms.Button btnMostrarAlbumes;
        private System.Windows.Forms.ListBox lstResultados;
        private System.Windows.Forms.GroupBox groupBoxConsultas;
        private System.Windows.Forms.Button btnAlbumesPorCancion;
        private System.Windows.Forms.ComboBox cboCancionConsulta;
        private System.Windows.Forms.Label lblCancionConsulta;
        private System.Windows.Forms.Button btnDuraciones;
        private System.Windows.Forms.Button btnAlbumConMasCanciones;
    }
}

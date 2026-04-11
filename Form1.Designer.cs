namespace FUSIIN_S2_Ejercicio1
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.cboTipoServicio = new System.Windows.Forms.ComboBox();
            this.cboTipoVehiculo = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPromedioLavado = new System.Windows.Forms.Label();
            this.lblMenorDemanda = new System.Windows.Forms.Label();
            this.lblSiliconas = new System.Windows.Forms.Label();
            this.lblEncerados = new System.Windows.Forms.Label();
            this.lblLavados = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.dgwAtenciones = new System.Windows.Forms.DataGridView();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtenciones)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnRegistrar);
            this.groupBox1.Controls.Add(this.cboTipoServicio);
            this.groupBox1.Controls.Add(this.cboTipoVehiculo);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(309, 134);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Registro";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(100, 87);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(193, 29);
            this.btnRegistrar.TabIndex = 4;
            this.btnRegistrar.Text = "Registrar";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            // 
            // cboTipoServicio
            // 
            this.cboTipoServicio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoServicio.FormattingEnabled = true;
            this.cboTipoServicio.Location = new System.Drawing.Point(100, 57);
            this.cboTipoServicio.Name = "cboTipoServicio";
            this.cboTipoServicio.Size = new System.Drawing.Size(193, 24);
            this.cboTipoServicio.TabIndex = 3;
            // 
            // cboTipoVehiculo
            // 
            this.cboTipoVehiculo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboTipoVehiculo.FormattingEnabled = true;
            this.cboTipoVehiculo.Location = new System.Drawing.Point(100, 25);
            this.cboTipoVehiculo.Name = "cboTipoVehiculo";
            this.cboTipoVehiculo.Size = new System.Drawing.Size(193, 24);
            this.cboTipoVehiculo.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 61);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Servicio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Vehículo";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.lblPromedioLavado);
            this.groupBox2.Controls.Add(this.lblMenorDemanda);
            this.groupBox2.Controls.Add(this.lblSiliconas);
            this.groupBox2.Controls.Add(this.lblEncerados);
            this.groupBox2.Controls.Add(this.lblLavados);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Location = new System.Drawing.Point(12, 152);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(309, 175);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Reporte";
            // 
            // lblPromedioLavado
            // 
            this.lblPromedioLavado.Location = new System.Drawing.Point(244, 136);
            this.lblPromedioLavado.Name = "lblPromedioLavado";
            this.lblPromedioLavado.Size = new System.Drawing.Size(43, 25);
            this.lblPromedioLavado.TabIndex = 9;
            this.lblPromedioLavado.Text = "0";
            this.lblPromedioLavado.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblMenorDemanda
            // 
            this.lblMenorDemanda.Location = new System.Drawing.Point(223, 106);
            this.lblMenorDemanda.Name = "lblMenorDemanda";
            this.lblMenorDemanda.Size = new System.Drawing.Size(64, 25);
            this.lblMenorDemanda.TabIndex = 8;
            this.lblMenorDemanda.Text = "0";
            this.lblMenorDemanda.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblSiliconas
            // 
            this.lblSiliconas.Location = new System.Drawing.Point(244, 76);
            this.lblSiliconas.Name = "lblSiliconas";
            this.lblSiliconas.Size = new System.Drawing.Size(43, 25);
            this.lblSiliconas.TabIndex = 7;
            this.lblSiliconas.Text = "0";
            this.lblSiliconas.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblEncerados
            // 
            this.lblEncerados.Location = new System.Drawing.Point(244, 49);
            this.lblEncerados.Name = "lblEncerados";
            this.lblEncerados.Size = new System.Drawing.Size(43, 25);
            this.lblEncerados.TabIndex = 6;
            this.lblEncerados.Text = "0";
            this.lblEncerados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLavados
            // 
            this.lblLavados.Location = new System.Drawing.Point(244, 24);
            this.lblLavados.Name = "lblLavados";
            this.lblLavados.Size = new System.Drawing.Size(43, 25);
            this.lblLavados.TabIndex = 5;
            this.lblLavados.Text = "0";
            this.lblLavados.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(20, 140);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(177, 16);
            this.label7.TabIndex = 4;
            this.label7.Text = "Monto promedio por Lavado";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(20, 110);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(197, 16);
            this.label6.TabIndex = 3;
            this.label6.Text = "Servicios menos demandados: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(20, 80);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(213, 16);
            this.label5.TabIndex = 2;
            this.label5.Text = "Cantidad de servicios de Silicona: ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(231, 16);
            this.label4.TabIndex = 1;
            this.label4.Text = "Cantidad de servicios de Encerados: ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(218, 16);
            this.label3.TabIndex = 0;
            this.label3.Text = "Cantidad de servicios de Lavados: ";
            // 
            // dgwAtenciones
            // 
            this.dgwAtenciones.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwAtenciones.Location = new System.Drawing.Point(347, 21);
            this.dgwAtenciones.Name = "dgwAtenciones";
            this.dgwAtenciones.RowHeadersWidth = 51;
            this.dgwAtenciones.RowTemplate.Height = 24;
            this.dgwAtenciones.Size = new System.Drawing.Size(362, 306);
            this.dgwAtenciones.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(739, 351);
            this.Controls.Add(this.dgwAtenciones);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Registro de Atenciones";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgwAtenciones)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.ComboBox cboTipoServicio;
        private System.Windows.Forms.ComboBox cboTipoVehiculo;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label lblPromedioLavado;
        private System.Windows.Forms.Label lblMenorDemanda;
        private System.Windows.Forms.Label lblSiliconas;
        private System.Windows.Forms.Label lblEncerados;
        private System.Windows.Forms.Label lblLavados;
        private System.Windows.Forms.DataGridView dgwAtenciones;
    }
}


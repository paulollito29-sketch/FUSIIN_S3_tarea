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
            this.groupBoxRegistro = new System.Windows.Forms.GroupBox();
            this.btnRegistrar = new System.Windows.Forms.Button();
            this.txtPrecio = new System.Windows.Forms.TextBox();
            this.txtStock = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.txtCodigo = new System.Windows.Forms.TextBox();
            this.lblPrecio = new System.Windows.Forms.Label();
            this.lblStock = new System.Windows.Forms.Label();
            this.lblNombre = new System.Windows.Forms.Label();
            this.lblCodigo = new System.Windows.Forms.Label();
            this.groupBoxOperaciones = new System.Windows.Forms.GroupBox();
            this.btnOrdenar = new System.Windows.Forms.Button();
            this.btnEliminarTodos = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnBuscar = new System.Windows.Forms.Button();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.lblBuscar = new System.Windows.Forms.Label();
            this.dgvMuebles = new System.Windows.Forms.DataGridView();
            this.lblTotalMueblesTitulo = new System.Windows.Forms.Label();
            this.lblTotalStockTitulo = new System.Windows.Forms.Label();
            this.lblTotalMuebles = new System.Windows.Forms.Label();
            this.lblTotalStock = new System.Windows.Forms.Label();
            this.groupBoxRegistro.SuspendLayout();
            this.groupBoxOperaciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuebles)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxRegistro
            // 
            this.groupBoxRegistro.Controls.Add(this.btnRegistrar);
            this.groupBoxRegistro.Controls.Add(this.txtPrecio);
            this.groupBoxRegistro.Controls.Add(this.txtStock);
            this.groupBoxRegistro.Controls.Add(this.txtNombre);
            this.groupBoxRegistro.Controls.Add(this.txtCodigo);
            this.groupBoxRegistro.Controls.Add(this.lblPrecio);
            this.groupBoxRegistro.Controls.Add(this.lblStock);
            this.groupBoxRegistro.Controls.Add(this.lblNombre);
            this.groupBoxRegistro.Controls.Add(this.lblCodigo);
            this.groupBoxRegistro.Location = new System.Drawing.Point(12, 12);
            this.groupBoxRegistro.Name = "groupBoxRegistro";
            this.groupBoxRegistro.Size = new System.Drawing.Size(370, 205);
            this.groupBoxRegistro.TabIndex = 0;
            this.groupBoxRegistro.TabStop = false;
            this.groupBoxRegistro.Text = "Registro de muebles";
            // 
            // btnRegistrar
            // 
            this.btnRegistrar.Location = new System.Drawing.Point(118, 160);
            this.btnRegistrar.Name = "btnRegistrar";
            this.btnRegistrar.Size = new System.Drawing.Size(228, 30);
            this.btnRegistrar.TabIndex = 8;
            this.btnRegistrar.Text = "Registrar mueble";
            this.btnRegistrar.UseVisualStyleBackColor = true;
            this.btnRegistrar.Click += new System.EventHandler(this.btnRegistrar_Click);
            // 
            // txtPrecio
            // 
            this.txtPrecio.Location = new System.Drawing.Point(118, 124);
            this.txtPrecio.Name = "txtPrecio";
            this.txtPrecio.Size = new System.Drawing.Size(228, 22);
            this.txtPrecio.TabIndex = 7;
            // 
            // txtStock
            // 
            this.txtStock.Location = new System.Drawing.Point(118, 92);
            this.txtStock.Name = "txtStock";
            this.txtStock.Size = new System.Drawing.Size(228, 22);
            this.txtStock.TabIndex = 6;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(118, 60);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(228, 22);
            this.txtNombre.TabIndex = 5;
            // 
            // txtCodigo
            // 
            this.txtCodigo.Location = new System.Drawing.Point(118, 28);
            this.txtCodigo.Name = "txtCodigo";
            this.txtCodigo.Size = new System.Drawing.Size(228, 22);
            this.txtCodigo.TabIndex = 4;
            // 
            // lblPrecio
            // 
            this.lblPrecio.AutoSize = true;
            this.lblPrecio.Location = new System.Drawing.Point(20, 127);
            this.lblPrecio.Name = "lblPrecio";
            this.lblPrecio.Size = new System.Drawing.Size(46, 16);
            this.lblPrecio.TabIndex = 3;
            this.lblPrecio.Text = "Precio";
            // 
            // lblStock
            // 
            this.lblStock.AutoSize = true;
            this.lblStock.Location = new System.Drawing.Point(20, 95);
            this.lblStock.Name = "lblStock";
            this.lblStock.Size = new System.Drawing.Size(41, 16);
            this.lblStock.TabIndex = 2;
            this.lblStock.Text = "Stock";
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(20, 63);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(56, 16);
            this.lblNombre.TabIndex = 1;
            this.lblNombre.Text = "Nombre";
            // 
            // lblCodigo
            // 
            this.lblCodigo.AutoSize = true;
            this.lblCodigo.Location = new System.Drawing.Point(20, 31);
            this.lblCodigo.Name = "lblCodigo";
            this.lblCodigo.Size = new System.Drawing.Size(52, 16);
            this.lblCodigo.TabIndex = 0;
            this.lblCodigo.Text = "Código";
            // 
            // groupBoxOperaciones
            // 
            this.groupBoxOperaciones.Controls.Add(this.btnOrdenar);
            this.groupBoxOperaciones.Controls.Add(this.btnEliminarTodos);
            this.groupBoxOperaciones.Controls.Add(this.btnEliminar);
            this.groupBoxOperaciones.Controls.Add(this.btnBuscar);
            this.groupBoxOperaciones.Controls.Add(this.txtBuscar);
            this.groupBoxOperaciones.Controls.Add(this.lblBuscar);
            this.groupBoxOperaciones.Location = new System.Drawing.Point(12, 223);
            this.groupBoxOperaciones.Name = "groupBoxOperaciones";
            this.groupBoxOperaciones.Size = new System.Drawing.Size(370, 172);
            this.groupBoxOperaciones.TabIndex = 1;
            this.groupBoxOperaciones.TabStop = false;
            this.groupBoxOperaciones.Text = "Operaciones";
            // 
            // btnOrdenar
            // 
            this.btnOrdenar.Location = new System.Drawing.Point(23, 128);
            this.btnOrdenar.Name = "btnOrdenar";
            this.btnOrdenar.Size = new System.Drawing.Size(323, 30);
            this.btnOrdenar.TabIndex = 5;
            this.btnOrdenar.Text = "Ordenar por precio (descendente)";
            this.btnOrdenar.UseVisualStyleBackColor = true;
            this.btnOrdenar.Click += new System.EventHandler(this.btnOrdenar_Click);
            // 
            // btnEliminarTodos
            // 
            this.btnEliminarTodos.Location = new System.Drawing.Point(187, 85);
            this.btnEliminarTodos.Name = "btnEliminarTodos";
            this.btnEliminarTodos.Size = new System.Drawing.Size(159, 30);
            this.btnEliminarTodos.TabIndex = 4;
            this.btnEliminarTodos.Text = "Eliminar todos";
            this.btnEliminarTodos.UseVisualStyleBackColor = true;
            this.btnEliminarTodos.Click += new System.EventHandler(this.btnEliminarTodos_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(23, 85);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(159, 30);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar seleccionado";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(266, 38);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(80, 30);
            this.btnBuscar.TabIndex = 2;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // txtBuscar
            // 
            this.txtBuscar.Location = new System.Drawing.Point(88, 42);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(172, 22);
            this.txtBuscar.TabIndex = 1;
            // 
            // lblBuscar
            // 
            this.lblBuscar.AutoSize = true;
            this.lblBuscar.Location = new System.Drawing.Point(20, 45);
            this.lblBuscar.Name = "lblBuscar";
            this.lblBuscar.Size = new System.Drawing.Size(50, 16);
            this.lblBuscar.TabIndex = 0;
            this.lblBuscar.Text = "Buscar";
            // 
            // dgvMuebles
            // 
            this.dgvMuebles.AllowUserToAddRows = false;
            this.dgvMuebles.AllowUserToDeleteRows = false;
            this.dgvMuebles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvMuebles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMuebles.Location = new System.Drawing.Point(401, 21);
            this.dgvMuebles.MultiSelect = false;
            this.dgvMuebles.Name = "dgvMuebles";
            this.dgvMuebles.ReadOnly = true;
            this.dgvMuebles.RowHeadersWidth = 51;
            this.dgvMuebles.RowTemplate.Height = 24;
            this.dgvMuebles.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvMuebles.Size = new System.Drawing.Size(545, 324);
            this.dgvMuebles.TabIndex = 2;
            // 
            // lblTotalMueblesTitulo
            // 
            this.lblTotalMueblesTitulo.AutoSize = true;
            this.lblTotalMueblesTitulo.Location = new System.Drawing.Point(398, 363);
            this.lblTotalMueblesTitulo.Name = "lblTotalMueblesTitulo";
            this.lblTotalMueblesTitulo.Size = new System.Drawing.Size(169, 16);
            this.lblTotalMueblesTitulo.TabIndex = 3;
            this.lblTotalMueblesTitulo.Text = "Total muebles registrados:";
            // 
            // lblTotalStockTitulo
            // 
            this.lblTotalStockTitulo.AutoSize = true;
            this.lblTotalStockTitulo.Location = new System.Drawing.Point(398, 389);
            this.lblTotalStockTitulo.Name = "lblTotalStockTitulo";
            this.lblTotalStockTitulo.Size = new System.Drawing.Size(145, 16);
            this.lblTotalStockTitulo.TabIndex = 4;
            this.lblTotalStockTitulo.Text = "Total unidades en stock:";
            // 
            // lblTotalMuebles
            // 
            this.lblTotalMuebles.Location = new System.Drawing.Point(582, 359);
            this.lblTotalMuebles.Name = "lblTotalMuebles";
            this.lblTotalMuebles.Size = new System.Drawing.Size(95, 23);
            this.lblTotalMuebles.TabIndex = 5;
            this.lblTotalMuebles.Text = "0";
            this.lblTotalMuebles.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblTotalStock
            // 
            this.lblTotalStock.Location = new System.Drawing.Point(582, 385);
            this.lblTotalStock.Name = "lblTotalStock";
            this.lblTotalStock.Size = new System.Drawing.Size(95, 23);
            this.lblTotalStock.TabIndex = 6;
            this.lblTotalStock.Text = "0";
            this.lblTotalStock.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(968, 421);
            this.Controls.Add(this.lblTotalStock);
            this.Controls.Add(this.lblTotalMuebles);
            this.Controls.Add(this.lblTotalStockTitulo);
            this.Controls.Add(this.lblTotalMueblesTitulo);
            this.Controls.Add(this.dgvMuebles);
            this.Controls.Add(this.groupBoxOperaciones);
            this.Controls.Add(this.groupBoxRegistro);
            this.Name = "Form1";
            this.Text = "Sistema de Inventario - Tienda de Muebles";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBoxRegistro.ResumeLayout(false);
            this.groupBoxRegistro.PerformLayout();
            this.groupBoxOperaciones.ResumeLayout(false);
            this.groupBoxOperaciones.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMuebles)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxRegistro;
        private System.Windows.Forms.Button btnRegistrar;
        private System.Windows.Forms.TextBox txtPrecio;
        private System.Windows.Forms.TextBox txtStock;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCodigo;
        private System.Windows.Forms.Label lblPrecio;
        private System.Windows.Forms.Label lblStock;
        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.Label lblCodigo;
        private System.Windows.Forms.GroupBox groupBoxOperaciones;
        private System.Windows.Forms.Button btnOrdenar;
        private System.Windows.Forms.Button btnEliminarTodos;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnBuscar;
        private System.Windows.Forms.TextBox txtBuscar;
        private System.Windows.Forms.Label lblBuscar;
        private System.Windows.Forms.DataGridView dgvMuebles;
        private System.Windows.Forms.Label lblTotalMueblesTitulo;
        private System.Windows.Forms.Label lblTotalStockTitulo;
        private System.Windows.Forms.Label lblTotalMuebles;
        private System.Windows.Forms.Label lblTotalStock;
    }
}

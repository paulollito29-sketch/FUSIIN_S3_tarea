namespace FUSIIN_S2_Ejercicio1
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null)) components.Dispose();
            base.Dispose(disposing);
        }

        private void InitializeComponent()
        {
            this.txtCodigoVideojuego = new System.Windows.Forms.TextBox();
            this.txtNombreVideojuego = new System.Windows.Forms.TextBox();
            this.btnRegistrarVideojuego = new System.Windows.Forms.Button();
            this.txtDniJugador = new System.Windows.Forms.TextBox();
            this.txtAliasJugador = new System.Windows.Forms.TextBox();
            this.cboVideojuegos = new System.Windows.Forms.ComboBox();
            this.btnRegistrarJugador = new System.Windows.Forms.Button();
            this.btnMostrarVideojuegos = new System.Windows.Forms.Button();
            this.btnMostrarJugadores = new System.Windows.Forms.Button();
            this.txtConsultaDni = new System.Windows.Forms.TextBox();
            this.btnBuscarPorDni = new System.Windows.Forms.Button();
            this.btnTopVideojuegos = new System.Windows.Forms.Button();
            this.dgvVideojuegos = new System.Windows.Forms.DataGridView();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.dgvResultados = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).BeginInit();
            this.SuspendLayout();
            this.txtCodigoVideojuego.Location = new System.Drawing.Point(12, 12);
            this.txtCodigoVideojuego.Size = new System.Drawing.Size(140, 22);
            this.txtNombreVideojuego.Location = new System.Drawing.Point(160, 12);
            this.txtNombreVideojuego.Size = new System.Drawing.Size(220, 22);
            this.btnRegistrarVideojuego.Location = new System.Drawing.Point(390, 10);
            this.btnRegistrarVideojuego.Size = new System.Drawing.Size(170, 27);
            this.btnRegistrarVideojuego.Text = "Registrar videojuego";
            this.btnRegistrarVideojuego.Click += new System.EventHandler(this.btnRegistrarVideojuego_Click);
            this.txtDniJugador.Location = new System.Drawing.Point(12, 50);
            this.txtDniJugador.Size = new System.Drawing.Size(140, 22);
            this.txtAliasJugador.Location = new System.Drawing.Point(160, 50);
            this.txtAliasJugador.Size = new System.Drawing.Size(140, 22);
            this.cboVideojuegos.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboVideojuegos.Location = new System.Drawing.Point(310, 50);
            this.cboVideojuegos.Size = new System.Drawing.Size(180, 24);
            this.btnRegistrarJugador.Location = new System.Drawing.Point(500, 48);
            this.btnRegistrarJugador.Size = new System.Drawing.Size(150, 27);
            this.btnRegistrarJugador.Text = "Registrar jugador";
            this.btnRegistrarJugador.Click += new System.EventHandler(this.btnRegistrarJugador_Click);
            this.btnMostrarVideojuegos.Location = new System.Drawing.Point(12, 87);
            this.btnMostrarVideojuegos.Size = new System.Drawing.Size(170, 27);
            this.btnMostrarVideojuegos.Text = "Mostrar videojuegos";
            this.btnMostrarVideojuegos.Click += new System.EventHandler(this.btnMostrarVideojuegos_Click);
            this.btnMostrarJugadores.Location = new System.Drawing.Point(190, 87);
            this.btnMostrarJugadores.Size = new System.Drawing.Size(170, 27);
            this.btnMostrarJugadores.Text = "Mostrar jugadores";
            this.btnMostrarJugadores.Click += new System.EventHandler(this.btnMostrarJugadores_Click);
            this.txtConsultaDni.Location = new System.Drawing.Point(370, 90);
            this.txtConsultaDni.Size = new System.Drawing.Size(120, 22);
            this.btnBuscarPorDni.Location = new System.Drawing.Point(500, 87);
            this.btnBuscarPorDni.Size = new System.Drawing.Size(180, 27);
            this.btnBuscarPorDni.Text = "Videojuegos por DNI";
            this.btnBuscarPorDni.Click += new System.EventHandler(this.btnBuscarPorDni_Click);
            this.btnTopVideojuegos.Location = new System.Drawing.Point(690, 87);
            this.btnTopVideojuegos.Size = new System.Drawing.Size(200, 27);
            this.btnTopVideojuegos.Text = "Videojuegos con más jugadores";
            this.btnTopVideojuegos.Click += new System.EventHandler(this.btnTopVideojuegos_Click);
            this.dgvVideojuegos.Location = new System.Drawing.Point(12, 130);
            this.dgvVideojuegos.Size = new System.Drawing.Size(420, 180);
            this.dgvJugadores.Location = new System.Drawing.Point(440, 130);
            this.dgvJugadores.Size = new System.Drawing.Size(450, 180);
            this.dgvResultados.Location = new System.Drawing.Point(12, 320);
            this.dgvResultados.Size = new System.Drawing.Size(878, 170);
            this.ClientSize = new System.Drawing.Size(905, 505);
            this.Controls.Add(this.txtCodigoVideojuego);
            this.Controls.Add(this.txtNombreVideojuego);
            this.Controls.Add(this.btnRegistrarVideojuego);
            this.Controls.Add(this.txtDniJugador);
            this.Controls.Add(this.txtAliasJugador);
            this.Controls.Add(this.cboVideojuegos);
            this.Controls.Add(this.btnRegistrarJugador);
            this.Controls.Add(this.btnMostrarVideojuegos);
            this.Controls.Add(this.btnMostrarJugadores);
            this.Controls.Add(this.txtConsultaDni);
            this.Controls.Add(this.btnBuscarPorDni);
            this.Controls.Add(this.btnTopVideojuegos);
            this.Controls.Add(this.dgvVideojuegos);
            this.Controls.Add(this.dgvJugadores);
            this.Controls.Add(this.dgvResultados);
            this.Name = "Form1";
            this.Text = "Gestión de Videojuegos y Jugadores";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvVideojuegos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvResultados)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }

        private System.Windows.Forms.TextBox txtCodigoVideojuego;
        private System.Windows.Forms.TextBox txtNombreVideojuego;
        private System.Windows.Forms.Button btnRegistrarVideojuego;
        private System.Windows.Forms.TextBox txtDniJugador;
        private System.Windows.Forms.TextBox txtAliasJugador;
        private System.Windows.Forms.ComboBox cboVideojuegos;
        private System.Windows.Forms.Button btnRegistrarJugador;
        private System.Windows.Forms.Button btnMostrarVideojuegos;
        private System.Windows.Forms.Button btnMostrarJugadores;
        private System.Windows.Forms.TextBox txtConsultaDni;
        private System.Windows.Forms.Button btnBuscarPorDni;
        private System.Windows.Forms.Button btnTopVideojuegos;
        private System.Windows.Forms.DataGridView dgvVideojuegos;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.DataGridView dgvResultados;
    }
}

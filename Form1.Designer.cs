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
            this.tabMockups = new System.Windows.Forms.TabControl();
            this.tabDashboard = new System.Windows.Forms.TabPage();
            this.dgvTorneos = new System.Windows.Forms.DataGridView();
            this.lblDashboardTitle = new System.Windows.Forms.Label();
            this.btnDarBajaTorneo = new System.Windows.Forms.Button();
            this.btnEditarTorneo = new System.Windows.Forms.Button();
            this.btnGuardarTorneo = new System.Windows.Forms.Button();
            this.dtpFechaInicio = new System.Windows.Forms.DateTimePicker();
            this.cboDeporte = new System.Windows.Forms.ComboBox();
            this.txtNombreTorneo = new System.Windows.Forms.TextBox();
            this.txtCodigoTorneo = new System.Windows.Forms.TextBox();
            this.tabEquiposJugadores = new System.Windows.Forms.TabPage();
            this.dgvJugadores = new System.Windows.Forms.DataGridView();
            this.dgvEquipos = new System.Windows.Forms.DataGridView();
            this.btnAgregarJugador = new System.Windows.Forms.Button();
            this.txtEdadJugador = new System.Windows.Forms.TextBox();
            this.txtDniJugador = new System.Windows.Forms.TextBox();
            this.txtNombreJugador = new System.Windows.Forms.TextBox();
            this.btnRegistrarEquipo = new System.Windows.Forms.Button();
            this.txtDniDelegado = new System.Windows.Forms.TextBox();
            this.txtNombreEquipo = new System.Windows.Forms.TextBox();
            this.cboTorneoEquipos = new System.Windows.Forms.ComboBox();
            this.tabFixtureResultados = new System.Windows.Forms.TabPage();
            this.dgvAuditoria = new System.Windows.Forms.DataGridView();
            this.dgvFixture = new System.Windows.Forms.DataGridView();
            this.btnGuardarResultado = new System.Windows.Forms.Button();
            this.txtMarcadorVisitante = new System.Windows.Forms.TextBox();
            this.txtMarcadorLocal = new System.Windows.Forms.TextBox();
            this.cboPartido = new System.Windows.Forms.ComboBox();
            this.btnGenerarFixture = new System.Windows.Forms.Button();
            this.rdoPorGrupos = new System.Windows.Forms.RadioButton();
            this.rdoAleatorio = new System.Windows.Forms.RadioButton();
            this.tabTablaPosiciones = new System.Windows.Forms.TabPage();
            this.btnExportarPdf = new System.Windows.Forms.Button();
            this.btnActualizarTabla = new System.Windows.Forms.Button();
            this.dtpFechaCorte = new System.Windows.Forms.DateTimePicker();
            this.cboTorneoTabla = new System.Windows.Forms.ComboBox();
            this.dgvTablaPosiciones = new System.Windows.Forms.DataGridView();
            this.tabMockups.SuspendLayout();
            this.tabDashboard.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneos)).BeginInit();
            this.tabEquiposJugadores.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).BeginInit();
            this.tabFixtureResultados.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixture)).BeginInit();
            this.tabTablaPosiciones.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPosiciones)).BeginInit();
            this.SuspendLayout();
            // 
            // tabMockups
            // 
            this.tabMockups.Controls.Add(this.tabDashboard);
            this.tabMockups.Controls.Add(this.tabEquiposJugadores);
            this.tabMockups.Controls.Add(this.tabFixtureResultados);
            this.tabMockups.Controls.Add(this.tabTablaPosiciones);
            this.tabMockups.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabMockups.Location = new System.Drawing.Point(0, 0);
            this.tabMockups.Name = "tabMockups";
            this.tabMockups.SelectedIndex = 0;
            this.tabMockups.Size = new System.Drawing.Size(1140, 620);
            // 
            // tabDashboard
            // 
            this.tabDashboard.Controls.Add(this.dgvTorneos);
            this.tabDashboard.Controls.Add(this.lblDashboardTitle);
            this.tabDashboard.Controls.Add(this.btnDarBajaTorneo);
            this.tabDashboard.Controls.Add(this.btnEditarTorneo);
            this.tabDashboard.Controls.Add(this.btnGuardarTorneo);
            this.tabDashboard.Controls.Add(this.dtpFechaInicio);
            this.tabDashboard.Controls.Add(this.cboDeporte);
            this.tabDashboard.Controls.Add(this.txtNombreTorneo);
            this.tabDashboard.Controls.Add(this.txtCodigoTorneo);
            this.tabDashboard.Location = new System.Drawing.Point(4, 25);
            this.tabDashboard.Name = "tabDashboard";
            this.tabDashboard.Padding = new System.Windows.Forms.Padding(3);
            this.tabDashboard.Size = new System.Drawing.Size(1132, 591);
            this.tabDashboard.Text = "Prompt 1 - Dashboard";
            this.tabDashboard.UseVisualStyleBackColor = true;
            // 
            // dgvTorneos
            // 
            this.dgvTorneos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvTorneos.Location = new System.Drawing.Point(24, 136);
            this.dgvTorneos.Name = "dgvTorneos";
            this.dgvTorneos.RowHeadersWidth = 51;
            this.dgvTorneos.Size = new System.Drawing.Size(1080, 428);
            // 
            // lblDashboardTitle
            // 
            this.lblDashboardTitle.AutoSize = true;
            this.lblDashboardTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.lblDashboardTitle.Location = new System.Drawing.Point(20, 14);
            this.lblDashboardTitle.Text = "RF01 Gestión de Torneos + RF09 Rendimiento";
            // ... fields
            this.txtCodigoTorneo.Location = new System.Drawing.Point(24, 62);            this.txtCodigoTorneo.Text = "";
            this.txtCodigoTorneo.Size = new System.Drawing.Size(150, 22);
            this.txtNombreTorneo.Location = new System.Drawing.Point(192, 62);            this.txtNombreTorneo.Text = "";
            this.txtNombreTorneo.Size = new System.Drawing.Size(240, 22);
            this.cboDeporte.Location = new System.Drawing.Point(448, 61);
            this.cboDeporte.Size = new System.Drawing.Size(140, 24);
            this.cboDeporte.Items.AddRange(new object[] {"Fútbol", "Vóley", "Basket"});
            this.dtpFechaInicio.Location = new System.Drawing.Point(606, 62);
            this.dtpFechaInicio.Size = new System.Drawing.Size(200, 22);
            this.btnGuardarTorneo.Location = new System.Drawing.Point(824, 60);
            this.btnGuardarTorneo.Size = new System.Drawing.Size(85, 26);
            this.btnGuardarTorneo.Text = "Guardar";
            this.btnEditarTorneo.Location = new System.Drawing.Point(919, 60);
            this.btnEditarTorneo.Size = new System.Drawing.Size(75, 26);
            this.btnEditarTorneo.Text = "Editar";
            this.btnDarBajaTorneo.Location = new System.Drawing.Point(1004, 60);
            this.btnDarBajaTorneo.Size = new System.Drawing.Size(100, 26);
            this.btnDarBajaTorneo.Text = "Dar de baja";

            // tabEquiposJugadores
            this.tabEquiposJugadores.Controls.Add(this.dgvJugadores);
            this.tabEquiposJugadores.Controls.Add(this.dgvEquipos);
            this.tabEquiposJugadores.Controls.Add(this.btnAgregarJugador);
            this.tabEquiposJugadores.Controls.Add(this.txtEdadJugador);
            this.tabEquiposJugadores.Controls.Add(this.txtDniJugador);
            this.tabEquiposJugadores.Controls.Add(this.txtNombreJugador);
            this.tabEquiposJugadores.Controls.Add(this.btnRegistrarEquipo);
            this.tabEquiposJugadores.Controls.Add(this.txtDniDelegado);
            this.tabEquiposJugadores.Controls.Add(this.txtNombreEquipo);
            this.tabEquiposJugadores.Controls.Add(this.cboTorneoEquipos);
            this.tabEquiposJugadores.Location = new System.Drawing.Point(4, 25);
            this.tabEquiposJugadores.Size = new System.Drawing.Size(1132, 591);
            this.tabEquiposJugadores.Text = "Prompt 2 - Equipos/Jugadores";
            this.tabEquiposJugadores.UseVisualStyleBackColor = true;
            this.cboTorneoEquipos.Location = new System.Drawing.Point(20, 20); this.cboTorneoEquipos.Size = new System.Drawing.Size(250,24);
            this.txtNombreEquipo.Location = new System.Drawing.Point(20, 60);            this.txtNombreEquipo.Text = "";
            this.txtDniDelegado.Location = new System.Drawing.Point(240, 60);            this.txtDniDelegado.Text = "";
            this.btnRegistrarEquipo.Location = new System.Drawing.Point(410, 58); this.btnRegistrarEquipo.Text = "Registrar equipo";
            this.dgvEquipos.Location = new System.Drawing.Point(20, 100); this.dgvEquipos.Size = new System.Drawing.Size(1080, 180);
            this.txtNombreJugador.Location = new System.Drawing.Point(20, 300);            this.txtNombreJugador.Text = "";
            this.txtDniJugador.Location = new System.Drawing.Point(240, 300);            this.txtDniJugador.Text = "";
            this.txtEdadJugador.Location = new System.Drawing.Point(390, 300);            this.txtEdadJugador.Text = "";
            this.btnAgregarJugador.Location = new System.Drawing.Point(520, 298); this.btnAgregarJugador.Text = "Agregar jugador";
            this.dgvJugadores.Location = new System.Drawing.Point(20, 340); this.dgvJugadores.Size = new System.Drawing.Size(1080, 220);

            // tabFixtureResultados
            this.tabFixtureResultados.Controls.Add(this.dgvAuditoria);
            this.tabFixtureResultados.Controls.Add(this.dgvFixture);
            this.tabFixtureResultados.Controls.Add(this.btnGuardarResultado);
            this.tabFixtureResultados.Controls.Add(this.txtMarcadorVisitante);
            this.tabFixtureResultados.Controls.Add(this.txtMarcadorLocal);
            this.tabFixtureResultados.Controls.Add(this.cboPartido);
            this.tabFixtureResultados.Controls.Add(this.btnGenerarFixture);
            this.tabFixtureResultados.Controls.Add(this.rdoPorGrupos);
            this.tabFixtureResultados.Controls.Add(this.rdoAleatorio);
            this.tabFixtureResultados.Location = new System.Drawing.Point(4, 25);
            this.tabFixtureResultados.Size = new System.Drawing.Size(1132, 591);
            this.tabFixtureResultados.Text = "Prompt 3 - Fixture/Resultados";
            this.tabFixtureResultados.UseVisualStyleBackColor = true;
            this.rdoAleatorio.Location = new System.Drawing.Point(20, 20); this.rdoAleatorio.Text = "Aleatorio"; this.rdoAleatorio.Checked = true;
            this.rdoPorGrupos.Location = new System.Drawing.Point(120, 20); this.rdoPorGrupos.Text = "Por grupos";
            this.btnGenerarFixture.Location = new System.Drawing.Point(230, 17); this.btnGenerarFixture.Text = "Generar fixture";
            this.dgvFixture.Location = new System.Drawing.Point(20, 60); this.dgvFixture.Size = new System.Drawing.Size(1080, 240);
            this.cboPartido.Location = new System.Drawing.Point(20, 320); this.cboPartido.Size = new System.Drawing.Size(350,24);
            this.txtMarcadorLocal.Location = new System.Drawing.Point(390, 320);            this.txtMarcadorLocal.Text = "";
            this.txtMarcadorVisitante.Location = new System.Drawing.Point(500, 320);            this.txtMarcadorVisitante.Text = "";
            this.btnGuardarResultado.Location = new System.Drawing.Point(620, 318); this.btnGuardarResultado.Text = "Guardar resultado";
            this.dgvAuditoria.Location = new System.Drawing.Point(20, 360); this.dgvAuditoria.Size = new System.Drawing.Size(1080, 200);

            // tabTablaPosiciones
            this.tabTablaPosiciones.Controls.Add(this.btnExportarPdf);
            this.tabTablaPosiciones.Controls.Add(this.btnActualizarTabla);
            this.tabTablaPosiciones.Controls.Add(this.dtpFechaCorte);
            this.tabTablaPosiciones.Controls.Add(this.cboTorneoTabla);
            this.tabTablaPosiciones.Controls.Add(this.dgvTablaPosiciones);
            this.tabTablaPosiciones.Location = new System.Drawing.Point(4, 25);
            this.tabTablaPosiciones.Size = new System.Drawing.Size(1132, 591);
            this.tabTablaPosiciones.Text = "Prompt 4 - Tabla";
            this.tabTablaPosiciones.UseVisualStyleBackColor = true;
            this.cboTorneoTabla.Location = new System.Drawing.Point(20, 20); this.cboTorneoTabla.Size = new System.Drawing.Size(280, 24);
            this.dtpFechaCorte.Location = new System.Drawing.Point(320, 21); this.dtpFechaCorte.Size = new System.Drawing.Size(210, 22);
            this.btnActualizarTabla.Location = new System.Drawing.Point(550, 19); this.btnActualizarTabla.Text = "Actualizar";
            this.btnExportarPdf.Location = new System.Drawing.Point(650, 19); this.btnExportarPdf.Text = "Exportar PDF";
            this.dgvTablaPosiciones.Location = new System.Drawing.Point(20, 60); this.dgvTablaPosiciones.Size = new System.Drawing.Size(1080, 500);

            this.ClientSize = new System.Drawing.Size(1140, 620);
            this.Controls.Add(this.tabMockups);
            this.Name = "Form1";
            this.Text = "SportMaster Pro - Mockups Windows Forms";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabMockups.ResumeLayout(false);
            this.tabDashboard.ResumeLayout(false);
            this.tabDashboard.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvTorneos)).EndInit();
            this.tabEquiposJugadores.ResumeLayout(false);
            this.tabEquiposJugadores.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvJugadores)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvEquipos)).EndInit();
            this.tabFixtureResultados.ResumeLayout(false);
            this.tabFixtureResultados.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAuditoria)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvFixture)).EndInit();
            this.tabTablaPosiciones.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvTablaPosiciones)).EndInit();
            this.ResumeLayout(false);
        }

        private System.Windows.Forms.TabControl tabMockups;
        private System.Windows.Forms.TabPage tabDashboard;
        private System.Windows.Forms.TabPage tabEquiposJugadores;
        private System.Windows.Forms.TabPage tabFixtureResultados;
        private System.Windows.Forms.TabPage tabTablaPosiciones;
        private System.Windows.Forms.DataGridView dgvTorneos;
        private System.Windows.Forms.Label lblDashboardTitle;
        private System.Windows.Forms.Button btnDarBajaTorneo;
        private System.Windows.Forms.Button btnEditarTorneo;
        private System.Windows.Forms.Button btnGuardarTorneo;
        private System.Windows.Forms.DateTimePicker dtpFechaInicio;
        private System.Windows.Forms.ComboBox cboDeporte;
        private System.Windows.Forms.TextBox txtNombreTorneo;
        private System.Windows.Forms.TextBox txtCodigoTorneo;
        private System.Windows.Forms.DataGridView dgvJugadores;
        private System.Windows.Forms.DataGridView dgvEquipos;
        private System.Windows.Forms.Button btnAgregarJugador;
        private System.Windows.Forms.TextBox txtEdadJugador;
        private System.Windows.Forms.TextBox txtDniJugador;
        private System.Windows.Forms.TextBox txtNombreJugador;
        private System.Windows.Forms.Button btnRegistrarEquipo;
        private System.Windows.Forms.TextBox txtDniDelegado;
        private System.Windows.Forms.TextBox txtNombreEquipo;
        private System.Windows.Forms.ComboBox cboTorneoEquipos;
        private System.Windows.Forms.DataGridView dgvAuditoria;
        private System.Windows.Forms.DataGridView dgvFixture;
        private System.Windows.Forms.Button btnGuardarResultado;
        private System.Windows.Forms.TextBox txtMarcadorVisitante;
        private System.Windows.Forms.TextBox txtMarcadorLocal;
        private System.Windows.Forms.ComboBox cboPartido;
        private System.Windows.Forms.Button btnGenerarFixture;
        private System.Windows.Forms.RadioButton rdoPorGrupos;
        private System.Windows.Forms.RadioButton rdoAleatorio;
        private System.Windows.Forms.Button btnExportarPdf;
        private System.Windows.Forms.Button btnActualizarTabla;
        private System.Windows.Forms.DateTimePicker dtpFechaCorte;
        private System.Windows.Forms.ComboBox cboTorneoTabla;
        private System.Windows.Forms.DataGridView dgvTablaPosiciones;
    }
}

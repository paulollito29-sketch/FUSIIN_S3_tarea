using System;
using System.Linq;
using System.Windows.Forms;
using FUSIIN_S2_Ejercicio1.controller;
using FUSIIN_S2_Ejercicio1.entity;

namespace FUSIIN_S2_Ejercicio1
{
    public partial class Form1 : Form
    {
        private readonly GestionVideojuegosController controller = new GestionVideojuegosController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarComboTorneos();
        }

        private void btnRegistrarVideojuego_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoVideojuego.Text.Trim();
            string nombre = txtNombreVideojuego.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese código y nombre del torneo.");
                return;
            }

            bool ok = controller.RegistrarTorneo(new Torneo
            {
                Codigo = codigo,
                Nombre = nombre,
                Deporte = "Fútbol",
                FechaInicio = DateTime.Now,
                Estado = "Activo"
            });

            if (!ok)
            {
                MessageBox.Show("Ya existe un torneo con ese código.");
                return;
            }

            txtCodigoVideojuego.Clear();
            txtNombreVideojuego.Clear();
            RefrescarComboTorneos();
            CargarGrillaTorneos();
        }

        private void btnRegistrarJugador_Click(object sender, EventArgs e)
        {
            if (!(cboVideojuegos.SelectedItem is ComboBoxOption opcion))
            {
                MessageBox.Show("Seleccione un torneo.");
                return;
            }

            string dni = txtDniJugador.Text.Trim();
            string nombreEquipo = txtAliasJugador.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(nombreEquipo))
            {
                MessageBox.Show("Ingrese DNI del delegado y nombre del equipo.");
                return;
            }

            bool ok = controller.RegistrarEquipoEnTorneo(opcion.Value, new Equipo
            {
                DniDelegado = dni,
                NombreEquipo = nombreEquipo
            });

            if (!ok)
            {
                MessageBox.Show("No se pudo registrar. Verifique DNI de delegado duplicado o torneo inexistente.");
                return;
            }

            txtDniJugador.Clear();
            txtAliasJugador.Clear();
            CargarGrillaEquipos();
            CargarGrillaTorneos();
        }

        private void btnMostrarVideojuegos_Click(object sender, EventArgs e) => CargarGrillaTorneos();

        private void btnMostrarJugadores_Click(object sender, EventArgs e) => CargarGrillaEquipos();

        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            string dni = txtConsultaDni.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Ingrese DNI para consultar.");
                return;
            }

            var torneos = controller.ObtenerTorneosPorDniDelegado(dni);
            dgvResultados.DataSource = torneos.Select(t => new
            {
                CodigoTorneo = t.Codigo,
                NombreTorneo = t.Nombre,
                Deporte = t.Deporte,
                EquiposInscriptos = t.Equipos.Count
            }).ToList();
        }

        private void btnTopVideojuegos_Click(object sender, EventArgs e)
        {
            var top = controller.ObtenerTopEquiposPorPuntos();
            dgvResultados.DataSource = top.Select(equipo => new
            {
                Equipo = equipo.NombreEquipo,
                DelegadoDNI = equipo.DniDelegado,
                PJ = equipo.PartidosJugados,
                PG = equipo.PartidosGanados,
                PE = equipo.PartidosEmpatados,
                PP = equipo.PartidosPerdidos,
                Puntos = equipo.Puntos
            }).ToList();
        }

        private void CargarGrillaTorneos()
        {
            dgvVideojuegos.DataSource = controller.ObtenerTorneos()
                .Select(t => new
                {
                    CodigoTorneo = t.Codigo,
                    NombreTorneo = t.Nombre,
                    Deporte = t.Deporte,
                    FechaInicio = t.FechaInicio,
                    Estado = t.Estado,
                    Equipos = t.Equipos.Count
                })
                .ToList();
        }

        private void CargarGrillaEquipos()
        {
            dgvJugadores.DataSource = controller.ObtenerEquipos()
                .Select(e => new
                {
                    Equipo = e.NombreEquipo,
                    DelegadoDNI = e.DniDelegado,
                    PJ = e.PartidosJugados,
                    PG = e.PartidosGanados,
                    PE = e.PartidosEmpatados,
                    PP = e.PartidosPerdidos,
                    Puntos = e.Puntos
                })
                .ToList();
        }

        private void RefrescarComboTorneos()
        {
            cboVideojuegos.DataSource = controller.ObtenerTorneos()
                .Select(t => new ComboBoxOption(t.Codigo, $"{t.Codigo} - {t.Nombre}"))
                .ToList();
        }

        private class ComboBoxOption
        {
            public string Value { get; }
            public string Text { get; }

            public ComboBoxOption(string value, string text)
            {
                Value = value;
                Text = text;
            }

            public override string ToString() => Text;
        }
    }
}

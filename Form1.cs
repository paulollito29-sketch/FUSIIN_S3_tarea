using System;
using System.Collections.Generic;
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
            RefrescarComboVideojuegos();
        }

        private void btnRegistrarVideojuego_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoVideojuego.Text.Trim();
            string nombre = txtNombreVideojuego.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese código y nombre del videojuego.");
                return;
            }

            bool ok = controller.RegistrarVideojuego(new Videojuego { Codigo = codigo, Nombre = nombre });
            if (!ok)
            {
                MessageBox.Show("Ya existe un videojuego con ese código.");
                return;
            }

            txtCodigoVideojuego.Clear();
            txtNombreVideojuego.Clear();
            RefrescarComboVideojuegos();
            CargarGrillaVideojuegos();
        }

        private void btnRegistrarJugador_Click(object sender, EventArgs e)
        {
            if (!(cboVideojuegos.SelectedItem is ComboBoxOption opcion))
            {
                MessageBox.Show("Seleccione un videojuego.");
                return;
            }

            string dni = txtDniJugador.Text.Trim();
            string alias = txtAliasJugador.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni) || string.IsNullOrWhiteSpace(alias))
            {
                MessageBox.Show("Ingrese DNI y alias del jugador.");
                return;
            }

            bool ok = controller.RegistrarJugadorEnVideojuego(opcion.Value, new Jugador { Dni = dni, Alias = alias });
            if (!ok)
            {
                MessageBox.Show("No se pudo registrar. Verifique DNI duplicado o videojuego inexistente.");
                return;
            }

            txtDniJugador.Clear();
            txtAliasJugador.Clear();
            CargarGrillaJugadores();
            CargarGrillaVideojuegos();
        }

        private void btnMostrarVideojuegos_Click(object sender, EventArgs e) => CargarGrillaVideojuegos();

        private void btnMostrarJugadores_Click(object sender, EventArgs e) => CargarGrillaJugadores();

        private void btnBuscarPorDni_Click(object sender, EventArgs e)
        {
            string dni = txtConsultaDni.Text.Trim();
            if (string.IsNullOrWhiteSpace(dni))
            {
                MessageBox.Show("Ingrese DNI para consultar.");
                return;
            }

            var juegos = controller.ObtenerVideojuegosPorDni(dni);
            dgvResultados.DataSource = juegos.Select(v => new
            {
                CodigoVideojuego = v.Codigo,
                NombreVideojuego = v.Nombre,
                CantidadJugadores = v.Jugadores.Count
            }).ToList();
        }

        private void btnTopVideojuegos_Click(object sender, EventArgs e)
        {
            var top = controller.ObtenerVideojuegosConMasJugadores();
            dgvResultados.DataSource = top.Select(v => new
            {
                CodigoVideojuego = v.Codigo,
                NombreVideojuego = v.Nombre,
                CantidadJugadores = v.Jugadores.Count
            }).ToList();
        }

        private void CargarGrillaVideojuegos()
        {
            dgvVideojuegos.DataSource = controller.ObtenerVideojuegos()
                .Select(v => new
                {
                    CodigoVideojuego = v.Codigo,
                    NombreVideojuego = v.Nombre,
                    CantidadJugadores = v.Jugadores.Count
                })
                .ToList();
        }

        private void CargarGrillaJugadores()
        {
            dgvJugadores.DataSource = controller.ObtenerJugadores()
                .Select(j => new
                {
                    DniJugador = j.Dni,
                    AliasJugador = j.Alias
                })
                .ToList();
        }

        private void RefrescarComboVideojuegos()
        {
            cboVideojuegos.DataSource = controller.ObtenerVideojuegos()
                .Select(v => new ComboBoxOption(v.Codigo, $"{v.Codigo} - {v.Nombre}"))
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

using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Windows.Forms;
using FUSIIN_S2_Ejercicio1.controller;
using FUSIIN_S2_Ejercicio1.entity;

namespace FUSIIN_S2_Ejercicio1
{
    public partial class Form1 : Form
    {
        private readonly CatalogoMusicalController catalogoMusicalController = new CatalogoMusicalController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            RefrescarCombos();
        }

        private void btnRegistrarAlbum_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigoAlbum.Text.Trim();
            string nombre = txtNombreAlbum.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese código y nombre para el álbum.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            bool ok = catalogoMusicalController.RegistrarAlbum(new Album { Codigo = codigo, Nombre = nombre });
            if (!ok)
            {
                MessageBox.Show("No se pudo registrar. Ya existe un álbum con ese código.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Álbum registrado correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCodigoAlbum.Clear();
            txtNombreAlbum.Clear();
            txtCodigoAlbum.Focus();
            RefrescarCombos();
        }

        private void btnRegistrarCancion_Click(object sender, EventArgs e)
        {
            if (!(cboAlbumCancion.SelectedItem is ComboBoxOption albumOption))
            {
                MessageBox.Show("Debe seleccionar un álbum.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = txtCodigoCancion.Text.Trim();
            string nombre = txtNombreCancion.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Ingrese código y nombre para la canción.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!double.TryParse(txtDuracionCancion.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out double duracion) || duracion <= 0)
            {
                MessageBox.Show("La duración debe ser un número mayor a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var cancion = new Cancion { Codigo = codigo, Nombre = nombre, Duracion = duracion };
            bool ok = catalogoMusicalController.RegistrarCancionEnAlbum(albumOption.Value, cancion);

            if (!ok)
            {
                MessageBox.Show("No se pudo registrar la canción. Verifique si el código ya existe dentro del álbum.", "Duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show("Canción registrada correctamente.", "Registro", MessageBoxButtons.OK, MessageBoxIcon.Information);
            txtCodigoCancion.Clear();
            txtNombreCancion.Clear();
            txtDuracionCancion.Clear();
            txtCodigoCancion.Focus();
            RefrescarCombos();
        }

        private void btnMostrarAlbumes_Click(object sender, EventArgs e)
        {
            var albumes = catalogoMusicalController.ObtenerAlbumes();
            lstResultados.Items.Clear();

            foreach (Album album in albumes)
            {
                lstResultados.Items.Add($"{album.Codigo} - {album.Nombre}");
            }

            if (!albumes.Any())
            {
                MessageBox.Show("No hay álbumes registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnMostrarCanciones_Click(object sender, EventArgs e)
        {
            List<string> canciones = catalogoMusicalController.ObtenerNombresCanciones();
            lstResultados.Items.Clear();

            foreach (string nombre in canciones)
            {
                lstResultados.Items.Add(nombre);
            }

            if (!canciones.Any())
            {
                MessageBox.Show("No hay canciones registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVerCancionesAlbum_Click(object sender, EventArgs e)
        {
            if (!(cboAlbumConsulta.SelectedItem is ComboBoxOption albumOption))
            {
                MessageBox.Show("Seleccione un álbum para listar sus canciones.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> canciones = catalogoMusicalController.ObtenerNombresCancionesPorAlbum(albumOption.Value);
            lstResultados.Items.Clear();

            foreach (string nombre in canciones)
            {
                lstResultados.Items.Add(nombre);
            }

            if (!canciones.Any())
            {
                MessageBox.Show("El álbum seleccionado no tiene canciones registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnAlbumConMasCanciones_Click(object sender, EventArgs e)
        {
            Album album = catalogoMusicalController.ObtenerAlbumConMasCanciones();
            if (album == null)
            {
                MessageBox.Show("No hay álbumes registrados.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            MessageBox.Show(
                $"Álbum con más canciones: {album.Nombre} ({album.Canciones.Count} canciones)",
                "Resultado",
                MessageBoxButtons.OK,
                MessageBoxIcon.Information);
        }

        private void btnAlbumesPorCancion_Click(object sender, EventArgs e)
        {
            if (!(cboCancionConsulta.SelectedItem is ComboBoxOption cancionOption))
            {
                MessageBox.Show("Seleccione una canción para consultar sus álbumes.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            List<string> albumes = catalogoMusicalController.ObtenerAlbumesDondeEstaCancion(cancionOption.Value);

            if (!albumes.Any())
            {
                MessageBox.Show("La canción seleccionada no está registrada en álbumes.", "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje = "La canción aparece en:\n- " + string.Join("\n- ", albumes);
            MessageBox.Show(mensaje, "Resultado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void btnDuraciones_Click(object sender, EventArgs e)
        {
            var (mayor, menor) = catalogoMusicalController.ObtenerCancionMayorYMenorDuracion();
            if (mayor == null || menor == null)
            {
                MessageBox.Show("No hay canciones registradas.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            string mensaje =
                $"Mayor duración: {mayor.Nombre} ({mayor.Duracion:F2})\n" +
                $"Menor duración: {menor.Nombre} ({menor.Duracion:F2})";

            MessageBox.Show(mensaje, "Duraciones", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void RefrescarCombos()
        {
            List<Album> albumes = catalogoMusicalController.ObtenerAlbumes();

            cboAlbumCancion.DataSource = albumes
                .Select(a => new ComboBoxOption(a.Codigo, $"{a.Codigo} - {a.Nombre}"))
                .ToList();

            cboAlbumConsulta.DataSource = albumes
                .Select(a => new ComboBoxOption(a.Codigo, $"{a.Codigo} - {a.Nombre}"))
                .ToList();

            List<ComboBoxOption> canciones = albumes
                .SelectMany(a => a.Canciones)
                .Select(c => new ComboBoxOption(c.Codigo, $"{c.Codigo} - {c.Nombre}"))
                .GroupBy(x => x.Value, StringComparer.OrdinalIgnoreCase)
                .Select(g => g.First())
                .OrderBy(x => x.Text)
                .ToList();

            cboCancionConsulta.DataSource = canciones;
        }

        private class ComboBoxOption
        {
            public ComboBoxOption(string value, string text)
            {
                Value = value;
                Text = text;
            }

            public string Value { get; }
            public string Text { get; }

            public override string ToString()
            {
                return Text;
            }
        }
    }
}

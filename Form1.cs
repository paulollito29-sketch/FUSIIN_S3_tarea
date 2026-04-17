using System;
using System.Collections.Generic;
using System.Globalization;
using System.Windows.Forms;
using FUSIIN_S2_Ejercicio1.controller;
using FUSIIN_S2_Ejercicio1.entity;

namespace FUSIIN_S2_Ejercicio1
{
    public partial class Form1 : Form
    {
        private readonly InventarioController inventarioController = new InventarioController();

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ConfigurarGrilla();
            RefrescarVista(inventarioController.ObtenerTodos());
        }

        private void ConfigurarGrilla()
        {
            dgvMuebles.AutoGenerateColumns = false;
            dgvMuebles.Columns.Clear();

            dgvMuebles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Código",
                DataPropertyName = "Codigo",
                Name = "Codigo"
            });

            dgvMuebles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Nombre",
                DataPropertyName = "Nombre",
                Name = "Nombre"
            });

            dgvMuebles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Stock",
                DataPropertyName = "Stock",
                Name = "Stock"
            });

            dgvMuebles.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Precio",
                DataPropertyName = "Precio",
                Name = "Precio",
                DefaultCellStyle = { Format = "C2" }
            });
        }

        private void btnRegistrar_Click(object sender, EventArgs e)
        {
            string codigo = txtCodigo.Text.Trim();
            string nombre = txtNombre.Text.Trim();

            if (string.IsNullOrWhiteSpace(codigo) || string.IsNullOrWhiteSpace(nombre))
            {
                MessageBox.Show("Debe ingresar código y nombre.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!int.TryParse(txtStock.Text.Trim(), out int stock) || stock < 0)
            {
                MessageBox.Show("El stock debe ser un número entero mayor o igual a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtPrecio.Text.Trim(), NumberStyles.Number, CultureInfo.CurrentCulture, out decimal precio) || precio < 0)
            {
                MessageBox.Show("El precio debe ser un número mayor o igual a 0.", "Validación", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var mueble = new Mueble(codigo, nombre, stock, precio);
            bool registrado = inventarioController.Registrar(mueble);

            if (!registrado)
            {
                MessageBox.Show("Ya existe un mueble con ese código.", "Código duplicado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            LimpiarCamposRegistro();
            RefrescarVista(inventarioController.ObtenerTodos());
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            RefrescarVista(inventarioController.BuscarPorNombre(txtBuscar.Text.Trim()));
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            if (dgvMuebles.SelectedRows.Count == 0)
            {
                MessageBox.Show("Seleccione un mueble para eliminar.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string codigo = Convert.ToString(dgvMuebles.SelectedRows[0].Cells["Codigo"].Value);

            if (!inventarioController.EliminarPorCodigo(codigo))
            {
                MessageBox.Show("No se pudo eliminar el mueble seleccionado.", "Eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            RefrescarVista(inventarioController.BuscarPorNombre(txtBuscar.Text.Trim()));
        }

        private void btnEliminarTodos_Click(object sender, EventArgs e)
        {
            var confirmacion = MessageBox.Show(
                "¿Seguro que desea eliminar todos los muebles registrados?",
                "Confirmación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion == DialogResult.No)
            {
                return;
            }

            inventarioController.EliminarTodos();
            RefrescarVista(inventarioController.ObtenerTodos());
        }

        private void btnOrdenar_Click(object sender, EventArgs e)
        {
            RefrescarVista(inventarioController.ObtenerTodos());
        }

        private void RefrescarVista(List<Mueble> muebles)
        {
            dgvMuebles.DataSource = null;
            dgvMuebles.DataSource = muebles;

            lblTotalMuebles.Text = inventarioController.TotalMueblesRegistrados().ToString();
            lblTotalStock.Text = inventarioController.TotalStock().ToString();
        }

        private void LimpiarCamposRegistro()
        {
            txtCodigo.Clear();
            txtNombre.Clear();
            txtStock.Clear();
            txtPrecio.Clear();
            txtCodigo.Focus();
        }
    }
}

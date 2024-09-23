using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Clases;

namespace Biblioteca
{
    public partial class FormPrestamos : Form
    {
        public FormPrestamos()
        {
            InitializeComponent();
            ConfigurarDataGridViewHistorial();
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar libros y miembros en los ComboBox
           
            CargarHistorialPrestamos();
        }

        private void CargarHistorialPrestamos()
        {

            var prestamos = Clases.Biblioteca.ObtenerHistorialPrestamos();
            dgvHistorialPrestamos.DataSource = prestamos;
        }



        

        
        private void ConfigurarDataGridViewHistorial()
        {
            dgvHistorialPrestamos.Columns.Clear();
            dgvHistorialPrestamos.AutoGenerateColumns = false;

           
            DataGridViewTextBoxColumn columnaTitulo = new DataGridViewTextBoxColumn();
            columnaTitulo.HeaderText = "Título del Libro";
            columnaTitulo.DataPropertyName = "TituloLibro";
            dgvHistorialPrestamos.Columns.Add(columnaTitulo);

            DataGridViewTextBoxColumn columnaMiembro = new DataGridViewTextBoxColumn();
            columnaMiembro.HeaderText = "Miembro";
            columnaMiembro.DataPropertyName = "NombreMiembro";
            dgvHistorialPrestamos.Columns.Add(columnaMiembro);

            DataGridViewTextBoxColumn columnaFechaPrestamo = new DataGridViewTextBoxColumn();
            columnaFechaPrestamo.HeaderText = "Fecha de Préstamo";
            columnaFechaPrestamo.DataPropertyName = "FechaPrestamo";
            dgvHistorialPrestamos.Columns.Add(columnaFechaPrestamo);

            DataGridViewTextBoxColumn columnaFechaDevolucion = new DataGridViewTextBoxColumn();
            columnaFechaDevolucion.HeaderText = "Fecha de Devolución";
            columnaFechaDevolucion.DataPropertyName = "FechaDevolucion";
            dgvHistorialPrestamos.Columns.Add(columnaFechaDevolucion);

            DataGridViewTextBoxColumn columnaEstado = new DataGridViewTextBoxColumn();
            columnaEstado.HeaderText = "Estado";
            columnaEstado.DataPropertyName = "Estado";
            dgvHistorialPrestamos.Columns.Add(columnaEstado);
        }

        private void dgvHistorialPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDevolver_Click(object sender, EventArgs e)
        {
           

        }
        private void ActualizarPrestamos()
        {
            dgvHistorialPrestamos.DataSource = null;
            dgvHistorialPrestamos.DataSource = Clases.Biblioteca.Prestamos; // Reemplaza con la lista de préstamos
        }


        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDevolver_Click_1(object sender, EventArgs e)
        {
            if (dgvHistorialPrestamos.SelectedRows.Count > 0)
            {
                
                HistorialPrestamoDTO historialSeleccionado = (HistorialPrestamoDTO)dgvHistorialPrestamos.SelectedRows[0].DataBoundItem;

              
                if (historialSeleccionado.FechaDevolucion != "Pendiente")
                {
                    MessageBox.Show("Este libro ya ha sido devuelto.");
                    return;
                }

                
                historialSeleccionado.FechaDevolucion = DateTime.Now.ToString();
                historialSeleccionado.Estado = "Devuelto";

                ActualizarPrestamos();
                MessageBox.Show("El libro ha sido devuelto exitosamente.");
            }
            else
            {
                MessageBox.Show("Seleccione un préstamo para devolver.");
            }
        }
    }
}

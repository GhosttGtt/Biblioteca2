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
    public partial class FormPrestamosAdd : Form
    {
        public FormPrestamosAdd()
        {
            InitializeComponent();
            
            CargarDatos();
        }

        private void CargarDatos()
        {
            // Cargar libros y miembros en los ComboBox
            cmbLibros.DataSource = Clases.Biblioteca.Libros;
            cmbLibros.DisplayMember = "Titulo"; // Mostrar el título en el ComboBox
            cmbLibros.ValueMember = "Titulo"; // Usar el título como valor seleccionado (esto debe ser ajustado para seleccionar el objeto)

            cmbMiembros.DataSource = Clases.Biblioteca.Miembros;
            cmbMiembros.DisplayMember = "Nombre"; // Mostrar el nombre en el ComboBox
            cmbMiembros.ValueMember = "NumeroMiembro"; // Usar el número de miembro como valor seleccionado (esto debe ser ajustado para seleccionar el objeto)

            
        }

       



        private void CargarLibros()
        {
            foreach (var libro in Clases.Biblioteca.Libros)
            {
                cmbLibros.Items.Add(libro.Titulo);
            }
        }
        private void CargarMiembros()
        {
            foreach (var miembro in Clases.Biblioteca.Miembros)
            {
                cmbMiembros.Items.Add(miembro.Nombre);
            }
        }

        private void btnRealizarPrestamo_Click(object sender, EventArgs e)
        {
            try
            {

                var libroSeleccionado = (Libro)cmbLibros.SelectedItem;
                var miembroSeleccionado = (Miembro)cmbMiembros.SelectedItem;

                if (libroSeleccionado == null || miembroSeleccionado == null)
                {
                    new showToast("Error", "Seleccione un libro y un miembro");
                    //MessageBox.Show("Por favor, seleccione un libro y un miembro.");
                    return;
                }
                if (libroSeleccionado.EstaPrestado)
                {
                    new showToast("Alerta","El libro ya esta prestado, seleccione otro libro");
                    //MessageBox.Show("El libro ya está prestado.");
                    return;
                }
                var nuevoPrestamo = new Prestamo(libroSeleccionado, miembroSeleccionado, dtpFechaPrestamo.Value);
                Clases.Biblioteca.Prestamos.Add(nuevoPrestamo);

                libroSeleccionado.EstaPrestado = true;
                miembroSeleccionado.HistorialPrestamos.Add(nuevoPrestamo);

                new showToast("Exito", "Lubro prestado exitosamente");
                //MessageBox.Show("Préstamo agregado exitosamente.");
            }
            catch (Exception ex)
            {
                new showToast("Error", $"Error al agregar prestamo {ex.Message}");
                //MessageBox.Show($"Error al agregar préstamo: {ex.Message}");
            }
        }
        

        private void dgvHistorialPrestamos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void btnDevolver_Click(object sender, EventArgs e)
        {
           

        }
        


        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        
    }
}

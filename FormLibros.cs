using Biblioteca.Clases;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Biblioteca
{
    public partial class FormLibros : Form
    {
        public FormLibros()
        {
            InitializeComponent();
            CargarLibros();

            
        }
        
        

        private void CargarDatos()
        {
            Clases.Biblioteca.CargarDatosEjemplo();
            dgvLibros.DataSource = Clases.Biblioteca.Libros;
        }

        private void ConfigurarColumnasDataGridView()
        {
            dgvLibros.Columns.Clear();
            dgvLibros.AutoGenerateColumns = false;

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Título", DataPropertyName = "Titulo" });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Autor", DataPropertyName = "Autor" });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Año de Publicación", DataPropertyName = "AnioPublicacion" });
            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn { HeaderText = "Estado", DataPropertyName = "EstaPrestado" });

            dgvLibros.Columns.Add(new DataGridViewTextBoxColumn
            {
                HeaderText = "Tipo",
                DataPropertyName = "Tipo" // Vinculado a la propiedad 'Tipo' de la clase Libro
            });


        }




        private void CargarLibros()
        {
            dgvLibros.DataSource = null; // Limpiar el DataGridView antes de recargarlo
            dgvLibros.DataSource = Clases.Biblioteca.Libros.OrderByDescending(l => l.AnioPublicacion).ToList(); // Mostrar los libros más recientes al inicio

            ConfigurarColumnasDataGridView();
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }


        

        

        private void btnBuscar_Click_1(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            dgvLibros.DataSource = Clases.Biblioteca.Libros.Where(libro => libro.Titulo.ToLower().Contains(busqueda) || libro.Autor.ToLower().Contains(busqueda))
                .ToList();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            string busqueda = txtBuscar.Text.ToLower();
            dgvLibros.DataSource = Clases.Biblioteca.Libros.Where(libro => libro.Titulo.ToLower().Contains(busqueda) || libro.Autor.ToLower().Contains(busqueda))
                .ToList();
        }

        private void btnEliminarlibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                DialogResult result;
                result = MessageBox.Show("¿Deseas eliminar permanentemente este registro?", "", MessageBoxButtons.YesNo);
                if (result == System.Windows.Forms.DialogResult.Yes)
                {
                    Clases.Libro LibroSeleccionado = (Libro)dgvLibros.SelectedRows[0].DataBoundItem;
                    Clases.Biblioteca.Libros.Remove(LibroSeleccionado);

                    ActualizarLibros();
                }
            }
            else {
                MessageBox.Show("Seleccione un libro para eliminar.");
            }
        }
        private void ActualizarLibros()
        {
            dgvLibros.DataSource = null;
            dgvLibros.DataSource = Clases.Biblioteca.Libros;
        }

        private void btnEditarLibro_Click(object sender, EventArgs e)
        {
            if (dgvLibros.SelectedRows.Count > 0)
            {
                
                Libro libroSeleccionado = (Libro)dgvLibros.SelectedRows[0].DataBoundItem;

              
                FormEditarLibro formEditarLibro = new FormEditarLibro(libroSeleccionado);
                var resultado = formEditarLibro.ShowDialog(); 

                if (resultado == DialogResult.OK)
                {
                    ActualizarLibros();
                }
            }
            else
            {
                MessageBox.Show("Seleccione un libro para editar.");
            }
        }
    }
}

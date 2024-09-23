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
    public partial class FormLibrosAdd : Form
    {
        public FormLibrosAdd()
        {
            InitializeComponent();
            
            InicializarComponentes();
        }
        public void showToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }
        private void InicializarComponentes()
        {
            
            cmbTipoLibro.Items.Clear(); 
            cmbTipoLibro.Items.Add("Físico");
            cmbTipoLibro.Items.Add("Digital");

            if (cmbTipoLibro.Items.Count > 0)
            {
                cmbTipoLibro.SelectedIndex = 0;
            }
            else {
                cmbTipoLibro.SelectedIndex = 0;
            }

            MostrarCamposSegunTipo();
        }
        private void MostrarCamposSegunTipo()
        {
            // Mostrar u ocultar campos según el tipo de libro
            if (cmbTipoLibro.SelectedIndex == 0) // Físico
            {
                txtUbicacion.Visible = true;
                lblUbicacion.Visible = true;
                txtTamanoArchivo.Visible = false;
                lblTamanoArchivo.Visible = false;
                txtFormato.Visible = false;
                lblFormato.Visible = false;
            }
            else if (cmbTipoLibro.SelectedIndex == 1) // Digital
            {
                txtUbicacion.Visible = false;
                lblUbicacion.Visible = false;
                txtTamanoArchivo.Visible = true;
                lblTamanoArchivo.Visible = true;
                txtFormato.Visible = true;
                lblFormato.Visible = true;
            }
        }

        
        




        

        private void btnBuscar_Click(object sender, EventArgs e)
        {

        }


        private void btnAgregarLibro_Click(object sender, EventArgs e)
        {
            try
            {
                
                string titulo = txtTitulo.Text;
                string autor = txtAutor.Text;
                int anioPublicacion = int.Parse(txtAnioPublicacion.Text);
                bool esFisico = cmbTipoLibro.SelectedIndex == 0;
                               

                if (esFisico)
                {
                    
                    var libroFisico = new Clases.LibroFisico
                    {
                        Titulo = titulo,
                        Autor = autor,
                        AnioPublicacion = anioPublicacion,
                        Ubicacion = txtUbicacion.Text
                    };
                    if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(txtAnioPublicacion.Text) || string.IsNullOrWhiteSpace(txtUbicacion.Text))
                    {
                        showToast("Error", "Todos los campos son obligatorios");
                        //MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }
                    else {

                        Clases.Biblioteca.Libros.Add(libroFisico);
                        LimpiarFormulario();
                    }

                    
                }
                else
                {
                    
                    int tamanoArchivo = int.Parse(txtTamanoArchivo.Text);
                    var libroDigital = new Clases.LibroElectronico
                    
                    {
                        Titulo = titulo,
                        Autor = autor,
                        AnioPublicacion = anioPublicacion,
                        TamanoArchivo = tamanoArchivo,
                        Formato = txtFormato.Text
                    };
                    if (string.IsNullOrWhiteSpace(titulo) || string.IsNullOrWhiteSpace(autor) || string.IsNullOrWhiteSpace(txtAnioPublicacion.Text) || string.IsNullOrWhiteSpace(txtTamanoArchivo.Text)|| string.IsNullOrWhiteSpace(txtFormato.Text))
                    {
                        showToast("Error", "Todos los campos son obligatorios");
                        //MessageBox.Show("Por favor, complete todos los campos obligatorios.");
                        return;
                    }
                    else
                    {
                        Clases.Biblioteca.Libros.Add(libroDigital);
                        LimpiarFormulario();
                    }
                }

                showToast("Exito", "Libro agregado exitosamente");
                //MessageBox.Show("Libro agregado exitosamente.");
                
            }
            catch (Exception)
            {
                showToast("Error", "Complete todos los campos");
                //MessageBox.Show($"Error al agregar el libro: Complete todos los campos");
            }
            
        }

        private void LimpiarFormulario()
        {
            txtTitulo.Clear();
            txtAutor.Clear();
            txtAnioPublicacion.Clear();
            txtUbicacion.Clear();
            txtTamanoArchivo.Clear();
            txtFormato.Clear();
        }

        

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void cmbTipoLibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            MostrarCamposSegunTipo();
        }

        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        


        
    }
}

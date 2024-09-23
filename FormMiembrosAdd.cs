using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Biblioteca.Clases;

namespace Biblioteca
{
    public partial class FormMiembrosAdd : Form
    {
        public FormMiembrosAdd()
        {
            InitializeComponent();
            CargarMiembros();
        }
        public static int ObtenerUltimoNumeroMiembro()
        {
            if (Clases.Biblioteca.Miembros.Count == 0)
            {
                return 1;
            }
            else
            {
                return Clases.Biblioteca.Miembros.Max(m => m.NumeroMiembro) + 1;
            }
        }
        private void btnAgregarMiembro_Click(object sender, EventArgs e)
        {
            int nuevoNumeroMiembro = ObtenerUltimoNumeroMiembro();

            Clases.Miembro nuevoMiembro = new Clases.Miembro()
            {
                Nombre = txtNombre.Text,
                NumeroMiembro = nuevoNumeroMiembro,
            };
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("Ingrese un nombre.");
            }
            else {
                Clases.Biblioteca.Miembros.Add(nuevoMiembro);
                
                MessageBox.Show("Miembro creado.");
                LimpiarFormulario();
                CargarMiembros();
            }
            
        }

        private void LimpiarFormulario()
        {
            txtNombre.Clear();
            nMiembro.Text = "0";
        }

        
        private void dvgMiembros_SelectionChanged(object sender, EventArgs e)
        {

        }
       
        private void CargarMiembros()
        {
            int nuevoNumeroMiembro = ObtenerUltimoNumeroMiembro();
            nMiembro.Text = nuevoNumeroMiembro.ToString();
           
        }
        
        private void Volver_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        

        
        

        
    }

}

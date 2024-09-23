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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
            Clases.Biblioteca.CargarDatosEjemplo();
            customizeDesign();

        }
        private void customizeDesign()
        {
            panelSubMiembros.Visible = false;
            panelSubLibros.Visible = false;
            panelSubPrestamos.Visible = false;
        }
        private void hideSubMenu()
        {
            if (panelSubMiembros.Visible == true)
            {
                panelSubMiembros.Visible = false;
            }
            if (panelSubLibros.Visible == true)
            {
                panelSubLibros.Visible = false;

            }
            if (panelSubPrestamos.Visible == true)
            {
                panelSubPrestamos.Visible = false;
            }
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
            {
                subMenu.Visible = false;
            }
        }
        public void showToast(string type, string message)
        {
            ToastForm toast = new ToastForm(type, message);
            toast.Show();
        }
        private void buttonLibros_Click(object sender, EventArgs e)
        {
           
            showSubMenu(panelSubLibros);
        }

        private void searchBox_TextChanged(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void buttonMiembos_Click(object sender, EventArgs e)
        {
            
            showSubMenu(panelSubMiembros);
        }

        private void buttonPrestamos_Click(object sender, EventArgs e)
        {
            
            
            showSubMenu(panelSubPrestamos);
        }
        private Form? activeForm = null;
        private void openFormContent(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelFormContent.Controls.Add(childForm);
            panelFormContent.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void buttonBuscarLibro_Click(object sender, EventArgs e)
        {
            openFormContent(new FormLibros());
        }

        private void buttonMiembrosGest_Click(object sender, EventArgs e)
        {
            openFormContent(new FormMiembros());
        }

        private void button1_Click(object sender, EventArgs e)
        {
            openFormContent(new FormMiembrosAdd());
        }

        private void buttonAgregarLibro_Click(object sender, EventArgs e)
        {
            openFormContent(new FormLibrosAdd());
        }

        private void button3_Click(object sender, EventArgs e)
        {
            openFormContent(new FormPrestamos());
        }

        private void button2_Click(object sender, EventArgs e)
        {
            openFormContent(new FormPrestamosAdd());
        }
    }
}

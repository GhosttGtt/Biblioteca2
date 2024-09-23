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
    public partial class ToastForm : Form
    {
        int toastX, toastY;
        public ToastForm()
        {
            InitializeComponent();
        }

        private void ToastForm_Load(object sender, EventArgs e)
        {

        }

        private void toastBorder_Paint(object sender, PaintEventArgs e)
        {
            Position();
        }
        private void Position()
        {
            int ScreenWidth = Screen.PrimaryScreen.WorkingArea.Width;
            int ScreenHeight = Screen.PrimaryScreen.WorkingArea.Height;

            toastX = ScreenWidth - this.Width - 5;
            toastY = ScreenHeight - this.Height - 5;

            this.Location = new Point(toastX, toastY);

        }
    }
}

namespace Biblioteca
{
    partial class Home
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();

            }
            base.Dispose(disposing);
            
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Home));
            panelLeftMenu = new Panel();
            panelSubPrestamos = new Panel();
            button2 = new Button();
            button3 = new Button();
            buttonPrestamos = new Button();
            panelSubMiembros = new Panel();
            button1 = new Button();
            buttonMiembrosGest = new Button();
            buttonMiembos = new Button();
            panelSubLibros = new Panel();
            buttonAgregarLibro = new Button();
            buttonBuscarLibro = new Button();
            buttonLibros = new Button();
            panelLogo = new Panel();
            panelFormContent = new Panel();
            panel1 = new Panel();
            panelLeftMenu.SuspendLayout();
            panelSubPrestamos.SuspendLayout();
            panelSubMiembros.SuspendLayout();
            panelSubLibros.SuspendLayout();
            panelFormContent.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeftMenu
            // 
            panelLeftMenu.AutoScroll = true;
            panelLeftMenu.BackColor = Color.FromArgb(0, 48, 84);
            panelLeftMenu.Controls.Add(panelSubPrestamos);
            panelLeftMenu.Controls.Add(buttonPrestamos);
            panelLeftMenu.Controls.Add(panelSubMiembros);
            panelLeftMenu.Controls.Add(buttonMiembos);
            panelLeftMenu.Controls.Add(panelSubLibros);
            panelLeftMenu.Controls.Add(buttonLibros);
            panelLeftMenu.Controls.Add(panelLogo);
            panelLeftMenu.Dock = DockStyle.Left;
            panelLeftMenu.Location = new Point(0, 0);
            panelLeftMenu.Name = "panelLeftMenu";
            panelLeftMenu.Size = new Size(200, 452);
            panelLeftMenu.TabIndex = 0;
            // 
            // panelSubPrestamos
            // 
            panelSubPrestamos.BackColor = Color.FromArgb(24, 67, 99);
            panelSubPrestamos.Controls.Add(button2);
            panelSubPrestamos.Controls.Add(button3);
            panelSubPrestamos.Dock = DockStyle.Top;
            panelSubPrestamos.Location = new Point(0, 335);
            panelSubPrestamos.Name = "panelSubPrestamos";
            panelSubPrestamos.Size = new Size(200, 57);
            panelSubPrestamos.TabIndex = 7;
            // 
            // button2
            // 
            button2.AutoSize = true;
            button2.BackColor = Color.Transparent;
            button2.Dock = DockStyle.Top;
            button2.FlatAppearance.BorderSize = 0;
            button2.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            button2.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            button2.FlatStyle = FlatStyle.Flat;
            button2.ForeColor = Color.White;
            button2.Location = new Point(0, 25);
            button2.Name = "button2";
            button2.Padding = new Padding(30, 0, 0, 0);
            button2.Size = new Size(200, 25);
            button2.TabIndex = 5;
            button2.Text = "Hacer un prestamo";
            button2.TextAlign = ContentAlignment.MiddleLeft;
            button2.UseVisualStyleBackColor = false;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.AutoSize = true;
            button3.BackColor = Color.Transparent;
            button3.Dock = DockStyle.Top;
            button3.FlatAppearance.BorderSize = 0;
            button3.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            button3.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            button3.FlatStyle = FlatStyle.Flat;
            button3.ForeColor = Color.White;
            button3.Location = new Point(0, 0);
            button3.Name = "button3";
            button3.Padding = new Padding(30, 0, 0, 0);
            button3.Size = new Size(200, 25);
            button3.TabIndex = 4;
            button3.Text = "Lista de prestamos";
            button3.TextAlign = ContentAlignment.MiddleLeft;
            button3.UseVisualStyleBackColor = false;
            button3.Click += button3_Click;
            // 
            // buttonPrestamos
            // 
            buttonPrestamos.AutoSize = true;
            buttonPrestamos.BackColor = Color.Transparent;
            buttonPrestamos.BackgroundImageLayout = ImageLayout.None;
            buttonPrestamos.Cursor = Cursors.Hand;
            buttonPrestamos.Dock = DockStyle.Top;
            buttonPrestamos.FlatAppearance.BorderSize = 0;
            buttonPrestamos.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 41, 71);
            buttonPrestamos.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 41, 71);
            buttonPrestamos.FlatStyle = FlatStyle.Flat;
            buttonPrestamos.Font = new Font("Segoe UI Semibold", 10F);
            buttonPrestamos.ForeColor = Color.White;
            buttonPrestamos.Image = (Image)resources.GetObject("buttonPrestamos.Image");
            buttonPrestamos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonPrestamos.Location = new Point(0, 285);
            buttonPrestamos.Name = "buttonPrestamos";
            buttonPrestamos.Padding = new Padding(15, 10, 0, 10);
            buttonPrestamos.Size = new Size(200, 50);
            buttonPrestamos.TabIndex = 6;
            buttonPrestamos.Text = "  Prestamos";
            buttonPrestamos.TextAlign = ContentAlignment.MiddleLeft;
            buttonPrestamos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonPrestamos.UseVisualStyleBackColor = false;
            buttonPrestamos.Click += buttonPrestamos_Click;
            // 
            // panelSubMiembros
            // 
            panelSubMiembros.BackColor = Color.FromArgb(24, 67, 99);
            panelSubMiembros.Controls.Add(button1);
            panelSubMiembros.Controls.Add(buttonMiembrosGest);
            panelSubMiembros.Dock = DockStyle.Top;
            panelSubMiembros.Location = new Point(0, 227);
            panelSubMiembros.Name = "panelSubMiembros";
            panelSubMiembros.Size = new Size(200, 58);
            panelSubMiembros.TabIndex = 5;
            // 
            // button1
            // 
            button1.AutoSize = true;
            button1.BackColor = Color.Transparent;
            button1.Dock = DockStyle.Top;
            button1.FlatAppearance.BorderSize = 0;
            button1.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            button1.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            button1.FlatStyle = FlatStyle.Flat;
            button1.ForeColor = Color.White;
            button1.Location = new Point(0, 25);
            button1.Name = "button1";
            button1.Padding = new Padding(30, 0, 0, 0);
            button1.Size = new Size(200, 25);
            button1.TabIndex = 3;
            button1.Text = "Agregar Miembros";
            button1.TextAlign = ContentAlignment.MiddleLeft;
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // buttonMiembrosGest
            // 
            buttonMiembrosGest.AutoSize = true;
            buttonMiembrosGest.BackColor = Color.Transparent;
            buttonMiembrosGest.Dock = DockStyle.Top;
            buttonMiembrosGest.FlatAppearance.BorderSize = 0;
            buttonMiembrosGest.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            buttonMiembrosGest.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            buttonMiembrosGest.FlatStyle = FlatStyle.Flat;
            buttonMiembrosGest.ForeColor = Color.White;
            buttonMiembrosGest.Location = new Point(0, 0);
            buttonMiembrosGest.Name = "buttonMiembrosGest";
            buttonMiembrosGest.Padding = new Padding(30, 0, 0, 0);
            buttonMiembrosGest.Size = new Size(200, 25);
            buttonMiembrosGest.TabIndex = 2;
            buttonMiembrosGest.Text = "Gestionar Miembros";
            buttonMiembrosGest.TextAlign = ContentAlignment.MiddleLeft;
            buttonMiembrosGest.UseVisualStyleBackColor = false;
            buttonMiembrosGest.Click += buttonMiembrosGest_Click;
            // 
            // buttonMiembos
            // 
            buttonMiembos.AutoSize = true;
            buttonMiembos.BackColor = Color.Transparent;
            buttonMiembos.BackgroundImageLayout = ImageLayout.None;
            buttonMiembos.Cursor = Cursors.Hand;
            buttonMiembos.Dock = DockStyle.Top;
            buttonMiembos.FlatAppearance.BorderSize = 0;
            buttonMiembos.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 41, 71);
            buttonMiembos.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 41, 71);
            buttonMiembos.FlatStyle = FlatStyle.Flat;
            buttonMiembos.Font = new Font("Segoe UI Semibold", 10F);
            buttonMiembos.ForeColor = Color.White;
            buttonMiembos.Image = (Image)resources.GetObject("buttonMiembos.Image");
            buttonMiembos.ImageAlign = ContentAlignment.MiddleLeft;
            buttonMiembos.Location = new Point(0, 177);
            buttonMiembos.Name = "buttonMiembos";
            buttonMiembos.Padding = new Padding(15, 10, 0, 10);
            buttonMiembos.Size = new Size(200, 50);
            buttonMiembos.TabIndex = 4;
            buttonMiembos.Text = "  Miembros";
            buttonMiembos.TextAlign = ContentAlignment.MiddleLeft;
            buttonMiembos.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonMiembos.UseVisualStyleBackColor = false;
            buttonMiembos.Click += buttonMiembos_Click;
            // 
            // panelSubLibros
            // 
            panelSubLibros.BackColor = Color.FromArgb(24, 67, 99);
            panelSubLibros.Controls.Add(buttonAgregarLibro);
            panelSubLibros.Controls.Add(buttonBuscarLibro);
            panelSubLibros.Dock = DockStyle.Top;
            panelSubLibros.Location = new Point(0, 120);
            panelSubLibros.Name = "panelSubLibros";
            panelSubLibros.Size = new Size(200, 57);
            panelSubLibros.TabIndex = 3;
            // 
            // buttonAgregarLibro
            // 
            buttonAgregarLibro.AutoSize = true;
            buttonAgregarLibro.BackColor = Color.Transparent;
            buttonAgregarLibro.Dock = DockStyle.Top;
            buttonAgregarLibro.FlatAppearance.BorderSize = 0;
            buttonAgregarLibro.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            buttonAgregarLibro.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            buttonAgregarLibro.FlatStyle = FlatStyle.Flat;
            buttonAgregarLibro.ForeColor = Color.White;
            buttonAgregarLibro.Location = new Point(0, 25);
            buttonAgregarLibro.Name = "buttonAgregarLibro";
            buttonAgregarLibro.Padding = new Padding(30, 0, 0, 0);
            buttonAgregarLibro.Size = new Size(200, 25);
            buttonAgregarLibro.TabIndex = 1;
            buttonAgregarLibro.Text = "Agregar libros";
            buttonAgregarLibro.TextAlign = ContentAlignment.MiddleLeft;
            buttonAgregarLibro.UseVisualStyleBackColor = false;
            buttonAgregarLibro.Click += buttonAgregarLibro_Click;
            // 
            // buttonBuscarLibro
            // 
            buttonBuscarLibro.AutoSize = true;
            buttonBuscarLibro.BackColor = Color.Transparent;
            buttonBuscarLibro.Dock = DockStyle.Top;
            buttonBuscarLibro.FlatAppearance.BorderSize = 0;
            buttonBuscarLibro.FlatAppearance.MouseDownBackColor = SystemColors.GrayText;
            buttonBuscarLibro.FlatAppearance.MouseOverBackColor = SystemColors.GrayText;
            buttonBuscarLibro.FlatStyle = FlatStyle.Flat;
            buttonBuscarLibro.ForeColor = Color.White;
            buttonBuscarLibro.Location = new Point(0, 0);
            buttonBuscarLibro.Name = "buttonBuscarLibro";
            buttonBuscarLibro.Padding = new Padding(30, 0, 0, 0);
            buttonBuscarLibro.Size = new Size(200, 25);
            buttonBuscarLibro.TabIndex = 0;
            buttonBuscarLibro.Text = "Gestionar Libros";
            buttonBuscarLibro.TextAlign = ContentAlignment.MiddleLeft;
            buttonBuscarLibro.UseVisualStyleBackColor = false;
            buttonBuscarLibro.Click += buttonBuscarLibro_Click;
            // 
            // buttonLibros
            // 
            buttonLibros.AutoSize = true;
            buttonLibros.BackColor = Color.Transparent;
            buttonLibros.BackgroundImageLayout = ImageLayout.None;
            buttonLibros.Cursor = Cursors.Hand;
            buttonLibros.Dock = DockStyle.Top;
            buttonLibros.FlatAppearance.BorderSize = 0;
            buttonLibros.FlatAppearance.MouseDownBackColor = Color.FromArgb(1, 41, 71);
            buttonLibros.FlatAppearance.MouseOverBackColor = Color.FromArgb(1, 41, 71);
            buttonLibros.FlatStyle = FlatStyle.Flat;
            buttonLibros.Font = new Font("Segoe UI Semibold", 10F);
            buttonLibros.ForeColor = Color.White;
            buttonLibros.Image = (Image)resources.GetObject("buttonLibros.Image");
            buttonLibros.ImageAlign = ContentAlignment.MiddleLeft;
            buttonLibros.Location = new Point(0, 70);
            buttonLibros.Name = "buttonLibros";
            buttonLibros.Padding = new Padding(15, 10, 0, 10);
            buttonLibros.Size = new Size(200, 50);
            buttonLibros.TabIndex = 2;
            buttonLibros.Text = "  Libros";
            buttonLibros.TextAlign = ContentAlignment.MiddleLeft;
            buttonLibros.TextImageRelation = TextImageRelation.ImageBeforeText;
            buttonLibros.UseMnemonic = false;
            buttonLibros.UseVisualStyleBackColor = true;
            buttonLibros.Click += buttonLibros_Click;
            // 
            // panelLogo
            // 
            panelLogo.BackgroundImage = (Image)resources.GetObject("panelLogo.BackgroundImage");
            panelLogo.BackgroundImageLayout = ImageLayout.Zoom;
            panelLogo.Dock = DockStyle.Top;
            panelLogo.Location = new Point(0, 0);
            panelLogo.Margin = new Padding(15);
            panelLogo.Name = "panelLogo";
            panelLogo.Padding = new Padding(25);
            panelLogo.Size = new Size(200, 70);
            panelLogo.TabIndex = 0;
            // 
            // panelFormContent
            // 
            panelFormContent.BackColor = Color.White;
            panelFormContent.Controls.Add(panel1);
            panelFormContent.Dock = DockStyle.Fill;
            panelFormContent.Location = new Point(200, 0);
            panelFormContent.Name = "panelFormContent";
            panelFormContent.Size = new Size(502, 452);
            panelFormContent.TabIndex = 1;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Transparent;
            panel1.BackgroundImage = (Image)resources.GetObject("panel1.BackgroundImage");
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Location = new Point(95, 109);
            panel1.Name = "panel1";
            panel1.Size = new Size(317, 244);
            panel1.TabIndex = 0;
            // 
            // Home
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.Control;
            ClientSize = new Size(702, 452);
            Controls.Add(panelFormContent);
            Controls.Add(panelLeftMenu);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            Icon = (Icon)resources.GetObject("$this.Icon");
            MaximizeBox = false;
            Name = "Home";
            Opacity = 0.99D;
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Biblioteca";
            panelLeftMenu.ResumeLayout(false);
            panelLeftMenu.PerformLayout();
            panelSubPrestamos.ResumeLayout(false);
            panelSubPrestamos.PerformLayout();
            panelSubMiembros.ResumeLayout(false);
            panelSubMiembros.PerformLayout();
            panelSubLibros.ResumeLayout(false);
            panelSubLibros.PerformLayout();
            panelFormContent.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeftMenu;
        private Panel panelFormContent;
        private Panel panelLogo;
        private Button buttonLibros;
        private Panel panelSubPrestamos;
        private Button buttonPrestamos;
        private Panel panelSubMiembros;
        private Button buttonMiembos;
        private Panel panelSubLibros;
        private Button buttonBuscarLibro;
        private Panel panel1;
        private Button buttonAgregarLibro;
        private Button button1;
        private Button buttonMiembrosGest;
        private Button button2;
        private Button button3;
    }
}
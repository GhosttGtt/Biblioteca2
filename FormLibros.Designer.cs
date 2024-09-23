namespace Biblioteca
{
    partial class FormLibros
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
            dgvLibros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Column3 = new DataGridViewTextBoxColumn();
            Column4 = new DataGridViewTextBoxColumn();
            txtBuscar = new TextBox();
            Volver = new Button();
            label5 = new Label();
            btnEditarLibro = new Button();
            btnEliminarlibro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvLibros).BeginInit();
            SuspendLayout();
            // 
            // dgvLibros
            // 
            dgvLibros.AllowUserToAddRows = false;
            dgvLibros.AllowUserToDeleteRows = false;
            dgvLibros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvLibros.BackgroundColor = Color.White;
            dgvLibros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvLibros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2, Column3, Column4 });
            dgvLibros.GridColor = SystemColors.ScrollBar;
            dgvLibros.Location = new Point(12, 84);
            dgvLibros.MultiSelect = false;
            dgvLibros.Name = "dgvLibros";
            dgvLibros.ReadOnly = true;
            dgvLibros.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvLibros.Size = new Size(476, 319);
            dgvLibros.TabIndex = 9;
            // 
            // Column1
            // 
            Column1.HeaderText = "Titulo";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Autor";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Column3
            // 
            Column3.HeaderText = "Publicacion";
            Column3.Name = "Column3";
            Column3.ReadOnly = true;
            // 
            // Column4
            // 
            Column4.HeaderText = "Estado";
            Column4.Name = "Column4";
            Column4.ReadOnly = true;
            // 
            // txtBuscar
            // 
            txtBuscar.BackColor = SystemColors.Menu;
            txtBuscar.Location = new Point(12, 55);
            txtBuscar.Name = "txtBuscar";
            txtBuscar.PlaceholderText = "Escribe el nombre de un libro";
            txtBuscar.Size = new Size(476, 23);
            txtBuscar.TabIndex = 10;
            txtBuscar.TextChanged += txtBuscar_TextChanged;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.FlatStyle = FlatStyle.Flat;
            Volver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = Color.White;
            Volver.Location = new Point(413, 12);
            Volver.Name = "Volver";
            Volver.Size = new Size(75, 27);
            Volver.TabIndex = 19;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 13);
            label5.Name = "label5";
            label5.Size = new Size(153, 25);
            label5.TabIndex = 22;
            label5.Text = "Gestionar libros";
            label5.Click += label5_Click;
            // 
            // btnEditarLibro
            // 
            btnEditarLibro.Location = new Point(12, 409);
            btnEditarLibro.Name = "btnEditarLibro";
            btnEditarLibro.Size = new Size(251, 23);
            btnEditarLibro.TabIndex = 23;
            btnEditarLibro.Text = "Editar libro";
            btnEditarLibro.UseVisualStyleBackColor = true;
            btnEditarLibro.Click += btnEditarLibro_Click;
            // 
            // btnEliminarlibro
            // 
            btnEliminarlibro.BackColor = Color.Red;
            btnEliminarlibro.FlatStyle = FlatStyle.Flat;
            btnEliminarlibro.ForeColor = Color.White;
            btnEliminarlibro.Location = new Point(251, 409);
            btnEliminarlibro.Name = "btnEliminarlibro";
            btnEliminarlibro.Size = new Size(237, 23);
            btnEliminarlibro.TabIndex = 24;
            btnEliminarlibro.Text = "Eliminar libro";
            btnEliminarlibro.UseVisualStyleBackColor = false;
            btnEliminarlibro.Click += btnEliminarlibro_Click;
            // 
            // FormLibros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 255);
            ClientSize = new Size(500, 450);
            Controls.Add(btnEliminarlibro);
            Controls.Add(btnEditarLibro);
            Controls.Add(label5);
            Controls.Add(Volver);
            Controls.Add(txtBuscar);
            Controls.Add(dgvLibros);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLibros";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLibros";
            ((System.ComponentModel.ISupportInitialize)dgvLibros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private DataGridView dgvLibros;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private DataGridViewTextBoxColumn Column3;
        private DataGridViewTextBoxColumn Column4;
        private TextBox txtBuscar;
        private Button Volver;
        private Label label5;
        private Button btnEditarLibro;
        private Button btnEliminarlibro;
    }
}
namespace Biblioteca
{
    partial class FormMiembros
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
            label5 = new Label();
            dgvMiembros = new DataGridView();
            Column1 = new DataGridViewTextBoxColumn();
            Column2 = new DataGridViewTextBoxColumn();
            Volver = new Button();
            btnModificarMiembro = new Button();
            txtNombreEdit = new TextBox();
            label3 = new Label();
            btnEliminarMiembro = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).BeginInit();
            SuspendLayout();
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 11);
            label5.Name = "label5";
            label5.Size = new Size(192, 25);
            label5.TabIndex = 23;
            label5.Text = "Gestionar miembros";
            // 
            // dgvMiembros
            // 
            dgvMiembros.AllowUserToAddRows = false;
            dgvMiembros.AllowUserToDeleteRows = false;
            dgvMiembros.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dgvMiembros.BackgroundColor = SystemColors.Control;
            dgvMiembros.BorderStyle = BorderStyle.None;
            dgvMiembros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvMiembros.Columns.AddRange(new DataGridViewColumn[] { Column1, Column2 });
            dgvMiembros.Location = new Point(12, 51);
            dgvMiembros.MultiSelect = false;
            dgvMiembros.Name = "dgvMiembros";
            dgvMiembros.ReadOnly = true;
            dgvMiembros.RowHeadersWidthSizeMode = DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            dgvMiembros.Size = new Size(476, 335);
            dgvMiembros.TabIndex = 25;
            dgvMiembros.CellContentClick += dvgMiembros_CellContentClick;
            // 
            // Column1
            // 
            Column1.HeaderText = "Miembro";
            Column1.Name = "Column1";
            Column1.ReadOnly = true;
            // 
            // Column2
            // 
            Column2.HeaderText = "Número de miembro";
            Column2.Name = "Column2";
            Column2.ReadOnly = true;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.FlatStyle = FlatStyle.Flat;
            Volver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = Color.White;
            Volver.Location = new Point(413, 9);
            Volver.Name = "Volver";
            Volver.Size = new Size(75, 27);
            Volver.TabIndex = 26;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // btnModificarMiembro
            // 
            btnModificarMiembro.Location = new Point(319, 401);
            btnModificarMiembro.Name = "btnModificarMiembro";
            btnModificarMiembro.Size = new Size(88, 23);
            btnModificarMiembro.TabIndex = 30;
            btnModificarMiembro.Text = "Modificar";
            btnModificarMiembro.UseVisualStyleBackColor = true;
            btnModificarMiembro.Click += btnModificarMiembro_Click;
            // 
            // txtNombreEdit
            // 
            txtNombreEdit.Location = new Point(118, 402);
            txtNombreEdit.Name = "txtNombreEdit";
            txtNombreEdit.Size = new Size(191, 23);
            txtNombreEdit.TabIndex = 31;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 406);
            label3.Name = "label3";
            label3.Size = new Size(90, 15);
            label3.TabIndex = 32;
            label3.Text = "Nuevo nombre:";
            // 
            // btnEliminarMiembro
            // 
            btnEliminarMiembro.Location = new Point(413, 401);
            btnEliminarMiembro.Name = "btnEliminarMiembro";
            btnEliminarMiembro.Size = new Size(75, 23);
            btnEliminarMiembro.TabIndex = 33;
            btnEliminarMiembro.Text = "Eliminar";
            btnEliminarMiembro.UseVisualStyleBackColor = true;
            btnEliminarMiembro.Click += btnEliminarMiembro_Click_1;
            // 
            // FormMiembros
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 255);
            ClientSize = new Size(500, 450);
            Controls.Add(btnEliminarMiembro);
            Controls.Add(label3);
            Controls.Add(txtNombreEdit);
            Controls.Add(btnModificarMiembro);
            Controls.Add(Volver);
            Controls.Add(dgvMiembros);
            Controls.Add(label5);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMiembros";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMiembros";
            ((System.ComponentModel.ISupportInitialize)dgvMiembros).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label label5;
        private DataGridView dgvMiembros;
        private Button Volver;
        private Button btnModificarMiembro;
        private DataGridViewTextBoxColumn Column1;
        private DataGridViewTextBoxColumn Column2;
        private TextBox txtNombreEdit;
        private Label label3;
        private Button btnEliminarMiembro;
    }
}
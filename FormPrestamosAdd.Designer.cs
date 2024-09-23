namespace Biblioteca
{
    partial class FormPrestamosAdd
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
            btnRealizarPrestamo = new Button();
            cmbLibros = new ComboBox();
            cmbMiembros = new ComboBox();
            dtpFechaPrestamo = new DateTimePicker();
            Volver = new Button();
            label5 = new Label();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // btnRealizarPrestamo
            // 
            btnRealizarPrestamo.BackColor = Color.FromArgb(0, 192, 0);
            btnRealizarPrestamo.FlatAppearance.BorderSize = 0;
            btnRealizarPrestamo.FlatStyle = FlatStyle.Flat;
            btnRealizarPrestamo.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnRealizarPrestamo.ForeColor = SystemColors.ControlLightLight;
            btnRealizarPrestamo.Location = new Point(107, 125);
            btnRealizarPrestamo.Name = "btnRealizarPrestamo";
            btnRealizarPrestamo.Size = new Size(250, 35);
            btnRealizarPrestamo.TabIndex = 0;
            btnRealizarPrestamo.Text = "Prestamo";
            btnRealizarPrestamo.UseVisualStyleBackColor = false;
            btnRealizarPrestamo.Click += btnRealizarPrestamo_Click;
            // 
            // cmbLibros
            // 
            cmbLibros.FormattingEnabled = true;
            cmbLibros.Location = new Point(29, 25);
            cmbLibros.Name = "cmbLibros";
            cmbLibros.Size = new Size(412, 23);
            cmbLibros.TabIndex = 1;
            // 
            // cmbMiembros
            // 
            cmbMiembros.FormattingEnabled = true;
            cmbMiembros.Location = new Point(29, 54);
            cmbMiembros.Name = "cmbMiembros";
            cmbMiembros.Size = new Size(412, 23);
            cmbMiembros.TabIndex = 2;
            // 
            // dtpFechaPrestamo
            // 
            dtpFechaPrestamo.Location = new Point(29, 83);
            dtpFechaPrestamo.Name = "dtpFechaPrestamo";
            dtpFechaPrestamo.Size = new Size(412, 23);
            dtpFechaPrestamo.TabIndex = 4;
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.FlatStyle = FlatStyle.Flat;
            Volver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = Color.White;
            Volver.Location = new Point(413, 14);
            Volver.Name = "Volver";
            Volver.Size = new Size(75, 27);
            Volver.TabIndex = 27;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(12, 12);
            label5.Name = "label5";
            label5.Size = new Size(182, 25);
            label5.TabIndex = 28;
            label5.Text = "Hacer un prestamo";
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveCaption;
            panel1.Controls.Add(cmbLibros);
            panel1.Controls.Add(cmbMiembros);
            panel1.Controls.Add(btnRealizarPrestamo);
            panel1.Controls.Add(dtpFechaPrestamo);
            panel1.Location = new Point(12, 57);
            panel1.Name = "panel1";
            panel1.Size = new Size(476, 224);
            panel1.TabIndex = 29;
            // 
            // FormPrestamosAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 255);
            ClientSize = new Size(500, 450);
            Controls.Add(label5);
            Controls.Add(Volver);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormPrestamosAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormPrestamos";
            panel1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnRealizarPrestamo;
        private ComboBox cmbLibros;
        private ComboBox cmbMiembros;
        private DateTimePicker dtpFechaPrestamo;
        private Button Volver;
        private Label label5;
        private Panel panel1;
    }
}
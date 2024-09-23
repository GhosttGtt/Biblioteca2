namespace Biblioteca
{
    partial class FormMiembrosAdd
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
            btnAgregarMiembro = new Button();
            txtNombre = new TextBox();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            label4 = new Label();
            Volver = new Button();
            label1 = new Label();
            label2 = new Label();
            nMiembro = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarMiembro
            // 
            btnAgregarMiembro.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarMiembro.Cursor = Cursors.Hand;
            btnAgregarMiembro.FlatAppearance.BorderSize = 0;
            btnAgregarMiembro.FlatStyle = FlatStyle.Flat;
            btnAgregarMiembro.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarMiembro.ForeColor = SystemColors.ControlLightLight;
            btnAgregarMiembro.Location = new Point(133, 292);
            btnAgregarMiembro.Name = "btnAgregarMiembro";
            btnAgregarMiembro.Size = new Size(250, 35);
            btnAgregarMiembro.TabIndex = 0;
            btnAgregarMiembro.Text = "Agregar";
            btnAgregarMiembro.UseVisualStyleBackColor = false;
            btnAgregarMiembro.Click += btnAgregarMiembro_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(175, 230);
            txtNombre.Name = "txtNombre";
            txtNombre.PlaceholderText = "Escribe un nombre";
            txtNombre.Size = new Size(227, 23);
            txtNombre.TabIndex = 1;
            txtNombre.TextChanged += txtNombre_TextChanged;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(14, 57);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(474, 374);
            pictureBox1.TabIndex = 21;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(14, 12);
            label5.Name = "label5";
            label5.Size = new Size(171, 25);
            label5.TabIndex = 23;
            label5.Text = "Agregar miembro";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = SystemColors.ActiveCaption;
            label4.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.Location = new Point(133, 137);
            label4.Name = "label4";
            label4.Size = new Size(235, 21);
            label4.TabIndex = 24;
            label4.Text = "REGISTRAR NUEVO MIEMBRO";
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
            Volver.TabIndex = 26;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(115, 233);
            label1.Name = "label1";
            label1.Size = new Size(54, 15);
            label1.TabIndex = 27;
            label1.Text = "Nombre:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(116, 195);
            label2.Name = "label2";
            label2.Size = new Size(122, 15);
            label2.TabIndex = 28;
            label2.Text = "Número de Miembro:";
            // 
            // nMiembro
            // 
            nMiembro.BackColor = SystemColors.ActiveCaption;
            nMiembro.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            nMiembro.Location = new Point(261, 190);
            nMiembro.Name = "nMiembro";
            nMiembro.Size = new Size(141, 25);
            nMiembro.TabIndex = 29;
            nMiembro.Text = "0";
            nMiembro.TextAlign = ContentAlignment.MiddleRight;
            // 
            // FormMiembrosAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 255);
            ClientSize = new Size(500, 450);
            Controls.Add(nMiembro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(Volver);
            Controls.Add(label4);
            Controls.Add(label5);
            Controls.Add(txtNombre);
            Controls.Add(btnAgregarMiembro);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormMiembrosAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormMiembros";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarMiembro;
        private TextBox txtNombre;
        private PictureBox pictureBox1;
        private Label label5;
        private Label label4;
        private Button Volver;
        private Label label1;
        private Label label2;
        private Label nMiembro;
    }
}
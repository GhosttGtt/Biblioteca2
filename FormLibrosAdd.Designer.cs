namespace Biblioteca
{
    partial class FormLibrosAdd
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
            btnAgregarLibro = new Button();
            txtTitulo = new TextBox();
            txtAutor = new TextBox();
            txtAnioPublicacion = new TextBox();
            txtUbicacion = new TextBox();
            txtTamanoArchivo = new TextBox();
            txtFormato = new TextBox();
            cmbTipoLibro = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            lblUbicacion = new Label();
            lblTamanoArchivo = new Label();
            lblFormato = new Label();
            Volver = new Button();
            pictureBox1 = new PictureBox();
            label5 = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // btnAgregarLibro
            // 
            btnAgregarLibro.BackColor = Color.FromArgb(0, 192, 0);
            btnAgregarLibro.Cursor = Cursors.Hand;
            btnAgregarLibro.FlatAppearance.BorderSize = 0;
            btnAgregarLibro.FlatStyle = FlatStyle.Flat;
            btnAgregarLibro.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAgregarLibro.ForeColor = SystemColors.ControlLightLight;
            btnAgregarLibro.Location = new Point(122, 374);
            btnAgregarLibro.Name = "btnAgregarLibro";
            btnAgregarLibro.Size = new Size(250, 35);
            btnAgregarLibro.TabIndex = 0;
            btnAgregarLibro.Text = "Agregar";
            btnAgregarLibro.UseVisualStyleBackColor = false;
            btnAgregarLibro.Click += btnAgregarLibro_Click;
            // 
            // txtTitulo
            // 
            txtTitulo.Location = new Point(136, 129);
            txtTitulo.Name = "txtTitulo";
            txtTitulo.Size = new Size(330, 23);
            txtTitulo.TabIndex = 1;
            // 
            // txtAutor
            // 
            txtAutor.Location = new Point(136, 173);
            txtAutor.Name = "txtAutor";
            txtAutor.Size = new Size(330, 23);
            txtAutor.TabIndex = 2;
            // 
            // txtAnioPublicacion
            // 
            txtAnioPublicacion.Location = new Point(136, 217);
            txtAnioPublicacion.Name = "txtAnioPublicacion";
            txtAnioPublicacion.Size = new Size(330, 23);
            txtAnioPublicacion.TabIndex = 3;
            // 
            // txtUbicacion
            // 
            txtUbicacion.Location = new Point(136, 262);
            txtUbicacion.Name = "txtUbicacion";
            txtUbicacion.Size = new Size(330, 23);
            txtUbicacion.TabIndex = 4;
            // 
            // txtTamanoArchivo
            // 
            txtTamanoArchivo.Location = new Point(136, 261);
            txtTamanoArchivo.Name = "txtTamanoArchivo";
            txtTamanoArchivo.Size = new Size(330, 23);
            txtTamanoArchivo.TabIndex = 5;
            // 
            // txtFormato
            // 
            txtFormato.Location = new Point(136, 305);
            txtFormato.Name = "txtFormato";
            txtFormato.Size = new Size(330, 23);
            txtFormato.TabIndex = 6;
            // 
            // cmbTipoLibro
            // 
            cmbTipoLibro.FormattingEnabled = true;
            cmbTipoLibro.Location = new Point(30, 83);
            cmbTipoLibro.Name = "cmbTipoLibro";
            cmbTipoLibro.Size = new Size(436, 23);
            cmbTipoLibro.TabIndex = 12;
            cmbTipoLibro.Text = "Tipo de Libro";
            cmbTipoLibro.SelectedIndexChanged += cmbTipoLibro_SelectedIndexChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = SystemColors.ActiveCaption;
            label1.Location = new Point(30, 132);
            label1.Name = "label1";
            label1.Size = new Size(100, 15);
            label1.TabIndex = 13;
            label1.Text = "Nombre del libro:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = SystemColors.ActiveCaption;
            label2.Location = new Point(30, 176);
            label2.Name = "label2";
            label2.Size = new Size(104, 15);
            label2.TabIndex = 14;
            label2.Text = "Nombre del autor:";
            label2.Click += label2_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = SystemColors.ActiveCaption;
            label3.Location = new Point(30, 220);
            label3.Name = "label3";
            label3.Size = new Size(97, 15);
            label3.TabIndex = 15;
            label3.Text = "Año publicacion:";
            // 
            // lblUbicacion
            // 
            lblUbicacion.AutoSize = true;
            lblUbicacion.BackColor = SystemColors.ActiveCaption;
            lblUbicacion.Location = new Point(30, 262);
            lblUbicacion.Name = "lblUbicacion";
            lblUbicacion.Size = new Size(63, 15);
            lblUbicacion.TabIndex = 16;
            lblUbicacion.Text = "Ubicación:";
            // 
            // lblTamanoArchivo
            // 
            lblTamanoArchivo.AutoSize = true;
            lblTamanoArchivo.BackColor = SystemColors.ActiveCaption;
            lblTamanoArchivo.Location = new Point(30, 264);
            lblTamanoArchivo.Name = "lblTamanoArchivo";
            lblTamanoArchivo.Size = new Size(91, 15);
            lblTamanoArchivo.TabIndex = 17;
            lblTamanoArchivo.Text = "Tamaño archivo";
            // 
            // lblFormato
            // 
            lblFormato.AutoSize = true;
            lblFormato.BackColor = SystemColors.ActiveCaption;
            lblFormato.Location = new Point(30, 309);
            lblFormato.Name = "lblFormato";
            lblFormato.Size = new Size(52, 15);
            lblFormato.TabIndex = 18;
            lblFormato.Text = "Formato";
            // 
            // Volver
            // 
            Volver.BackColor = Color.Red;
            Volver.FlatStyle = FlatStyle.Flat;
            Volver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            Volver.ForeColor = Color.White;
            Volver.Location = new Point(413, 10);
            Volver.Name = "Volver";
            Volver.Size = new Size(75, 27);
            Volver.TabIndex = 19;
            Volver.Text = "Regresar";
            Volver.UseVisualStyleBackColor = false;
            Volver.Click += Volver_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.BackColor = SystemColors.ActiveCaption;
            pictureBox1.Location = new Point(13, 58);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(475, 377);
            pictureBox1.TabIndex = 20;
            pictureBox1.TabStop = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.Location = new Point(13, 12);
            label5.Name = "label5";
            label5.Size = new Size(132, 25);
            label5.TabIndex = 22;
            label5.Text = "Agregar libro";
            label5.Click += label5_Click;
            // 
            // FormLibrosAdd
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(220, 225, 255);
            ClientSize = new Size(500, 450);
            Controls.Add(label5);
            Controls.Add(Volver);
            Controls.Add(lblFormato);
            Controls.Add(lblTamanoArchivo);
            Controls.Add(lblUbicacion);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(cmbTipoLibro);
            Controls.Add(txtFormato);
            Controls.Add(txtTamanoArchivo);
            Controls.Add(txtUbicacion);
            Controls.Add(txtAnioPublicacion);
            Controls.Add(txtAutor);
            Controls.Add(txtTitulo);
            Controls.Add(btnAgregarLibro);
            Controls.Add(pictureBox1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "FormLibrosAdd";
            StartPosition = FormStartPosition.CenterParent;
            Text = "FormLibrosAdd";
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAgregarLibro;
        private TextBox txtTitulo;
        private TextBox txtAutor;
        private TextBox txtAnioPublicacion;
        private TextBox txtUbicacion;
        private TextBox txtTamanoArchivo;
        private TextBox txtFormato;
        private ComboBox cmbTipoLibro;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label lblUbicacion;
        private Label lblTamanoArchivo;
        private Label lblFormato;
        private Button Volver;
        private PictureBox pictureBox1;
        private Label label5;
    }
}
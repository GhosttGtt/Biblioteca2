namespace Biblioteca
{
    partial class ToastForm
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
            toastBorder = new Panel();
            picIcon = new PictureBox();
            lblTitle = new Label();
            lblMessage = new Label();
            ((System.ComponentModel.ISupportInitialize)picIcon).BeginInit();
            SuspendLayout();
            // 
            // toastBorder
            // 
            toastBorder.BackColor = Color.FromArgb(57, 155, 53);
            toastBorder.Dock = DockStyle.Left;
            toastBorder.Location = new Point(0, 0);
            toastBorder.Name = "toastBorder";
            toastBorder.Size = new Size(5, 59);
            toastBorder.TabIndex = 0;
            toastBorder.Paint += toastBorder_Paint;
            // 
            // picIcon
            // 
            
            picIcon.Location = new Point(12, 12);
            picIcon.Name = "picIcon";
            picIcon.Size = new Size(32, 32);
            picIcon.SizeMode = PictureBoxSizeMode.StretchImage;
            picIcon.TabIndex = 1;
            picIcon.TabStop = false;
            // 
            // lblTitle
            // 
            lblTitle.AutoSize = true;
            lblTitle.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.Location = new Point(56, 9);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(37, 17);
            lblTitle.TabIndex = 2;
            lblTitle.Text = "Type";
            // 
            // lblMessage
            // 
            lblMessage.AutoSize = true;
            lblMessage.Font = new Font("Segoe UI", 8.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblMessage.Location = new Point(56, 31);
            lblMessage.Name = "lblMessage";
            lblMessage.Size = new Size(52, 13);
            lblMessage.TabIndex = 3;
            lblMessage.Text = "Message";
            // 
            // ToastForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(298, 59);
            Controls.Add(lblMessage);
            Controls.Add(lblTitle);
            Controls.Add(picIcon);
            Controls.Add(toastBorder);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ToastForm";
            Text = "ToastForm";
            Load += ToastForm_Load;
            ((System.ComponentModel.ISupportInitialize)picIcon).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel toastBorder;
        private PictureBox picIcon;
        private Label lblTitle;
        private Label lblMessage;
    }
}
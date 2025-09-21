namespace pryAstudilloSp1
{
    partial class frmInicio
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
            lblBienvenido = new Label();
            btnIngresar = new Button();
            lblLogo = new Label();
            SuspendLayout();
            // 
            // lblBienvenido
            // 
            lblBienvenido.AutoSize = true;
            lblBienvenido.BorderStyle = BorderStyle.Fixed3D;
            lblBienvenido.Font = new Font("SimSun", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblBienvenido.Location = new Point(124, 101);
            lblBienvenido.Name = "lblBienvenido";
            lblBienvenido.Size = new Size(254, 23);
            lblBienvenido.TabIndex = 0;
            lblBienvenido.Text = "Bienvenido al sistema!";
            lblBienvenido.Click += label1_Click;
            // 
            // btnIngresar
            // 
            btnIngresar.Location = new Point(207, 172);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(80, 27);
            btnIngresar.TabIndex = 1;
            btnIngresar.Text = "&Ingresar";
            btnIngresar.UseVisualStyleBackColor = true;
            // 
            // lblLogo
            // 
            lblLogo.AutoSize = true;
            lblLogo.Font = new Font("Stencil", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblLogo.ForeColor = Color.CornflowerBlue;
            lblLogo.Location = new Point(12, 9);
            lblLogo.Name = "lblLogo";
            lblLogo.Size = new Size(151, 22);
            lblLogo.TabIndex = 2;
            lblLogo.Text = "Sintepart SRL";
            // 
            // frmInicio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(495, 283);
            Controls.Add(lblLogo);
            Controls.Add(btnIngresar);
            Controls.Add(lblBienvenido);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Name = "frmInicio";
            StartPosition = FormStartPosition.CenterScreen;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblBienvenido;
        private Button btnIngresar;
        private Label lblLogo;
    }
}
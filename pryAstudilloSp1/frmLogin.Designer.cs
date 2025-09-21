namespace pryAstudilloSp1
{
    partial class frmLogin
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
            label1 = new Label();
            l = new Label();
            lblMódulo = new Label();
            btnCancelar = new Button();
            btnAceptar = new Button();
            cmbMódulo = new ComboBox();
            txtContraseña = new TextBox();
            txtUsuario = new TextBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(56, 56);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 0;
            label1.Text = "Usuario ";
            // 
            // l
            // 
            l.AutoSize = true;
            l.Location = new Point(56, 107);
            l.Name = "l";
            l.Size = new Size(67, 15);
            l.TabIndex = 1;
            l.Text = "Contraseña";
            // 
            // lblMódulo
            // 
            lblMódulo.AutoSize = true;
            lblMódulo.Location = new Point(56, 170);
            lblMódulo.Name = "lblMódulo";
            lblMódulo.Size = new Size(49, 15);
            lblMódulo.TabIndex = 2;
            lblMódulo.Text = "Módulo";
            // 
            // btnCancelar
            // 
            btnCancelar.Location = new Point(233, 239);
            btnCancelar.Name = "btnCancelar";
            btnCancelar.Size = new Size(75, 23);
            btnCancelar.TabIndex = 3;
            btnCancelar.Text = "&Cancelar";
            btnCancelar.UseVisualStyleBackColor = true;
            btnCancelar.Click += btnCancelar_Click;
            // 
            // btnAceptar
            // 
            btnAceptar.Location = new Point(88, 239);
            btnAceptar.Name = "btnAceptar";
            btnAceptar.Size = new Size(75, 23);
            btnAceptar.TabIndex = 4;
            btnAceptar.Text = "&Aceptar";
            btnAceptar.UseVisualStyleBackColor = true;
            btnAceptar.Click += btnAceptar_Click;
            // 
            // cmbMódulo
            // 
            cmbMódulo.DropDownStyle = ComboBoxStyle.DropDownList;
            cmbMódulo.FormattingEnabled = true;
            cmbMódulo.Items.AddRange(new object[] { "ADM", "SIST", "COM", "VTA" });
            cmbMódulo.Location = new Point(150, 162);
            cmbMódulo.Name = "cmbMódulo";
            cmbMódulo.Size = new Size(158, 23);
            cmbMódulo.TabIndex = 5;
            // 
            // txtContraseña
            // 
            txtContraseña.Enabled = false;
            txtContraseña.Location = new Point(150, 99);
            txtContraseña.MaxLength = 10;
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(158, 23);
            txtContraseña.TabIndex = 6;
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(150, 48);
            txtUsuario.MaxLength = 10;
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(158, 23);
            txtUsuario.TabIndex = 7;
            txtUsuario.TextChanged += txtUsuario_TextChanged;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(389, 307);
            Controls.Add(txtUsuario);
            Controls.Add(txtContraseña);
            Controls.Add(cmbMódulo);
            Controls.Add(btnAceptar);
            Controls.Add(btnCancelar);
            Controls.Add(lblMódulo);
            Controls.Add(l);
            Controls.Add(label1);
            Name = "frmLogin";
            Text = "frmLogin";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label l;
        private Label lblMódulo;
        private Button btnCancelar;
        private Button btnAceptar;
        private ComboBox cmbMódulo;
        private TextBox txtContraseña;
        private TextBox txtUsuario;
    }
}
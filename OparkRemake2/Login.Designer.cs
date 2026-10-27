namespace OparkRemake2
{
    partial class Login
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            panelLeft = new Panel();
            lblTitulo = new Label();
            panelRight = new Panel();
            btnIngresar = new Button();
            txtContraseña = new TextBox();
            lblContraseña = new Label();
            lblUsuario = new Label();
            txtUsuario = new TextBox();
            lblIniSesion = new Label();
            btnCerrar = new Button();
            panelLeft.SuspendLayout();
            panelRight.SuspendLayout();
            SuspendLayout();
            // 
            // panelLeft
            // 
            panelLeft.BackColor = Color.FromArgb(15, 23, 42);
            panelLeft.Controls.Add(lblTitulo);
            panelLeft.Dock = DockStyle.Left;
            panelLeft.Location = new Point(0, 0);
            panelLeft.Name = "panelLeft";
            panelLeft.Size = new Size(300, 511);
            panelLeft.TabIndex = 0;
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Font = new Font("Segoe UI", 55F, FontStyle.Bold);
            lblTitulo.ForeColor = Color.White;
            lblTitulo.Location = new Point(98, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(98, 495);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "O\r\nP\r\nA\r\nR\r\nQ";
            // 
            // panelRight
            // 
            panelRight.Controls.Add(btnIngresar);
            panelRight.Controls.Add(txtContraseña);
            panelRight.Controls.Add(lblContraseña);
            panelRight.Controls.Add(lblUsuario);
            panelRight.Controls.Add(txtUsuario);
            panelRight.Controls.Add(lblIniSesion);
            panelRight.Controls.Add(btnCerrar);
            panelRight.Dock = DockStyle.Fill;
            panelRight.Location = new Point(300, 0);
            panelRight.Name = "panelRight";
            panelRight.Size = new Size(434, 511);
            panelRight.TabIndex = 1;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.FromArgb(0, 122, 204);
            btnIngresar.FlatAppearance.BorderSize = 0;
            btnIngresar.FlatStyle = FlatStyle.Flat;
            btnIngresar.Font = new Font("Segoe UI", 12F, FontStyle.Bold);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(44, 347);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(345, 49);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "INGRESAR";
            btnIngresar.UseVisualStyleBackColor = false;
            // 
            // txtContraseña
            // 
            txtContraseña.BackColor = Color.FromArgb(45, 45, 50);
            txtContraseña.BorderStyle = BorderStyle.FixedSingle;
            txtContraseña.Font = new Font("Segoe UI", 11F);
            txtContraseña.ForeColor = Color.White;
            txtContraseña.Location = new Point(44, 280);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.Size = new Size(345, 27);
            txtContraseña.TabIndex = 5;
            // 
            // lblContraseña
            // 
            lblContraseña.AutoSize = true;
            lblContraseña.Font = new Font("Segoe UI", 11F);
            lblContraseña.ForeColor = Color.White;
            lblContraseña.Location = new Point(44, 235);
            lblContraseña.Name = "lblContraseña";
            lblContraseña.Size = new Size(83, 20);
            lblContraseña.TabIndex = 4;
            lblContraseña.Text = "Contraseña";
            // 
            // lblUsuario
            // 
            lblUsuario.AutoSize = true;
            lblUsuario.Font = new Font("Segoe UI", 11F);
            lblUsuario.ForeColor = Color.White;
            lblUsuario.Location = new Point(44, 153);
            lblUsuario.Name = "lblUsuario";
            lblUsuario.Size = new Size(59, 20);
            lblUsuario.TabIndex = 3;
            lblUsuario.Text = "Usuario";
            // 
            // txtUsuario
            // 
            txtUsuario.BackColor = Color.FromArgb(45, 45, 50);
            txtUsuario.BorderStyle = BorderStyle.FixedSingle;
            txtUsuario.Font = new Font("Segoe UI", 11F);
            txtUsuario.ForeColor = Color.White;
            txtUsuario.Location = new Point(44, 187);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(345, 27);
            txtUsuario.TabIndex = 2;
            // 
            // lblIniSesion
            // 
            lblIniSesion.AutoSize = true;
            lblIniSesion.Font = new Font("Segoe UI", 15F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblIniSesion.ForeColor = Color.White;
            lblIniSesion.Location = new Point(44, 50);
            lblIniSesion.Name = "lblIniSesion";
            lblIniSesion.Size = new Size(161, 28);
            lblIniSesion.TabIndex = 1;
            lblIniSesion.Text = "INICIAR SESIÓN";
            // 
            // btnCerrar
            // 
            btnCerrar.FlatAppearance.BorderSize = 0;
            btnCerrar.FlatStyle = FlatStyle.Flat;
            btnCerrar.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrar.ForeColor = Color.White;
            btnCerrar.Location = new Point(394, 0);
            btnCerrar.Name = "btnCerrar";
            btnCerrar.Size = new Size(40, 40);
            btnCerrar.TabIndex = 0;
            btnCerrar.Text = "✕";
            btnCerrar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(734, 511);
            Controls.Add(panelRight);
            Controls.Add(panelLeft);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Login";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Login";
            panelLeft.ResumeLayout(false);
            panelLeft.PerformLayout();
            panelRight.ResumeLayout(false);
            panelRight.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Panel panelLeft;
        private Panel panelRight;
        private Button btnCerrar;
        private Label lblIniSesion;
        private Label lblContraseña;
        private Label lblUsuario;
        private TextBox txtUsuario;
        private Button btnIngresar;
        private TextBox txtContraseña;
        private Label lblTitulo;
    }
}

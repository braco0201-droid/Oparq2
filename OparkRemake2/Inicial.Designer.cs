namespace OparkRemake2
{
    partial class Inicial
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
            panelIzquierdaInicial = new Panel();
            btnClientesInicial = new Button();
            lblTituloInicial = new Label();
            panelCabezaInicial = new Panel();
            btnMinimizarInicial = new Button();
            btnMaximizarInicial = new Button();
            btnCerrarInicial = new Button();
            panelIzquierdaInicial.SuspendLayout();
            panelCabezaInicial.SuspendLayout();
            SuspendLayout();
            // 
            // panelIzquierdaInicial
            // 
            panelIzquierdaInicial.BackColor = Color.FromArgb(15, 23, 42);
            panelIzquierdaInicial.Controls.Add(btnClientesInicial);
            panelIzquierdaInicial.Controls.Add(lblTituloInicial);
            panelIzquierdaInicial.Dock = DockStyle.Left;
            panelIzquierdaInicial.Location = new Point(0, 0);
            panelIzquierdaInicial.Name = "panelIzquierdaInicial";
            panelIzquierdaInicial.Size = new Size(220, 1040);
            panelIzquierdaInicial.TabIndex = 1;
            // 
            // btnClientesInicial
            // 
            btnClientesInicial.Dock = DockStyle.Top;
            btnClientesInicial.Location = new Point(0, 147);
            btnClientesInicial.Name = "btnClientesInicial";
            btnClientesInicial.Size = new Size(220, 23);
            btnClientesInicial.TabIndex = 1;
            btnClientesInicial.Text = "button1";
            btnClientesInicial.UseVisualStyleBackColor = true;
            // 
            // lblTituloInicial
            // 
            lblTituloInicial.AutoSize = true;
            lblTituloInicial.Dock = DockStyle.Top;
            lblTituloInicial.Font = new Font("Segoe UI", 26F, FontStyle.Bold);
            lblTituloInicial.ForeColor = Color.White;
            lblTituloInicial.Location = new Point(0, 0);
            lblTituloInicial.Name = "lblTituloInicial";
            lblTituloInicial.Padding = new Padding(30, 50, 0, 50);
            lblTituloInicial.Size = new Size(172, 147);
            lblTituloInicial.TabIndex = 0;
            lblTituloInicial.Text = "OPARQ";
            // 
            // panelCabezaInicial
            // 
            panelCabezaInicial.BackColor = Color.FromArgb(30, 30, 36);
            panelCabezaInicial.Controls.Add(btnMinimizarInicial);
            panelCabezaInicial.Controls.Add(btnMaximizarInicial);
            panelCabezaInicial.Controls.Add(btnCerrarInicial);
            panelCabezaInicial.Dock = DockStyle.Top;
            panelCabezaInicial.Location = new Point(220, 0);
            panelCabezaInicial.Name = "panelCabezaInicial";
            panelCabezaInicial.Size = new Size(1700, 45);
            panelCabezaInicial.TabIndex = 2;
            // 
            // btnMinimizarInicial
            // 
            btnMinimizarInicial.BackColor = Color.FromArgb(30, 30, 36);
            btnMinimizarInicial.Dock = DockStyle.Right;
            btnMinimizarInicial.FlatAppearance.BorderSize = 0;
            btnMinimizarInicial.FlatStyle = FlatStyle.Flat;
            btnMinimizarInicial.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnMinimizarInicial.ForeColor = Color.White;
            btnMinimizarInicial.Location = new Point(1565, 0);
            btnMinimizarInicial.Name = "btnMinimizarInicial";
            btnMinimizarInicial.Size = new Size(45, 45);
            btnMinimizarInicial.TabIndex = 2;
            btnMinimizarInicial.Text = "—";
            btnMinimizarInicial.UseVisualStyleBackColor = false;
            // 
            // btnMaximizarInicial
            // 
            btnMaximizarInicial.BackColor = Color.FromArgb(30, 30, 36);
            btnMaximizarInicial.Dock = DockStyle.Right;
            btnMaximizarInicial.FlatAppearance.BorderSize = 0;
            btnMaximizarInicial.FlatStyle = FlatStyle.Flat;
            btnMaximizarInicial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnMaximizarInicial.ForeColor = Color.White;
            btnMaximizarInicial.Location = new Point(1610, 0);
            btnMaximizarInicial.Name = "btnMaximizarInicial";
            btnMaximizarInicial.Size = new Size(45, 45);
            btnMaximizarInicial.TabIndex = 1;
            btnMaximizarInicial.Text = "🗖";
            btnMaximizarInicial.UseVisualStyleBackColor = false;
            // 
            // btnCerrarInicial
            // 
            btnCerrarInicial.BackColor = Color.FromArgb(30, 30, 36);
            btnCerrarInicial.Dock = DockStyle.Right;
            btnCerrarInicial.FlatAppearance.BorderSize = 0;
            btnCerrarInicial.FlatStyle = FlatStyle.Flat;
            btnCerrarInicial.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnCerrarInicial.ForeColor = Color.White;
            btnCerrarInicial.Location = new Point(1655, 0);
            btnCerrarInicial.Name = "btnCerrarInicial";
            btnCerrarInicial.Size = new Size(45, 45);
            btnCerrarInicial.TabIndex = 0;
            btnCerrarInicial.Tag = "";
            btnCerrarInicial.Text = "✕";
            btnCerrarInicial.UseVisualStyleBackColor = false;
            // 
            // Inicial
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(1920, 1040);
            Controls.Add(panelCabezaInicial);
            Controls.Add(panelIzquierdaInicial);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Inicial";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inicial";
            panelIzquierdaInicial.ResumeLayout(false);
            panelIzquierdaInicial.PerformLayout();
            panelCabezaInicial.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion
        private Panel panelIzquierdaInicial;
        private Label lblTituloInicial;
        private Panel panelCabezaInicial;
        private Button btnMinimizarInicial;
        private Button btnMaximizarInicial;
        private Button btnCerrarInicial;
        private Button btnClientesInicial;
    }
}
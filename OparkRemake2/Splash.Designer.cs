namespace OparkRemake2
{
    partial class Splash
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
            components = new System.ComponentModel.Container();
            lblTituloSplash = new Label();
            lblSubTituloSplash = new Label();
            progressBarSplash = new ProgressBar();
            timerSplash = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lblTituloSplash
            // 
            lblTituloSplash.AutoSize = true;
            lblTituloSplash.Font = new Font("Segoe UI", 24F, FontStyle.Bold);
            lblTituloSplash.ForeColor = Color.White;
            lblTituloSplash.Location = new Point(52, 57);
            lblTituloSplash.Name = "lblTituloSplash";
            lblTituloSplash.Size = new Size(130, 45);
            lblTituloSplash.TabIndex = 0;
            lblTituloSplash.Text = "OPARQ";
            // 
            // lblSubTituloSplash
            // 
            lblSubTituloSplash.AutoSize = true;
            lblSubTituloSplash.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblSubTituloSplash.ForeColor = Color.FromArgb(13, 122, 178);
            lblSubTituloSplash.Location = new Point(52, 118);
            lblSubTituloSplash.Name = "lblSubTituloSplash";
            lblSubTituloSplash.Size = new Size(283, 15);
            lblSubTituloSplash.TabIndex = 1;
            lblSubTituloSplash.Text = "Sistema de Gestión para Despacho de Arquitectos";
            // 
            // progressBarSplash
            // 
            progressBarSplash.Location = new Point(52, 211);
            progressBarSplash.Name = "progressBarSplash";
            progressBarSplash.Size = new Size(550, 15);
            progressBarSplash.Style = ProgressBarStyle.Continuous;
            progressBarSplash.TabIndex = 2;
            // 
            // timerSplash
            // 
            timerSplash.Enabled = true;
            timerSplash.Interval = 30;
            // 
            // Splash
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(24, 24, 27);
            ClientSize = new Size(650, 300);
            Controls.Add(progressBarSplash);
            Controls.Add(lblSubTituloSplash);
            Controls.Add(lblTituloSplash);
            FormBorderStyle = FormBorderStyle.None;
            Name = "Splash";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Splash";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTituloSplash;
        private Label lblSubTituloSplash;
        private ProgressBar progressBarSplash;
        private System.Windows.Forms.Timer timerSplash;
    }
}
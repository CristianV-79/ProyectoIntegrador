namespace ProyectoIntegrador
{
    partial class frmInscripciones
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
            btnSocio = new Button();
            btnNoSocio = new Button();
            btnVolver = new Button();
            lblIngreso = new Label();
            SuspendLayout();
            // 
            // btnSocio
            // 
            btnSocio.BackColor = Color.SeaGreen;
            btnSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSocio.ForeColor = SystemColors.Control;
            btnSocio.Location = new Point(166, 186);
            btnSocio.Margin = new Padding(3, 4, 3, 4);
            btnSocio.Name = "btnSocio";
            btnSocio.Size = new Size(222, 106);
            btnSocio.TabIndex = 0;
            btnSocio.Text = "INSCRIPCION DE SOCIO";
            btnSocio.UseVisualStyleBackColor = false;
            btnSocio.Click += btnSocio_Click;
            // 
            // btnNoSocio
            // 
            btnNoSocio.BackColor = Color.SeaGreen;
            btnNoSocio.Font = new Font("Segoe UI", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnNoSocio.ForeColor = SystemColors.Control;
            btnNoSocio.Location = new Point(513, 188);
            btnNoSocio.Margin = new Padding(3, 4, 3, 4);
            btnNoSocio.Name = "btnNoSocio";
            btnNoSocio.Size = new Size(222, 104);
            btnNoSocio.TabIndex = 1;
            btnNoSocio.Text = "INSCRIPCION DE NO SOCIO";
            btnNoSocio.UseVisualStyleBackColor = false;
            btnNoSocio.Click += btnNoSocio_Click;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(686, 40);
            btnVolver.Margin = new Padding(3, 4, 3, 4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 30);
            btnVolver.TabIndex = 2;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(40, 26);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(87, 20);
            lblIngreso.TabIndex = 3;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // frmInscripciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(914, 600);
            Controls.Add(lblIngreso);
            Controls.Add(btnVolver);
            Controls.Add(btnNoSocio);
            Controls.Add(btnSocio);
            Margin = new Padding(3, 4, 3, 4);
            Name = "frmInscripciones";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmInscripciones";
            Load += frmInscripciones_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSocio;
        private Button btnNoSocio;
        private Button btnVolver;
        private Label lblIngreso;
    }
}
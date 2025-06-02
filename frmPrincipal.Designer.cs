namespace ProyectoIntegrador
{
    partial class frmPrincipal
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
            btnAlta = new Button();
            btnClase = new Button();
            btnPagar = new Button();
            button4 = new Button();
            lblIngreso = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnAlta
            // 
            btnAlta.BackColor = Color.SeaGreen;
            btnAlta.ForeColor = SystemColors.Control;
            btnAlta.Location = new Point(166, 120);
            btnAlta.Name = "btnAlta";
            btnAlta.Size = new Size(160, 40);
            btnAlta.TabIndex = 0;
            btnAlta.Text = "Alta";
            btnAlta.UseVisualStyleBackColor = false;
            btnAlta.Click += btnAlta_Click;
            // 
            // btnClase
            // 
            btnClase.BackColor = Color.SeaGreen;
            btnClase.ForeColor = SystemColors.Control;
            btnClase.Location = new Point(160, 300);
            btnClase.Name = "btnClase";
            btnClase.Size = new Size(160, 40);
            btnClase.TabIndex = 1;
            btnClase.Text = "Actividad";
            btnClase.UseVisualStyleBackColor = false;
            btnClase.Click += btnClase_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.SeaGreen;
            btnPagar.ForeColor = SystemColors.Control;
            btnPagar.Location = new Point(505, 127);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(160, 40);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar Cuota";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // button4
            // 
            button4.BackColor = Color.SeaGreen;
            button4.ForeColor = SystemColors.Control;
            button4.Location = new Point(505, 300);
            button4.Name = "button4";
            button4.Size = new Size(160, 40);
            button4.TabIndex = 3;
            button4.Text = "Estado de Cuentas";
            button4.UseVisualStyleBackColor = false;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(35, 32);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(87, 20);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SeaGreen;
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(640, 36);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(94, 29);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Controls.Add(button4);
            Controls.Add(btnPagar);
            Controls.Add(btnClase);
            Controls.Add(btnAlta);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlta;
        private Button btnClase;
        private Button btnPagar;
        private Button button4;
        private Label lblIngreso;
        private Button btnSalir;
    }
}
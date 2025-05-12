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
            button2 = new Button();
            button3 = new Button();
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
            // button2
            // 
            button2.BackColor = Color.SeaGreen;
            button2.ForeColor = SystemColors.Control;
            button2.Location = new Point(160, 300);
            button2.Name = "button2";
            button2.Size = new Size(160, 40);
            button2.TabIndex = 1;
            button2.Text = "Actividad";
            button2.UseVisualStyleBackColor = false;
            // 
            // button3
            // 
            button3.BackColor = Color.SeaGreen;
            button3.ForeColor = SystemColors.Control;
            button3.Location = new Point(505, 127);
            button3.Name = "button3";
            button3.Size = new Size(160, 40);
            button3.TabIndex = 2;
            button3.Text = "Pagar Cuota";
            button3.UseVisualStyleBackColor = false;
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
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(btnAlta);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnAlta;
        private Button button2;
        private Button button3;
        private Button button4;
        private Label lblIngreso;
        private Button btnSalir;
    }
}
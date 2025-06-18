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
            btnInscripciones = new Button();
            btnClase = new Button();
            btnPagar = new Button();
            btnEstadoCuenta = new Button();
            lblIngreso = new Label();
            btnSalir = new Button();
            SuspendLayout();
            // 
            // btnInscripciones
            // 
            btnInscripciones.BackColor = Color.SeaGreen;
            btnInscripciones.ForeColor = SystemColors.Control;
            btnInscripciones.Location = new Point(145, 90);
            btnInscripciones.Margin = new Padding(3, 2, 3, 2);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(140, 30);
            btnInscripciones.TabIndex = 0;
            btnInscripciones.Text = "INSCRIPCIONES";
            btnInscripciones.UseVisualStyleBackColor = false;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // btnClase
            // 
            btnClase.BackColor = Color.SeaGreen;
            btnClase.ForeColor = SystemColors.Control;
            btnClase.Location = new Point(140, 225);
            btnClase.Margin = new Padding(3, 2, 3, 2);
            btnClase.Name = "btnClase";
            btnClase.Size = new Size(140, 30);
            btnClase.TabIndex = 1;
            btnClase.Text = "Actividad";
            btnClase.UseVisualStyleBackColor = false;
            btnClase.Click += btnClase_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.SeaGreen;
            btnPagar.ForeColor = SystemColors.Control;
            btnPagar.Location = new Point(442, 95);
            btnPagar.Margin = new Padding(3, 2, 3, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(140, 30);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "Pagar Cuota";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnEstadoCuenta
            // 
            btnEstadoCuenta.BackColor = Color.SeaGreen;
            btnEstadoCuenta.ForeColor = SystemColors.Control;
            btnEstadoCuenta.Location = new Point(442, 225);
            btnEstadoCuenta.Margin = new Padding(3, 2, 3, 2);
            btnEstadoCuenta.Name = "btnEstadoCuenta";
            btnEstadoCuenta.Size = new Size(140, 30);
            btnEstadoCuenta.TabIndex = 3;
            btnEstadoCuenta.Text = "Estado de Cuentas";
            btnEstadoCuenta.UseVisualStyleBackColor = false;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(31, 24);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(69, 15);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SeaGreen;
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(560, 27);
            btnSalir.Margin = new Padding(3, 2, 3, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(82, 22);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "Salir";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Controls.Add(btnEstadoCuenta);
            Controls.Add(btnPagar);
            Controls.Add(btnClase);
            Controls.Add(btnInscripciones);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmPrincipal";
            Text = "frmPrincipal";
            Load += frmPrincipal_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnInscripciones;
        private Button btnClase;
        private Button btnPagar;
        private Button btnEstadoCuenta;
        private Label lblIngreso;
        private Button btnSalir;
    }
}
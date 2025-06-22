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
            btnCarnet = new Button();
            SuspendLayout();
            // 
            // btnInscripciones
            // 
            btnInscripciones.BackColor = Color.SeaGreen;
            btnInscripciones.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnInscripciones.ForeColor = SystemColors.Control;
            btnInscripciones.Location = new Point(154, 158);
            btnInscripciones.Margin = new Padding(4, 2, 4, 2);
            btnInscripciones.Name = "btnInscripciones";
            btnInscripciones.Size = new Size(200, 112);
            btnInscripciones.TabIndex = 0;
            btnInscripciones.Text = "INSCRIPCIONES";
            btnInscripciones.UseVisualStyleBackColor = false;
            btnInscripciones.Click += btnInscripciones_Click;
            // 
            // btnClase
            // 
            btnClase.BackColor = Color.SeaGreen;
            btnClase.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnClase.ForeColor = SystemColors.Control;
            btnClase.Location = new Point(154, 375);
            btnClase.Margin = new Padding(4, 2, 4, 2);
            btnClase.Name = "btnClase";
            btnClase.Size = new Size(200, 112);
            btnClase.TabIndex = 1;
            btnClase.Text = "ACTIVIDADES";
            btnClase.UseVisualStyleBackColor = false;
            btnClase.Click += btnClase_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.SeaGreen;
            btnPagar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPagar.ForeColor = SystemColors.Control;
            btnPagar.Location = new Point(668, 158);
            btnPagar.Margin = new Padding(4, 2, 4, 2);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(200, 112);
            btnPagar.TabIndex = 2;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // btnEstadoCuenta
            // 
            btnEstadoCuenta.BackColor = Color.SeaGreen;
            btnEstadoCuenta.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnEstadoCuenta.ForeColor = SystemColors.Control;
            btnEstadoCuenta.Location = new Point(412, 264);
            btnEstadoCuenta.Margin = new Padding(4, 2, 4, 2);
            btnEstadoCuenta.Name = "btnEstadoCuenta";
            btnEstadoCuenta.Size = new Size(200, 112);
            btnEstadoCuenta.TabIndex = 3;
            btnEstadoCuenta.Text = "ESTADO DE CUENTAS";
            btnEstadoCuenta.UseVisualStyleBackColor = false;
            btnEstadoCuenta.Click += btnEstadoCuenta_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(44, 40);
            lblIngreso.Margin = new Padding(4, 0, 4, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(104, 25);
            lblIngreso.TabIndex = 4;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // btnSalir
            // 
            btnSalir.BackColor = Color.SeaGreen;
            btnSalir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSalir.ForeColor = SystemColors.Control;
            btnSalir.Location = new Point(800, 45);
            btnSalir.Margin = new Padding(4, 2, 4, 2);
            btnSalir.Name = "btnSalir";
            btnSalir.Size = new Size(118, 38);
            btnSalir.TabIndex = 5;
            btnSalir.Text = "SALIR";
            btnSalir.UseVisualStyleBackColor = false;
            btnSalir.Click += btnSalir_Click;
            // 
            // btnCarnet
            // 
            btnCarnet.BackColor = Color.SeaGreen;
            btnCarnet.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnCarnet.ForeColor = SystemColors.Control;
            btnCarnet.Location = new Point(668, 375);
            btnCarnet.Margin = new Padding(4, 2, 4, 2);
            btnCarnet.Name = "btnCarnet";
            btnCarnet.Size = new Size(200, 112);
            btnCarnet.TabIndex = 6;
            btnCarnet.Text = "EMITIR CARNET";
            btnCarnet.UseVisualStyleBackColor = false;
            btnCarnet.Click += btnCarnet_Click;
            // 
            // frmPrincipal
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnCarnet);
            Controls.Add(btnSalir);
            Controls.Add(lblIngreso);
            Controls.Add(btnEstadoCuenta);
            Controls.Add(btnPagar);
            Controls.Add(btnClase);
            Controls.Add(btnInscripciones);
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmPrincipal";
            StartPosition = FormStartPosition.CenterScreen;
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
        private Button btnCarnet;
    }
}
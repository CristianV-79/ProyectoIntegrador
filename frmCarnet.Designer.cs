namespace ProyectoIntegrador
{
    partial class frmCarnet
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
            lblSocioNumero = new Label();
            lblNombreCompleto = new Label();
            lblDNI = new Label();
            lblFechaAlta = new Label();
            lblEmail = new Label();
            lblTelefono = new Label();
            lblDireccion = new Label();
            lblFechaEmision = new Label();
            btnImprimir = new Button();
            panel1 = new Panel();
            btnVolver = new Button();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // lblSocioNumero
            // 
            lblSocioNumero.AutoSize = true;
            lblSocioNumero.BackColor = Color.SeaGreen;
            lblSocioNumero.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSocioNumero.ForeColor = SystemColors.Control;
            lblSocioNumero.Location = new Point(24, 31);
            lblSocioNumero.Name = "lblSocioNumero";
            lblSocioNumero.Size = new Size(129, 20);
            lblSocioNumero.TabIndex = 0;
            lblSocioNumero.Text = "Numero de Socio";
            // 
            // lblNombreCompleto
            // 
            lblNombreCompleto.AutoSize = true;
            lblNombreCompleto.BackColor = Color.SeaGreen;
            lblNombreCompleto.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblNombreCompleto.ForeColor = SystemColors.Control;
            lblNombreCompleto.Location = new Point(24, 70);
            lblNombreCompleto.Name = "lblNombreCompleto";
            lblNombreCompleto.Size = new Size(139, 20);
            lblNombreCompleto.TabIndex = 1;
            lblNombreCompleto.Text = "Nombre Completo";
            // 
            // lblDNI
            // 
            lblDNI.AutoSize = true;
            lblDNI.BackColor = Color.SeaGreen;
            lblDNI.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDNI.ForeColor = SystemColors.Control;
            lblDNI.Location = new Point(24, 111);
            lblDNI.Name = "lblDNI";
            lblDNI.Size = new Size(37, 20);
            lblDNI.TabIndex = 2;
            lblDNI.Text = "DNI";
            // 
            // lblFechaAlta
            // 
            lblFechaAlta.AutoSize = true;
            lblFechaAlta.BackColor = Color.SeaGreen;
            lblFechaAlta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaAlta.ForeColor = SystemColors.Control;
            lblFechaAlta.Location = new Point(24, 146);
            lblFechaAlta.Name = "lblFechaAlta";
            lblFechaAlta.Size = new Size(82, 20);
            lblFechaAlta.TabIndex = 3;
            lblFechaAlta.Text = "Fecha Alta";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.SeaGreen;
            lblEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblEmail.ForeColor = SystemColors.Control;
            lblEmail.Location = new Point(343, 31);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(47, 20);
            lblEmail.TabIndex = 4;
            lblEmail.Text = "Email";
            // 
            // lblTelefono
            // 
            lblTelefono.AutoSize = true;
            lblTelefono.BackColor = Color.SeaGreen;
            lblTelefono.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblTelefono.ForeColor = SystemColors.Control;
            lblTelefono.Location = new Point(343, 70);
            lblTelefono.Name = "lblTelefono";
            lblTelefono.Size = new Size(70, 20);
            lblTelefono.TabIndex = 5;
            lblTelefono.Text = "Telefono";
            // 
            // lblDireccion
            // 
            lblDireccion.AutoSize = true;
            lblDireccion.BackColor = Color.SeaGreen;
            lblDireccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblDireccion.ForeColor = SystemColors.Control;
            lblDireccion.Location = new Point(343, 111);
            lblDireccion.Name = "lblDireccion";
            lblDireccion.Size = new Size(74, 20);
            lblDireccion.TabIndex = 6;
            lblDireccion.Text = "Direccion";
            // 
            // lblFechaEmision
            // 
            lblFechaEmision.AutoSize = true;
            lblFechaEmision.BackColor = Color.SeaGreen;
            lblFechaEmision.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblFechaEmision.ForeColor = SystemColors.Control;
            lblFechaEmision.Location = new Point(343, 146);
            lblFechaEmision.Name = "lblFechaEmision";
            lblFechaEmision.Size = new Size(204, 20);
            lblFechaEmision.TabIndex = 7;
            lblFechaEmision.Text = "Fecha de Emision del Carnet";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.SeaGreen;
            btnImprimir.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = SystemColors.Control;
            btnImprimir.Location = new Point(314, 351);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(139, 46);
            btnImprimir.TabIndex = 8;
            btnImprimir.Text = "Imprimir";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.Controls.Add(lblDireccion);
            panel1.Controls.Add(lblTelefono);
            panel1.Controls.Add(lblSocioNumero);
            panel1.Controls.Add(lblFechaEmision);
            panel1.Controls.Add(lblEmail);
            panel1.Controls.Add(lblFechaAlta);
            panel1.Controls.Add(lblDNI);
            panel1.Controls.Add(lblNombreCompleto);
            panel1.Location = new Point(63, 113);
            panel1.Name = "panel1";
            panel1.Size = new Size(654, 210);
            panel1.TabIndex = 9;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(597, 25);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 10;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmCarnet
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Controls.Add(btnImprimir);
            Name = "frmCarnet";
            Text = "frmCarnet";
            Load += frmCarnet_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblSocioNumero;
        private Label lblNombreCompleto;
        private Label lblDNI;
        private Label lblFechaAlta;
        private Label lblEmail;
        private Label lblTelefono;
        private Label lblDireccion;
        private Label lblFechaEmision;
        private Button btnImprimir;
        private Panel panel1;
        private Button btnVolver;
    }
}
namespace ProyectoIntegrador
{
    partial class frmInscripcionNoSocio
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
            lblIngreso = new Label();
            btnVolver = new Button();
            lblTitle = new Label();
            lblEmail = new Label();
            lblFeNac = new Label();
            lblDni = new Label();
            lblApellido = new Label();
            lblNombre = new Label();
            txtEmail = new TextBox();
            txtFeNac = new TextBox();
            txtDni = new TextBox();
            txtApellido = new TextBox();
            txtNombre = new TextBox();
            btnLimpiar = new Button();
            btnInscribir = new Button();
            SuspendLayout();
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(50, 33);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(104, 25);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(819, 35);
            btnVolver.Margin = new Padding(4, 3, 4, 3);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 39);
            btnVolver.TabIndex = 1;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblTitle
            // 
            lblTitle.AccessibleRole = AccessibleRole.TitleBar;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(369, 48);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(249, 48);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Alta No Socio";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Location = new Point(628, 301);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 28);
            lblEmail.TabIndex = 34;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFeNac
            // 
            lblFeNac.AutoSize = true;
            lblFeNac.BackColor = Color.Transparent;
            lblFeNac.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeNac.ForeColor = SystemColors.ButtonHighlight;
            lblFeNac.Location = new Point(493, 227);
            lblFeNac.Margin = new Padding(4, 0, 4, 0);
            lblFeNac.Name = "lblFeNac";
            lblFeNac.Size = new Size(216, 28);
            lblFeNac.TabIndex = 29;
            lblFeNac.Text = "Fecha de Nacimiento:";
            lblFeNac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.ForeColor = SystemColors.ButtonHighlight;
            lblDni.Location = new Point(191, 336);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(68, 28);
            lblDni.TabIndex = 28;
            lblDni.Text = "D.N.I.:";
            lblDni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.ButtonHighlight;
            lblApellido.Location = new Point(167, 264);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(96, 28);
            lblApellido.TabIndex = 27;
            lblApellido.Text = "Apellido:";
            lblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(169, 191);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 28);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(703, 301);
            txtEmail.Margin = new Padding(4, 3, 4, 3);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 31);
            txtEmail.TabIndex = 32;
            // 
            // txtFeNac
            // 
            txtFeNac.Location = new Point(703, 227);
            txtFeNac.Margin = new Padding(4, 3, 4, 3);
            txtFeNac.Name = "txtFeNac";
            txtFeNac.Size = new Size(184, 31);
            txtFeNac.TabIndex = 24;
            txtFeNac.Text = "DD/MM/AAAA";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(267, 336);
            txtDni.Margin = new Padding(4, 3, 4, 3);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(184, 31);
            txtDni.TabIndex = 23;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(267, 264);
            txtApellido.Margin = new Padding(4, 3, 4, 3);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(184, 31);
            txtApellido.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(267, 191);
            txtNombre.Margin = new Padding(4, 3, 4, 3);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 31);
            txtNombre.TabIndex = 21;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SeaGreen;
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(567, 422);
            btnLimpiar.Margin = new Padding(4, 3, 4, 3);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 65);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.SeaGreen;
            btnInscribir.ForeColor = SystemColors.Control;
            btnInscribir.Location = new Point(322, 422);
            btnInscribir.Margin = new Padding(4, 3, 4, 3);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(154, 65);
            btnInscribir.TabIndex = 31;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // frmInscripcionNoSocio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1026, 750);
            Controls.Add(btnLimpiar);
            Controls.Add(btnInscribir);
            Controls.Add(lblEmail);
            Controls.Add(lblFeNac);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtEmail);
            Controls.Add(txtFeNac);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(lblTitle);
            Controls.Add(btnVolver);
            Controls.Add(lblIngreso);
            Margin = new Padding(4, 5, 4, 5);
            Name = "frmInscripcionNoSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripción de No Socios";
            Load += frmInscripcionNoSocio_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblIngreso;
        private Button btnVolver;
        private Label lblTitle;
        private Label lblEmail;
        private Label lblFeNac;
        private Label lblDni;
        private Label lblApellido;
        private Label lblNombre;
        private TextBox txtEmail;
        private TextBox txtFeNac;
        private TextBox txtDni;
        private TextBox txtApellido;
        private TextBox txtNombre;
        private Button btnLimpiar;
        private Button btnInscribir;
    }
}
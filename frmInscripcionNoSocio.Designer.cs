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
            lblIngreso.Location = new Point(45, 26);
            lblIngreso.Margin = new Padding(2, 0, 2, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(93, 20);
            lblIngreso.TabIndex = 0;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(737, 28);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(108, 31);
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
            lblTitle.Location = new Point(332, 38);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(210, 41);
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
            lblEmail.Location = new Point(565, 241);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(59, 23);
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
            lblFeNac.Location = new Point(443, 182);
            lblFeNac.Name = "lblFeNac";
            lblFeNac.Size = new Size(182, 23);
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
            lblDni.Location = new Point(172, 269);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(60, 23);
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
            lblApellido.Location = new Point(151, 211);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(83, 23);
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
            lblNombre.Location = new Point(152, 153);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(81, 23);
            lblNombre.TabIndex = 26;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(632, 241);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(166, 27);
            txtEmail.TabIndex = 32;
            // 
            // txtFeNac
            // 
            txtFeNac.Location = new Point(632, 182);
            txtFeNac.Margin = new Padding(3, 2, 3, 2);
            txtFeNac.Name = "txtFeNac";
            txtFeNac.Size = new Size(166, 27);
            txtFeNac.TabIndex = 24;
            txtFeNac.Text = "DD/MM/AAAA";
            // 
            // txtDni
            // 
            txtDni.Location = new Point(241, 269);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(166, 27);
            txtDni.TabIndex = 23;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(241, 211);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(166, 27);
            txtApellido.TabIndex = 22;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(241, 153);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(166, 27);
            txtNombre.TabIndex = 21;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SeaGreen;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(511, 338);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(138, 52);
            btnLimpiar.TabIndex = 32;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.SeaGreen;
            btnInscribir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInscribir.ForeColor = SystemColors.Control;
            btnInscribir.Location = new Point(290, 338);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(138, 52);
            btnInscribir.TabIndex = 31;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // frmInscripcionNoSocio
            // 
            AutoScaleDimensions = new SizeF(9F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(924, 600);
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
            Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            Margin = new Padding(3, 4, 3, 4);
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
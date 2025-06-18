namespace ProyectoIntegrador
{
    partial class frmInscripcionSocio
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
            btnVolver = new Button();
            lblIngreso = new Label();
            btnInscribir = new Button();
            btnLimpiar = new Button();
            txtNombre = new TextBox();
            txtApellido = new TextBox();
            txtDni = new TextBox();
            txtFeNac = new TextBox();
            txtEmail = new TextBox();
            txtTel = new TextBox();
            txtDir = new TextBox();
            lblNombre = new Label();
            lblApellido = new Label();
            lblDni = new Label();
            lblFeNac = new Label();
            lblEmail = new Label();
            lblTel = new Label();
            lblDir = new Label();
            lblTitle = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(573, 21);
            btnVolver.Margin = new Padding(3, 2, 3, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(82, 22);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(35, 20);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(69, 15);
            lblIngreso.TabIndex = 1;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.SeaGreen;
            btnInscribir.ForeColor = SystemColors.Control;
            btnInscribir.Location = new Point(204, 273);
            btnInscribir.Margin = new Padding(3, 2, 3, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(108, 39);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SeaGreen;
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(375, 273);
            btnLimpiar.Margin = new Padding(3, 2, 3, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(108, 39);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(195, 92);
            txtNombre.Margin = new Padding(3, 2, 3, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(130, 23);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(195, 137);
            txtApellido.Margin = new Padding(3, 2, 3, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(130, 23);
            txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(195, 183);
            txtDni.Margin = new Padding(3, 2, 3, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(130, 23);
            txtDni.TabIndex = 8;
            // 
            // txtFeNac
            // 
            txtFeNac.Location = new Point(195, 227);
            txtFeNac.Margin = new Padding(3, 2, 3, 2);
            txtFeNac.Name = "txtFeNac";
            txtFeNac.Size = new Size(130, 23);
            txtFeNac.TabIndex = 9;
            txtFeNac.Text = "DD/MM/AAAA";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(417, 92);
            txtEmail.Margin = new Padding(3, 2, 3, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(130, 23);
            txtEmail.TabIndex = 10;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(417, 137);
            txtTel.Margin = new Padding(3, 2, 3, 2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(130, 23);
            txtTel.TabIndex = 11;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(417, 183);
            txtDir.Margin = new Padding(3, 2, 3, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(130, 23);
            txtDir.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(127, 92);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(62, 17);
            lblNombre.TabIndex = 13;
            lblNombre.Text = "Nombre:";
            lblNombre.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblApellido
            // 
            lblApellido.AutoSize = true;
            lblApellido.BackColor = Color.Transparent;
            lblApellido.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblApellido.ForeColor = SystemColors.ButtonHighlight;
            lblApellido.Location = new Point(125, 137);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(64, 17);
            lblApellido.TabIndex = 14;
            lblApellido.Text = "Apellido:";
            lblApellido.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDni
            // 
            lblDni.AutoSize = true;
            lblDni.BackColor = Color.Transparent;
            lblDni.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDni.ForeColor = SystemColors.ButtonHighlight;
            lblDni.Location = new Point(142, 183);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(47, 17);
            lblDni.TabIndex = 15;
            lblDni.Text = "D.N.I.:";
            lblDni.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblFeNac
            // 
            lblFeNac.AutoSize = true;
            lblFeNac.BackColor = Color.Transparent;
            lblFeNac.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFeNac.ForeColor = SystemColors.ButtonHighlight;
            lblFeNac.Location = new Point(48, 227);
            lblFeNac.Name = "lblFeNac";
            lblFeNac.Size = new Size(141, 17);
            lblFeNac.TabIndex = 16;
            lblFeNac.Text = "Fecha de Nacimiento:";
            lblFeNac.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblEmail.ForeColor = SystemColors.ButtonHighlight;
            lblEmail.Location = new Point(365, 92);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(46, 17);
            lblEmail.TabIndex = 17;
            lblEmail.Text = "Email:";
            lblEmail.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTel
            // 
            lblTel.AutoSize = true;
            lblTel.BackColor = Color.Transparent;
            lblTel.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTel.ForeColor = SystemColors.ButtonHighlight;
            lblTel.Location = new Point(345, 138);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(66, 17);
            lblTel.TabIndex = 18;
            lblTel.Text = "Teléfono:";
            lblTel.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblDir
            // 
            lblDir.AutoSize = true;
            lblDir.BackColor = Color.Transparent;
            lblDir.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblDir.ForeColor = SystemColors.ButtonHighlight;
            lblDir.Location = new Point(341, 184);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(70, 17);
            lblDir.TabIndex = 19;
            lblDir.Text = "Dirección:";
            lblDir.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // lblTitle
            // 
            lblTitle.AccessibleRole = AccessibleRole.TitleBar;
            lblTitle.AutoSize = true;
            lblTitle.BackColor = Color.Transparent;
            lblTitle.Font = new Font("Segoe UI", 18F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitle.ForeColor = SystemColors.ButtonHighlight;
            lblTitle.Location = new Point(258, 29);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(211, 32);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Alta Nuevo Socio";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // frmInscripcionSocio
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(700, 338);
            Controls.Add(lblTitle);
            Controls.Add(lblDir);
            Controls.Add(lblTel);
            Controls.Add(lblEmail);
            Controls.Add(lblFeNac);
            Controls.Add(lblDni);
            Controls.Add(lblApellido);
            Controls.Add(lblNombre);
            Controls.Add(txtDir);
            Controls.Add(txtTel);
            Controls.Add(txtEmail);
            Controls.Add(txtFeNac);
            Controls.Add(txtDni);
            Controls.Add(txtApellido);
            Controls.Add(txtNombre);
            Controls.Add(btnLimpiar);
            Controls.Add(btnInscribir);
            Controls.Add(lblIngreso);
            Controls.Add(btnVolver);
            Margin = new Padding(3, 2, 3, 2);
            Name = "frmInscripcionSocio";
            Text = "frmAlta";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnVolver;
        private Label lblIngreso;
        private Button btnInscribir;
        private Button btnLimpiar;
        private TextBox txtNombre;
        private TextBox txtApellido;
        private TextBox txtDni;
        private TextBox txtFeNac;
        private TextBox txtEmail;
        private TextBox txtTel;
        private TextBox txtDir;
        private Label lblNombre;
        private Label lblApellido;
        private Label lblDni;
        private Label lblFeNac;
        private Label lblEmail;
        private Label lblTel;
        private Label lblDir;
        private Label lblTitle;
    }
}
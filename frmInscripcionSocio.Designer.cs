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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            SuspendLayout();
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(819, 35);
            btnVolver.Margin = new Padding(4, 2, 4, 2);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 39);
            btnVolver.TabIndex = 0;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // lblIngreso
            // 
            lblIngreso.AutoSize = true;
            lblIngreso.Location = new Point(50, 32);
            lblIngreso.Margin = new Padding(4, 0, 4, 0);
            lblIngreso.Name = "lblIngreso";
            lblIngreso.Size = new Size(104, 25);
            lblIngreso.TabIndex = 1;
            lblIngreso.Text = "Usuario/Rol";
            // 
            // btnInscribir
            // 
            btnInscribir.BackColor = Color.SeaGreen;
            btnInscribir.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnInscribir.ForeColor = SystemColors.Control;
            btnInscribir.Location = new Point(291, 455);
            btnInscribir.Margin = new Padding(4, 2, 4, 2);
            btnInscribir.Name = "btnInscribir";
            btnInscribir.Size = new Size(154, 65);
            btnInscribir.TabIndex = 4;
            btnInscribir.Text = "Inscribir";
            btnInscribir.UseVisualStyleBackColor = false;
            btnInscribir.Click += btnInscribir_Click;
            // 
            // btnLimpiar
            // 
            btnLimpiar.BackColor = Color.SeaGreen;
            btnLimpiar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold);
            btnLimpiar.ForeColor = SystemColors.Control;
            btnLimpiar.Location = new Point(536, 455);
            btnLimpiar.Margin = new Padding(4, 2, 4, 2);
            btnLimpiar.Name = "btnLimpiar";
            btnLimpiar.Size = new Size(154, 65);
            btnLimpiar.TabIndex = 5;
            btnLimpiar.Text = "Limpiar";
            btnLimpiar.UseVisualStyleBackColor = false;
            btnLimpiar.Click += btnLimpiar_Click;
            // 
            // txtNombre
            // 
            txtNombre.Location = new Point(279, 152);
            txtNombre.Margin = new Padding(4, 2, 4, 2);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(184, 31);
            txtNombre.TabIndex = 6;
            // 
            // txtApellido
            // 
            txtApellido.Location = new Point(279, 228);
            txtApellido.Margin = new Padding(4, 2, 4, 2);
            txtApellido.Name = "txtApellido";
            txtApellido.Size = new Size(184, 31);
            txtApellido.TabIndex = 7;
            // 
            // txtDni
            // 
            txtDni.Location = new Point(279, 305);
            txtDni.Margin = new Padding(4, 2, 4, 2);
            txtDni.Name = "txtDni";
            txtDni.Size = new Size(184, 31);
            txtDni.TabIndex = 8;
            // 
            // txtFeNac
            // 
            txtFeNac.Location = new Point(279, 378);
            txtFeNac.Margin = new Padding(4, 2, 4, 2);
            txtFeNac.Name = "txtFeNac";
            txtFeNac.Size = new Size(184, 31);
            txtFeNac.TabIndex = 9;
            txtFeNac.Text = "DD/MM/AAAA";
            // 
            // txtEmail
            // 
            txtEmail.Location = new Point(596, 152);
            txtEmail.Margin = new Padding(4, 2, 4, 2);
            txtEmail.Name = "txtEmail";
            txtEmail.Size = new Size(184, 31);
            txtEmail.TabIndex = 10;
            // 
            // txtTel
            // 
            txtTel.Location = new Point(596, 228);
            txtTel.Margin = new Padding(4, 2, 4, 2);
            txtTel.Name = "txtTel";
            txtTel.Size = new Size(184, 31);
            txtTel.TabIndex = 11;
            // 
            // txtDir
            // 
            txtDir.Location = new Point(596, 305);
            txtDir.Margin = new Padding(4, 2, 4, 2);
            txtDir.Name = "txtDir";
            txtDir.Size = new Size(184, 31);
            txtDir.TabIndex = 12;
            // 
            // lblNombre
            // 
            lblNombre.AutoSize = true;
            lblNombre.BackColor = Color.Transparent;
            lblNombre.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNombre.ForeColor = SystemColors.ButtonHighlight;
            lblNombre.Location = new Point(181, 152);
            lblNombre.Margin = new Padding(4, 0, 4, 0);
            lblNombre.Name = "lblNombre";
            lblNombre.Size = new Size(94, 28);
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
            lblApellido.Location = new Point(179, 228);
            lblApellido.Margin = new Padding(4, 0, 4, 0);
            lblApellido.Name = "lblApellido";
            lblApellido.Size = new Size(96, 28);
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
            lblDni.Location = new Point(202, 305);
            lblDni.Margin = new Padding(4, 0, 4, 0);
            lblDni.Name = "lblDni";
            lblDni.Size = new Size(68, 28);
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
            lblFeNac.Location = new Point(69, 378);
            lblFeNac.Margin = new Padding(4, 0, 4, 0);
            lblFeNac.Name = "lblFeNac";
            lblFeNac.Size = new Size(216, 28);
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
            lblEmail.Location = new Point(521, 152);
            lblEmail.Margin = new Padding(4, 0, 4, 0);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(69, 28);
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
            lblTel.Location = new Point(492, 230);
            lblTel.Margin = new Padding(4, 0, 4, 0);
            lblTel.Name = "lblTel";
            lblTel.Size = new Size(99, 28);
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
            lblDir.Location = new Point(488, 308);
            lblDir.Margin = new Padding(4, 0, 4, 0);
            lblDir.Name = "lblDir";
            lblDir.Size = new Size(107, 28);
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
            lblTitle.Location = new Point(369, 48);
            lblTitle.Margin = new Padding(4, 0, 4, 0);
            lblTitle.Name = "lblTitle";
            lblTitle.Size = new Size(310, 48);
            lblTitle.TabIndex = 20;
            lblTitle.Text = "Alta Nuevo Socio";
            lblTitle.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Red;
            label1.Location = new Point(461, 150);
            label1.Name = "label1";
            label1.Size = new Size(26, 32);
            label1.TabIndex = 21;
            label1.Text = "*";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.Red;
            label2.Location = new Point(461, 226);
            label2.Name = "label2";
            label2.Size = new Size(26, 32);
            label2.TabIndex = 22;
            label2.Text = "*";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Red;
            label3.Location = new Point(461, 304);
            label3.Name = "label3";
            label3.Size = new Size(26, 32);
            label3.TabIndex = 23;
            label3.Text = "*";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.BackColor = Color.Transparent;
            label4.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Red;
            label4.Location = new Point(461, 377);
            label4.Name = "label4";
            label4.Size = new Size(26, 32);
            label4.TabIndex = 24;
            label4.Text = "*";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.BackColor = Color.Transparent;
            label5.Font = new Font("Segoe UI Black", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.Red;
            label5.Location = new Point(777, 152);
            label5.Name = "label5";
            label5.Size = new Size(26, 32);
            label5.TabIndex = 25;
            label5.Text = "*";
            // 
            // frmInscripcionSocio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(1000, 562);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
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
            Margin = new Padding(4, 2, 4, 2);
            Name = "frmInscripcionSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Inscripción de Socios";
            Load += frmInscripcionSocio_Load;
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
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
    }
}
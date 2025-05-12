namespace ProyectoIntegrador
{
    public partial class frmLogin
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            txtUsuario = new TextBox();
            txtContraseña = new TextBox();
            btnIngresar = new Button();
            chkRecordarUsuario = new CheckBox();
            panel1 = new Panel();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // txtUsuario
            // 
            txtUsuario.Location = new Point(54, 202);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(203, 27);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(54, 255);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(203, 27);
            txtContraseña.TabIndex = 1;
            txtContraseña.Text = "CONTRASEÑA";
            txtContraseña.Enter += txtContraseña_Enter;
            txtContraseña.Leave += txtContraseña_Leave;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.SeaGreen;
            btnIngresar.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.Location = new Point(77, 346);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(169, 37);
            btnIngresar.TabIndex = 2;
            btnIngresar.Text = "Iniciar Sesion";
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // chkRecordarUsuario
            // 
            chkRecordarUsuario.AutoSize = true;
            chkRecordarUsuario.BackColor = Color.Transparent;
            chkRecordarUsuario.ForeColor = SystemColors.ButtonHighlight;
            chkRecordarUsuario.Location = new Point(77, 301);
            chkRecordarUsuario.Name = "chkRecordarUsuario";
            chkRecordarUsuario.Size = new Size(143, 24);
            chkRecordarUsuario.TabIndex = 3;
            chkRecordarUsuario.Text = "Recordar usuario";
            chkRecordarUsuario.UseVisualStyleBackColor = false;
            // 
            // panel1
            // 
            panel1.BackColor = SystemColors.ActiveBorder;
            panel1.BackgroundImage = Properties.Resources.Background_login;
            panel1.BackgroundImageLayout = ImageLayout.Stretch;
            panel1.Controls.Add(btnIngresar);
            panel1.Controls.Add(txtUsuario);
            panel1.Controls.Add(txtContraseña);
            panel1.Controls.Add(chkRecordarUsuario);
            panel1.Location = new Point(215, 116);
            panel1.Name = "panel1";
            panel1.Size = new Size(314, 418);
            panel1.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(750, 721);
            Controls.Add(panel1);
            Name = "frmLogin";
            Text = "LoginForm";
            Load += frmLogin_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private TextBox txtUsuario;
        private TextBox txtContraseña;
        private Button btnIngresar;
        private CheckBox chkRecordarUsuario;
        private Panel panel1;
    }
}

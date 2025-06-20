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
            txtUsuario.Location = new Point(68, 252);
            txtUsuario.Margin = new Padding(4, 4, 4, 4);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.Size = new Size(253, 31);
            txtUsuario.TabIndex = 0;
            txtUsuario.Text = "USUARIO";
            txtUsuario.Enter += txtUsuario_Enter;
            txtUsuario.Leave += txtUsuario_Leave;
            // 
            // txtContraseña
            // 
            txtContraseña.Location = new Point(68, 319);
            txtContraseña.Margin = new Padding(4, 4, 4, 4);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.Size = new Size(253, 31);
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
            btnIngresar.Location = new Point(96, 432);
            btnIngresar.Margin = new Padding(4, 4, 4, 4);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.Size = new Size(211, 46);
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
            chkRecordarUsuario.Location = new Point(96, 376);
            chkRecordarUsuario.Margin = new Padding(4, 4, 4, 4);
            chkRecordarUsuario.Name = "chkRecordarUsuario";
            chkRecordarUsuario.Size = new Size(171, 29);
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
            panel1.Location = new Point(269, 145);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(392, 522);
            panel1.TabIndex = 4;
            // 
            // frmLogin
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(938, 901);
            Controls.Add(panel1);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmLogin";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Ingreso al Sistema";
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

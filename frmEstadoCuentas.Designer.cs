namespace ProyectoIntegrador
{
    partial class frmEstadoCuentas
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
            label1 = new Label();
            dtgvCuotaVencer = new DataGridView();
            codSocio = new DataGridViewTextBoxColumn();
            nombre = new DataGridViewTextBoxColumn();
            apellido = new DataGridViewTextBoxColumn();
            monto = new DataGridViewTextBoxColumn();
            telefono = new DataGridViewTextBoxColumn();
            email = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvCuotaVencer).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(346, 64);
            label1.Name = "label1";
            label1.Size = new Size(302, 20);
            label1.TabIndex = 0;
            label1.Text = "LISTADO DE SOCIOS CON CUOTA A VENCER";
            label1.Click += label1_Click;
            // 
            // dtgvCuotaVencer
            // 
            dtgvCuotaVencer.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvCuotaVencer.Columns.AddRange(new DataGridViewColumn[] { codSocio, nombre, apellido, monto, telefono, email });
            dtgvCuotaVencer.Location = new Point(59, 135);
            dtgvCuotaVencer.Name = "dtgvCuotaVencer";
            dtgvCuotaVencer.RowHeadersWidth = 51;
            dtgvCuotaVencer.Size = new Size(919, 188);
            dtgvCuotaVencer.TabIndex = 1;
            dtgvCuotaVencer.CellContentClick += dtgvCuotaVencer_CellContentClick;
            // 
            // codSocio
            // 
            codSocio.HeaderText = "Código de socio";
            codSocio.MinimumWidth = 6;
            codSocio.Name = "codSocio";
            codSocio.Width = 125;
            // 
            // nombre
            // 
            nombre.HeaderText = "Nombre";
            nombre.MinimumWidth = 6;
            nombre.Name = "nombre";
            nombre.Width = 125;
            // 
            // apellido
            // 
            apellido.HeaderText = "Apellido";
            apellido.MinimumWidth = 6;
            apellido.Name = "apellido";
            apellido.Width = 125;
            // 
            // monto
            // 
            monto.HeaderText = "Monto";
            monto.MinimumWidth = 6;
            monto.Name = "monto";
            monto.Width = 125;
            // 
            // telefono
            // 
            telefono.HeaderText = "Teléfono";
            telefono.MinimumWidth = 6;
            telefono.Name = "telefono";
            telefono.Width = 125;
            // 
            // email
            // 
            email.HeaderText = "Email";
            email.MinimumWidth = 6;
            email.Name = "email";
            email.Width = 125;
            // 
            // frmEstadoCuentas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background;
            ClientSize = new Size(1011, 450);
            Controls.Add(dtgvCuotaVencer);
            Controls.Add(label1);
            Name = "frmEstadoCuentas";
            Text = "frmEstadoCuentas";
            Load += frmEstadoCuentas_Load_1;
            ((System.ComponentModel.ISupportInitialize)dtgvCuotaVencer).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private DataGridView dtgvCuotaVencer;
        private DataGridViewTextBoxColumn codSocio;
        private DataGridViewTextBoxColumn nombre;
        private DataGridViewTextBoxColumn apellido;
        private DataGridViewTextBoxColumn monto;
        private DataGridViewTextBoxColumn telefono;
        private DataGridViewTextBoxColumn email;
    }
}
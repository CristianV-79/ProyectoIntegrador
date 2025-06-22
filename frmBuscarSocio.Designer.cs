namespace ProyectoIntegrador
{
    partial class frmBuscarSocio
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
            lblTitulo = new Label();
            lblInstruccion = new Label();
            txtBusqueda = new TextBox();
            btnGenerarCarnet = new Button();
            panel1 = new Panel();
            panel2 = new Panel();
            btnVolver = new Button();
            panel1.SuspendLayout();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.BackColor = Color.Green;
            lblTitulo.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblTitulo.ForeColor = SystemColors.Control;
            lblTitulo.Location = new Point(181, 38);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(218, 38);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "BUSCAR SOCIO";
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.BackColor = Color.Transparent;
            lblInstruccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruccion.ForeColor = SystemColors.Control;
            lblInstruccion.Location = new Point(65, 70);
            lblInstruccion.Margin = new Padding(4, 0, 4, 0);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(155, 25);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Ingrese Nro DNI:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(228, 66);
            txtBusqueda.Margin = new Padding(4);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(228, 31);
            txtBusqueda.TabIndex = 2;
            // 
            // btnGenerarCarnet
            // 
            btnGenerarCarnet.BackColor = Color.SeaGreen;
            btnGenerarCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarCarnet.ForeColor = SystemColors.Control;
            btnGenerarCarnet.Location = new Point(142, 160);
            btnGenerarCarnet.Margin = new Padding(4);
            btnGenerarCarnet.Name = "btnGenerarCarnet";
            btnGenerarCarnet.Size = new Size(296, 60);
            btnGenerarCarnet.TabIndex = 3;
            btnGenerarCarnet.Text = "Generar Carnet";
            btnGenerarCarnet.UseVisualStyleBackColor = false;
            btnGenerarCarnet.Click += btnGenerarCarnet_Click;
            // 
            // panel1
            // 
            panel1.BackgroundImage = Properties.Resources.Background;
            panel1.Controls.Add(btnGenerarCarnet);
            panel1.Controls.Add(txtBusqueda);
            panel1.Controls.Add(lblInstruccion);
            panel1.Location = new Point(179, 195);
            panel1.Margin = new Padding(4);
            panel1.Name = "panel1";
            panel1.Size = new Size(574, 272);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(lblTitulo);
            panel2.Location = new Point(179, 85);
            panel2.Margin = new Padding(4);
            panel2.Name = "panel2";
            panel2.Size = new Size(574, 102);
            panel2.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(805, 488);
            btnVolver.Margin = new Padding(4);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(150, 50);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmBuscarSocio
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(1000, 562);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Margin = new Padding(4);
            Name = "frmBuscarSocio";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Buscar Socio";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label lblTitulo;
        private Label lblInstruccion;
        private TextBox txtBusqueda;
        private Button btnGenerarCarnet;
        private Panel panel1;
        private Panel panel2;
        private Button btnVolver;
    }
}
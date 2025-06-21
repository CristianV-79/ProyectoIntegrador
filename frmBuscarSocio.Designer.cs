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
            label1 = new Label();
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
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Green;
            label1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = SystemColors.Control;
            label1.Location = new Point(145, 30);
            label1.Name = "label1";
            label1.Size = new Size(198, 31);
            label1.TabIndex = 0;
            label1.Text = "BUSCAR CLIENTE";
            label1.Click += label1_Click;
            // 
            // lblInstruccion
            // 
            lblInstruccion.AutoSize = true;
            lblInstruccion.BackColor = Color.Transparent;
            lblInstruccion.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblInstruccion.ForeColor = SystemColors.Control;
            lblInstruccion.Location = new Point(52, 56);
            lblInstruccion.Name = "lblInstruccion";
            lblInstruccion.Size = new Size(128, 20);
            lblInstruccion.TabIndex = 1;
            lblInstruccion.Text = "Ingrese Nro DNI:";
            // 
            // txtBusqueda
            // 
            txtBusqueda.Location = new Point(182, 53);
            txtBusqueda.Name = "txtBusqueda";
            txtBusqueda.Size = new Size(183, 27);
            txtBusqueda.TabIndex = 2;
            // 
            // btnGenerarCarnet
            // 
            btnGenerarCarnet.BackColor = Color.SeaGreen;
            btnGenerarCarnet.Font = new Font("Segoe UI", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnGenerarCarnet.ForeColor = SystemColors.Control;
            btnGenerarCarnet.Location = new Point(114, 128);
            btnGenerarCarnet.Name = "btnGenerarCarnet";
            btnGenerarCarnet.Size = new Size(237, 48);
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
            panel1.Location = new Point(143, 156);
            panel1.Name = "panel1";
            panel1.Size = new Size(459, 218);
            panel1.TabIndex = 4;
            // 
            // panel2
            // 
            panel2.BackColor = Color.Green;
            panel2.Controls.Add(label1);
            panel2.Location = new Point(143, 68);
            panel2.Name = "panel2";
            panel2.Size = new Size(459, 82);
            panel2.TabIndex = 5;
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(644, 390);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(120, 40);
            btnVolver.TabIndex = 6;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmBuscarSocio
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.SeaGreen;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(panel1);
            Controls.Add(panel2);
            Name = "frmBuscarSocio";
            Text = "frmBuscarSocio";
            Load += frmBuscarSocio_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Label label1;
        private Label lblInstruccion;
        private TextBox txtBusqueda;
        private Button btnGenerarCarnet;
        private Panel panel1;
        private Panel panel2;
        private Button btnVolver;
    }
}
namespace ProyectoIntegrador
{
    partial class frmPagar
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
            lblNumInscripcion = new Label();
            btnPagar = new Button();
            txtNro = new TextBox();
            cmbTipoPago = new ComboBox();
            lblSeleccionPago = new Label();
            optEfvo = new RadioButton();
            rdoTarjeta = new RadioButton();
            lblFormaPago = new Label();
            btnVolver = new Button();
            panel1 = new Panel();
            SuspendLayout();
            // 
            // lblNumInscripcion
            // 
            lblNumInscripcion.AutoSize = true;
            lblNumInscripcion.BackColor = Color.Transparent;
            lblNumInscripcion.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblNumInscripcion.ForeColor = SystemColors.Control;
            lblNumInscripcion.Location = new Point(81, 64);
            lblNumInscripcion.Name = "lblNumInscripcion";
            lblNumInscripcion.Size = new Size(222, 23);
            lblNumInscripcion.TabIndex = 0;
            lblNumInscripcion.Text = "Ingrese Codigo de Cliente:";
            lblNumInscripcion.Click += label1_Click;
            // 
            // btnPagar
            // 
            btnPagar.BackColor = Color.SeaGreen;
            btnPagar.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnPagar.ForeColor = SystemColors.Control;
            btnPagar.Location = new Point(81, 330);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(239, 47);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = false;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtNro
            // 
            txtNro.Location = new Point(81, 104);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(259, 27);
            txtNro.TabIndex = 2;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(189, 184);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(151, 28);
            cmbTipoPago.TabIndex = 3;
            // 
            // lblSeleccionPago
            // 
            lblSeleccionPago.AutoSize = true;
            lblSeleccionPago.BackColor = Color.Transparent;
            lblSeleccionPago.Font = new Font("Segoe UI", 10.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblSeleccionPago.ForeColor = SystemColors.Control;
            lblSeleccionPago.Location = new Point(80, 189);
            lblSeleccionPago.Name = "lblSeleccionPago";
            lblSeleccionPago.Size = new Size(106, 23);
            lblSeleccionPago.TabIndex = 4;
            lblSeleccionPago.Text = "Seleccionar:";
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.BackColor = Color.SeaGreen;
            optEfvo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            optEfvo.ForeColor = SystemColors.Control;
            optEfvo.Location = new Point(500, 115);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(86, 24);
            optEfvo.TabIndex = 6;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = false;
            // 
            // rdoTarjeta
            // 
            rdoTarjeta.AutoSize = true;
            rdoTarjeta.BackColor = Color.SeaGreen;
            rdoTarjeta.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            rdoTarjeta.ForeColor = SystemColors.Control;
            rdoTarjeta.Location = new Point(500, 145);
            rdoTarjeta.Name = "rdoTarjeta";
            rdoTarjeta.Size = new Size(78, 24);
            rdoTarjeta.TabIndex = 7;
            rdoTarjeta.TabStop = true;
            rdoTarjeta.Text = "Tarjeta";
            rdoTarjeta.UseVisualStyleBackColor = false;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.BackColor = Color.SeaGreen;
            lblFormaPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lblFormaPago.ForeColor = SystemColors.Control;
            lblFormaPago.Location = new Point(500, 81);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(114, 20);
            lblFormaPago.TabIndex = 8;
            lblFormaPago.Text = "Forma de pago";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 10.8F, FontStyle.Bold);
            btnVolver.ForeColor = SystemColors.Control;
            btnVolver.Location = new Point(500, 323);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(239, 54);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.SeaGreen;
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Location = new Point(489, 64);
            panel1.Name = "panel1";
            panel1.Size = new Size(250, 125);
            panel1.TabIndex = 10;
            // 
            // frmPagar
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background2;
            ClientSize = new Size(800, 450);
            Controls.Add(btnVolver);
            Controls.Add(lblFormaPago);
            Controls.Add(rdoTarjeta);
            Controls.Add(optEfvo);
            Controls.Add(lblSeleccionPago);
            Controls.Add(cmbTipoPago);
            Controls.Add(txtNro);
            Controls.Add(btnPagar);
            Controls.Add(lblNumInscripcion);
            Controls.Add(panel1);
            Name = "frmPagar";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Pagar la cuota o la actividad";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblNumInscripcion;
        private Button btnPagar;
        private TextBox txtNro;
        private ComboBox cmbTipoPago;
        private Label lblSeleccionPago;
        private RadioButton optEfvo;
        private RadioButton rdoTarjeta;
        private Label lblFormaPago;
        private Button btnVolver;
        private Panel panel1;
    }
}
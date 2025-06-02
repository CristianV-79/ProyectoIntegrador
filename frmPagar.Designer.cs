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
            btnComprobante = new Button();
            optEfvo = new RadioButton();
            rdoTarjeta = new RadioButton();
            lblFormaPago = new Label();
            btnVolver = new Button();
            SuspendLayout();
            // 
            // lblNumInscripcion
            // 
            lblNumInscripcion.AutoSize = true;
            lblNumInscripcion.Location = new Point(81, 64);
            lblNumInscripcion.Name = "lblNumInscripcion";
            lblNumInscripcion.Size = new Size(224, 20);
            lblNumInscripcion.TabIndex = 0;
            lblNumInscripcion.Text = "Ingrese el número de inscripción";
            lblNumInscripcion.Click += label1_Click;
            // 
            // btnPagar
            // 
            btnPagar.Location = new Point(500, 223);
            btnPagar.Name = "btnPagar";
            btnPagar.Size = new Size(239, 47);
            btnPagar.TabIndex = 1;
            btnPagar.Text = "PAGAR";
            btnPagar.UseVisualStyleBackColor = true;
            btnPagar.Click += btnPagar_Click;
            // 
            // txtNro
            // 
            txtNro.Location = new Point(81, 104);
            txtNro.Name = "txtNro";
            txtNro.Size = new Size(239, 27);
            txtNro.TabIndex = 2;
            // 
            // cmbTipoPago
            // 
            cmbTipoPago.FormattingEnabled = true;
            cmbTipoPago.Location = new Point(169, 186);
            cmbTipoPago.Name = "cmbTipoPago";
            cmbTipoPago.Size = new Size(151, 28);
            cmbTipoPago.TabIndex = 3;
            // 
            // lblSeleccionPago
            // 
            lblSeleccionPago.AutoSize = true;
            lblSeleccionPago.Location = new Point(80, 189);
            lblSeleccionPago.Name = "lblSeleccionPago";
            lblSeleccionPago.Size = new Size(83, 20);
            lblSeleccionPago.TabIndex = 4;
            lblSeleccionPago.Text = "Seleccioná:";
            // 
            // btnComprobante
            // 
            btnComprobante.Location = new Point(81, 323);
            btnComprobante.Name = "btnComprobante";
            btnComprobante.Size = new Size(239, 54);
            btnComprobante.TabIndex = 5;
            btnComprobante.Text = "COMPROBANTE";
            btnComprobante.UseVisualStyleBackColor = true;
            
            // 
            // optEfvo
            // 
            optEfvo.AutoSize = true;
            optEfvo.Location = new Point(500, 104);
            optEfvo.Name = "optEfvo";
            optEfvo.Size = new Size(83, 24);
            optEfvo.TabIndex = 6;
            optEfvo.TabStop = true;
            optEfvo.Text = "Efectivo";
            optEfvo.UseVisualStyleBackColor = true;
            // 
            // rdoTarjeta
            // 
            rdoTarjeta.AutoSize = true;
            rdoTarjeta.Location = new Point(500, 134);
            rdoTarjeta.Name = "rdoTarjeta";
            rdoTarjeta.Size = new Size(74, 24);
            rdoTarjeta.TabIndex = 7;
            rdoTarjeta.TabStop = true;
            rdoTarjeta.Text = "Tarjeta";
            rdoTarjeta.UseVisualStyleBackColor = true;
            // 
            // lblFormaPago
            // 
            lblFormaPago.AutoSize = true;
            lblFormaPago.Location = new Point(500, 64);
            lblFormaPago.Name = "lblFormaPago";
            lblFormaPago.Size = new Size(111, 20);
            lblFormaPago.TabIndex = 8;
            lblFormaPago.Text = "Forma de pago";
            // 
            // btnVolver
            // 
            btnVolver.Location = new Point(500, 323);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(239, 54);
            btnVolver.TabIndex = 9;
            btnVolver.Text = "VOLVER";
            btnVolver.UseVisualStyleBackColor = true;
            btnVolver.Click += btnVolver_Click;
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
            Controls.Add(btnComprobante);
            Controls.Add(lblSeleccionPago);
            Controls.Add(cmbTipoPago);
            Controls.Add(txtNro);
            Controls.Add(btnPagar);
            Controls.Add(lblNumInscripcion);
            Name = "frmPagar";
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
        private Button btnComprobante;
        private RadioButton optEfvo;
        private RadioButton rdoTarjeta;
        private Label lblFormaPago;
        private Button btnVolver;
    }
}
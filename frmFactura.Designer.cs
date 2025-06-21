namespace ProyectoIntegrador
{
    partial class frmFactura
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFactura));
            panel1 = new Panel();
            label1 = new Label();
            panel2 = new Panel();
            panel3 = new Panel();
            lblFechaHoy = new Label();
            label3 = new Label();
            btnImprimir = new Button();
            lblSolicitante = new Label();
            lblFecha = new Label();
            label2 = new Label();
            lblPago = new Label();
            lblForma = new Label();
            lblImp = new Label();
            lblImporte = new Label();
            label4 = new Label();
            lblClase = new Label();
            btnVolver = new Button();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BorderStyle = BorderStyle.FixedSingle;
            panel1.Controls.Add(label1);
            panel1.Font = new Font("Segoe UI", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            panel1.Location = new Point(25, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(235, 23);
            label1.Name = "label1";
            label1.Size = new Size(290, 31);
            label1.TabIndex = 0;
            label1.Text = "COMPROBANTE DE PAGO";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(25, 94);
            panel2.Name = "panel2";
            panel2.Size = new Size(366, 179);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.BorderStyle = BorderStyle.FixedSingle;
            panel3.Controls.Add(lblFechaHoy);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(397, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 179);
            panel3.TabIndex = 2;
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.AutoSize = true;
            lblFechaHoy.Location = new Point(78, 25);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(50, 20);
            lblFechaHoy.TabIndex = 12;
            lblFechaHoy.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(22, 25);
            label3.Name = "label3";
            label3.Size = new Size(53, 20);
            label3.TabIndex = 11;
            label3.Text = "Fecha:";
            // 
            // btnImprimir
            // 
            btnImprimir.BackColor = Color.SeaGreen;
            btnImprimir.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnImprimir.ForeColor = Color.White;
            btnImprimir.Location = new Point(601, 419);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(140, 40);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = false;
            btnImprimir.Click += btnImprimir_Click_1;
            // 
            // lblSolicitante
            // 
            lblSolicitante.AutoSize = true;
            lblSolicitante.Location = new Point(25, 299);
            lblSolicitante.Name = "lblSolicitante";
            lblSolicitante.Size = new Size(50, 20);
            lblSolicitante.TabIndex = 4;
            lblSolicitante.Text = "label2";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(171, 341);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(50, 20);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label2.Location = new Point(25, 341);
            label2.Name = "label2";
            label2.Size = new Size(145, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha de comienzo:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblPago.Location = new Point(25, 386);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(118, 20);
            lblPago.TabIndex = 7;
            lblPago.Text = "Forma de pago:";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Location = new Point(171, 386);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(50, 20);
            lblForma.TabIndex = 8;
            lblForma.Text = "label3";
            // 
            // lblImp
            // 
            lblImp.AutoSize = true;
            lblImp.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            lblImp.Location = new Point(397, 386);
            lblImp.Name = "lblImp";
            lblImp.Size = new Size(60, 20);
            lblImp.TabIndex = 9;
            lblImp.Text = "Monto:";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(459, 386);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(50, 20);
            lblImporte.TabIndex = 10;
            lblImporte.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            label4.Location = new Point(397, 341);
            label4.Name = "label4";
            label4.Size = new Size(49, 20);
            label4.TabIndex = 13;
            label4.Text = "Clase:";
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Location = new Point(450, 341);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(26, 20);
            lblClase.TabIndex = 14;
            lblClase.Text = "lbl";
            // 
            // btnVolver
            // 
            btnVolver.BackColor = Color.SeaGreen;
            btnVolver.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnVolver.ForeColor = Color.White;
            btnVolver.Location = new Point(43, 419);
            btnVolver.Name = "btnVolver";
            btnVolver.Size = new Size(140, 40);
            btnVolver.TabIndex = 15;
            btnVolver.Text = "Volver";
            btnVolver.UseVisualStyleBackColor = false;
            btnVolver.Click += btnVolver_Click;
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(btnVolver);
            Controls.Add(lblClase);
            Controls.Add(label4);
            Controls.Add(lblImporte);
            Controls.Add(lblImp);
            Controls.Add(lblForma);
            Controls.Add(lblPago);
            Controls.Add(label2);
            Controls.Add(lblFecha);
            Controls.Add(lblSolicitante);
            Controls.Add(btnImprimir);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmFactura";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Comprobante de pago";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            panel3.ResumeLayout(false);
            panel3.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label label1;
        private Panel panel2;
        private Panel panel3;
        private Button btnImprimir;
        private Label lblSolicitante;
        private Label lblFecha;
        private Label label2;
        private Label lblPago;
        private Label lblForma;
        private Label lblImp;
        private Label lblImporte;
        private Label lblFechaHoy;
        private Label label3;
        private Label label4;
        private Label lblClase;
        private Button btnVolver;
    }
}
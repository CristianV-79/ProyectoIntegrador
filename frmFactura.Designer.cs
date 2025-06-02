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
            lblDia = new Label();
            label3 = new Label();
            btnImprimir = new Button();
            lblSolicitante = new Label();
            lblFecha = new Label();
            label2 = new Label();
            lblPago = new Label();
            lblFPago = new Label();
            lblMonto = new Label();
            lblValor = new Label();
            label4 = new Label();
            lblClase = new Label();
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(25, 12);
            panel1.Name = "panel1";
            panel1.Size = new Size(763, 76);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(280, 36);
            label1.Name = "label1";
            label1.Size = new Size(181, 20);
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
            panel3.Controls.Add(lblDia);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(397, 94);
            panel3.Name = "panel3";
            panel3.Size = new Size(391, 179);
            panel3.TabIndex = 2;
            // 
            // lblDia
            // 
            lblDia.AutoSize = true;
            lblDia.Location = new Point(78, 25);
            lblDia.Name = "lblDia";
            lblDia.Size = new Size(50, 20);
            lblDia.TabIndex = 12;
            lblDia.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(22, 25);
            label3.Name = "label3";
            label3.Size = new Size(50, 20);
            label3.TabIndex = 11;
            label3.Text = "Fecha:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(644, 432);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(94, 29);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
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
            label2.Location = new Point(25, 341);
            label2.Name = "label2";
            label2.Size = new Size(140, 20);
            label2.TabIndex = 6;
            label2.Text = "Fecha de comienzo:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(25, 386);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(114, 20);
            lblPago.TabIndex = 7;
            lblPago.Text = "Forma de pago:";
            // 
            // lblFPago
            // 
            lblFPago.AutoSize = true;
            lblFPago.Location = new Point(171, 386);
            lblFPago.Name = "lblFPago";
            lblFPago.Size = new Size(50, 20);
            lblFPago.TabIndex = 8;
            lblFPago.Text = "label3";
            // 
            // lblMonto
            // 
            lblMonto.AutoSize = true;
            lblMonto.Location = new Point(397, 386);
            lblMonto.Name = "lblMonto";
            lblMonto.Size = new Size(72, 20);
            lblMonto.TabIndex = 9;
            lblMonto.Text = "Monto:  $";
            // 
            // lblValor
            // 
            lblValor.AutoSize = true;
            lblValor.Location = new Point(475, 386);
            lblValor.Name = "lblValor";
            lblValor.Size = new Size(50, 20);
            lblValor.TabIndex = 10;
            lblValor.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(397, 341);
            label4.Name = "label4";
            label4.Size = new Size(47, 20);
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
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 473);
            Controls.Add(lblClase);
            Controls.Add(label4);
            Controls.Add(lblValor);
            Controls.Add(lblMonto);
            Controls.Add(lblFPago);
            Controls.Add(lblPago);
            Controls.Add(label2);
            Controls.Add(lblFecha);
            Controls.Add(lblSolicitante);
            Controls.Add(btnImprimir);
            Controls.Add(panel3);
            Controls.Add(panel2);
            Controls.Add(panel1);
            Name = "frmFactura";
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
        private Label lblFPago;
        private Label lblMonto;
        private Label lblValor;
        private Label lblDia;
        private Label label3;
        private Label label4;
        private Label lblClase;
    }
}
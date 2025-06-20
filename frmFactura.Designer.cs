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
            panel1.SuspendLayout();
            panel3.SuspendLayout();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.Controls.Add(label1);
            panel1.Location = new Point(31, 15);
            panel1.Margin = new Padding(4, 4, 4, 4);
            panel1.Name = "panel1";
            panel1.Size = new Size(954, 95);
            panel1.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(350, 45);
            label1.Margin = new Padding(4, 0, 4, 0);
            label1.Name = "label1";
            label1.Size = new Size(220, 25);
            label1.TabIndex = 0;
            label1.Text = "COMPROBANTE DE PAGO";
            // 
            // panel2
            // 
            panel2.BackgroundImage = (Image)resources.GetObject("panel2.BackgroundImage");
            panel2.Location = new Point(31, 118);
            panel2.Margin = new Padding(4, 4, 4, 4);
            panel2.Name = "panel2";
            panel2.Size = new Size(458, 224);
            panel2.TabIndex = 1;
            // 
            // panel3
            // 
            panel3.Controls.Add(lblFechaHoy);
            panel3.Controls.Add(label3);
            panel3.Location = new Point(496, 118);
            panel3.Margin = new Padding(4, 4, 4, 4);
            panel3.Name = "panel3";
            panel3.Size = new Size(489, 224);
            panel3.TabIndex = 2;
            // 
            // lblFechaHoy
            // 
            lblFechaHoy.AutoSize = true;
            lblFechaHoy.Location = new Point(98, 31);
            lblFechaHoy.Margin = new Padding(4, 0, 4, 0);
            lblFechaHoy.Name = "lblFechaHoy";
            lblFechaHoy.Size = new Size(59, 25);
            lblFechaHoy.TabIndex = 12;
            lblFechaHoy.Text = "label4";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(28, 31);
            label3.Margin = new Padding(4, 0, 4, 0);
            label3.Name = "label3";
            label3.Size = new Size(61, 25);
            label3.TabIndex = 11;
            label3.Text = "Fecha:";
            // 
            // btnImprimir
            // 
            btnImprimir.Location = new Point(805, 540);
            btnImprimir.Margin = new Padding(4, 4, 4, 4);
            btnImprimir.Name = "btnImprimir";
            btnImprimir.Size = new Size(118, 36);
            btnImprimir.TabIndex = 3;
            btnImprimir.Text = "IMPRIMIR";
            btnImprimir.UseVisualStyleBackColor = true;
            // 
            // lblSolicitante
            // 
            lblSolicitante.AutoSize = true;
            lblSolicitante.Location = new Point(31, 374);
            lblSolicitante.Margin = new Padding(4, 0, 4, 0);
            lblSolicitante.Name = "lblSolicitante";
            lblSolicitante.Size = new Size(59, 25);
            lblSolicitante.TabIndex = 4;
            lblSolicitante.Text = "label2";
            // 
            // lblFecha
            // 
            lblFecha.AutoSize = true;
            lblFecha.Location = new Point(214, 426);
            lblFecha.Margin = new Padding(4, 0, 4, 0);
            lblFecha.Name = "lblFecha";
            lblFecha.Size = new Size(59, 25);
            lblFecha.TabIndex = 5;
            lblFecha.Text = "label2";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(31, 426);
            label2.Margin = new Padding(4, 0, 4, 0);
            label2.Name = "label2";
            label2.Size = new Size(168, 25);
            label2.TabIndex = 6;
            label2.Text = "Fecha de comienzo:";
            // 
            // lblPago
            // 
            lblPago.AutoSize = true;
            lblPago.Location = new Point(31, 482);
            lblPago.Margin = new Padding(4, 0, 4, 0);
            lblPago.Name = "lblPago";
            lblPago.Size = new Size(139, 25);
            lblPago.TabIndex = 7;
            lblPago.Text = "Forma de pago:";
            // 
            // lblForma
            // 
            lblForma.AutoSize = true;
            lblForma.Location = new Point(214, 482);
            lblForma.Margin = new Padding(4, 0, 4, 0);
            lblForma.Name = "lblForma";
            lblForma.Size = new Size(59, 25);
            lblForma.TabIndex = 8;
            lblForma.Text = "label3";
            // 
            // lblImp
            // 
            lblImp.AutoSize = true;
            lblImp.Location = new Point(496, 482);
            lblImp.Margin = new Padding(4, 0, 4, 0);
            lblImp.Name = "lblImp";
            lblImp.Size = new Size(70, 25);
            lblImp.TabIndex = 9;
            lblImp.Text = "Monto:";
            // 
            // lblImporte
            // 
            lblImporte.AutoSize = true;
            lblImporte.Location = new Point(574, 482);
            lblImporte.Margin = new Padding(4, 0, 4, 0);
            lblImporte.Name = "lblImporte";
            lblImporte.Size = new Size(59, 25);
            lblImporte.TabIndex = 10;
            lblImporte.Text = "label3";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(496, 426);
            label4.Margin = new Padding(4, 0, 4, 0);
            label4.Name = "label4";
            label4.Size = new Size(57, 25);
            label4.TabIndex = 13;
            label4.Text = "Clase:";
            // 
            // lblClase
            // 
            lblClase.AutoSize = true;
            lblClase.Location = new Point(562, 426);
            lblClase.Margin = new Padding(4, 0, 4, 0);
            lblClase.Name = "lblClase";
            lblClase.Size = new Size(31, 25);
            lblClase.TabIndex = 14;
            lblClase.Text = "lbl";
            // 
            // frmFactura
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1000, 591);
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
            Margin = new Padding(4, 4, 4, 4);
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
    }
}
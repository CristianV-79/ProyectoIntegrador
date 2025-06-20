namespace ProyectoIntegrador
{
    partial class frmClase
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
            dtgvClase = new DataGridView();
            NombreClase = new DataGridViewTextBoxColumn();
            Horario = new DataGridViewTextBoxColumn();
            Precio = new DataGridViewTextBoxColumn();
            Disponibilidad = new DataGridViewTextBoxColumn();
            Profesor = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)dtgvClase).BeginInit();
            SuspendLayout();
            // 
            // lblTitulo
            // 
            lblTitulo.AutoSize = true;
            lblTitulo.Location = new Point(384, 88);
            lblTitulo.Margin = new Padding(4, 0, 4, 0);
            lblTitulo.Name = "lblTitulo";
            lblTitulo.Size = new Size(197, 25);
            lblTitulo.TabIndex = 0;
            lblTitulo.Text = "LISTA DE ACTIVIDADES";
            // 
            // dtgvClase
            // 
            dtgvClase.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dtgvClase.Columns.AddRange(new DataGridViewColumn[] { NombreClase, Horario, Precio, Disponibilidad, Profesor });
            dtgvClase.Location = new Point(71, 166);
            dtgvClase.Margin = new Padding(4, 4, 4, 4);
            dtgvClase.Name = "dtgvClase";
            dtgvClase.RowHeadersWidth = 51;
            dtgvClase.Size = new Size(844, 235);
            dtgvClase.TabIndex = 1;
            // 
            // NombreClase
            // 
            NombreClase.HeaderText = "CLASE";
            NombreClase.MinimumWidth = 6;
            NombreClase.Name = "NombreClase";
            NombreClase.Width = 125;
            // 
            // Horario
            // 
            Horario.HeaderText = "HORARIO";
            Horario.MinimumWidth = 6;
            Horario.Name = "Horario";
            Horario.Width = 125;
            // 
            // Precio
            // 
            Precio.HeaderText = "PRECIO";
            Precio.MinimumWidth = 6;
            Precio.Name = "Precio";
            Precio.Width = 125;
            // 
            // Disponibilidad
            // 
            Disponibilidad.HeaderText = "DISPONIBILIDAD";
            Disponibilidad.MinimumWidth = 6;
            Disponibilidad.Name = "Disponibilidad";
            Disponibilidad.Width = 125;
            // 
            // Profesor
            // 
            Profesor.HeaderText = "PROFESOR";
            Profesor.MinimumWidth = 6;
            Profesor.Name = "Profesor";
            Profesor.Width = 125;
            // 
            // frmClase
            // 
            AutoScaleDimensions = new SizeF(10F, 25F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources.Background1;
            ClientSize = new Size(1000, 562);
            Controls.Add(dtgvClase);
            Controls.Add(lblTitulo);
            Margin = new Padding(4, 4, 4, 4);
            Name = "frmClase";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "frmClase";
            ((System.ComponentModel.ISupportInitialize)dtgvClase).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblTitulo;
        private DataGridView dtgvClase;
        private DataGridViewTextBoxColumn NombreClase;
        private DataGridViewTextBoxColumn Horario;
        private DataGridViewTextBoxColumn Precio;
        private DataGridViewTextBoxColumn Disponibilidad;
        private DataGridViewTextBoxColumn Profesor;
    }
}
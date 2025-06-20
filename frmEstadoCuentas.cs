using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmEstadoCuentas : Form
    {
        public frmEstadoCuentas()
        {
            InitializeComponent();
            this.Load += frmEstadoCuentas_Load;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void dtgvCuotaVencer_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void frmEstadoCuentas_Load(object sender, EventArgs e)
        {
            string connectionString = "server=localhost;user=root;database=proyecto;password=8462;";
            using (MySqlConnection conn = new MySqlConnection(connectionString))
            {
                try
                {
                    conn.Open();
                    string query = @"SELECT s.CodSoc, s.Nombre, s.Apellido, c.Monto, s.Telefono, s.Email
                                     FROM socio s JOIN cuota c ON s.CodSoc = c.CodSoc
                                     WHERE c.FechaVencimiento >= CURDATE() AND c.FechaVencimiento < CURDATE() + INTERVAL 1 DAY
                                     AND s.Activo = 1";

                    MySqlDataAdapter adapter = new MySqlDataAdapter(query, conn);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);
                    dtgvCuotaVencer.Columns[0].DataPropertyName = "CodSoc";
                    dtgvCuotaVencer.Columns[1].DataPropertyName = "Nombre";
                    dtgvCuotaVencer.Columns[2].DataPropertyName = "Apellido";
                    dtgvCuotaVencer.Columns[3].DataPropertyName = "Monto";
                    dtgvCuotaVencer.Columns[4].DataPropertyName = "Telefono";
                    dtgvCuotaVencer.Columns[5].DataPropertyName = "Email";
                    int rowCount = dt.Rows.Count;
                    //MessageBox.Show("Filas recuperadas: " + rowCount);
                    dtgvCuotaVencer.DataSource = dt;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
                //MessageBox.Show("Form cargado");
            }
}
    }
}

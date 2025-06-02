using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Datos;

namespace ProyectoIntegrador
{
    public partial class frmClase : Form
    {
        public frmClase()
        {
            InitializeComponent();
            this.Load += frmClase_Load;
        }
        private void frmClase_Load(object sender, EventArgs e)
        {
            CargarGrilla();
        }

        private void CargarGrilla()
        {
            try
            {
                DataTable clases = ClaseDatos.ObtenerClases();

                if (clases.Rows.Count == 0)
                {
                    MessageBox.Show("NO HAY DATOS PARA LA CARGA DE LA GRILLA");
                    return;
                }

                dtgvClase.Rows.Clear(); // Limpiar grilla si es necesario

                foreach (DataRow row in clases.Rows)
                {
                    int index = dtgvClase.Rows.Add();
                    dtgvClase.Rows[index].Cells[0].Value = row["NombreClase"];
                    dtgvClase.Rows[index].Cells[1].Value = row["Horario"];
                    dtgvClase.Rows[index].Cells[2].Value = row["Precio"];
                    dtgvClase.Rows[index].Cells[3].Value = row["Disponibilidad"];
                    dtgvClase.Rows[index].Cells[4].Value = row["Profesor"];
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error al cargar cursos: " + ex.Message);
            }
        }
    }
}

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
    public partial class frmAlta : Form
    {
        private string rol;
        private string usuario;
        public frmAlta(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
        }
        private void frmAlta_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(usuario, rol);
            this.Hide();
            frmPrincipal.Show();
        }
    }
}

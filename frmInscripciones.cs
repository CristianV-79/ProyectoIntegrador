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
    public partial class frmInscripciones : Form
    {
        private string rol;
        private string usuario;
        public frmInscripciones(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
        }
        private void frmInscripciones_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnSocio_Click(object sender, EventArgs e)
        {
            frmInscripcionSocio frmInscripcionSocio = new frmInscripcionSocio(usuario, rol);
            frmInscripcionSocio.Show();
            this.Hide();
        }

        private void btnNoSocio_Click(object sender, EventArgs e)
        {
            frmInscripcionNoSocio frmInscripcionNoSocio = new frmInscripcionNoSocio(usuario, rol);
            frmInscripcionNoSocio.Show();
            this.Hide();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(usuario, rol);
            frmPrincipal.Show();
            this.Hide();
        }
    }
}

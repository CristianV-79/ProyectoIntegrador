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
    public partial class frmPrincipal : Form
    {
        private string rol;
        private string usuario;
        public frmPrincipal(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
        }
        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }

        private void btnInscripciones_Click(object sender, EventArgs e)
        {
            frmInscripciones frmInscripciones = new frmInscripciones(usuario, rol);
            frmInscripciones.Show();
            this.Hide();
        }
        private void btnClase_Click(object sender, EventArgs e)
        {
            frmClase frmClase = new frmClase();
            frmClase.Show();
            this.Hide();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagar frmPagar = new frmPagar(usuario,rol);
            frmPagar.Show();
            this.Hide();
        }
        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void btnEstadoCuenta_Click(object sender, EventArgs e)
        {
            frmEstadoCuentas estadoCuentas = new frmEstadoCuentas();
            estadoCuentas.ShowDialog();
        }
    }
}
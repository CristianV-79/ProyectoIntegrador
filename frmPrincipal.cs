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

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnAlta_Click(object sender, EventArgs e)
        {
            frmAlta frmAlta = new frmAlta(usuario, rol);
            this.Hide();
            frmAlta.Show();
        }
        private void btnClase_Click(object sender, EventArgs e)
        {
            frmClase frmClase = new frmClase();
            this.Hide();
            frmClase.Show();
        }
        private void btnPagar_Click(object sender, EventArgs e)
        {
            frmPagar frmPagar = new frmPagar();
            this.Hide();
            frmPagar.Show();
        }
    }
}
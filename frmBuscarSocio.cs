using ProyectoIntegrador.Entidades;
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
    public partial class frmBuscarSocio : Form
    {
        private string rol;
        private string usuario;
        public frmBuscarSocio()
        {
            InitializeComponent();
        }
        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmBuscarSocio_Load(object sender, EventArgs e)
        {

        }

        private void btnGenerarCarnet_Click(object sender, EventArgs e)
        {
            // Obtener el valor ingresado (número de socio o DNI) y eliminar espacios en blanco.
            string valorBusqueda = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Ingrese el número de socio o DNI.",
                    "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se asume que tienes un método en Datos.Socios que recibe un string y devuelve un objeto E_Socio
            Datos.Socios datosSocios = new Datos.Socios();
            E_Socio socioEncontrado = datosSocios.BuscarSocio(valorBusqueda);

            if (socioEncontrado == null)
            {
                MessageBox.Show("Socio no encontrado.",
                    "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // Si se encontró el socio, se instancia el formulario de carnet y se asignan sus propiedades.
            frmCarnet frmCarnet = new frmCarnet
            {
                SocioNumero = socioEncontrado.CodSoc,
                DniSocio = socioEncontrado.Dni,
                NombreSocio = socioEncontrado.Nombre,
                ApellidoSocio = socioEncontrado.Apellido,
                FechaAltaSocio = socioEncontrado.FechaAlta,
                EmailSocio = socioEncontrado.Email,
                TelefonoSocio = socioEncontrado.Telefono,
                DireccionSocio = socioEncontrado.Direccion
            };

            // Se muestra el formulario para que el usuario pueda ver e imprimir el carnet.
            frmCarnet.ShowDialog();
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(usuario, rol);
            frmPrincipal.Show();
            this.Hide();
        }
    }
}

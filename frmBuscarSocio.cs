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
        public frmBuscarSocio(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
        }

        private void btnGenerarCarnet_Click(object sender, EventArgs e)
        {
            // Se obtiene el valor ingresado (se espera que sea un DNI) y se quitan espacios en blanco.
            string valorBusqueda = txtBusqueda.Text.Trim();

            if (string.IsNullOrEmpty(valorBusqueda))
            {
                MessageBox.Show("Ingrese el DNI.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Se intenta ubicar el registro en la tabla de socios (buscando solo por DNI)
            Datos.Socios datosSocios = new Datos.Socios();
            E_Socio socioEncontrado = datosSocios.BuscarSocio(valorBusqueda);

            if (socioEncontrado != null)
            {
                // Si se encontró en socios, se genera el carnet con los datos recuperados.
                frmCarnet frmCarnet = new frmCarnet(usuario, rol)
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

                frmCarnet.ShowDialog();
            }
            else
            {
                MessageBox.Show("No se encontró ningún socio con ese DNI. Los no socios no pueden tener carnet", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(usuario, rol);
            frmPrincipal.Show();
            this.Hide();
        }
    }
}

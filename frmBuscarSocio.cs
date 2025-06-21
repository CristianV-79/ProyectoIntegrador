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

                frmCarnet.ShowDialog();
            }
            else
            {
                // Si no se encontró en la tabla de socios, se busca en la de no socios (también por DNI)
                Datos.NoSocios datosNoSocios = new Datos.NoSocios();
                E_NoSocio noSocioEncontrado = datosNoSocios.BuscarNoSocio(valorBusqueda);

                if (noSocioEncontrado != null)
                {
                    // Generamos el carnet con los datos proporcionados; 
                    // observá que puede ser que en la entidad de NoSocio se utilice otra propiedad para el identificador (por ejemplo, CodNoSoc).
                    frmCarnet frmCarnet = new frmCarnet
                    {
                        SocioNumero = noSocioEncontrado.CodNoSoc,  // o una propiedad equivalente para identificar a los no socios
                        DniSocio = noSocioEncontrado.Dni,
                        NombreSocio = noSocioEncontrado.Nombre,
                        ApellidoSocio = noSocioEncontrado.Apellido,
                        FechaAltaSocio = noSocioEncontrado.FechaAlta,
                        EmailSocio = noSocioEncontrado.Email,
                        TelefonoSocio = noSocioEncontrado.Telefono,
                        DireccionSocio = noSocioEncontrado.Direccion
                    };

                    frmCarnet.ShowDialog();
                }
                else
                {
                    MessageBox.Show("No se encontró ningún socio o no socio con ese DNI.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
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

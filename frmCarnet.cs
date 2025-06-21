using ProyectoIntegrador.Datos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Printing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoIntegrador
{
    public partial class frmCarnet : Form
    {
        private string rol;
        private string usuario;
        // Propiedades para almacenar los datos del socio
        public int SocioNumero { get; set; }      // CodSoc
        public int DniSocio { get; set; }           // Dni
        public string NombreSocio { get; set; }     // Nombre
        public string ApellidoSocio { get; set; }   // Apellido
        public DateTime FechaAltaSocio { get; set; }// FechaAlta
        public string EmailSocio { get; set; }      // Email
        public string TelefonoSocio { get; set; }   // Telefono
        public string DireccionSocio { get; set; }  // Direccion
        public frmCarnet()
        {
            InitializeComponent();
        }

        private void frmCarnet_Load(object sender, EventArgs e)
        {
            // Asignamos los datos a los controles del carnet.
            // Asegurate de que en el diseñador tengas labels con estos nombres:
            // lblSocioNumero, lblNombreCompleto, lblDNI, lblFechaAlta, lblEmail, lblTelefono, lblDireccion y lblFechaEmision
            lblSocioNumero.Text = "Socio Nº: " + SocioNumero.ToString();
            lblNombreCompleto.Text = NombreSocio + " " + ApellidoSocio;
            lblDNI.Text = "DNI: " + DniSocio.ToString();
            lblFechaAlta.Text = "Fecha de Alta: " + FechaAltaSocio.ToShortDateString();
            lblEmail.Text = "Email: " + EmailSocio;
            lblTelefono.Text = "Teléfono: " + TelefonoSocio;
            lblDireccion.Text = "Dirección: " + DireccionSocio;
            // Fecha actual de emisión del carnet
            lblFechaEmision.Text = "Emitido: " + DateTime.Now.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {
            // Ocultamos el botón de imprimir para que no aparezca en el carnet
            btnImprimir.Visible = false;

            // Creamos y configuramos el objeto para impresión
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(GenerarCarnet);
            pd.Print();

            // Volvemos a mostrar el botón
            btnImprimir.Visible = true;

            MessageBox.Show("Carnet impreso exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void GenerarCarnet(object sender, PrintPageEventArgs e)
        {
            // Obtenemos el área del formulario para generar la imagen del carnet
            Rectangle bounds = new Rectangle(0, 0, this.Width, this.Height);
            Bitmap bitmap = new Bitmap(bounds.Width, bounds.Height);
            this.DrawToBitmap(bitmap, bounds);
            // Dibujamos el bitmap en la página a imprimir
            e.Graphics.DrawImage(bitmap, new Point(50, 50));
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(usuario, rol);
            frmPrincipal.Show();
            this.Hide();
        }
    }
}

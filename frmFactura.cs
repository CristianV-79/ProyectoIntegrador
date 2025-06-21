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
    public partial class frmFactura : Form
    {
        private string usuario;
        private string rol;

        public string solicitante_f;
        public string clase_f;
        public DateTime fecha_f;
        public float monto_f;
        public string forma_f;

        public frmFactura(string solicitante, string clase, DateTime fecha, float monto, string forma, string usuario, string rol)
        {
            InitializeComponent();
            solicitante_f = solicitante;
            clase_f = clase;
            fecha_f = fecha;
            monto_f = monto;
            forma_f = forma;
            this.usuario = usuario;
            this.rol = rol;

            // Aquí podés mostrar los datos en los controles del formulario, por ejemplo:
            lblSolicitante.Text = solicitante_f;
            lblClase.Text = clase_f;
            lblFecha.Text = fecha_f.ToShortDateString();
            lblImporte.Text = monto_f.ToString("C2");
            lblForma.Text = forma_f;
            lblFechaHoy.Text = DateTime.Now.ToShortDateString();
        }

        private void btnImprimir_Click(object sender, EventArgs e)
        {

            btnImprimir.Visible = false;

            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            btnImprimir.Visible = true;
            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal(usuario, rol);
            principal.Show();
            this.Close();
        }

        private void ImprimirForm1(object o, PrintPageEventArgs e)
        {
            int x = SystemInformation.WorkingArea.X;
            int y = SystemInformation.WorkingArea.Y;
            int ancho = this.Width;
            int alto = this.Height;
            Rectangle bounds = new Rectangle(x, y, ancho, alto);
            Bitmap img = new Bitmap(ancho, alto);
            this.DrawToBitmap(img, bounds);
            Point p = new Point(100, 100);
            e.Graphics.DrawImage(img, p);
        }
        private void frmFactura_Load(object sender, EventArgs e)
        {

            lblSolicitante.Text = solicitante_f;
            lblClase.Text = clase_f;
            lblFechaHoy.Text = Convert.ToString(fecha_f);
            lblImp.Text = Convert.ToString(monto_f);
            lblForma.Text = forma_f;

        }

        private void btnImprimir_Click_1(object sender, EventArgs e)
        {
            // Ocultamos el botón de imprimir para que no aparezca en el carnet
            btnImprimir.Visible = false;

            // Creamos y configuramos el objeto para impresión
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(GenerarComprobante);
            pd.Print();

            // Volvemos a mostrar el botón
            btnImprimir.Visible = true;

            MessageBox.Show("Carnet impreso exitosamente.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void GenerarComprobante(object sender, PrintPageEventArgs e)
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
            frmPagar frmPagar = new frmPagar(usuario,rol);
            frmPagar.Show();
            this.Hide();
        }
    }
}

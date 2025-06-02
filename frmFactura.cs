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
        public frmFactura()
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;

        }
        
        public string? solicitante_f;
        public string? clase_f;
        public string? pago_f;
        public float monto_f;
        public int numero_f;
        public DateTime fecha_f;
        public string? forma_f;
        private void btnImprimir_Click(object sender, EventArgs e)
        {
            
            btnImprimir.Visible = false;
            
            PrintDocument pd = new PrintDocument();
            pd.PrintPage += new PrintPageEventHandler(ImprimirForm1);
            pd.Print();

            btnImprimir.Visible = true; 
            MessageBox.Show("Operaación existosa", "AVISO DEL SISTEMA",
            MessageBoxButtons.OK, MessageBoxIcon.Information);
            frmPrincipal principal = new frmPrincipal(usuario,rol);
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
            lblDia.Text = Convert.ToString(fecha_f);
            lblMonto.Text = Convert.ToString(monto_f);
            lblFPago.Text = forma_f;
            
        }


    }
}

using MySql.Data.MySqlClient;
using ProyectoIntegrador.Datos;
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
    public partial class frmPagar : Form
    {
        //public frmFactura doc = new frmFactura();
        private string usuario;
        private string rol;
        public frmPagar(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
            this.Load += frmPagar_Load;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        private void frmPagar_Load(object sender, EventArgs e)
        {
            cmbTipoPago.Items.Add("Pago de cuota");
            cmbTipoPago.Items.Add("Pago de actividad");
            cmbTipoPago.SelectedIndex = 0; // Selección por defecto
        }

        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal principal = new frmPrincipal(usuario, rol);
            principal.Show();
            this.Hide();
        }

        /*private void btnComprobante_Click(object sender, EventArgs e)
        {
            doc.Show();
            this.Hide();
        }*/

        private void btnPagar_Click(object sender, EventArgs e)
        {
            string tipoPago = cmbTipoPago.SelectedItem.ToString();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                string query;
                sqlCon = Conexion.getInstancia().CrearConexion();

                if (tipoPago == "Pago de cuota")
                {
                    //pago de cuota mensual
                    query = "SELECT idcuota, descricion, CONCAT(nombre, ' ', apellido), monto, fechaVencimiento " +
                            "FROM cuota c INNER JOIN socio s ON c.CodSoc = s.CodSoc " +
                            "WHERE idcuota = " + txtNro.Text;
                }
                else // Pago de actividad
                {
                    query = "SELECT IdInscri, c.Nombre, CONCAT(NombreS, ' ', ApellidoS), c.Precio, e.fecha " +
                            "FROM inscripcion i " +
                            "INNER JOIN edicion e ON i.IdEdicion = e.IdEdicion " +
                            "INNER JOIN clase c ON c.IdClase = e.IdClase " +
                            "INNER JOIN nosocio ns ON ns.CodNoSoc = i.CodNoSoc " +
                            "INNER JOIN solicitante s ON s.NSolic = ns.NSolic " +
                            "WHERE IdInscri = @IdInscri";
                }

                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                comando.Parameters.AddWithValue("@IdInscri", txtNro.Text);
                comando.CommandType = CommandType.Text;
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();

                if (reader.HasRows)
                {
                    reader.Read();
                    /*
                    doc.numero_f = reader.GetInt32(0); ;
                    doc.clase_f = reader.GetString(1);
                    doc.solicitante_f = reader.GetString(2);
                    doc.monto_f = (float)reader.GetDouble(3); ;
                    doc.fecha_f = reader.GetDateTime(4); */

                    /*if (optEfvo.Checked)
                    {
                        doc.forma_f = "Efectivo";
                        doc.monto_f = (float)(doc.monto_f * 0.90); // 10% de descuento
                    }
                    else
                    {
                        doc.forma_f = "Tarjeta";
                    }*/
                    string solicitante = reader.GetString(2);
                    string clase = reader.GetString(1);
                    DateTime fecha = reader.GetDateTime(4);
                    //DateTime fecha = Convert.ToDateTime(reader.GetString(4));
                    //float monto = (float)Convert.ToDouble(reader.GetString(3));
                    float monto = (float)reader.GetDouble(3);
                    string forma = optEfvo.Checked ? "Efectivo" : "Tarjeta";

                    if (forma == "Efectivo")
                        monto *= 0.90f;

                    //frmFactura doc = new frmFactura(solicitante, clase, fecha, monto, forma);
                    frmFactura doc = new frmFactura(solicitante, clase, fecha, monto, forma, usuario, rol);
                    doc.Show();
                    this.Hide();


                    //comprobar funcionamiento
                    MessageBox.Show(
                     $"Solicitante: {doc.solicitante_f}\nClase: {doc.clase_f}\nMonto: {doc.monto_f}\nForma: {doc.forma_f}",
                     "Debug"
                     );

                    btnComprobante.Enabled = true;
                }
                else
                {
                    MessageBox.Show("Número ingresado inexistente", "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "MENSAJE DEL CATCH", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}
    


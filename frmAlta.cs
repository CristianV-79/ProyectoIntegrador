using Org.BouncyCastle.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ProyectoIntegrador.Entidades;

namespace ProyectoIntegrador
{
    public partial class frmAlta : Form
    {
        private string rol;
        private string usuario;
        public frmAlta(string usuario, string rol)
        {
            InitializeComponent();
            this.usuario = usuario;
            this.rol = rol;
        }
        private void frmAlta_Load(object sender, EventArgs e)
        {
            lblIngreso.Text = "USUARIO: " + usuario + " " + "(" + rol + ")";
        }
        private void btnVolver_Click(object sender, EventArgs e)
        {
            frmPrincipal frmPrincipal = new frmPrincipal(usuario, rol);
            this.Hide();
            frmPrincipal.Show();
        }

        private void btnInscribir_Click(object sender, EventArgs e)
        {
            // Validación de campos obligatorios
            if (string.IsNullOrEmpty(txtNombre.Text) ||
                string.IsNullOrEmpty(txtApellido.Text) ||
                string.IsNullOrEmpty(txtDni.Text) ||
                string.IsNullOrEmpty(txtFeNac.Text) ||
                string.IsNullOrEmpty(txtEmail.Text))
            {
                MessageBox.Show("Debe completar todos los datos requeridos (*)",
                "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de DNI
            if (txtDni.Text.Length > 8 || !int.TryParse(txtDni.Text, out int dni))
            {
                MessageBox.Show("El DNI debe ser un número válido de 8 dígitos",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Validación de Fecha de Nacimiento
            if (!DateTime.TryParse(txtFeNac.Text, out DateTime fechaNacimiento))
            {
                MessageBox.Show("La fecha de nacimiento no tiene un formato válido (dd/mm/aaaa)",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Creación del objeto socio
            E_Socio socio = new E_Socio
            {
                Nombre = txtNombre.Text,
                Apellido = txtApellido.Text,
                Dni = dni,
                FechaNacimiento = fechaNacimiento,
                Email = txtEmail.Text,
                Telefono = txtTel.Text,
                Direccion = txtDir.Text,
                FechaAlta = DateTime.Now
            };

            // Intento de inserción en la base de datos
            Datos.Socios socios = new Datos.Socios();
            string respuesta;

            try
            {
                respuesta = socios.Nuevo_Socio(socio);

                if (int.TryParse(respuesta, out int codigo))
                {
                    if (codigo == 0)
                    {
                        MessageBox.Show("SOCIO YA EXISTE", "AVISO DEL SISTEMA",
                        MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    else
                    {
                        MessageBox.Show($"Se inscribió con éxito con el código Nro {respuesta}",
                        "AVISO DEL SISTEMA", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        // Limpiar los campos después de la inscripción
                        txtNombre.Clear();
                        txtApellido.Clear();
                        txtDni.Clear();
                        txtFeNac.Clear();
                        txtEmail.Clear();
                        txtTel.Clear();
                        txtDir.Clear();
                    }
                }
                else
                {
                    MessageBox.Show("No se recibió un código válido desde el servidor.",
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al inscribir socio: {ex.Message}",
                "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }


        /* ===================================================
        * Limpiamos los objetos para un nuevo ingreso
        * ================================================ */
        private void btnLimpiar_Click(object sender, EventArgs e)
        {
            txtNombre.Text = "";
            txtApellido.Text = "";
            txtDni.Text = "";
            txtFeNac.Text = "";
            txtEmail.Text = "";
            txtTel.Text = "";
            txtDir.Text = "";
            txtNombre.Focus();
        }
    }
}

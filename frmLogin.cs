using Org.BouncyCastle.Pqc.Crypto.Lms;
using ProyectoIntegrador.Datos;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Data;
using System.Configuration;

namespace ProyectoIntegrador
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();

        }
        private void LoginForm_Load(object sender, EventArgs e)
        {
            txtUsuario.Text = Properties.Settings1.Default.UsuarioGuardado; // Cargar usuario guardado
            chkRecordarUsuario.Checked = !string.IsNullOrEmpty(txtUsuario.Text); // Si hay usuario guardado, marcar CheckBox
        }
        private void txtUsuario_Enter(object sender, EventArgs e)
        {
            /*Este evento se ejecuta cuando llega el foco*/
            if (txtUsuario.Text == "USUARIO")
            {
                txtUsuario.Text = "";
            }
        }
        private void txtUsuario_Leave(object sender, EventArgs e)
        {
            /*Este evento se ejecuta cuando se va el foco*/
            if (txtUsuario.Text == "")
            {
                txtUsuario.Text = "USUARIO";
            }
        }
        private void txtContraseña_Enter(object sender, EventArgs e)
        {
            /*Este evento se ejecuta cuando llega el foco*/
            if (txtContraseña.Text == "CONTRASEÑA")
            {
                txtContraseña.Text = "";
                txtContraseña.UseSystemPasswordChar = true;
            }
        }
        private void txtContraseña_Leave(object sender, EventArgs e)
        {
            /*Este evento se ejecuta cuando se va el foco*/
            if (txtContraseña.Text == "")
            {
                txtContraseña.Text = "CONTRASEÑA";
                txtContraseña.UseSystemPasswordChar = false;
            }
        }
        private void btnIngresar_Click(object sender, EventArgs e)
        {
            DataTable tablaLogin = new DataTable(); // es la que recibe los datos desde el formulario
            Datos.Usuarios dato = new Datos.Usuarios(); // variable que contiene todas las caracteristicas de la clase
            tablaLogin = dato.Log_Usu(txtUsuario.Text, txtContraseña.Text);
            
            if (tablaLogin.Rows.Count > 0)
            {
                //MessageBox.Show("Ingreso exitoso"); // quiere decir que el resultado tiene 1 fila por lo que el usuario EXISTE

                if (chkRecordarUsuario.Checked) // Guardar usuario si la opción "Recordar Usuario" está activada
                {
                    Properties.Settings1.Default.UsuarioGuardado = txtUsuario.Text;
                    Properties.Settings1.Default.Save(); // Guarda el valor en la configuración
                }

                string usuario = txtUsuario.Text;
                string rol = Convert.ToString(tablaLogin.Rows[0][0]);

                frmPrincipal frmPrincipal = new frmPrincipal(usuario, rol);
                this.Hide(); // Oculta el formulario actual
                frmPrincipal.Show();

                //frmPrincipal.rol = Convert.ToString(tablaLogin.Rows[0][0]);
                //frmPrincipal.usuario = Convert.ToString(txtUsuario.Text);
            }
            else
            {
                MessageBox.Show("Usuario y/o password incorrecto");
            }
        }
        private void chkRecordarUsuario_CheckedChanged(object sender, EventArgs e)
        {
            if (!chkRecordarUsuario.Checked)
            {
                Properties.Settings1.Default.UsuarioGuardado = "";
                Properties.Settings1.Default.Save(); // Borra el dato guardado
            }
        }
        private void frmLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Referencia a MySQL
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador.Datos
{
    public class Conexion
    {
        //Declaramos las variables
        private string baseDatos;
        private string servidor;
        private string puerto;
        private string usuario;
        private string clave;
        private static Conexion? con = null;
        //Asignamos valores a las variables de conexion
        private Conexion()
        {
            //Variables usadas para la repeticion de lineas de codgo
            bool correcto = false;
            int mensaje;
            //Creamos las variables para recibir los datos desde el teclado
            string T_servidor = "Servidor";
            string T_puerto = "Puerto";
            string T_usuario = "Usuario";
            string T_clave = "Clave";
            //Se antepone la T para indicar que vienen desde teclado
            /*Usamos un ciclo While para volver a repetir el ingreso de datos
             la variable "correcto" la inicializamos para ingresar al ciclo*/
            while (correcto != true)
            {
                //Armamos los cuadros de dialogo para el ingreso de datos
                T_servidor = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Servidor", "DATOS DE INSTALACION MySQL");
                T_puerto = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Puerto", "DATOS DE INSTALACION MySQL");
                T_usuario = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Usuario", "DATOS DE INSTALACION MySQL");
                T_clave = Microsoft.VisualBasic.Interaction.InputBox("Ingrese Clave", "DATOS DE INSTALACION MySQL");
                /*Controlamos que los datos ingresados para acceder a MySQL son correctos*/
                mensaje = (int)MessageBox.Show("Su ingreso: SERVIDOR = " + T_servidor + " - PUERTO = " + T_puerto + " - USUARIO: " + T_usuario + " - CLAVE: " + T_clave, "AVISO DEL SISTEMA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (mensaje != 6) //El valor corresponde a si
                {
                    MessageBox.Show("INGRESE NUEVAMENTE LOS DATOS");
                    correcto = false;
                }
                else
                {
                    correcto = true;
                }
            }
            /*Reemplazamos los datos concretos que teniamos por las variables*/
            this.baseDatos = "proyecto";
            this.servidor = T_servidor;
            this.puerto = T_puerto;
            this.usuario = T_usuario;
            this.clave = T_clave;
        }
        //Proceso de interaccion
        public MySqlConnection CrearConexion()
        {
            //Instanciamos la conexion
            MySqlConnection? cadena = new MySqlConnection();
            //Armamos el bloque try para controlar los errores
            try
            {
                cadena.ConnectionString = "datasource=" + servidor + ";port=" + puerto + ";username=" + usuario + ";password=" + clave + ";Database=" + baseDatos;
            }
            catch (Exception ex)
            {
                cadena = null;
                throw;
            }
            return cadena;
        }
        //Evaluamos a instancia de la conexion
        public static Conexion getInstancia()
        {
            if (con == null)//Si la conexion esta cerrada
            {
                con = new Conexion();//Creamos una nueva
            }
            return con;
        }
    }
}
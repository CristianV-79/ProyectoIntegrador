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
            this.baseDatos = "proyecto";
            this.servidor = "localhost";
            this.puerto = "3306";
            this.usuario = "root";
            this.clave = "8462";
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

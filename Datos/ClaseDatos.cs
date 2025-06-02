using MySql.Data.MySqlClient;
using ProyectoIntegrador.Entidades;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ComponentModel.Design.ObjectSelectorEditor;

namespace ProyectoIntegrador.Datos
{
    internal class ClaseDatos
    {
        public static DataTable ObtenerClases()
        {
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();

            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                string query = "SELECT c.Nombre AS NombreClase, c.Horario, c.Precio, CASE WHEN c.HayDisponibilidad THEN 'SI' ELSE 'NO' END AS Disponibilidad,p.Nombre AS Profesor FROM clase c JOIN profesor p ON c.IdProfesor = p.IdProfesor";
                MySqlCommand comando = new MySqlCommand(query, sqlCon);
                sqlCon.Open();
                MySqlDataReader reader = comando.ExecuteReader();
                tabla.Load(reader);
                return tabla;
            }
            catch
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                    sqlCon.Close();
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using MySql.Data.MySqlClient;

namespace ProyectoIntegrador.Datos
{
    internal class Usuarios
    {
        //Creamos un metodo que retorne una tabla con la informacion
        public DataTable Log_Usu(string L_Usu, string P_Usu)
        {
            MySqlDataReader resultado;
            DataTable tabla = new DataTable();
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                //El comando es un elemento que almacena el nombre del procedimiento almacenado y la referencia a la conexion
                MySqlCommand comando = new MySqlCommand("IngresoLogin", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;
                //Definimos los parametros que tiene el procedure
                comando.Parameters.Add("Usu", MySqlDbType.VarChar).Value = L_Usu;
                comando.Parameters.Add("Pass", MySqlDbType.VarChar).Value = P_Usu;
                //Abrimos la conexion
                sqlCon.Open();
                //Almacenamos el resultado en la variable
                resultado = comando.ExecuteReader();
                //Cargamos la tabla con el resultado
                tabla.Load(resultado);
                return tabla;
            }
            catch (Exception ex)
            {
                throw;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                {
                    sqlCon.Close();
                }
            }
        }
    }
}

using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProyectoIntegrador.Entidades;

namespace ProyectoIntegrador.Datos
{
    internal class Socios
    {
        public string Nuevo_Socio(E_Socio socio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = socio.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = socio.Apellido;
                comando.Parameters.Add("pDni", MySqlDbType.Int32).Value = socio.Dni;
                comando.Parameters.Add("FeNac", MySqlDbType.Date).Value = socio.FechaNacimiento;
                comando.Parameters.Add("Email", MySqlDbType.VarChar).Value = socio.Email;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = socio.Telefono;
                comando.Parameters.Add("Dir", MySqlDbType.VarChar).Value = socio.Direccion;
                comando.Parameters.Add("FeAlta", MySqlDbType.Date).Value = socio.FechaAlta;

                // Parámetro de salida
                MySqlParameter ParCodigo = new MySqlParameter("rta", MySqlDbType.Int32);
                ParCodigo.Direction = ParameterDirection.Output;
                comando.Parameters.Add(ParCodigo);

                sqlCon.Open();
                comando.ExecuteNonQuery();

                // Capturamos el valor devuelto por el procedimiento
                salida = ParCodigo.Value?.ToString() ?? "0";

            }
            catch (Exception ex)
            {
                salida = ex.Message;
            }
            finally
            {
                if (sqlCon.State == ConnectionState.Open)
                { sqlCon.Close(); }
                ;
            }
            return salida;
        }
    }
}

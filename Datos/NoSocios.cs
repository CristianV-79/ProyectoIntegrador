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
    internal class NoSocios
    {
        public string Nuevo_NoSocio(E_NoSocio no_socio)
        {
            string? salida;
            MySqlConnection sqlCon = new MySqlConnection();
            try
            {
                sqlCon = Conexion.getInstancia().CrearConexion();
                MySqlCommand comando = new MySqlCommand("NuevoNoSocio", sqlCon);
                comando.CommandType = CommandType.StoredProcedure;

                // Parámetros de entrada
                comando.Parameters.Add("Nom", MySqlDbType.VarChar).Value = no_socio.Nombre;
                comando.Parameters.Add("Ape", MySqlDbType.VarChar).Value = no_socio.Apellido;
                comando.Parameters.Add("pDni", MySqlDbType.Int32).Value = no_socio.Dni;
                comando.Parameters.Add("FeNac", MySqlDbType.Date).Value = no_socio.FechaNacimiento;
                comando.Parameters.Add("Tel", MySqlDbType.VarChar).Value = no_socio.Telefono;
                comando.Parameters.Add("FeAlta", MySqlDbType.Date).Value = no_socio.FechaAlta;
                comando.Parameters.Add("NSolic", MySqlDbType.Int32).Value = null;

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

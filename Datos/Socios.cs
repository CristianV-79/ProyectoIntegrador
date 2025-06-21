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

        public E_Socio BuscarSocio(string valorBusqueda)
        {
            E_Socio socio = null;
            // Consulta que busca por CodSoc o por DNI
            string query = "SELECT * FROM socio WHERE CodSoc = @valor OR Dni = @valor";

            try
            {
                // Usar el mismo método para crear la conexión
                using (MySqlConnection sqlCon = Conexion.getInstancia().CrearConexion())
                {
                    sqlCon.Open(); // Ahora la conexión tiene un ConnectionString válido.
                    using (MySqlCommand cmd = new MySqlCommand(query, sqlCon))
                    {
                        // Asignamos el valor al parámetro.
                        cmd.Parameters.AddWithValue("@valor", valorBusqueda);

                        using (MySqlDataReader reader = cmd.ExecuteReader())
                        {
                            if (reader.Read())
                            {
                                socio = new E_Socio
                                {
                                    CodSoc = reader.GetInt32("CodSoc"),
                                    Nombre = reader.GetString("Nombre"),
                                    Apellido = reader.GetString("Apellido"),
                                    Dni = reader.GetInt32("Dni"),
                                    FechaAlta = reader.GetDateTime("FechaAlta"),
                                    Email = reader.GetString("Email"),
                                    Telefono = reader.IsDBNull(reader.GetOrdinal("Telefono"))
                                                ? string.Empty
                                                : reader.GetString("Telefono"),
                                    Direccion = reader.IsDBNull(reader.GetOrdinal("Direccion"))
                                                ? string.Empty
                                                : reader.GetString("Direccion")
                                };
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                // Puedes loguear el error o mostrar un mensaje específico.
                throw new Exception("Error al buscar socio: " + ex.Message);
            }

            return socio;
        }
    }
}

using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SistemaGestionData
{
    public class ClienteData
    {
        private static string connectionString = "Data Source=DESKTOP-TPQIIQH\\SQL2019;Integrated Security=True;Connect Timeout=30; Initial Catalog = SistemaGestion";
        public static List<Cliente> ObtenerCliente(int IDCliente)
        {
            List<Cliente> lista = new List<Cliente>();

            var query = "SELECT Id, NombreApellido, Domicilio, Telefono FROM Clientes WHERE Id=@IdCliente;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdCliente";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IDCliente;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var Cliente = new Cliente();
                                Cliente.Id = Convert.ToInt32(dr["Id"]);
                                Cliente.NombreApellido = dr["NombreApellido"].ToString();
                                Cliente.Domicilio = dr["Domicilio"].ToString();
                                Cliente.Telefono = dr["Telefono"].ToString();
                                lista.Add(Cliente);

                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Cliente> GetClientes()
        {
            List<Cliente> lista = new List<Cliente>();

            var query = "SELECT Id, NombreApellido, Domicilio, Telefono FROM Clientes;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var Cliente = new Cliente();
                                Cliente.Id = Convert.ToInt32(dr["Id"]);
                                Cliente.NombreApellido = dr["NombreApellido"].ToString();
                                Cliente.Domicilio = dr["Domicilio"].ToString();
                                Cliente.Telefono = dr["Telefono"].ToString();
                                lista.Add(Cliente);

                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static void CrearCliente(Cliente Cliente)
        {
            var query = "INSERT INTO Clientes (NombreApellido, Domicilio, Telefono) " +
                        "VALUES(@NombreApellido, @Domicilio, @Telefono)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("NombreApellido", SqlDbType.VarChar) { Value = Cliente.NombreApellido });
                    comando.Parameters.Add(new SqlParameter("Domicilio", SqlDbType.VarChar) { Value = Cliente.Domicilio });
                    comando.Parameters.Add(new SqlParameter("Telefono", SqlDbType.VarChar) { Value = Cliente.Telefono });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void ModificarCliente(Cliente Cliente)
        {
            var query = "UPDATE Clientes " + "SET NombreApellido = @NombreApellido" + ", Domicilio = @Domicilio" + ", Telefono = @Telefono" + " WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Cliente.Id });
                    comando.Parameters.Add(new SqlParameter("NombreApellido", SqlDbType.VarChar) { Value = Cliente.NombreApellido });
                    comando.Parameters.Add(new SqlParameter("Domicilio", SqlDbType.VarChar) { Value = Cliente.Domicilio });
                    comando.Parameters.Add(new SqlParameter("Telefono", SqlDbType.VarChar) { Value = Cliente.Telefono });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void EliminarCliente(Cliente Cliente)
        {
            var query = "DELETE FROM Clientes WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = Cliente.Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}

using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class VentaData
    {
        private static string connectionString = "Data Source=DESKTOP-TPQIIQH\\SQL2019;Integrated Security=True;Connect Timeout=30; Initial Catalog = SistemaGestion"; 
        public static List<Venta> ObtenerVenta(int IDVenta)
        {
            List<Venta> lista = new List<Venta>();

            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta WHERE Id=@IdVenta;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdVenta";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IDVenta;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(dr["Id"]);
                                venta.Comentarios = dr["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(venta);

                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Venta> ListarVenta()
        {
            List<Venta> lista = new List<Venta>();

            var query = "SELECT Id, Comentarios, IdUsuario FROM Venta;";

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
                                var venta = new Venta();
                                venta.Id = Convert.ToInt32(dr["Id"]);
                                venta.Comentarios = dr["Comentarios"].ToString();
                                venta.IdUsuario = Convert.ToInt32(dr["IdUsuario"]);
                                lista.Add(venta);

                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static void CrearVenta(Venta venta)
        {
            var query = "INSERT INTO Venta (Comentarios, IdUsuario) " +
                        "VALUES(@Comentarios, @IdUsuario)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void ModificarVenta(Venta venta)
        {
            var query = "UPDATE Venta " + "SET Comentarios = @Comentarios" + ", IdUsuario = @IdUsuario " + "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Comentarios", SqlDbType.VarChar) { Value = venta.Comentarios });
                    comando.Parameters.Add(new SqlParameter("IdUsuario", SqlDbType.Int) { Value = venta.IdUsuario });
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void EliminarVenta(int idVenta)
        {
            var query = "DELETE FROM Venta WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = venta.Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}

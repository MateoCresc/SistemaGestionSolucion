﻿using SistemaGestionEntities;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SistemaGestionData
{
    public class UsuarioData
    {
        private static string connectionString = "Data Source=DESKTOP-TPQIIQH\\SQL2019;Integrated Security=True;Connect Timeout=30; Initial Catalog = SistemaGestion"; 
        public static List<Usuario> ObtenerUsuario(int IDUsuario)
        {
            List<Usuario> lista = new List<Usuario>();

            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario WHERE Id=@IdUsuario;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "IdUsuario";
                    parametro.SqlDbType = SqlDbType.Int;
                    parametro.Value = IDUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString(); 
                                usuario.Contraseña = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();
                                lista.Add(usuario);

                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Usuario> ObtenerUsuarioPorNombreUsuario(string nombreUsuario)
        {
            List<Usuario> lista = new List<Usuario>();

            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario WHERE NombreUsuario=@NombreUsuario;";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    var parametro = new SqlParameter();
                    parametro.ParameterName = "NombreUsuario";
                    parametro.SqlDbType = SqlDbType.VarChar;
                    parametro.Value = nombreUsuario;

                    comando.Parameters.Add(parametro);

                    using (SqlDataReader dr = comando.ExecuteReader())
                    {
                        if (dr.HasRows)
                        {
                            while (dr.Read())
                            {
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Contraseña = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();
                                lista.Add(usuario);

                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static List<Usuario> ListarUsuario()
        {
            List<Usuario> lista = new List<Usuario>();

            var query = "SELECT Id, Nombre, Apellido, NombreUsuario, Contraseña, Mail FROM Usuario;";

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
                                var usuario = new Usuario();
                                usuario.Id = Convert.ToInt32(dr["Id"]);
                                usuario.Nombre = dr["Nombre"].ToString();
                                usuario.Apellido = dr["Apellido"].ToString();
                                usuario.NombreUsuario = dr["NombreUsuario"].ToString();
                                usuario.Contraseña = dr["Contraseña"].ToString();
                                usuario.Mail = dr["Mail"].ToString();
                                lista.Add(usuario);

                            }
                        }
                    }
                }
            }
            return lista;
        }

        public static void CrearUsuario(Usuario usuario)
        {
            var query = "INSERT INTO Usuario (Nombre, Apellido, NombreUsuario, Contraseña, Mail) " +
                        "VALUES(@Nombre, @Apellido, @NombreUsuario, @Contraseña, @Mail)";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void ModificarUsuario(Usuario usuario)
        {
            var query = "UPDATE Usuario " + "SET Nombre = @Nombre" + ", Apellido = @Apellido" + ", NombreUsuario = @NombreUsuario" + ", Contraseña = @Contraseña" + ", Mail = @Mail " + "WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    comando.Parameters.Add(new SqlParameter("Nombre", SqlDbType.VarChar) { Value = usuario.Nombre });
                    comando.Parameters.Add(new SqlParameter("Apellido", SqlDbType.VarChar) { Value = usuario.Apellido });
                    comando.Parameters.Add(new SqlParameter("NombreUsuario", SqlDbType.VarChar) { Value = usuario.NombreUsuario });
                    comando.Parameters.Add(new SqlParameter("Contraseña", SqlDbType.VarChar) { Value = usuario.Contraseña });
                    comando.Parameters.Add(new SqlParameter("Mail", SqlDbType.VarChar) { Value = usuario.Mail });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }

        public static void EliminarUsuario(Usuario usuario)
        {
            var query = "DELETE FROM Usuario WHERE Id = @Id";

            using (SqlConnection conexion = new SqlConnection(connectionString))
            {
                conexion.Open();
                using (SqlCommand comando = new SqlCommand(query, conexion))
                {
                    comando.Parameters.Add(new SqlParameter("Id", SqlDbType.Int) { Value = usuario.Id });
                    comando.ExecuteNonQuery();
                }
                conexion.Close();
            }
        }
    }
}

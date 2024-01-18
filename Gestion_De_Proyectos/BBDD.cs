using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Gestion_De_Proyectos
{
    public static class BBDD
    {

        public static string cadenaConexion = "Data Source=(localdb)\\MSSQLLocalDB;" +
            "Initial Catalog=Productos;" +
            "Integrated Security=True";


        //Metodo para generar una conexion a la bbdd
        public static SqlConnection getConexion()
        {
            return new SqlConnection(cadenaConexion);
        }

        public static void insertarProductos(string instruccionSql, SqlParameter nombre, SqlParameter categoria, SqlParameter precio)
        {
            SqlConnection conn = null;
            SqlCommand cmd = null;
            
            try
            {

                using (conn = getConexion())
                {
                    conn.Open();
                    using (cmd = new SqlCommand(instruccionSql, conn))
                    {
                        cmd.Parameters.Add(nombre);
                        cmd.Parameters.Add(categoria);

                        //Añadimos la escala para que solo tenga 2 decimales el precio
                        precio.SqlDbType = SqlDbType.Decimal;
                        precio.Scale = 2;
                        cmd.Parameters.Add(precio);
                        cmd.ExecuteNonQuery();
                    }
                }

            }
            catch (Exception)
            {

                throw;
            }
            finally
            {
                if (conn != null || conn.State == ConnectionState.Open)
                {
                    conn.Close();
                }
            }




        }

        public static void cargarProductosEliminar(ComboBox cbEliminar)
        {
            string instruccionSql = "SELECT Nombre FROM dbo.Producto;";
            using (SqlConnection conn = getConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(instruccionSql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        cbEliminar.Items.Add(reader["Nombre"].ToString());
                    }
                }
            }
        }

        public static void cargarProductosActualizar(ComboBox cbActualizar)
        {
            string instruccionSql = "SELECT * FROM dbo.Producto;";
            using (SqlConnection conn = getConexion())
            {
                conn.Open();

                using (SqlCommand cmd = new SqlCommand(instruccionSql, conn))
                {
                    SqlDataReader reader = cmd.ExecuteReader();
                    while (reader.Read())
                    {
                        string items = $"{reader["Nombre"]} | {reader["Categoria"]} | {reader["Precio"]}";
                        cbActualizar.Items.Add(items);
                    }
                }
            }
        }

        public static void eliminarProducto(string nombre)
        {
            string instruccionSql = "DELETE FROM dbo.Producto WHERE Nombre = @nombre;";
            using (SqlConnection conn = getConexion())
            {
                conn.Open();
                using (SqlCommand cmd = new SqlCommand(instruccionSql, conn))
                {
                    cmd.Parameters.AddWithValue("@nombre", nombre);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

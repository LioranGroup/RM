using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RM.Model
{
    public class Logica
    {
        public static void InsertarIngrediante(string nombre, int Cantidad, int Criteria )
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "INSERT INTO Ingredients (Name, Cantidad, Criteria) VALUES (@Name, @Cantidad, @Criteria)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", nombre);
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@Criteria", Criteria);
                    cmd.ExecuteNonQuery();
                }
            }


        }
        //Falta configurar las varables de las columnas
        public static void InsertarPlatillo(string nombre, string Ingredientes)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "INSERT INTO Dishes (Name, Ingredients) VALUES (@Name, @Ingredientes)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", nombre);
                    cmd.Parameters.AddWithValue("@Ingredientes", Ingredientes);
                    
                    cmd.ExecuteNonQuery();
                }
            }


        }
        //Falta configurar las varables de las columnas
        public static void InsertarUsuario(string nombre, int Cantidad, int Criteria)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "INSERT INTO Ingredients (Name, Cantidad, Criteria) VALUES (@Name, @Cantidad, @Criteria)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", nombre);
                    cmd.Parameters.AddWithValue("@Cantidad", Cantidad);
                    cmd.Parameters.AddWithValue("@Criteria", Criteria);
                    cmd.ExecuteNonQuery();
                }
            }


        }

        public static DataTable Obtenerplatillo()
        {
            DataTable tabla = new DataTable();
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT * FROM Dishes";
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }


        public static DataTable Obteneringredientes()
        {
            DataTable tabla = new DataTable();
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT Name FROM Ingredients";
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
    }

}



using System.Data.SQLite;
using System.Data;

namespace RM.Model
{
    internal class menu
    {
    
        public static void Add(string Name, string Ingredient)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "INSERT INTO Dishes (Name, Ingredients) VALUES (@Name, @Ingredient)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Ingredientes", Ingredient);

                    cmd.ExecuteNonQuery();
                }
            }


        }
    
   
        public static DataTable Get()
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
    
    }
}
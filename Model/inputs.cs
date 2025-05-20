using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Model
{
    internal class Ingredients
    {
        public static DataTable Get()
        {
            DataTable tabla = new DataTable();
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT * FROM inputs";
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }

        public static void Add(string Name, int Quantity, int Minimum)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "INSERT INTO Ingredients (Name, Quantity, Minimum) VALUES (@Name, @Quantity, @Minimum)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.Parameters.AddWithValue("@Minimum", Minimum);
                    cmd.ExecuteNonQuery();
                }
            }
        }
        public static void Update(int Idnum, int Quantity)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "Update Ingredients set Cantidad = @Quantity where ID = @Idnum";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Idnum", Idnum);
                    cmd.Parameters.AddWithValue("@Quantity", Quantity);
                    cmd.ExecuteNonQuery();
                }
            }
        }
    }
}

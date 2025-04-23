using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RM.Model
{
    internal class Users
    {
        public static void Add (string Name, int Admin, int Mang, string Pssw)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "INSERT INTO Users (Name, Admin, Mang) VALUES (@Name, @Admin, @Mang)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Admin", Admin);
                    cmd.Parameters.AddWithValue("@Mang", Mang);
                    cmd.ExecuteNonQuery();

                    if (Admin == 1 || Mang == 1)
                    {
                        //MessageBox.Show("si");
                        query = "INSERT INTO Admin (Name, Pssw, Adm) VALUES (@Name, @Pssw, @Admin)";
                        using (SQLiteCommand cmd1 = new SQLiteCommand(query, conexion))
                        {
                            cmd1.Parameters.AddWithValue("@Name", Name);
                            cmd1.Parameters.AddWithValue("@Pssw", Pssw);
                            cmd1.Parameters.AddWithValue("@Admin", Admin);
                            cmd1.ExecuteNonQuery();
                        }
                    }
                }
            }

        }

        public static DataTable Get()
        {
            DataTable tabla = new DataTable();
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT * FROM Users";
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }

        public static DataTable GetAdim()
        {
            DataTable tabla = new DataTable();
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT * FROM Admin";
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }

    }
}

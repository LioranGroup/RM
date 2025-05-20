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

        public static bool Validation(string Name, string Pssw)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT COUNT(*) FROM view_users_pssw WHERE user_name = @Name AND pssw = @Pssw";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.Parameters.AddWithValue("@Pssw", Pssw);

                    long count = (long)cmd.ExecuteScalar();

                    return count > 0;
                }
            }
        }
        public static void Add (string name, int position, string pssw)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "INSERT INTO Users (user_name, position) VALUES (@Name, @position)";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Name", name);
                    cmd.Parameters.AddWithValue("@position", position);
                    cmd.ExecuteNonQuery();
                }
                if (position == 1)
                {
                            //MessageBox.Show("si");
                    query = "update  users set pssw = @Pssw where name = @name";
                    using (SQLiteCommand cmd1 = new SQLiteCommand(query, conexion))
                    {
                        cmd1.Parameters.AddWithValue("@Name", name);
                        cmd1.Parameters.AddWithValue("@Pssw", pssw);
                        cmd1.Parameters.AddWithValue("@Admin", position);
                        cmd1.ExecuteNonQuery();
                    }
                }
            }
        }

        

        public static void Update(int Idnum, string Name)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "Update Users set Name = @Name where ID = @Idnum";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Idnum", Idnum);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.ExecuteNonQuery();
                }
            }
        }


        public static void UpdateAdm(int Idnum, string Name, string PsswN, string PsswO)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                if(PsswO != "" && PsswN != "")
                {
                 string query = "Update Users set Name = @Name where ID = @Idnum";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                    cmd.Parameters.AddWithValue("@Idnum", Idnum);
                    cmd.Parameters.AddWithValue("@Name", Name);
                    cmd.ExecuteNonQuery();
                    }
                }
                else
                {
                    if(PsswO != "" || PsswN != "")
                    {
                        MessageBox.Show("llene los dos campos");
                    }
                    string query = "Update Admin set Pssw = @Psswn where ID = @Idnum";
                    using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                    {
                        cmd.Parameters.AddWithValue("@Idnum", Idnum);
                        cmd.Parameters.AddWithValue("@Name", Name);
                        cmd.ExecuteNonQuery();
                    }
                }
            }
        }



        public static void Delete(int Idnum)
        {
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "Delete from Users where ID = @Idnum";
                using (SQLiteCommand cmd = new SQLiteCommand(query, conexion))
                {
                    cmd.Parameters.AddWithValue("@Idnum", Idnum);
                    cmd.ExecuteNonQuery();
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





        public static DataTable GetAdm()
        {
            DataTable tabla = new DataTable();
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT * FROM users where position = 1";
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
    }
}

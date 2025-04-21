using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RM.Model
{
    //Needs modification***********************************************************
    public class AddUsers
    {
        public static void InsertarUsuario(string Name, int Admin, int Mang, string Pssw)
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
                        MessageBox.Show("si");
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
    }

    public class AddConsumables

    {
        public static void InsertIngredient(string Name, int Quantity, int Minimum)
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
    }


    public class ModifyIngredientsQty

    {
        public static void Modify(int Idnum, int Quantity)
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


    public class AddDishes

    {
        public static void InsertDishes(string Name, string Ingredient)
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
    }

    public class GetDishes

    {
        public static DataTable GetDish()
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

    public class GetAllIngredients

    {
        public static DataTable GetIngredients()
        {
            DataTable tabla = new DataTable();
            using (var conexion = Connection.ObtenerConexion())
            {
                string query = "SELECT * FROM Ingredients";
                using (SQLiteDataAdapter adaptador = new SQLiteDataAdapter(query, conexion))
                {
                    adaptador.Fill(tabla);
                }
            }
            return tabla;
        }
    }

    public class GetAllUsers

    {
        public static DataTable GetUsers()
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
    }

    public class GetAllAdm

    {
        public static DataTable GetAdm()
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

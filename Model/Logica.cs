using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SQLite;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace RM.Model
{
    public class AddUsers
    //Needs modification***********************************************************
    {
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

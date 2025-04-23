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
        
    }

    public class AddConsumables

    {
        
    }


    public class ModifyIngredientsQty

    {
        
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

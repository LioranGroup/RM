using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SQLite;
using System.Data;



namespace RM.Model
{
    public class Connection
    {
        private static string cadenaConexion = "Data Source=DataBase\\database.db;Version=3;";
        public static SQLiteConnection ObtenerConexion()
        {
            var conexion = new SQLiteConnection(cadenaConexion);
            conexion.Open();
            return conexion;
        }
        

        
    }
}

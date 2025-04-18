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
        private static bool MessageError = false;

        public static SQLiteConnection ObtenerConexion()
        {
            try
            {
                var conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();
                return conexion;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return null;

        }
        public static void ObtenerConexion2()
        {
            try
            {
                var conexion = new SQLiteConnection(cadenaConexion);
                conexion.Open();
                 
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            

        }



    }
}

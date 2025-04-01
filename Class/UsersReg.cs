using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace RM.Class
{
    internal class UsersReg
    {

        static public string Path = "Users.csv";


        static public void FindUserfile()
        {
            if (!File.Exists(Path))
            {
                File.Create(Path).Dispose();
                using (TextWriter writer = new StreamWriter(Path))
                {
                    writer.WriteLine("Username,Pass");
                    writer.WriteLine("Admin,124");
                }

            }

        }


        public static bool FindUser(string username, string password)
        {
            var lines = File.ReadAllLines(Path);

            foreach (var line in lines.Skip(1))
            {
                var parts = line.Split(',');
                if (parts.Length == 2 && parts[0] == username && parts[1] == password)
                {
                    USER = parts[0];
                    return true;
                }

            }
            return false;
        }
        private static string username;
        public static string USER
        {
            get { return username; }
            private set { username = value; }
        }

        static public void RegUser(string username, string password)
        {

        }


    }
}

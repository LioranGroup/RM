using RM.Class;
using System.Security.Cryptography.X509Certificates;

namespace RM
{
    public partial class Frmlog : Form
    {


        public Frmlog()
        {
            Mainform mainform = new Mainform();
            mainform.Show();
            //InitializeComponent();
            //UsersReg.FindUserfile();
        }

        private void Exitbtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Logbtt_Click(object sender, EventArgs e)
        {
           
            if (UsersReg.FindUser(Userbx.Text,Psswbx.Text))
            {
                 Mainform mainform = new Mainform();
                 mainform.Show();

                 this.Hide();
            }
            else
            {
                MessageBox.Show("User not found\nIncorrect password");
            }
        }
    }
}

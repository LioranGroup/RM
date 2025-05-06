using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM.Model;

namespace RM.Views
{
    public partial class FrmTest : Form
    {
        int Adm = 0;
        int Mang = 0;
        public FrmTest()
        {
            InitializeComponent();
            UsersTable();
            IngTable();
            DishTable();
            AdmTable();
        }

        private void UsersTable()
        {
            UsersView.DataSource = Users.Get();
        }

        private void IngTable()
        {
            IngView.DataSource = Ingredients.Get();
        }

        private void DishTable()
        {
            Dishview.DataSource = menu.Get();
        }

        private void AdmTable()
        {
            AdminView.DataSource = Users.GetAdm();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            
                string Name = txtUsName.Text;
                string Pssw = txtPssw.Text;
                if (CbxPos.SelectedIndex == 0)
                {
                    Adm = 1;
                    Mang = 0;
                    if (Pssw != "" ) { Users.Add(Name, Adm, Mang, Pssw); }
                    else { MessageBox.Show("Plese add a password"); }
                    AdmTable();
                    
                }
                if (CbxPos.SelectedIndex == 1)
                {
                    Mang = 1;
                    Adm = 0;
                    if (Pssw != "") { Users.Add(Name, Adm, Mang, Pssw); }
                    else { MessageBox.Show("Plese add a password"); }
                    AdmTable();
                }
            UsersTable();

        }
    }
}

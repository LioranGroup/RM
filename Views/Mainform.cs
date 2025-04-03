using RM.Class;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class Mainform : Form
    {
        public Mainform()
        {
            InitializeComponent();



        }


        public void AddControls(Form f)
        {
            CenterPanel.Controls.Clear();
            f.Dock = DockStyle.Fill;
            f.TopLevel = false;
            CenterPanel.Controls.Add(f);
            f.Show();
        }





        private void Exitbtt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Mainform_Load(object sender, EventArgs e)
        {
            Lbuser.Text = UsersReg.USER;
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            AddControls(new FrmHome());
        }


        private void btnSettings_Click(object sender, EventArgs e)
        {
            AddControls(new Views.FrmSettings());
        }
    }
}

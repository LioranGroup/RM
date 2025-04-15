using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using RM.Model;


namespace RM.Views
{
    public partial class FrmCreateDishes : Form
    {
        private FrmSelectInputs frmSelectInputs;

        public FrmCreateDishes()
        {
            InitializeComponent();
            frmSelectInputs = new FrmSelectInputs();
            cargarplatillo();

        }

        private void btnagregaring_Click(object sender, EventArgs e)
        {
            frmSelectInputs.ShowDialog();
        }

        private void btnagregarplt_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;

            string Ingredientes = "Lechuga,pepino,tomate";


            Logica.InsertarPlatillo(Name,Ingredientes);
            cargarplatillo();

        }

        private void cargarplatillo()
        {
            Dishesview.DataSource = Logica.Obtenerplatillo();
        }
    }
}

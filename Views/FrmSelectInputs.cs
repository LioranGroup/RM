using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SQLite;
using RM.Model;


namespace RM.Views
{
    public partial class FrmSelectInputs : Form
    {
        public FrmSelectInputs()
        {
            InitializeComponent();
            CargarIngredientes();
        }

        private void CargarIngredientes()
        {
            IngredientList.DataSource = Logica.Obteneringredientes();
        }

        


    }
}

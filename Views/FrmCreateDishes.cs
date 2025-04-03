using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views
{
    public partial class FrmCreateDishes : Form
    {
        private FrmSelectInputs frmSelectInputs;

        public FrmCreateDishes()
        {
            InitializeComponent();
            frmSelectInputs = new FrmSelectInputs();
        }

        private void btnagregaring_Click(object sender, EventArgs e)
        {
            frmSelectInputs.ShowDialog();
        }
    }
}

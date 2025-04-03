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
    public partial class FrmWindowEmergent : Form
    {

       
        public FrmWindowEmergent()
        {
            
            InitializeComponent();
        }

        private void FrmErrorWindow_Load(object sender, EventArgs e)
        {

        }

        public void actualizar(string mensaje, string nombreVentana)
        {
            lblerror.Text = mensaje;
            this.Text = nombreVentana;
        }
    }
}

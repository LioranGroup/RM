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
        private string ingredientesSeleccionados = "";
        private string cantidadesSeleccionadas = "";

        public FrmCreateDishes()
        {
            InitializeComponent();
            frmSelectInputs = new FrmSelectInputs();
            cargarplatillo();

        }

        private void btnagregaring_Click(object sender, EventArgs e)
        {
            //frmSelectInputs.ShowDialog();
            var selectForm = new FrmSelectInputs();

            if (selectForm.ShowDialog() == DialogResult.OK)
            {
                // Guardamos los valores recibidos en variables internas
                ingredientesSeleccionados = selectForm.IngredientesConcatenados;
                cantidadesSeleccionadas = selectForm.CantidadesConcatenadas;
            }
        }

        private void btnagregarplt_Click(object sender, EventArgs e)
        {
            string Name = txtname.Text;

            if (string.IsNullOrEmpty(Name) || string.IsNullOrEmpty(ingredientesSeleccionados))
            {
                MessageBox.Show("Debe ingresar un nombre de platillo y agregar al menos un ingrediente.");
                return;
            }

            string Ingredientes = ingredientesSeleccionados + " - " + cantidadesSeleccionadas;

            Logica.InsertarPlatillo(Name, Ingredientes);
            cargarplatillo();

            // Limpiar
            ingredientesSeleccionados = "";
            cantidadesSeleccionadas = "";
            txtname.Clear();

        }

        private void cargarplatillo()
        {
            Dishesview.DataSource = Logica.Obtenerplatillo();
        }
    }
}

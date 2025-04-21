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
        public string IngredientesConcatenados { get; private set; }
        public string CantidadesConcatenadas { get; private set; }

        public FrmSelectInputs()
        {
            InitializeComponent();
            CargarIngredientes();
            nuevaTabla();

        }

        private void CargarIngredientes()
        {
           // IngredientList.DataSource = Logica.Obteneringredientes();
        }

        private void IngredientList_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = IngredientList.Rows[e.RowIndex];

                string ingredient = row.Cells["Name"].Value.ToString();

                lblname.Text = ingredient;
                txtcantidad.Text = null;
            }
        }

        private void nuevaTabla()
        {
            NuevosIng.Columns.Add("Name", "Ingrediente");
            NuevosIng.Columns.Add("Qty", "Cantidad");
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            string Nombre = lblname.Text;
            string Cantidad = txtcantidad.Text;

            if (string.IsNullOrEmpty(Nombre) || string.IsNullOrEmpty(Cantidad))
            {
                MessageBox.Show("Selecciona un ingrediente e ingresa una cantidad.");
                return;
            }

            NuevosIng.Rows.Add(Nombre, Cantidad);
        }

        private void Savebttn_Click(object sender, EventArgs e)
        {
            List<string> nombresList = new List<string>();
            List<string> cantidadesList = new List<string>();

            foreach (DataGridViewRow row in NuevosIng.Rows)
            {
                if (row.IsNewRow) continue;

                string nombre = row.Cells["Name"].Value.ToString();
                string cantidad = row.Cells["Qty"].Value.ToString();

                nombresList.Add(nombre);
                cantidadesList.Add(cantidad);
            }

            IngredientesConcatenados = string.Join(",", nombresList);
            CantidadesConcatenadas = string.Join(",", cantidadesList);

            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}

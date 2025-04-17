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
    public partial class FrmCreateInputs : Form
    {
        //Atributos y variables
        private const string MensajeError = "Ingrese los Datos Correctamente";
        private Boolean validacion = false;
        private FrmWindowEmergent ventanaEmergente;



        public FrmCreateInputs()
        {
            InitializeComponent();
            ventanaEmergente = new FrmWindowEmergent();
            


        }

        //METODOS
        private void btnagregar_Click(object sender, EventArgs e)
        {
            validacion_Campos();


            if (validacion)
            {
                //Obtencion y Guardado de valores

                string valores = $"nombre: {txtname.Text} cantidad: {txtcantidad.Text} criterio: {txtcriterio.Text}";

                lblprueba.Text = valores ;
                lblprueba.Visible = true;

                //agregar valores a base de datos en debug bin
                Logica.InsertarIngrediante(txtname.Text,int.Parse(txtcantidad.Text),int.Parse(txtcriterio.Text));

                ventanaEmergente.actualizar("Agregado Correctamente", "Succefull");
                ventanaEmergente.ShowDialog();
                txtname.Text = "";
                txtcantidad.Text = "";
                txtcriterio.Text = "";
                lblerror.Visible = false;

                //Conexion con base de datos y agregar el registro 

            }
            else
            {
                lblprueba.Visible= false;
                lblerror.Text = "Datos Incompletos o Incorrectos";
                lblerror.Visible = true;
            }
        }

        
        



        // SUBMETODOS
        private void validacion_Campos()
        {
            try
            {
                if (txtname.Text != "")
                {
                    if (txtcantidad.Text != "" & Convert.ToInt64(txtcantidad.Text) >= 0)
                    {
                        if (txtcriterio.Text != "" & Convert.ToInt64(txtcriterio.Text) > 0)
                        {
                            validacion = true;
                        }
                        else validacion = false;
                    }
                    else validacion = false;

                }else validacion = false;
            }
            catch (FormatException e)
            {
                ventanaEmergente.actualizar("Se introdujo un caracter en donde iba un numero", "Exeption");
                ventanaEmergente.ShowDialog();
                validacion = false;


            }
            catch (Exception ex)
            {
                ventanaEmergente.actualizar("Se produjo una excepcion desconocida", "Exeption");
                ventanaEmergente.ShowDialog();
                validacion = false;
            }

            
        }

       
    }
}

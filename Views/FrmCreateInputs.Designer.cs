namespace RM.Views
{
    partial class FrmCreateInputs
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lblname = new Label();
            txtname = new TextBox();
            txtcantidad = new TextBox();
            lblcantidad = new Label();
            txtcriterio = new TextBox();
            lblcriterio = new Label();
            btnagregar = new Button();
            lblprueba = new Label();
            lblerror = new Label();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(225, 114);
            lblname.Name = "lblname";
            lblname.Size = new Size(119, 15);
            lblname.TabIndex = 0;
            lblname.Text = "Nombre del Insumo: ";
            // 
            // txtname
            // 
            txtname.Location = new Point(364, 111);
            txtname.Multiline = true;
            txtname.Name = "txtname";
            txtname.Size = new Size(212, 31);
            txtname.TabIndex = 1;
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(364, 168);
            txtcantidad.Multiline = true;
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(212, 31);
            txtcantidad.TabIndex = 3;
            // 
            // lblcantidad
            // 
            lblcantidad.AutoSize = true;
            lblcantidad.Location = new Point(225, 171);
            lblcantidad.Name = "lblcantidad";
            lblcantidad.Size = new Size(98, 15);
            lblcantidad.TabIndex = 2;
            lblcantidad.Text = "Cantidad Actual: ";
            // 
            // txtcriterio
            // 
            txtcriterio.Location = new Point(364, 219);
            txtcriterio.Multiline = true;
            txtcriterio.Name = "txtcriterio";
            txtcriterio.Size = new Size(212, 31);
            txtcriterio.TabIndex = 5;
            // 
            // lblcriterio
            // 
            lblcriterio.AutoSize = true;
            lblcriterio.Location = new Point(162, 222);
            lblcriterio.Name = "lblcriterio";
            lblcriterio.Size = new Size(182, 15);
            lblcriterio.TabIndex = 4;
            lblcriterio.Text = "Criterio a tomar (Solo Numeros): ";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(336, 329);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(137, 37);
            btnagregar.TabIndex = 6;
            btnagregar.Text = "Agregar Insumo";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lblprueba
            // 
            lblprueba.AutoSize = true;
            lblprueba.Location = new Point(390, 55);
            lblprueba.Name = "lblprueba";
            lblprueba.Size = new Size(63, 15);
            lblprueba.TabIndex = 7;
            lblprueba.Text = "Contenido";
            lblprueba.Visible = false;
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.ForeColor = Color.Crimson;
            lblerror.Location = new Point(387, 284);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(38, 15);
            lblerror.TabIndex = 8;
            lblerror.Text = "label1";
            lblerror.Visible = false;
            // 
            // FrmCreateInputs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(817, 450);
            Controls.Add(lblerror);
            Controls.Add(lblprueba);
            Controls.Add(btnagregar);
            Controls.Add(txtcriterio);
            Controls.Add(lblcriterio);
            Controls.Add(txtcantidad);
            Controls.Add(lblcantidad);
            Controls.Add(txtname);
            Controls.Add(lblname);
            Name = "FrmCreateInputs";
            Text = "FrmCreateInputs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private TextBox txtname;
        private TextBox txtcantidad;
        private Label lblcantidad;
        private TextBox txtcriterio;
        private Label lblcriterio;
        private Button btnagregar;
        private Label lblprueba;
        private Label lblerror;
    }
}
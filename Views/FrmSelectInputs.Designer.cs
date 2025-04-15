namespace RM.Views
{
    partial class FrmSelectInputs
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
            menuStrip1 = new MenuStrip();
            btnagregar = new Button();
            lbltitle = new Label();
            lblname = new Label();
            label1 = new Label();
            txtcantidad = new TextBox();
            IngredientList = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)IngredientList).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1486, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(1060, 766);
            btnagregar.Margin = new Padding(6, 6, 6, 6);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(336, 79);
            btnagregar.TabIndex = 2;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(1166, 158);
            lbltitle.Margin = new Padding(6, 0, 6, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(137, 32);
            lbltitle.TabIndex = 3;
            lbltitle.Text = "Ingrediente";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(1107, 213);
            lblname.Margin = new Padding(6, 0, 6, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(272, 32);
            lblname.TabIndex = 4;
            lblname.Text = "Nombre del Ingrediente";
            lblname.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1124, 452);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 5;
            label1.Text = "Cantidad por Porcion";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(1144, 518);
            txtcantidad.Margin = new Padding(6, 6, 6, 6);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(182, 39);
            txtcantidad.TabIndex = 6;
            // 
            // IngredientList
            // 
            IngredientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientList.Location = new Point(41, 54);
            IngredientList.Name = "IngredientList";
            IngredientList.RowHeadersWidth = 82;
            IngredientList.Size = new Size(985, 864);
            IngredientList.TabIndex = 7;
            // 
            // FrmSelectInputs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(IngredientList);
            Controls.Add(txtcantidad);
            Controls.Add(label1);
            Controls.Add(lblname);
            Controls.Add(lbltitle);
            Controls.Add(btnagregar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Margin = new Padding(6, 6, 6, 6);
            Name = "FrmSelectInputs";
            Text = "FrmSelectInputs";
            ((System.ComponentModel.ISupportInitialize)IngredientList).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private Button btnagregar;
        private Label lbltitle;
        private Label lblname;
        private Label label1;
        private TextBox txtcantidad;
        private DataGridView IngredientList;
    }
}
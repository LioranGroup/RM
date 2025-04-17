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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmSelectInputs));
            menuStrip1 = new MenuStrip();
            btnagregar = new Button();
            lbltitle = new Label();
            lblname = new Label();
            label1 = new Label();
            txtcantidad = new TextBox();
            IngredientList = new DataGridView();
            NuevosIng = new DataGridView();
            pictureBox1 = new PictureBox();
            Savebttn = new Button();
            ((System.ComponentModel.ISupportInitialize)IngredientList).BeginInit();
            ((System.ComponentModel.ISupportInitialize)NuevosIng).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(32, 32);
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(599, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(195, 316);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(181, 37);
            btnagregar.TabIndex = 2;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(92, 254);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(67, 15);
            lbltitle.TabIndex = 3;
            lbltitle.Text = "Ingrediente";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(60, 280);
            lblname.Name = "lblname";
            lblname.Size = new Size(133, 15);
            lblname.TabIndex = 4;
            lblname.Text = "Nombre del ingrediente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(364, 254);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Cantidad por Porcion";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(375, 285);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 6;
            // 
            // IngredientList
            // 
            IngredientList.AllowUserToAddRows = false;
            IngredientList.AllowUserToDeleteRows = false;
            IngredientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientList.Location = new Point(17, 13);
            IngredientList.Margin = new Padding(2, 1, 2, 1);
            IngredientList.Name = "IngredientList";
            IngredientList.ReadOnly = true;
            IngredientList.RowHeadersWidth = 82;
            IngredientList.Size = new Size(238, 225);
            IngredientList.TabIndex = 7;
            IngredientList.CellClick += IngredientList_CellClick;
            // 
            // NuevosIng
            // 
            NuevosIng.AllowUserToAddRows = false;
            NuevosIng.AllowUserToDeleteRows = false;
            NuevosIng.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NuevosIng.Location = new Point(322, 13);
            NuevosIng.Margin = new Padding(2, 1, 2, 1);
            NuevosIng.Name = "NuevosIng";
            NuevosIng.ReadOnly = true;
            NuevosIng.RowHeadersWidth = 82;
            NuevosIng.Size = new Size(238, 225);
            NuevosIng.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(258, 89);
            pictureBox1.Margin = new Padding(2, 1, 2, 1);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(61, 54);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Savebttn
            // 
            Savebttn.Location = new Point(479, 371);
            Savebttn.Margin = new Padding(2, 1, 2, 1);
            Savebttn.Name = "Savebttn";
            Savebttn.Size = new Size(81, 22);
            Savebttn.TabIndex = 10;
            Savebttn.Text = "Guardar";
            Savebttn.UseVisualStyleBackColor = true;
            Savebttn.Click += Savebttn_Click;
            // 
            // FrmSelectInputs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(599, 411);
            Controls.Add(Savebttn);
            Controls.Add(pictureBox1);
            Controls.Add(NuevosIng);
            Controls.Add(IngredientList);
            Controls.Add(txtcantidad);
            Controls.Add(label1);
            Controls.Add(lblname);
            Controls.Add(lbltitle);
            Controls.Add(btnagregar);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmSelectInputs";
            Text = "FrmSelectInputs";
            ((System.ComponentModel.ISupportInitialize)IngredientList).EndInit();
            ((System.ComponentModel.ISupportInitialize)NuevosIng).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
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
        private DataGridView NuevosIng;
        private PictureBox pictureBox1;
        private Button Savebttn;
    }
}
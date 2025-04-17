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
            menuStrip1.Padding = new Padding(11, 4, 0, 4);
            menuStrip1.Size = new Size(1113, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(362, 675);
            btnagregar.Margin = new Padding(6);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(336, 79);
            btnagregar.TabIndex = 2;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            btnagregar.Click += btnagregar_Click;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(170, 542);
            lbltitle.Margin = new Padding(6, 0, 6, 0);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(137, 32);
            lbltitle.TabIndex = 3;
            lbltitle.Text = "Ingrediente";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(111, 597);
            lblname.Margin = new Padding(6, 0, 6, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(272, 32);
            lblname.TabIndex = 4;
            lblname.Text = "Nombre del ingrediente";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(676, 542);
            label1.Margin = new Padding(6, 0, 6, 0);
            label1.Name = "label1";
            label1.Size = new Size(238, 32);
            label1.TabIndex = 5;
            label1.Text = "Cantidad por Porcion";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(696, 608);
            txtcantidad.Margin = new Padding(6);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(182, 39);
            txtcantidad.TabIndex = 6;
            // 
            // IngredientList
            // 
            IngredientList.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            IngredientList.Location = new Point(31, 27);
            IngredientList.Name = "IngredientList";
            IngredientList.RowHeadersWidth = 82;
            IngredientList.Size = new Size(442, 481);
            IngredientList.TabIndex = 7;
            IngredientList.CellContentClick += IngredientList_CellContentClick;
            // 
            // NuevosIng
            // 
            NuevosIng.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            NuevosIng.Location = new Point(598, 27);
            NuevosIng.Name = "NuevosIng";
            NuevosIng.RowHeadersWidth = 82;
            NuevosIng.Size = new Size(442, 481);
            NuevosIng.TabIndex = 8;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(479, 190);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(113, 115);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 9;
            pictureBox1.TabStop = false;
            // 
            // Savebttn
            // 
            Savebttn.Location = new Point(890, 792);
            Savebttn.Name = "Savebttn";
            Savebttn.Size = new Size(150, 46);
            Savebttn.TabIndex = 10;
            Savebttn.Text = "Guardar";
            Savebttn.UseVisualStyleBackColor = true;
            Savebttn.Click += Savebttn_Click;
            // 
            // FrmSelectInputs
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1113, 876);
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
            Margin = new Padding(6);
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
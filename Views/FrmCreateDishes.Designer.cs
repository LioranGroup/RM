namespace RM.Views
{
    partial class FrmCreateDishes
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
            lbltitulo = new Label();
            btnagregaring = new Button();
            btnagregarplt = new Button();
            Dishesview = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)Dishesview).BeginInit();
            SuspendLayout();
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(325, 98);
            lblname.Margin = new Padding(6, 0, 6, 0);
            lblname.Name = "lblname";
            lblname.Size = new Size(232, 32);
            lblname.TabIndex = 0;
            lblname.Text = "Nombre del Platillo: ";
            // 
            // txtname
            // 
            txtname.Location = new Point(550, 98);
            txtname.Margin = new Padding(6);
            txtname.Name = "txtname";
            txtname.Size = new Size(444, 39);
            txtname.TabIndex = 1;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(628, 254);
            lbltitulo.Margin = new Padding(6, 0, 6, 0);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(265, 32);
            lbltitulo.TabIndex = 2;
            lbltitulo.Text = "Ingredientes del Platillo";
            // 
            // btnagregaring
            // 
            btnagregaring.Location = new Point(591, 655);
            btnagregaring.Margin = new Padding(6);
            btnagregaring.Name = "btnagregaring";
            btnagregaring.Size = new Size(279, 66);
            btnagregaring.TabIndex = 6;
            btnagregaring.Text = "Agregar Ingrediente";
            btnagregaring.UseVisualStyleBackColor = true;
            btnagregaring.Click += btnagregaring_Click;
            // 
            // btnagregarplt
            // 
            btnagregarplt.Location = new Point(566, 787);
            btnagregarplt.Margin = new Padding(6);
            btnagregarplt.Name = "btnagregarplt";
            btnagregarplt.Size = new Size(334, 83);
            btnagregarplt.TabIndex = 7;
            btnagregarplt.Text = "Agregar Platillo";
            btnagregarplt.UseVisualStyleBackColor = true;
            btnagregarplt.Click += btnagregarplt_Click;
            // 
            // Dishesview
            // 
            Dishesview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dishesview.Location = new Point(453, 320);
            Dishesview.Name = "Dishesview";
            Dishesview.RowHeadersWidth = 82;
            Dishesview.Size = new Size(563, 258);
            Dishesview.TabIndex = 8;
            // 
            // FrmCreateDishes
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(Dishesview);
            Controls.Add(btnagregarplt);
            Controls.Add(btnagregaring);
            Controls.Add(lbltitulo);
            Controls.Add(txtname);
            Controls.Add(lblname);
            Margin = new Padding(6);
            Name = "FrmCreateDishes";
            Text = "Create Dishes";
            ((System.ComponentModel.ISupportInitialize)Dishesview).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblname;
        private TextBox txtname;
        private Label lbltitulo;
        private Button btnagregaring;
        private Button btnagregarplt;
        private DataGridView Dishesview;
    }
}
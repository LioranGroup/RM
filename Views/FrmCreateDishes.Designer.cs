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
            lblname.Location = new Point(175, 46);
            lblname.Name = "lblname";
            lblname.Size = new Size(115, 15);
            lblname.TabIndex = 0;
            lblname.Text = "Nombre del Platillo: ";
            // 
            // txtname
            // 
            txtname.Location = new Point(296, 46);
            txtname.Name = "txtname";
            txtname.Size = new Size(241, 23);
            txtname.TabIndex = 1;
            // 
            // lbltitulo
            // 
            lbltitulo.AutoSize = true;
            lbltitulo.Location = new Point(338, 119);
            lbltitulo.Name = "lbltitulo";
            lbltitulo.Size = new Size(130, 15);
            lbltitulo.TabIndex = 2;
            lbltitulo.Text = "Ingredientes del Platillo";
            // 
            // btnagregaring
            // 
            btnagregaring.Location = new Point(318, 307);
            btnagregaring.Name = "btnagregaring";
            btnagregaring.Size = new Size(150, 31);
            btnagregaring.TabIndex = 6;
            btnagregaring.Text = "Agregar Ingrediente";
            btnagregaring.UseVisualStyleBackColor = true;
            btnagregaring.Click += btnagregaring_Click;
            // 
            // btnagregarplt
            // 
            btnagregarplt.Location = new Point(305, 369);
            btnagregarplt.Name = "btnagregarplt";
            btnagregarplt.Size = new Size(180, 39);
            btnagregarplt.TabIndex = 7;
            btnagregarplt.Text = "Agregar Platillo";
            btnagregarplt.UseVisualStyleBackColor = true;
            btnagregarplt.Click += btnagregarplt_Click;
            // 
            // Dishesview
            // 
            Dishesview.AllowUserToAddRows = false;
            Dishesview.AllowUserToDeleteRows = false;
            Dishesview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            Dishesview.Location = new Point(244, 150);
            Dishesview.Margin = new Padding(2, 1, 2, 1);
            Dishesview.Name = "Dishesview";
            Dishesview.ReadOnly = true;
            Dishesview.RowHeadersWidth = 82;
            Dishesview.Size = new Size(303, 121);
            Dishesview.TabIndex = 8;
            // 
            // FrmCreateDishes
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(Dishesview);
            Controls.Add(btnagregarplt);
            Controls.Add(btnagregaring);
            Controls.Add(lbltitulo);
            Controls.Add(txtname);
            Controls.Add(lblname);
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
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
            listInputs = new ListBox();
            menuStrip1 = new MenuStrip();
            btnagregar = new Button();
            lbltitle = new Label();
            lblname = new Label();
            label1 = new Label();
            txtcantidad = new TextBox();
            SuspendLayout();
            // 
            // listInputs
            // 
            listInputs.FormattingEnabled = true;
            listInputs.ItemHeight = 15;
            listInputs.Location = new Point(27, 29);
            listInputs.Name = "listInputs";
            listInputs.ScrollAlwaysVisible = true;
            listInputs.Size = new Size(492, 379);
            listInputs.TabIndex = 0;
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(800, 24);
            menuStrip1.TabIndex = 1;
            menuStrip1.Text = "menuStrip1";
            // 
            // btnagregar
            // 
            btnagregar.Location = new Point(571, 359);
            btnagregar.Name = "btnagregar";
            btnagregar.Size = new Size(181, 37);
            btnagregar.TabIndex = 2;
            btnagregar.Text = "Agregar";
            btnagregar.UseVisualStyleBackColor = true;
            // 
            // lbltitle
            // 
            lbltitle.AutoSize = true;
            lbltitle.Location = new Point(628, 74);
            lbltitle.Name = "lbltitle";
            lbltitle.Size = new Size(67, 15);
            lbltitle.TabIndex = 3;
            lbltitle.Text = "Ingrediente";
            // 
            // lblname
            // 
            lblname.AutoSize = true;
            lblname.Location = new Point(596, 100);
            lblname.Name = "lblname";
            lblname.Size = new Size(133, 15);
            lblname.TabIndex = 4;
            lblname.Text = "Nombre del Ingrediente";
            lblname.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(605, 212);
            label1.Name = "label1";
            label1.Size = new Size(120, 15);
            label1.TabIndex = 5;
            label1.Text = "Cantidad por Porcion";
            // 
            // txtcantidad
            // 
            txtcantidad.Location = new Point(616, 243);
            txtcantidad.Name = "txtcantidad";
            txtcantidad.Size = new Size(100, 23);
            txtcantidad.TabIndex = 6;
            // 
            // FrmSelectInputs
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(txtcantidad);
            Controls.Add(label1);
            Controls.Add(lblname);
            Controls.Add(lbltitle);
            Controls.Add(btnagregar);
            Controls.Add(listInputs);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "FrmSelectInputs";
            Text = "FrmSelectInputs";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox listInputs;
        private MenuStrip menuStrip1;
        private Button btnagregar;
        private Label lbltitle;
        private Label lblname;
        private Label label1;
        private TextBox txtcantidad;
    }
}
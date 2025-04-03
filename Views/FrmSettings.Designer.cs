namespace RM.Views
{
    partial class FrmSettings
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
            btncreateinputs = new Button();
            btncreatedishes = new Button();
            SuspendLayout();
            // 
            // btncreateinputs
            // 
            btncreateinputs.Location = new Point(74, 38);
            btncreateinputs.Name = "btncreateinputs";
            btncreateinputs.Size = new Size(156, 47);
            btncreateinputs.TabIndex = 0;
            btncreateinputs.Text = "Crear un Ingrediente";
            btncreateinputs.UseVisualStyleBackColor = true;
            btncreateinputs.Click += btncreateinputs_Click;
            // 
            // btncreatedishes
            // 
            btncreatedishes.Location = new Point(258, 38);
            btncreatedishes.Name = "btncreatedishes";
            btncreatedishes.Size = new Size(156, 47);
            btncreatedishes.TabIndex = 1;
            btncreatedishes.Text = "Crear un Platillo";
            btncreatedishes.UseVisualStyleBackColor = true;
            btncreatedishes.Click += btncreatedishes_Click;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(btncreatedishes);
            Controls.Add(btncreateinputs);
            Name = "FrmSettings";
            Text = "FrmSettings";
            ResumeLayout(false);
        }

        #endregion

        private Button btncreateinputs;
        private Button btncreatedishes;
    }
}
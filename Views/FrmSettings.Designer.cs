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
            ViewBttn = new Button();
            SuspendLayout();
            // 
            // btncreateinputs
            // 
            btncreateinputs.Location = new Point(137, 81);
            btncreateinputs.Margin = new Padding(6, 6, 6, 6);
            btncreateinputs.Name = "btncreateinputs";
            btncreateinputs.Size = new Size(290, 100);
            btncreateinputs.TabIndex = 0;
            btncreateinputs.Text = "Crear un Ingrediente";
            btncreateinputs.UseVisualStyleBackColor = true;
            btncreateinputs.Click += btncreateinputs_Click;
            // 
            // btncreatedishes
            // 
            btncreatedishes.Location = new Point(479, 81);
            btncreatedishes.Margin = new Padding(6, 6, 6, 6);
            btncreatedishes.Name = "btncreatedishes";
            btncreatedishes.Size = new Size(290, 100);
            btncreatedishes.TabIndex = 1;
            btncreatedishes.Text = "Crear un Platillo";
            btncreatedishes.UseVisualStyleBackColor = true;
            btncreatedishes.Click += btncreatedishes_Click;
            // 
            // ViewBttn
            // 
            ViewBttn.Location = new Point(598, 430);
            ViewBttn.Margin = new Padding(6);
            ViewBttn.Name = "ViewBttn";
            ViewBttn.Size = new Size(290, 100);
            ViewBttn.TabIndex = 2;
            ViewBttn.Text = "Inputs view";
            ViewBttn.UseVisualStyleBackColor = true;
            ViewBttn.Click += ViewBttn_Click;
            // 
            // FrmSettings
            // 
            AutoScaleDimensions = new SizeF(13F, 32F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1486, 960);
            Controls.Add(ViewBttn);
            Controls.Add(btncreatedishes);
            Controls.Add(btncreateinputs);
            Margin = new Padding(6, 6, 6, 6);
            Name = "FrmSettings";
            Text = "FrmSettings";
            ResumeLayout(false);
        }

        #endregion

        private Button btncreateinputs;
        private Button btncreatedishes;
        private Button ViewBttn;
    }
}
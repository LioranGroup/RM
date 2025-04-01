namespace RM
{
    partial class SampleView
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
            components = new System.ComponentModel.Container();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges1 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges2 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            Guna.UI2.WinForms.Suite.CustomizableEdges customizableEdges3 = new Guna.UI2.WinForms.Suite.CustomizableEdges();
            label1 = new Label();
            SearchBox = new Guna.UI2.WinForms.Guna2TextBox();
            guna2AnimateWindow1 = new Guna.UI2.WinForms.Guna2AnimateWindow(components);
            Addbttn = new Guna.UI2.WinForms.Guna2ImageButton();
            HeaderLb = new Label();
            guna2Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(827, 44);
            label1.Name = "label1";
            label1.Size = new Size(95, 37);
            label1.TabIndex = 0;
            label1.Text = "Search";
            // 
            // SearchBox
            // 
            SearchBox.AccessibleDescription = "";
            SearchBox.BackColor = Color.White;
            SearchBox.CustomizableEdges = customizableEdges1;
            SearchBox.DefaultText = "";
            SearchBox.DisabledState.BorderColor = Color.FromArgb(208, 208, 208);
            SearchBox.DisabledState.FillColor = Color.FromArgb(226, 226, 226);
            SearchBox.DisabledState.ForeColor = Color.FromArgb(138, 138, 138);
            SearchBox.DisabledState.PlaceholderForeColor = Color.FromArgb(138, 138, 138);
            SearchBox.FocusedState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBox.Font = new Font("Segoe UI", 9F);
            SearchBox.HoverState.BorderColor = Color.FromArgb(94, 148, 255);
            SearchBox.IconLeft = Properties.Resources._9035096_search_icon;
            SearchBox.IconLeftOffset = new Point(10, 0);
            SearchBox.IconLeftSize = new Size(30, 30);
            SearchBox.Location = new Point(827, 87);
            SearchBox.Margin = new Padding(6, 6, 6, 6);
            SearchBox.Name = "SearchBox";
            SearchBox.PasswordChar = '\0';
            SearchBox.PlaceholderText = "Search Here";
            SearchBox.SelectedText = "";
            SearchBox.ShadowDecoration.CustomizableEdges = customizableEdges2;
            SearchBox.Size = new Size(463, 63);
            SearchBox.TabIndex = 1;
            SearchBox.TextChanged += SearchBox_TextChanged;
            // 
            // Addbttn
            // 
            Addbttn.CheckedState.ImageSize = new Size(64, 64);
            Addbttn.HoverState.ImageSize = new Size(75, 75);
            Addbttn.Image = Properties.Resources._3669477_add_box_ic_icon__2_;
            Addbttn.ImageOffset = new Point(0, 0);
            Addbttn.ImageRotate = 0F;
            Addbttn.ImageSize = new Size(80, 80);
            Addbttn.Location = new Point(12, 80);
            Addbttn.Name = "Addbttn";
            Addbttn.PressedState.ImageSize = new Size(110, 110);
            Addbttn.ShadowDecoration.CustomizableEdges = customizableEdges3;
            Addbttn.Size = new Size(70, 70);
            Addbttn.TabIndex = 2;
            Addbttn.Click += Addbttn_Click;
            // 
            // HeaderLb
            // 
            HeaderLb.AutoSize = true;
            HeaderLb.Font = new Font("Segoe UI", 16.125F, FontStyle.Regular, GraphicsUnit.Point, 0);
            HeaderLb.Location = new Point(12, 20);
            HeaderLb.Name = "HeaderLb";
            HeaderLb.Size = new Size(162, 59);
            HeaderLb.TabIndex = 0;
            HeaderLb.Text = "Header";
            // 
            // guna2Separator1
            // 
            guna2Separator1.Location = new Point(12, 168);
            guna2Separator1.Name = "guna2Separator1";
            guna2Separator1.Size = new Size(1278, 39);
            guna2Separator1.TabIndex = 3;
            // 
            // SampleView
            // 
            AutoScaleMode = AutoScaleMode.None;
            BackColor = Color.White;
            ClientSize = new Size(1305, 742);
            Controls.Add(guna2Separator1);
            Controls.Add(Addbttn);
            Controls.Add(SearchBox);
            Controls.Add(HeaderLb);
            Controls.Add(label1);
            Font = new Font("Segoe UI", 10F);
            FormBorderStyle = FormBorderStyle.None;
            Name = "SampleView";
            Text = "SampleView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Guna.UI2.WinForms.Guna2TextBox guna2TextBox1;
        private Guna.UI2.WinForms.Guna2AnimateWindow guna2AnimateWindow1;
        public Label label1;
        public Guna.UI2.WinForms.Guna2TextBox SearchBox;
        public Guna.UI2.WinForms.Guna2ImageButton Addbttn;
        public Label HeaderLb;
        private Guna.UI2.WinForms.Guna2Separator guna2Separator1;
    }
}
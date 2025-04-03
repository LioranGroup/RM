namespace RM.Views
{
    partial class FrmWindowEmergent
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
            lblerror = new Label();
            SuspendLayout();
            // 
            // lblerror
            // 
            lblerror.AutoSize = true;
            lblerror.Location = new Point(85, 49);
            lblerror.Name = "lblerror";
            lblerror.Size = new Size(43, 15);
            lblerror.TabIndex = 0;
            lblerror.Text = "ERROR";
            lblerror.TextAlign = ContentAlignment.TopCenter;
            // 
            // FrmErrorWindow
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(219, 114);
            Controls.Add(lblerror);
            Name = "FrmErrorWindow";
            Text = "Warning";
            Load += FrmErrorWindow_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public Label lblerror;
    }
}
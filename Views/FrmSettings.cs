﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM.Views
{
    public partial class FrmSettings : Form
    {
        private FrmCreateInputs frmCreateInputs;
        private FrmCreateDishes frmCreateDishes;
        //test
        private FrmSelectInputs frmSelectInputs;

        public FrmSettings()
        {
            InitializeComponent();
            frmCreateDishes = new FrmCreateDishes();
            frmCreateInputs = new FrmCreateInputs();
            frmSelectInputs = new FrmSelectInputs();

        }

        private void btncreateinputs_Click(object sender, EventArgs e)
        {
            frmCreateInputs.ShowDialog();
        }

        private void btncreatedishes_Click(object sender, EventArgs e)
        {
            frmCreateDishes.ShowDialog();
        }

        private void ViewBttn_Click(object sender, EventArgs e)
        {
            frmSelectInputs.ShowDialog();
        }
    }
}

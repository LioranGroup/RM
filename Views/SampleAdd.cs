﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RM
{
    public partial class SampleAdd : Form
    {
        public SampleAdd()
        {
            InitializeComponent();
        }

        public virtual void CloseBttn_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public virtual void SaveBttn_Click(object sender, EventArgs e)
        {
            
        }
    }
}

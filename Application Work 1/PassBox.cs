﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Application_Work_1
{
    public partial class PassBox : Form
    {
        public PassBox()
        {
            InitializeComponent();
        }
        string deleteurun = "asd";
        private static int Pas()
        {

            return 1;
        }
        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if(passbox1.Text == deleteurun)
            {
                Pas();
            }
        }
    }
}

﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ContexMenuStrip_kontrola
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBoxLijevo_TextChanged(object sender, EventArgs e)
        {

        }

        private void lijevoDesnoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxDesno.Text = textBoxLijevo.Text;
        }

        private void desnoLijevoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            textBoxLijevo.Text = textBoxDesno.Text;
        }
    }
}

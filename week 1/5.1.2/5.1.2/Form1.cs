﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1._2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            studenti obieqti_1 = new studenti();
            obieqti_1.universitetisDasaxeleba = textBox1.Text;
            obieqti_1.kursi = Convert.ToInt32(textBox2.Text);
            label1.Text = obieqti_1.universitetisDasaxeleba;
            label2.Text = obieqti_1.kursi.ToString();
        }
    }
}

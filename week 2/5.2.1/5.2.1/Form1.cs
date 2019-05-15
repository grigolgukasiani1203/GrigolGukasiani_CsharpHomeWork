using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] masivi = new int[] { 60, 87, 71, 90, 94, 58, 83, 57, 70, 65 };
            double shedegi;
            studenti obieqti_1 = new studenti();
            shedegi = obieqti_1.SashualoQula(masivi);
            label1.Text = shedegi.ToString();
        }
    }
}

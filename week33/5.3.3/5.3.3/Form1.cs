using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._3._3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int gverdi1 = Convert.ToInt32(textBox1.Text);
            int gverdi2 = Convert.ToInt32(textBox2.Text);
            martkutxedi obieqti_1 = new martkutxedi(gverdi1, gverdi2);
            obieqti_1.Gamotana(label1);
        }
    }
}

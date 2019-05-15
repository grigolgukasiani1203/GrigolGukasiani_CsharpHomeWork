using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._1._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            tvitmfrinavi obieqti_1 = new tvitmfrinavi();
            obieqti_1.mgzavrebisRaodenoba = Convert.ToInt32(textBox1.Text);
            obieqti_1.gayiduliBilitebi = Convert.ToInt32(textBox2.Text);
            label1.Text = obieqti_1.mgzavrebisRaodenoba.ToString();
            label2.Text = obieqti_1.gayiduliBilitebi.ToString();
        }
    }
}

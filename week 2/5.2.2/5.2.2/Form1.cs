using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._2
{
    public partial class Form1 : Form
    {
        
    
    private void button4_Click(object sender, EventArgs e)
    {
        studenti obieqti_1 = new studenti();
        string gvari = textBox1.Text;
        string saxeli = textBox2.Text;
        int asaki = Convert.ToInt32(textBox3.Text);
        obieqti_1.gadacema(gvari, saxeli, asaki);
        obieqti_1.gamotana(label1);
    }
    }
}

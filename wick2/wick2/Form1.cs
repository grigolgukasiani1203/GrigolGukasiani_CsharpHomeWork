using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wick2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            int[] nishnebi = { 100, 67, 87, 98, 60, 98, 67, 59, 78, 81 };
            student studentobject = new student();
            label1.Text = studentobject.sashualoAritmetikuli(nishnebi).ToString();
        }
    }
}

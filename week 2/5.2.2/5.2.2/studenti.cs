using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._2._2
{
    class studenti
    {
        string gvari;
        string saxeli;
        int asaki;
        void minicheba(string par1, string par2, int par3)
        {
            gvari = par1;
            saxeli = par2;
            asaki = par3;
        }
        public void gadacema(string par1, string par2, int par3)
        {
            minicheba(par1, par2, par3);
        }
        public void gamotana(Label lab)
        {
            lab.Text = "სტუდენტის გვარი: " + gvari + "\nსტუდენტის სახელი: " + saxeli +
            "\nსტუდენტის ასაკი: " + asaki.ToString();
        }
    }
        
}

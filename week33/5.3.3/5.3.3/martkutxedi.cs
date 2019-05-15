using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _5._3._3
{
    class martkutxedi
    {
        public int gverdi1;
        public int gverdi2;
        private int perimetri;
        private int fartobi;
        public martkutxedi(int par1, int par2)
        {
            gverdi1 = par1;
            gverdi1 = par2;
            perimetri = (gverdi1 + gverdi2) * 2;
            fartobi = gverdi1 * gverdi2;
        }
        public void Gamotana(Label lab1)
        {
            lab1.Text = "პერიმეტრი = " + perimetri.ToString() + "ფართობი = " + fartobi.ToString();
        }
    }
}

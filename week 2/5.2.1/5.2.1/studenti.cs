using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _5._2._1
{
    class studenti
    {
        public double SashualoQula(int[] masivi1)
        {
            int jami = 0;
            for (int ind = 0; ind < masivi1.Length; ind++)
                jami += masivi1[ind];
            return jami / masivi1.Length;

           

}
    }
}

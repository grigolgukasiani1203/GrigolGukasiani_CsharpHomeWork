using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace wick2
{
    class student
    {
        public double sashualoAritmetikuli(int[] nishnebi)
        {
            double sashualo = 0 , jami =0;
            for (int i=0; i < nishnebi.Length; i++)
            {
                jami += nishnebi[i];
            }
            sashualo = jami / nishnebi.Length;
            return sashualo;
        }

    }
}

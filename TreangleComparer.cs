using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreangleSort
{
    class TreangleComparer : IComparer<Treangle>
    {
        public int Compare(Treangle t1, Treangle t2)
        {
            if (t1.Area > t2.Area)
            {
                return -1;
            }
            else if (t1.Area < t2.Area)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreangleSort
{
    class Treangle
    {
        public string Name { get; }
        public double Area { get; }

        public Treangle(string name, double firstSide, double secondSide, double thirdSide)
        {
            Name = name;
            Area = TreangleAreaCounter.CountArea(firstSide, secondSide, thirdSide);
        }
    }
}

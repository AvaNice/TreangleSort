using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreangleSort
{
    static class TreangleAreaCounter
    {
        private const int BISECTOR = 2;

        public static double CountArea(double firstSide, double secondSide, double thirdSide)
        {
            double halfPerimeter = CountPerimeter(firstSide, secondSide, thirdSide) / BISECTOR;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - firstSide)
                * (halfPerimeter - secondSide) * (halfPerimeter - thirdSide));
        }

        private static double CountPerimeter(double firstSide, double secondSide, double thirdSide)
        {
            return firstSide + secondSide + thirdSide;
        }
    }
}

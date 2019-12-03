using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreangleSort
{
    class Treangle : IComparable<Treangle>
    {
        private const int BISECTOR = 2;

        public string Name { get; }
        public double FirstSide { get; }
        public double SecondSide { get; }
        public double ThirdSide { get; }
        public double Area { get; }
        public double Perimeter { get; }


        public Treangle(string name, double firstSide, double secondSide, double thirdSide)
        {
            FirstSide = firstSide;
            SecondSide = secondSide;
            ThirdSide = thirdSide;
            Name = name;

            Perimeter = CountPerimeter();
            Area = CountArea();
        }

        public double CountArea()
        {
            double halfPerimeter = CountPerimeter() / BISECTOR;

            return Math.Sqrt(halfPerimeter * (halfPerimeter - FirstSide)
                * (halfPerimeter - SecondSide) * (halfPerimeter - ThirdSide));
        }

        public double CountPerimeter()
        {

            return FirstSide + SecondSide + ThirdSide;
        }

        public int CompareTo(Treangle treangle)
        {
            if (Area > treangle.Area)
            {

                return -1;
            }
            else if (Area < treangle.Area)
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

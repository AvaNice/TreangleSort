using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TreangleSort
{
    class Program
    {
        static List<Treangle> treangles = new List<Treangle>();

        static void Main()
        {
            treangles.Add(GetTreangle());

            treangles.Sort();
            foreach (var item in treangles)
            {
                Console.WriteLine($"[{item.Name}] {item.Area} ");
            }

            Main();
        }
        static Treangle GetTreangle()
        {
            string input = Console.ReadLine();

            string[] splitedInput = new string[4];

            splitedInput = input.Split('.');

            //исключение свое. и структуру менять. 
            string name;
            double firstSide;
            double secondSide;
            double thirdSide;

            name = splitedInput[0];

            firstSide = Convert.ToDouble(splitedInput[1]);
            secondSide = Convert.ToDouble(splitedInput[2]);
            thirdSide = Convert.ToDouble(splitedInput[3]);

            Treangle treangle = new Treangle(name, firstSide, secondSide, thirdSide);

            if (treangle.Area > 0)
            {
                return treangle;
            }

            throw new Exception("Sides of the triangle entered incorrectly!");

        }
    }
}

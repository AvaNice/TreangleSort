using System;
using System.Collections;
using System.Collections.Generic;

namespace TreangleSort
{
    class TriangleUI
    {
        TriangleValidator validator = new TriangleValidator();

        public Triangle GetTriangle()
        {
            string[] splitedInput = new string[4];

            Console.WriteLine(TextMessages.ENTER_TREANGLE);

            string input = Console.ReadLine();

            splitedInput = input.Split('.');

            string name;
            double firstSide;
            double secondSide;
            double thirdSide;

            try
            {
                name = splitedInput[0];

                firstSide = Convert.ToDouble(splitedInput[1]);
                secondSide = Convert.ToDouble(splitedInput[2]);
                thirdSide = Convert.ToDouble(splitedInput[3]);

                Triangle triangle = new Triangle(name, firstSide, secondSide, thirdSide);

                if (validator.Validate(triangle).IsValid)
                {
                    return triangle;
                }
                else
                {
                    ShowIncorrectInput();
                }
            }

            catch (FormatException ex)
            {
                ShowIncorrectInput(ex, input);
                //TODO log
            }

            catch (NullReferenceException ex)
            {
                ShowIncorrectInput(ex, input);
                //TODO log
            }

            catch (IndexOutOfRangeException ex)
            {
                ShowIncorrectInput(ex, input);
                //TODO log
            }

            return GetTriangle();
        }

        public void WriteTriangles(ICollection<Triangle> treangles)
        {
            foreach (var treangle in treangles)
            {
                Console.WriteLine($"[{treangle.Name}]: {treangle.Area} cm");
            }
        }

        public bool IsMoreTriangles()
        {
            Console.WriteLine(TextMessages.DO_NEED_MORE);

            string input;

            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case TextMessages.START_MODE:
                case TextMessages.START_MODE_SECOND:

                    return true;

                default:

                    return false;
            }
        }

        private void ShowIncorrectInput(Exception ex, string input)
        {
            Console.WriteLine(TextMessages.INCORRECT_INPUT);
        }

        private void ShowIncorrectInput()
        {
            Console.WriteLine(TextMessages.TREANGLE_NOT_EXIST);
        }
    }
}

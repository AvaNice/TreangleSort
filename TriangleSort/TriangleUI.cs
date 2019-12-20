using Serilog;
using System;
using System.Collections.Generic;

namespace TreangleSort
{
    public class TriangleUI
    {
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

                return triangle;
            }
            catch (FormatException ex)
            {
                ShowIncorrectInput(ex, input);
                Log.Logger.Error($"{ex.Message} UI.GetTriang user input wrong format");
            }
            catch (NullReferenceException ex)
            {
                ShowIncorrectInput(ex, input);
                Log.Logger.Error($"{ex.Message} UI.GetTriang user input empty string");
            }
            catch (IndexOutOfRangeException ex)
            {
                Log.Logger.Error($"{ex.Message} UI.GetTriang user entered not all sides");
                ShowIncorrectInput(ex, input);
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
            bool result = false;

            input = Console.ReadLine();

            switch (input.ToLower())
            {
                case TextMessages.START_MODE:
                case TextMessages.START_MODE_SECOND:
                    result = true;
                    break;

                default:
                    result = false;
                    break;
            }

            return result;
        }

        public void Delay()
        {
            Console.ReadKey();
        }

        public void ShowIncorrectInput()
        {
            Console.WriteLine(TextMessages.TREANGLE_NOT_EXIST);
        }

        private void ShowIncorrectInput(Exception ex, string input)
        {
            Console.WriteLine(TextMessages.INCORRECT_INPUT);
            Log.Logger
                .Information($"{ex.Message}; Incorrect input message is displayed. previous input {input}");
        }
    }
}

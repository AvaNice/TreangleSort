using Serilog;
using System;
using System.Collections.Generic;

namespace TreangleSort
{
    public class Program
    {
        static void Main(string[] args)
        {
            TriangleValidator validator = new TriangleValidator();
            SortedSet<Triangle> triangles = new SortedSet<Triangle>();
            TriangleUI userInterface = new TriangleUI();
            TriangleSortApp app = new TriangleSortApp(userInterface, validator);

            ConfigLogger();

            try
            {
                do
                {
                    app.AddTreangle(triangles);
                }
                while (userInterface.IsMoreTriangles());

                userInterface.WriteTriangles(triangles);

                userInterface.Delay();
            }
            catch (ArgumentException ex)
            {
                Log.Logger.Error($"{ex.Message} User triangle not exist");
                app.AddTreangle(triangles);
            }
            catch (Exception ex)
            {
                Log.Logger.Error($"{ex.Message} Program.Main catch Exeption");
            }
        }

        private static void ConfigLogger()
        {
            Log.Logger = new LoggerConfiguration().MinimumLevel.Debug()
               .WriteTo.File("log.txt").CreateLogger();
        }
    }
}

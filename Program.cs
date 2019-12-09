using System;

namespace TreangleSort
{
    class Program
    {
        private static TriangleSortApp _app = new TriangleSortApp();
     
        static void Main(string[] args)
        {
            try
            {
                _app.Start();
            }

            catch(Exception ex)
            {
                //TODO log
            }
        }
    }
}

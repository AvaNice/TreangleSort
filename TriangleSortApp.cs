using System.Collections.Generic;

namespace TreangleSort
{
    class TriangleSortApp
    {
        private List<Triangle> triangles = new List<Triangle>();
       
        TriangleUI UI = new TriangleUI();

        public void Start()
        {
            triangles.Add(UI.GetTriangle());
            
            if(UI.IsMoreTriangles())
            {
                Start();
            }

            triangles.Sort();

            UI.WriteTriangles(triangles);

            Start();
        }
    }
}

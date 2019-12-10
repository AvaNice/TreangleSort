using System.Collections.Generic;

namespace TreangleSort
{
    class TriangleSortApp
    {
        TriangleUI UI = new TriangleUI();

        SortedSet<Triangle> triangles = new SortedSet<Triangle>();

        public void Start()
        {
            triangles.Add(UI.GetTriangle());
            
            if(UI.IsMoreTriangles())
            {
                Start();
            }

            UI.WriteTriangles(triangles);

            Start();
        }
    }
}

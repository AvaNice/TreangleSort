using System;
using System.Collections.Generic;

namespace TreangleSort
{
    public class TriangleSortApp
    {
        TriangleUI _userInterface;
        TriangleValidator _validator;

        public TriangleSortApp(TriangleUI userInterface, TriangleValidator validator)
        {
            _userInterface = userInterface;
            _validator = validator;
        }

        public void AddTreangle(SortedSet<Triangle> triangles)
        {
            Triangle triangle;

            triangle = _userInterface.GetTriangle();
            
            if (_validator.Validate(triangle).IsValid)
            {
                triangles.Add(triangle);
            }
            else
            {
                _userInterface.ShowIncorrectInput();

                throw new ArgumentException("Triangle does not exist");
            }
        }
    }
}

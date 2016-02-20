using System;

namespace Sandbox
{
    class InsertCodeHere
    {
        public void MyCode()
        {
            // The FIRST line of code should be BELOW this line
             Geometry geometry = new Geometry();

            geometry.Rectangle(10, 10);
            geometry.CalculatePerimeterOfRectangle();
            geometry.CalculateAreaOfRectangle();

            Console.WriteLine("The perimeter of the rectangle is: {0} and the area is: {1}", geometry.perimeter, geometry.area);

            geometry.Circle(3);
            geometry.CalculateAreaOfCircle();
            Console.WriteLine("The perimeter of the circle is: {0}", geometry.circleArea);

            geometry.Polygon(90, 90, 90, 90);
            geometry.IsPolygonRectangle();
            Console.WriteLine("The polygon is a rectangle? = {0}", geometry.isRectangle);
            // The LAST line of code should be ABOVE this line
        }
    }
}

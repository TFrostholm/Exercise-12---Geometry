using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Sandbox
{
    public class Geometry
    {
        private double length, hight, radius, angle1, angle2, angle3, angle4;

        public double perimeter, area, circleArea;
        public bool isRectangle;

        //Creating the rectangle
        public void Rectangle(double sideA, double sideB)
        {
            this.length = sideA;
            this.hight = sideB;
        }
        
        public double CalculatePerimeterOfRectangle()
        {
            perimeter = length*2 + hight*2;
            return perimeter;
        }

        public double CalculateAreaOfRectangle()
        {
            area = length*hight;
            return area;
        }

        public void Circle(double radius)
        {
            this.radius = radius;
        }

        public double CalculateAreaOfCircle()
        {
            circleArea = Math.PI*(radius*radius);
            return circleArea;
        }

        public void Polygon(double angle1, double angle2, double angle3, double angle4)
        {
            this.angle1 = angle2;
            this.angle2 = angle2;
            this.angle3 = angle3;
            this.angle4 = angle4;
        }

        public bool IsPolygonRectangle()
        {
            if (angle1 == 90 && angle2 == 90 && angle3 == 90 && angle4 == 90)
            {
                isRectangle = true;
            }
            else
            {
                isRectangle = false;
            }
            return isRectangle;

        }
    }
}

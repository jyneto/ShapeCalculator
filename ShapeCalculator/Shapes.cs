using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShapeCalculator
{
    // Interface and abstract class are used to have more flexible and reusable code. 

    //Interface difines the methods that all shape must have/implement. 
    public interface Ishape
    {
        //Method to calculate the area
        double GetArea();
    }
    //Abstract class representing a generic shape
    public abstract class Shape
    {
        //Abstract method to calculate the circumference(omkrets)
        public abstract double GetCircumference();
    }
    // Class representing a Circle , inheriting from Shape and implementing from IShape
    public class Circle : Shape, Ishape
    {
        /*Property to store the radius of a circle
          and assign the input to the  */
        public double Radie { get; set; }

        // Constructor to initializw the circle with a given radius
        public Circle(double radie)
        {
            Radie = radie;
        }
        // Implenting the method from Ishape to calculate the area of the circle
        public double GetArea()
        {
            return Math.PI * Math.Pow(Radie, 2);

        }
        // Override the method from abstract class Shape to calculate circumference specific to circle
        public override double GetCircumference()
        {
            return 2 * Math.PI * Radie; // Circumference formula
        }
        // Method for caculating a in this case a sphere
        public double GetVolume()
        {
            return (4.0 / 3.0) * Math.PI * Math.Pow(Radie, 3);
        }
    }


    public class Triangle : Shape, Ishape
    {
        //Properties for a triangle
        public double SideA { get; set; }
        public double SideB { get; set; }
        public double SideC { get; set; }
        //Constructor 
        public Triangle(double sideA, double sideB, double sideC)
        {
            SideA = sideA;
            SideB = sideB;
            SideC = sideC;
        }
        // Implement GetArea method from IShape to calculate area of a triangle
        public double GetArea()
        {
            //Semi perimeter
            double triangleSides = (SideA + SideB + SideC) / 2;
            //Area formula
            return Math.Sqrt(triangleSides * (triangleSides - SideA) * (triangleSides - SideB) * (triangleSides - SideC));
        }

        //Overriding the GetCircumference method from abstract class Shape to calculate circumference specific to triangles
        public override double GetCircumference()
        {
            return SideA + SideB + SideC;
        }
    }
}

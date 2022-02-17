using System;
using CSharpDZ1;
class Program
{
    public static void Main(string[] args)
    {
        Point centerPoint = new Point
        {
            X = 0,
            Y = 0
        };
        int semiMajorAxis = 0;
        int semiMinorAxis = 5;

        try
        {
            Ellipse ellipse = new Ellipse(centerPoint, semiMajorAxis, semiMinorAxis);
            Console.WriteLine($"Center coordinates: {ellipse.CenterPoint}, Semi-major axis = {ellipse.SemiMajorAxis}, Semi-minor axis = {ellipse.SemiMinorAxis}.");
            double area = ellipse.GetSquare();
            double length = ellipse.GetLength();
            Console.WriteLine($"Area = {area}, Length = {length}.");
        }

        catch (ArgumentException ex)
        {
            Console.WriteLine(ex.Message);
        }
    }
}
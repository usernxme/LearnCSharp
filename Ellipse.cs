using System;

namespace CSharpDZ1
{
    public class Ellipse
    {
        public Point CenterPoint { get; private set; }
        public int SemiMajorAxis { get; private set; }
        public int SemiMinorAxis { get; private set; }

        public Ellipse(Point centerPoint, int semiMajorAxis, int semiMinorAxis)
        {
            if (semiMajorAxis <= 0 | semiMinorAxis <= 0)
            {
                throw new ArgumentException("Semiaxis must be greater than zero.");
            }

            CenterPoint = centerPoint;
            SemiMinorAxis = semiMinorAxis;
            SemiMajorAxis = semiMajorAxis;
        }

        public double GetSquare()
        {
            return Math.PI * SemiMajorAxis * SemiMinorAxis;
        }
        public double GetLength()
        {
            return Math.PI * (SemiMajorAxis + SemiMinorAxis);
        }
    }
}
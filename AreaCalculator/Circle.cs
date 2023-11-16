using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AreaCalculator
{
    public class Circle : IShape
    {
        public double Radius { get; set; }
        public Circle(double radius)
        {
            Validate(radius);
            Radius = radius;
        }

        private void Validate(double radius) 
        {
            if (radius <= 0)
            {
                throw new ArgumentException("Given radious is non-positivie");
            }
        }

        public double CalculateArea()
        {
            return Math.PI * Radius * Radius;
        }
    }
}

using System;
using System.Collections.Generic;

namespace Equation
{
    class B : A
    {
        private float discriminant;

        public List<float> quadratic(float a, float b, float c)
        {

            if (a == 0)
            {

                return linear(b, c);
            }

            discriminant = Discriminant(a, b, c);

            if (discriminant < 0)
            {
                return null;
            }

            x = new List<float>();


            if (discriminant > 0)
            {

                x.Add(((-b) - (float)Math.Sqrt(discriminant)) / (2 * a));
                x.Add(((-b) + (float)Math.Sqrt(discriminant)) / (2 * a));
                return x;
            }

            x.Add((-b) / (2 * a));

            return x;
        }

        protected float Discriminant(float a, float b, float c)
        {
            return b * b - 4 * a * c;
        }
    }
}

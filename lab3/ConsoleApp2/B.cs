using System;
using System.Collections.Generic;
using System.Text;

namespace Tarasov
{
    class B:A, core.EquationInterface
    {
        public List<float> solve(float a, float b, float c)
        {

            if (a == 0)
            {
                return decision(b, c);

            }

            float d = discr(a, b, c);
            if (d < 0)
            {
                return null;
            }
            x = new List<float>();
            if (d == 0)
            {

                x.Add((-b) / (2 * a));
                return x;
            }
            d = (float)Math.Sqrt(d);
            x.Add(Convert.ToSingle(((-b) - d) / (2 * a)));
            x.Add(Convert.ToSingle(((-b) + d) / (2 * a)));
            return x;
        }
        protected float discr(float a, float b, float c)
        {
            //добавить проверку на А перед дискр.
            return b * b - (4 * a * c);//49 +32 = 81 
        }
    }
}

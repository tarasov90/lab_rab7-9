using System;
using System.Collections.Generic;

namespace Equation {
    class A
    {
        protected List<float> x;

        public List<float> linear(float a, float b)
        {
            if (a == 0)
            {
                return null;
            }

            x = new List<float>();
            x.Add((-b) / a);
            return x;
        }
    }
}

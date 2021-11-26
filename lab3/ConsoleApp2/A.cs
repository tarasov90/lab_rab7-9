using System;
using System.Collections.Generic;
using System.Text;

namespace Tarasov
{
    class A
    {
        protected List<float> x;
        public List<float> decision(float b, float c)
        {
            if (b == 0)
            {
                return null;
            }

            return x = new List<float>() { -c / b };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tarasov
{
    class LineDesision
    {
        protected List<float> x;
        public List<float> decision(float b, float c)
        {
            if (b == 0)
            {
                throw new TarasovException("Определено, что такое уравнение не существует"); 
            }
            TarasovLog.I().log("Ваше уравнение - линейное!");
            return x = new List<float>() { -c / b };
        }
    }
}

using System;
using System.Collections.Generic;
using System.Text;

namespace Tarasov
{
    class TarasovException: Exception 
    {
        public TarasovException(string message) : base(message)
        { }
    }  
}

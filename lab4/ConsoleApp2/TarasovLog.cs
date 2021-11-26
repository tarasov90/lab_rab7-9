using System;
using System.Collections.Generic;
using System.Text;

namespace Tarasov
{
    class TarasovLog: core.LogAbstract, core.LogInterface
    {
        private static TarasovLog tarasovLog = null;
        public List <string> logs = new List<string>();
        public core.LogInterface log(string str)
        {
            logs.Add(str);
            return this;    
        }
        public core.LogInterface write()
        {
            writeConsole(logs.ToArray());
            return this;
        }
       
        private TarasovLog()
        {

        }
        public static TarasovLog I()
        {
            if (tarasovLog == null)
                tarasovLog = new TarasovLog();
            return tarasovLog;
        }
    }
}

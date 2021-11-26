using System;
using System.Collections.Generic;
namespace ConsoleApp2
{
    class Program
    {

        
        static void Main(string[] args)
        {
            Tarasov.A a = new Tarasov.A();
            Tarasov.B b = new Tarasov.B();
            TarasovLog tarasovLog = TarasovLog.I();
            List<float> n = new List<float>();
            n = b.solve(10, -7, -2);
            string result = Convert.ToString(n[1]) + " " + Convert.ToString(n[0]);
            tarasovLog.log(result);
            tarasovLog.write();
            Console.ReadLine();
            
        }
    }
    
}


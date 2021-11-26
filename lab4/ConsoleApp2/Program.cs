using System;
using System.Collections.Generic;
using Tarasov;
namespace ConsoleApp2
{
    class Program
    {

        
        static void Main(string[] args)
        {
            List<float> n = new List<float>();
            Console.WriteLine("Введите 3 параметра a, b и с");
            QuadraticDecision quadraticDecision = new QuadraticDecision();
            try
            {
                float aParam = Convert.ToSingle(Console.ReadLine());
                float bParam = Convert.ToSingle(Console.ReadLine());
                float cParam = Convert.ToSingle(Console.ReadLine());
                TarasovLog.I().log("(" + aParam + ")a^2+(" + bParam + ")b+(" + cParam + ") = 0");
                n = quadraticDecision.solve(aParam, bParam, cParam);
                TarasovLog.I().log("Корни уравнения: "+String.Join("; ",n));
            }
            catch( TarasovException ex)
            {
                TarasovLog.I().log(ex.Message);
            }
            catch
            {
                TarasovLog.I().log("Data input error");
            }
            TarasovLog.I().write();
            Console.ReadLine();
            
        }
    }
    
}


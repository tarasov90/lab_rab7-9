using System;
using System.Collections.Generic;
using Equation;

namespace lab1
{
    class Program
    {
        static void Main()
        {
            B bClass = new B();

            Console.WriteLine("Введите а: ");
            float a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите b: ");
            float b = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Введите c: ");
            float c = Convert.ToInt32(Console.ReadLine());

            List<float> answer = bClass.quadratic(a, b, c);

            if (answer == null)
            {
                Console.WriteLine("Корней нет.");
            }
            else {
                Console.WriteLine("Результат: ");
                foreach (float x in answer) {
                    Console.WriteLine(x);
                } 
            }

            Console.ReadKey();
        }
    }
}

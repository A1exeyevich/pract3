using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using USQLCSharpProject1;

namespace ConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            MyMath math = new MyMath();
          
            math.PrintHello();
            math.PrintSum(3, 5);

            int sum = math.Add(10, 20);
            Console.WriteLine($"Сумма = {sum}");

            string greeting = math.GetGreeting("Владимир");
            Console.WriteLine(greeting);

            double area = math.CalculateCircleArea(5);
            Console.WriteLine($"Площадь круга = {area}");

            Console.ReadLine();
        }
    }
}

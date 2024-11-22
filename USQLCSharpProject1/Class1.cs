using Microsoft.Analytics.Interfaces;
using Microsoft.Analytics.Interfaces.Streaming;
using Microsoft.Analytics.Types.Sql;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;

namespace USQLCSharpProject1
{
    public class MyMath
    {
        // Метод с типом void
        public void PrintHello()
        {
            Console.WriteLine("Hello from DLL!");
        }

        // Метод с типом void
        public void PrintSum(int a, int b)
        {
            Console.WriteLine($"Сумма {a} и {b} = {a + b}");
        }

        // Метод с возвращаемым значением int
        public int Add(int a, int b)
        {
            return a + b;
        }

        // Метод с возвращаемым значением string
        public string GetGreeting(string name)
        {
            return $"Здравствуйте, {name}!";
        }

        // Метод с возвращаемым значением double
        public double CalculateCircleArea(double radius)
        {
            return Math.PI * radius * radius;
        }
    }
}
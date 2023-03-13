using System;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator calc = new StringCalculator();
            Console.WriteLine(calc.Add("1\n2,3?1")); 
        }
    }
}

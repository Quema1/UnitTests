using System;

namespace UnitTests
{
    class Program
    {
        static void Main(string[] args)
        {
            StringCalculator calc = new StringCalculator();
            
            Console.WriteLine("Enter your string: ");
            string str = Console.ReadLine();
            
            try
            {
                Console.WriteLine("Result: " + calc.Add(str));
            }
            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }

        }
    }
}

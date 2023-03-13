using System;
using System.Linq;
using System.Collections.Generic;

namespace UnitTests
{
    public class StringCalculator
    {
        public int Add(string numbers)
        {
            var separators = new string[] { ",", ".", "//", "/n", "\n", "?" };
            int result = 0;

            if (numbers.Length == 0)
            {
                return result;
            }


            if (numbers.Length == 1)
            {
                result += Convert.ToInt32(new string(numbers.FirstOrDefault(), 1));
                return result;
            }
            
            if (numbers.StartsWith("//"))
            {
                Array.Resize(ref separators, separators.Length + 1);
                separators[separators.Length - 1] = Convert.ToString(numbers[2]);
                numbers = numbers.Substring(3);

            }

           
            var array = numbers.Split(separators, StringSplitOptions.None);
            bool isNegative = false;
            string warning = "negatives not allowed: ";

            foreach (var el in array)
            {
                if (el != "")
                {
                    int num = Convert.ToInt32(el);
                    if (num < 0)
                    {
                        warning += num;
                        warning += " ";
                        isNegative = true;                      
                    }
                    result += num;
                }
            }
            if (isNegative)
            {
                throw new Exception(warning);
            }
            return result;
        }
    }
}

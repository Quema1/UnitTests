using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UnitTests
{
    class StringCalculator
    {
        public int Add(string numbers)
        {
            string[] separators = new string[] { ",", ".", "/", "/n", "\n", "?" };
            int result = 0;
            if (numbers.Length == 0)
                return result;
            if (numbers.Length == 1)
            {
                result += Convert.ToInt32(new string(numbers.FirstOrDefault(), 1));
                return result;
            }

            string[] array = numbers.Split(separators, StringSplitOptions.None);
            foreach (var el in array)
            {
                result += Convert.ToInt32(el);
            }
            return result;
        }
    }
}

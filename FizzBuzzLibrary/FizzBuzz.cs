using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public static string GetFizzOrBuzzOrNumber(int number)
        {
            if (number < 1)
            {
                throw new ArgumentOutOfRangeException("Number should be greater than one ");
            }
            string value;
            if (number % 3 == 0 && number % 5 == 0)
            { value = "FizzBuzz"; }
            else if (number % 3 == 0)
            { value= "Fizz"; }
            else if (number % 5 == 0)
            { value= "Buzz"; }
            else
            { value= number.ToString(); }
            return value;
        }
    }
}

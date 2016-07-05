using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FizzBuzzLibrary
{
    public class FizzBuzz
    {
        public static string StartGame()
        {
            
            string test="";
            for(int i = 1; i <= 100; i++)
            {
                if (i%3==0 && i % 5 == 0)
                {
                    test += "FizzBuzz, ";
                }
                else if (i % 3 == 0)
                {
                    test += "Fizz, ";
                }
                else if (i % 5 == 0)
                {
                    test += "Buzz, ";
                }
                else
                {
                    test += i.ToString()+", ";
                }
            }

            return test;
        }
    }
}
